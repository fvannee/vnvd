using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using Antlr.Runtime;
using Antlr.StringTemplate;
using Antlr.Utility;
using Antlr.Runtime.Tree;
using Antlr.Utility.Tree;
using Vnvd.UserDefined;
using Vnvd.Antlr;

namespace Vnvd
{
   /// <summary>
   /// This is the main class of Vnvd.
   /// </summary>
   public class Vnvd
   {
      private static bool opt_ast = false;
      private static bool opt_dot = false;
      private static bool opt_nochecker = false;
      private static bool wait = false;
      private static List<string> refs = new List<string>() { "mscorlib" };
      private static string output = String.Empty;
      private static List<string> filenames = new List<string>();
      private static bool opt_nogenerator;
      private static LibraryChecker lib;
      private static ModuleBuilder mb;

      /// <summary>
      /// Gets the LibraryChecker used by the compiler
      /// </summary>
      public static LibraryChecker Library
      {
         get { return lib; }
      }

      /// <summary>
      /// Gets the filename of the file to output the assembly to
      /// </summary>
      public static String OutputFile
      {
         get { return output; }
      }

      /// <summary>
      /// Gets the ModuleBuilder object of the assembly which is being constructed
      /// </summary>
      public static ModuleBuilder ModBuilder
      {
         get
         {
            return mb;  
         }
      }

      private static void PrintHelp()
      {
         Console.Error.WriteLine("Valid options:");
         Console.Error.WriteLine("\t--ast\t\tPrint the abstract syntax tree");
         Console.Error.WriteLine("\t--dot\t\tGenerate a Graphviz file for the AST");
         Console.Error.WriteLine("\t--nochecker\tDisable the checker");
         Console.Error.WriteLine("\t--nogenerator\tDisable the code generator");
         Console.Error.WriteLine("\t--ref:\t\tReference other assemblies");
         Console.Error.WriteLine("\t--out:\t\tOutput file");   
      }

      /// <summary>
      /// Command line options parser.
      /// </summary>
      /// <param name="args">The options given on the command line.</param>
      private static void ParseOptions(String[] args)
      {
         Type t = typeof(string[]);
         if (args.Length == 0)
         {
            Console.Error.WriteLine("Error: no options specified");
            //PrintHelp();
            //Environment.Exit(1);
            
            filenames.Add("ex1.vnvd");
            refs.Add("System");
            //refs.Add("System.Windows.Forms");
            //refs.Add("System.Drawing");
            output = "MyAsm.exe";
            opt_ast = true;
            //opt_nogenerator = true;
            //opt_nochecker = true;
            wait = true;
            ////Environment.Exit(1);
         }
         else
         {
            for (int i = 0; i < args.Length; i++)
            {
               if (args[i].Equals("--ast"))
               {
                  opt_ast = true;
               }
               else if (args[i].Equals("--dot"))
               {
                  opt_dot = true;
               }
               else if (args[i].Equals("--nochecker"))
               {
                  opt_nochecker = true;
               }
               else if (args[i].Equals("--nogenerator"))
               {
                  opt_nogenerator = true;
               }
               else if (args[i].StartsWith("--ref:"))
               {
                  refs.Add(args[i].Substring(6, args[i].Length - 6));
               }
               else if (args[i].StartsWith("--out:"))
               {
                  output = args[i].Substring(6, args[i].Length - 6);
               }
               else if (args[i].Equals("--van"))
               {
                  Console.WriteLine("Nee");
                  Environment.Exit(0);
               }
               else if (!args[i].StartsWith("--"))
               {
                  filenames.Add(args[i]);
               }
               else
               {
                  Console.Error.WriteLine("Error: unknown option '" + args[i] + "'");
                  PrintHelp();
                  Environment.Exit(1);
               }
            }
            if (filenames.Count == 0)
            {
               Console.Error.WriteLine("Error: no files to compile specified.");
               Environment.Exit(1);
            }
            if (output == String.Empty)
            {
               int ext = filenames[0].LastIndexOf(".");
               output = (ext != -1 ? filenames[0].Substring(0, ext) : filenames[0]) + ".exe";

               int slash = output.LastIndexOf("/");
               int backslash = output.LastIndexOf("\\");

               output = (slash != -1 ? output.Substring(slash + 1) : output);
               output = (backslash != -1 ? output.Substring(backslash + 1) : output);
            }
         }

         foreach (string filename in filenames)
         {
            if (!File.Exists(filename))
            {
               Console.Error.WriteLine("Error: File doesn't exist '" + filename + "'");

               Environment.Exit(1);
            }
         }
      }

      /// <summary>
      /// The main function of Vnvd. This runs the compiler.
      /// </summary>
      /// <param name="args">The command line arguments given to Vnvd.</param>
      public static void Main(String[] args)
      {
         Console.Out.WriteLine("Vnvd Compiler v" + Assembly.GetExecutingAssembly().GetName().Version);
         Console.Out.WriteLine("======================");
         Console.Out.WriteLine();
         ParseOptions(args);
         try
         {
            lib = new LibraryChecker(refs.ToArray());
         }
         catch (ArgumentException ex)
         {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
         }
         List<TreeNode> trees = new List<TreeNode>();
         bool error = false;

         foreach (String filename in filenames)
         {
            VnvdLexer lexer = new VnvdLexer(new ANTLRFileStream(filename));

            CommonTokenStream tokens = new CommonTokenStream(lexer);
            VnvdParser parser = new VnvdParser(tokens);
            parser.TreeAdaptor = new TreeNodeAdaptor();

            VnvdParser.program_return result = parser.program();
            TreeNode tree = (TreeNode) result.Tree;
            trees.Add(tree);

            if (parser.NumberOfSyntaxErrors > 0)
               error = true;
         }

         if (!error)
         {
            VnvdTreeWalker checker = null;
            if (!opt_nochecker)
            {
               // check the AST
               CheckerManual manual = new CheckerManual();
               try
               {
                  foreach (TreeNode tree in trees)
                  {
                     manual.WalkClasses(tree);
                  }
                  manual.WalkClassExtendation();
                  manual.WalkClassMembers();

                  for (int i = 0; i < trees.Count; i++)
                  {
                     TreeNode tree = trees[i];
                     ITreeNodeStream nodes = new CommonTreeNodeStream(tree);
                     CheckerHelper helper = new CheckerHelper();
                     checker = new VnvdTreeWalker(helper, nodes);
                     checker.Filename = filenames[i];
                     checker.TreeAdaptor = new TreeNodeAdaptor();
                     helper.Walker = checker;

                     checker.program();
                     if (checker.SemanticErrorCount > 0 || checker.NumberOfSyntaxErrors > 0)
                        error = true;
                  }
               }
               catch (CheckerException ex)
               {
                  Console.WriteLine(ex.ToString());
                  error = true;
               }
            }

            if (!error)
            {
               if (!opt_nogenerator)
               {
                  AssemblyName aName = new AssemblyName();
                  aName.Name = Vnvd.OutputFile.Substring(0, Vnvd.OutputFile.LastIndexOf('.'));

                  AssemblyBuilder ab =
                     AppDomain.CurrentDomain.DefineDynamicAssembly(
                         aName,
                         AssemblyBuilderAccess.Save);

                  // For a single-module assembly, the module name is usually
                  // the assembly name plus an extension.
                  mb =
                      ab.DefineDynamicModule(aName.Name, Vnvd.OutputFile);
                  GeneratorManual manualWalker = new GeneratorManual(mb, ab);

                  foreach (TreeNode tree in trees)
                  {
                     manualWalker.WalkTypes(tree);
                  }
                  manualWalker.WalkTypeMembers();

                  foreach (TreeNode tree in trees)
                  {
                     ITreeNodeStream nodes = new CommonTreeNodeStream(tree);
                     VnvdTreeWalker generator = new VnvdTreeWalker(new GeneratorHelper(), nodes);
                     generator.program();
                  }

                  foreach (TypeBuilder t in manualWalker.AllTypes)
                  {
                     t.CreateType();
                  }

                  try
                  {
                     ab.Save(OutputFile);
                  }
                  catch (IOException)
                  {
                     Console.WriteLine("Error while saving the assembly. The output file is in use.");
                  }
               }
            }

            if (opt_ast)
            {
               // print the AST as string
               StringBuilder sb = new StringBuilder();

               foreach (TreeNode tree in trees)
               {
                  String s = tree.ToStringTree();
                  int indent = 0;
                  foreach (char c in s)
                  {
                     if (c == '(')
                     {
                        sb.Append('\n');
                        indent += 3;
                        for (int i = 0; i < indent; i++)
                           sb.Append(' ');
                     }
                     else if (c == ')')
                     {
                        indent -= 3;
                     }
                     sb.Append(c);
                  }

                  sb.AppendLine();
                  sb.AppendLine();
               }
              

               //Console.WriteLine(sb.ToString());
               Console.WriteLine("AST was written to ast.txt");
               StreamWriter sw = new StreamWriter("ast.txt");
               sw.Write(sb.ToString());
               sw.Close();
            }
            else if (opt_dot)
            {
               // print the AST as DOT specification
               DOTTreeGenerator gen = new DOTTreeGenerator();

               Console.WriteLine("Graphviz AST graph (only first tree) was written to ast.dot");
               StringTemplate st = gen.ToDOT(trees[0]);
               StreamWriter sw = new StreamWriter("ast.dot");
               sw.Write(st.ToString());
               sw.Close();
            }
         }

         if (wait)
            Console.Read();
      }
   }
}
