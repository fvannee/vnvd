
using System;
using Antlr.Runtime.Tree;
using System.Collections.Generic;
using Vnvd.UserDefined;

namespace Vnvd
{
   /// <summary>
   /// This is the abstract definition of a TreeWalker helper class.
   /// </summary>
   public abstract class AbstractHelper
   {
      public abstract void ConstLiteralNumber(TreeNode node);
      public abstract void ConstLiteralFloat(TreeNode node);
      public abstract void ConstLiteralCharacter(TreeNode node);
      public abstract void ConstLiteralBoolean(TreeNode node);
      public abstract void ConstLiteralString(TreeNode node);

      /// <summary>
      /// TreeWalker method for an array creation expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void ArrayCreationExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for an elemented array creation expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void ArrayElementedCreationExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for the begin of an elemented array creation expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void BeforeArrayElementedCreationExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for the start of an elemented array element expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void BeforeArrayElementedElement(TreeNode node);

      /// <summary>
      /// TreeWalker method for an elemented array element expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void ArrayElementedElement(TreeNode node);

      /// <summary>
      /// TreeWalker method for an assignment expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void AssignmentExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a class declaration expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="modifiers">The modifiers used on the class</param>
      /// <param name="qualifier">The full qualifier of the class</param>
      /// <param name="extendation">The classes that are extended by this class</param>
      /// <param name="implementation">The classes that are implemented by this class</param>
      public abstract void Class(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> extendation, List<Qualifier> implementation);

      /// <summary>
      /// TreeWalker method for a constante declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void ConstDecl(TreeNode node);

      /// <summary>
      /// TreeWalker method for a constant field declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="modifiers">The modifiers used on the field</param>
      /// <param name="qualifier">The type of the field</param>
      /// <param name="identifier">The name of the field</param>
      public abstract void ConstField(TreeNode node, List<string> modifiers, Qualifier qualifier, string identifier);

      /// <summary>
      /// TreeWalker method for a constructor (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="modifiers">The modifiers used on the constructor</param>
      /// <param name="parameters">The parameters of the constructor</param>
      public abstract void Constructor(TreeNode node, List<string> modifiers, List<Parameter> parameters);

      /// <summary>
      /// TreeWalker method for a declaration statement (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qualifier">The full qualifier of the type</param>
      /// <param name="identifier">The identifier of the variable</param>
      public abstract void DeclarationStatement(TreeNode node, Qualifier qualifier, string identifier);

      /// <summary>
      /// TreeWalker method for a division expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void DivisionExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a equal (comparison) expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void EqualExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a field declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="modifiers">The modifiers used on the field</param>
      /// <param name="qualifier">The full qualifier of the type of the field</param>
      /// <param name="identifier">The identifier of the field</param>
      public abstract void Field(TreeNode node, List<string> modifiers, Qualifier qualifier, string identifier);

      /// <summary>
      /// TreeWalker method for a greater than or equal expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void GreaterEqualExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a greater than expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void GreaterExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for an import statement (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qualifier">The qualifier to import</param>
      public abstract void Import(TreeNode node, Qualifier qualifier);

      /// <summary>
      /// TreeWalker method for an interface declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="modifiers">The modifiers used on the interface</param>
      /// <param name="qualifier">The full qualifier of the interface</param>
      /// <param name="extendation">The interfaces extended by this interface</param>
      public abstract void Interface(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> extendation);

      /// <summary>
      /// TreeWalker method for an interface method declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qualifier">The full qualifier of the type of the method</param>
      /// <param name="identifier">The identifier of the method</param>
      /// <param name="parameters">The parameters of the method</param>
      public abstract void InterfaceMethod(TreeNode node, Qualifier qualifier, string identifier, List<Parameter> parameters);

      /// <summary>
      /// TreeWalker method for an invocation expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="identifier">The identifier of the method invocated</param>
      public abstract void InvocationExpr(TreeNode node, string identifier);

      /// <summary>
      /// TreeWalker method for a less than or equal expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LessEqualExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a less than expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LessExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for the end of a conditional and expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void EndConditionalAndExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a logical not expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LogicNotExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for the end of a conditional or expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void EndConditionalOrExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a method declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="modifiers">The modifiers used on the method</param>
      /// <param name="qualifier">The full qualifier of the type of the method</param>
      /// <param name="identifier">The identifier of the method</param>
      /// <param name="parameters">The parameters of the method</param>
      public abstract void Method(TreeNode node, List<string> modifiers, Qualifier qualifier, string identifier, List<Parameter> parameters);

      /// <summary>
      /// TreeWalker method for a minus expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void MinusExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a modulo expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void ModExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a multiply expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void MultiplyExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a namespace declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qualifier">The full qualifier of the namespace</param>
      public abstract void Namespace(TreeNode node, Qualifier qualifier);

      /// <summary>
      /// TreeWalker method for the begin of a namespace declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qualifier">The full qualifier of the namespace</param>
      public abstract void BeginNamespace(TreeNode node, Qualifier qualifier);

      /// <summary>
      /// TreeWalker method for a not equal expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void NotEqualExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for an object creation expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qualifier">The full qualifier of the class the object is an instance off</param>
      public abstract void ObjectCreation(TreeNode node, Qualifier qualifier);

      /// <summary>
      /// TreeWalker method for a plus expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void PlusExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a program declaration (see grammar).
      /// This is the root of the AST.
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void Program(TreeNode node);

      /// <summary>
      /// TreeWalker method for a ternary expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void TernaryExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a while loop declaration expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void WhileLoop(TreeNode node);

      /// <summary>
      /// TreeWalker method for a variable usage expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qual">The full qualifier of the variable used</param>
      public abstract void VariableUsed(TreeNode node, Qualifier qual);

      /// <summary>
      /// TreeWalker method for a literal number expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LiteralNumber(TreeNode node);

      /// <summary>
      /// TreeWalker method for a literal string expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LiteralString(TreeNode node);

      /// <summary>
      /// TreeWalker method for a literal character expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LiteralCharacter(TreeNode node);

      /// <summary>
      /// TreeWalker method for a literal boolean expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LiteralBoolean(TreeNode node);

      /// <summary>
      /// TreeWalker method for a literal float expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LiteralFloat(TreeNode node);
      
      /// <summary>
      /// TreeWalker method for an expression block (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void ExpressionBlock(TreeNode node);

      /// <summary>
      /// TreeWalker method for a statement block (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void StatementBlock(TreeNode node);

      /// <summary>
      /// TreeWalker method for the begin of a class declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="modifiers">The modifiers used on the class</param>
      /// <param name="qualifier">The qualifier of the class</param>
      /// <param name="extends">The classes extended by this class</param>
      /// <param name="implements">The interfaces implemented by this class</param>
      public abstract void BeginClass(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> extends, List<Qualifier> implements);

      /// <summary>
      /// TreeWalker method for the begin of a interface declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="modifiers">The modifiers used on the interface</param>
      /// <param name="qualifier">The qualifier of the interface</param>
      /// <param name="extends">The classes extended by the interface</param>
      public abstract void BeginInterface(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> extends);

      /// <summary>
      /// TreeWalker method for the begin of a method declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="modifiers">The modifiers used on the method</param>
      /// <param name="returns">The full qualifier of the type of the method</param>
      /// <param name="name">The identifier of the method</param>
      /// <param name="parameters">The parameters of the method</param>
      public abstract void BeginMethod(TreeNode node, List<string> modifiers, Qualifier returns, string name, List<Parameter> parameters);

      /// <summary>
      /// TreeWalker method for the begin of the body of a constructor declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="modifiers">The modifiers used on the constructor</param>
      /// <param name="parameters">The parameters of the constructor</param>
      /// <param name="bas">The base call of the constructor</param>
      public abstract void BeginConstructor(TreeNode node, List<string> modifiers, List<Parameter> parameters, TreeNode bas);

      /// <summary>
      /// TreeWalker method for the begin of a constructor declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void BeginConstructorBeforeBaseCall(TreeNode node);

      /// <summary>
      /// TreeWalker method for the begin of a program declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void BeginProgram(TreeNode node);

      /// <summary>
      /// TreeWalker method for a scope expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void ScopeExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a literal this expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LiteralThis(TreeNode node);

      /// <summary>
      /// TreeWalker method for a literal base expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LiteralBase(TreeNode node);

      /// <summary>
      /// TreeWalker method for opening a new scope level (see grammar).
      /// </summary>
      public abstract void OpenScope();

      /// <summary>
      /// TreeWalker method for closing a new scope level (see grammar).
      /// </summary>
      public abstract void CloseScope();

      /// <summary>
      /// TreeWalker method for a literal null declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LiteralNull(TreeNode node);

      /// <summary>
      /// TreeWalker method for a cast expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qual">The qualifier of the type to cast to</param>
      public abstract void CastExpression(TreeNode node, Qualifier qual);

      /// <summary>
      /// TreeWalker method for a cast as expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qual">The qualifier of the type to cast to</param>
      public abstract void CastAsExpression(TreeNode node, Qualifier qual);

      /// <summary>
      /// TreeWalker method for an unary plus expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void UnaryPlusExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for an unary minus expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void UnaryMinusExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for the begin of a try block (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void BeginTry(TreeNode node);

      /// <summary>
      /// TreeWalker method for the end of a try block (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void EndTry(TreeNode node);

      /// <summary>
      /// TreeWalker method for the begin of a catch block (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="node2">The node of the local used to store the exception</param>
      /// <param name="qual">The qualifier of the type of the local used to store the exception</param>
      /// <param name="p">The identifier of the local used to store the exception</param>
      public abstract void BeginCatch(TreeNode node, TreeNode node2, Qualifier qual, string p);

      /// <summary>
      /// TreeWalker method for the begin of a catch block (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qual">The qualifier of the type of the local used to store the exception</param>
      /// <param name="p">The identifier of the local used to store the exception</param>
      public abstract void EndCatch(TreeNode node, Qualifier qual, string p);

      /// <summary>
      /// TreeWalker method for the begin of a finally block (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void BeginFinally(TreeNode node);

      /// <summary>
      /// TreeWalker method for the end of a finally block (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void EndFinally(TreeNode node);

      /// <summary>
      /// TreeWalker method for a constant declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qual">The full qualifier of the type of the constant</param>
      /// <param name="p">The identifier of the constant</param>
      public abstract void ConstantDeclaration(TreeNode node, Qualifier qual, string p);

      /// <summary>
      /// TreeWalker method for an array access expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void AccessArray(TreeNode node);

      /// <summary>
      /// TreeWalker method for a throw statement (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void ThrowStatement(TreeNode node);

      /// <summary>
      /// TreeWalker method for an abstract method declaration (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="modifiers">The modifiers used on the abstract method</param>
      /// <param name="returns">The qualifier of the type returned by the abstract method</param>
      /// <param name="p">The identifier of the abstract method</param>
      /// <param name="parameters">The parameters of the abstract method</param>
      public abstract void AbstractMethod(TreeNode node, List<string> modifiers, Qualifier returns, string p, List<Parameter> parameters);

      /// <summary>
      /// TreeWalker method for the begin of a for loop expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="node2">The node of the local used by the for loop</param>
      /// <param name="qual">The qualifier of the type used by the for loop</param>
      /// <param name="p">The identifier of the type used by the for loop</param>
      public abstract void BeginFor(TreeNode node, TreeNode node2, Qualifier qual, string p);

      /// <summary>
      /// TreeWalker method for a for loop expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void ForLoop(TreeNode node);

      /// <summary>
      /// TreeWalker method for a read() expression (see grammar) with return type.
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="identifier">The identifier of the variable to read</param>
      public abstract void ReadExpression(TreeNode node, String identifier);

      /// <summary>
      /// TreeWalker method for a read() expression (see grammar) with no return type.
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="identifier">The identifier of the variable to read</param>
      public abstract void ReadVoidExpression(TreeNode node, String identifier);

      /// <summary>
      /// TreeWalker method for a write() expression (see grammar) with return type
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void WriteExpression(TreeNode node);

      /// <summary>
      /// TreeWalker method for a write() expression with no return type (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void WriteVoidExpression(TreeNode node);

      /// <summary>
      /// TreeWalker method for an event expression (see grammar). Called when adding a delegate to an event
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void AddEventExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for an event expression (see grammar). Called when removing a delegate from an event
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void RemoveEventExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a logic OR expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LogicOrExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a logic XOR expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LogicXorExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a logic AND expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void LogicAndExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a conditional OR expression (see grammar). Called at the start of the expression.
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void BeginCondOr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a conditional OR expression (see grammar). Called after the first value is evaluated.
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void MiddleCondOr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a conditional AND expression (see grammar). Called at the start of the expression
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void BeginCondAnd(TreeNode node);

      /// <summary>
      /// TreeWalker method for a conditional AND expression (see grammar). Called after the first value is evaluated.
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void MiddleCondAnd(TreeNode node);

      /// <summary>
      /// TreeWalker method for an instanceof expression (see grammar).
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="qual">The qualifier to try to cast to</param>
      public abstract void IsTypeExpression(TreeNode node, Qualifier qual);

      /// <summary>
      /// TreeWalker method for a ternary expression (see grammar). Called just before the else part of the expression
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void TernaryElse(TreeNode node);

      /// <summary>
      /// TreeWalker method for a ternary expression (see grammar). Called just before the then part of the expression
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void TernaryThen(TreeNode node);

      /// <summary>
      /// TreeWalker method for a while statement (see grammar). Called at the beginning of the loop
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void WhileStart(TreeNode node);

      /// <summary>
      /// TreeWalker method for a while statement (see grammar). Called after a while loop
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void WhileAfterExpr(TreeNode node);

      /// <summary>
      /// TreeWalker method for a constant array (see grammar). Called at the beginning of each constant array
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void ConstantArray(TreeNode node);

      /// <summary>
      /// TreeWalker method for an constant array element (see grammar). Called for every element in a constant array
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void ConstantArrayElement(TreeNode node);

      /// <summary>
      /// TreeWalker method for a static constructor (see grammar). Called just before the body
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void BeginStaticConstructor(TreeNode node);

      /// <summary>
      /// TreeWalker method for a static constructor (see grammar). Called at the end of the static constructor
      /// </summary>
      /// <param name="node">The AST node</param>
      public abstract void EndStaticConstructor(TreeNode node);

      // Non-abstract functions

      /// <summary>
      /// Transforms a FQUALIFIER tree node into a full qualifier object.
      /// </summary>
      /// <param name="fullQualifier">The AST node</param>
      /// <returns>The full qualifier</returns>
      public Qualifier FullQualifier(ITree fullQualifier)
      {
         return GetFullQualifier(fullQualifier);
      }

      /// <summary>
      /// Transforms a type qualifier to a Qualifier object.
      /// </summary>
      /// <param name="name">The identifier of the type</param>
      /// <returns>The full qualifier</returns>
      public Qualifier TypeQualifier(string name)
      {
         Qualifier ids = new Qualifier();
         ids.Add(name);
         return ids;
      }

      /// <summary>
      /// Transforms a type qualifier to a Qualifier object.
      /// </summary>
      /// <param name="name">The full qualifier</param>
      /// <returns>The full qualifier</returns>
      public Qualifier TypeQualifier(Qualifier list)
      {
         return list;
      }

      /// <summary>
      /// Transforms a MODIFIERS tree node into a list of modifiers.
      /// </summary>
      /// <param name="modifiers">The AST node</param>
      /// <returns>The list of modifiers</returns>
      public List<string> Modifiers(ITree modifiers)
      {
         return GetModifiers(modifiers);
      }

      /// <summary>
      /// Transforms an EXTENDS tree node into a list of Qualifier objects.
      /// </summary>
      /// <param name="extending">The AST node</param>
      /// <returns>The list of qualifiers</returns>
      public List<Qualifier> Extendation(ITree extending)
      {
         return GetExtendation(extending);
      }

      /// <summary>
      /// Transforms an IMPLEMENTS tree node into a list of Qualifier objects.
      /// </summary>
      /// <param name="implementing">The AST node</param>
      /// <returns>The list of qualifiers</returns>
      public List<Qualifier> Implements(ITree implementing)
      {
         return GetImplements(implementing);
      }

      /// <summary>
      /// Retrieves the parameters of a method of its definition in the tree
      /// </summary>
      /// <param name="parameters">The tree with the method definition</param>
      /// <returns>A list of parameters</returns>
      public List<Parameter> Parameters(ITree parameters)
      {
         List<Parameter> ids = new List<Parameter>();

         if (parameters == null)
         {
            return ids;
         }

         for (int i = 0; i < parameters.ChildCount; i += 2)
         {
            ids.Add(new Parameter(FullQualifier(parameters.GetChild(i)), parameters.GetChild((i + 1)).Text));
         }

         return ids;
      }

      /// <summary>
      /// Retrieves the parameter names of a METHOD node
      /// </summary>
      /// <param name="parameters">The tree containing the method definition</param>
      /// <returns>The method parameter names</returns>
      public string[] ParameterNames(ITree parameters)
      {
         return GetParameterNames(parameters);
      }

      /// <summary>
      /// Retrieves the parameter types of a METHOD node
      /// </summary>
      /// <param name="parameters">The tree containing the method definition</param>
      /// <returns>The method parameter types</returns>
      public string[] ParameterTypes(ITree parameters)
      {
         return GetParameterTypes(parameters);
      }

      /// <summary>
      /// Transforms a FQUALIFIER tree node into a full qualifier object.
      /// </summary>
      /// <param name="fullQualifier">The AST node</param>
      /// <returns>The full qualifier</returns>
      public static Qualifier GetFullQualifier(ITree fullQualifier)
      {
         Qualifier ids = new Qualifier();

         if (fullQualifier == null)
         {
            return ids;
         }
         for (int i = 0; i < fullQualifier.ChildCount - 1; i++)
         {
            ids.Add(fullQualifier.GetChild(i).Text);
         }

         if (fullQualifier.GetChild(fullQualifier.ChildCount - 1).Text.Equals("ARRAY"))
            ids[ids.Count - 1] = ids[ids.Count - 1] + "[]";
         else
            ids.Add(fullQualifier.GetChild(fullQualifier.ChildCount - 1).Text);

         return ids;
      }

      /// <summary>
      /// Transforms a MODIFIERS tree node into a list of modifiers.
      /// </summary>
      /// <param name="modifiers">The AST node</param>
      /// <returns>The list of modifiers</returns>
      public static List<string> GetModifiers(ITree modifiers)
      {
         List<string> ret = new List<string>();

         for (int i = 0; i < modifiers.ChildCount; i++)
         {
            ret.Add(modifiers.GetChild(i).Text);
         }

         if (ret.Remove("protected"))
            ret.Add("family");
         if (ret.Remove("internal"))
            ret.Add("assembly");
         return ret;
      }

      /// <summary>
      /// Retrieves the parameter names of a METHOD node
      /// </summary>
      /// <param name="parameters">The tree containing the method definition</param>
      /// <returns>The method parameter names</returns>
      public static string[] GetParameterNames(ITree parameters)
      {
         List<String> ids = new List<String>();

         if (parameters == null)
         {
            return ids.ToArray();
         }

         for (int i = 0; i < parameters.ChildCount; i += 2)
         {
            ids.Add(parameters.GetChild(i + 1).Text);
         }

         return ids.ToArray();
      }

      /// <summary>
      /// Retrieves the parameter types of a METHOD node
      /// </summary>
      /// <param name="parameters">The tree containing the method definition</param>
      /// <returns>The method parameter types</returns>
      public static string[] GetParameterTypes(ITree parameters)
      {
         List<String> ids = new List<String>();

         if (parameters == null)
         {
            return ids.ToArray();
         }

         for (int i = 0; i < parameters.ChildCount; i += 2)
         {
            ids.Add(GetFullQualifier(parameters.GetChild(i)).ToString());
         }

         return ids.ToArray();
      }

      /// <summary>
      /// Transforms an EXTENDS tree node into a list of Qualifier objects.
      /// </summary>
      /// <param name="extending">The AST node</param>
      /// <returns>The list of qualifiers</returns>
      public static List<Qualifier> GetExtendation(ITree extending)
      {
         List<Qualifier> ids = new List<Qualifier>();

         if (extending == null)
         {
            return ids;
         }

         for (int i = 0; i < extending.ChildCount; i++)
         {
            ids.Add(GetFullQualifier(extending.GetChild(i)));
         }

         return ids;
      }

      /// <summary>
      /// Transforms an IMPLEMENTS tree node into a list of Qualifier objects.
      /// </summary>
      /// <param name="implementing">The AST node</param>
      /// <returns>The list of qualifiers</returns>
      public static List<Qualifier> GetImplements(ITree implementing)
      {
         return GetExtendation(implementing);
      }

      /// <summary>
      /// Determines if a type is assignable from another type
      /// </summary>
      /// <param name="t1">The type which would be assigned to</param>
      /// <param name="t2">The type which would be assigned from</param>
      /// <returns>true if it is possible, false otherwise</returns>
      public static Boolean IsAssignableFrom(Type t1, Type t2)
      {
         if (!t1.IsValueType && t2 == NullType.Default || t1 == typeof(object) && t2.IsInterface)
            return true;

         if (t1 is UserType || t2 is UserType)
         {
            bool ret = false;
            Type c2 = t2;
            while (c2 != null && !ret)
            {
               ret = c2.FullName.Equals(t1.FullName);

               c2 = c2.BaseType;
            }
            if (t2 != null && !ret && t1.IsInterface)
            {
               Type[] interfaces = t2.GetInterfaces();
               int i = 0;
               while (i < interfaces.Length && !ret)
               {
                  ret = interfaces[i].FullName.Equals(t1.FullName);
                  i++;
               }
            }
            return ret;
         }
         else
         {
            return t1.IsAssignableFrom(t2);
         }
      }

      public abstract void CallVirtual(TreeNode node, string text);
      public abstract void Call(TreeNode node, string text);
      public abstract void LoadField(TreeNode node, string text);
      public abstract void LoadStaticField(TreeNode node, string text);
      public abstract void LoadLiteral(TreeNode node, string text);
      public abstract void LoadVirtualFunction(TreeNode node, string text);
      public abstract void LoadFunction(TreeNode node, string text);
      public abstract void FieldAssignment(TreeNode node, string text);
   }
}