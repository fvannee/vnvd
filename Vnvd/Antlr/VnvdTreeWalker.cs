// $ANTLR 3.2 Sep 23, 2009 12:02:23 VnvdTreeWalker.g 2010-03-17 00:16:59

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


	using System.Collections.Generic;
	using Vnvd;
	using Vnvd.UserDefined;


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

namespace 
	Vnvd.Antlr

{
public partial class VnvdTreeWalker : TreeParser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"COLON", 
		"SEMICOLON", 
		"LPAREN", 
		"RPAREN", 
		"COMMA", 
		"PERIOD", 
		"LCURLYBRACE", 
		"RCURLYBRACE", 
		"LBRACKET", 
		"RBRACKET", 
		"QUESTION", 
		"TILDE", 
		"DCOLON", 
		"ADDEVENT", 
		"REMEVENT", 
		"BECOMES", 
		"PLUS", 
		"MINUS", 
		"MULTIPLY", 
		"DIVISION", 
		"LE", 
		"LEQ", 
		"GE", 
		"GEQ", 
		"EQ", 
		"NEQ", 
		"AND", 
		"OR", 
		"LXOR", 
		"LAND", 
		"LOR", 
		"NOT", 
		"MOD", 
		"USING", 
		"NAMESPACE", 
		"CLASS", 
		"INTERFACE", 
		"NEW", 
		"STATIC", 
		"VOID", 
		"IF", 
		"THEN", 
		"ELSE", 
		"WHILE", 
		"FOR", 
		"ENUM", 
		"IN", 
		"RETURN", 
		"CONST", 
		"TRUE", 
		"FALSE", 
		"BASE", 
		"THIS", 
		"METHOD", 
		"IMETHOD", 
		"FIELD", 
		"CONSTRUCTOR", 
		"LOCAL", 
		"EXTENDS", 
		"IMPLEMENTS", 
		"FI", 
		"PRINT", 
		"READ", 
		"NULL", 
		"AS", 
		"IS", 
		"TRY", 
		"CATCH", 
		"CAREBOX", 
		"FINALLY", 
		"THROW", 
		"WRITE", 
		"PRIVATE", 
		"PUBLIC", 
		"PROTECTED", 
		"INTERNAL", 
		"ABSTRACT", 
		"VIRTUAL", 
		"OVERRIDE", 
		"INITONLY", 
		"PROGRAM", 
		"VARDECL", 
		"PARAMETER", 
		"ARGUMENT", 
		"SLIST", 
		"ENUMOPTION", 
		"FQUALIFIER", 
		"EQUALIFIER", 
		"MODIFIERS", 
		"EXPRBLOCK", 
		"USAGE", 
		"SCOPEEXPR", 
		"CAST", 
		"ARRAY", 
		"READVOID", 
		"WRITEVOID", 
		"ALIST", 
		"NEWARR", 
		"NEWARRELEMS", 
		"ARRELEMS", 
		"ARRELEM", 
		"SCONSTRUCTOR", 
		"ICATCH", 
		"CALLVIRT", 
		"CALL", 
		"LDFLD", 
		"LDSFLD", 
		"LDLITERAL", 
		"LDVIRTFTN", 
		"LDFTN", 
		"DONTLD", 
		"IDENTIFIER", 
		"NUMBER", 
		"STRING", 
		"CHAR", 
		"FLOAT", 
		"LETTER", 
		"DIGIT", 
		"QUOTED_CHARACTER", 
		"COMMENT", 
		"WS", 
		"LOWER", 
		"UPPER"
    };

    public const int LOR = 34;
    public const int CAST = 96;
    public const int INTERNAL = 79;
    public const int LDSFLD = 110;
    public const int LDFTN = 113;
    public const int WHILE = 47;
    public const int LETTER = 120;
    public const int MOD = 36;
    public const int CONST = 52;
    public const int CHAR = 118;
    public const int NEW = 41;
    public const int NOT = 35;
    public const int EOF = -1;
    public const int LBRACKET = 12;
    public const int RPAREN = 7;
    public const int DCOLON = 16;
    public const int LDLITERAL = 111;
    public const int USING = 37;
    public const int EQUALIFIER = 91;
    public const int PARAMETER = 86;
    public const int THIS = 56;
    public const int RETURN = 51;
    public const int DIVISION = 23;
    public const int BASE = 55;
    public const int VOID = 43;
    public const int GEQ = 27;
    public const int EQ = 28;
    public const int COMMENT = 123;
    public const int EXPRBLOCK = 93;
    public const int VIRTUAL = 81;
    public const int ARRAY = 97;
    public const int INITONLY = 83;
    public const int IMETHOD = 58;
    public const int GE = 26;
    public const int PRIVATE = 76;
    public const int PERIOD = 9;
    public const int STATIC = 42;
    public const int NULL = 67;
    public const int ELSE = 46;
    public const int NUMBER = 116;
    public const int CALLVIRT = 107;
    public const int SCONSTRUCTOR = 105;
    public const int SEMICOLON = 5;
    public const int LOCAL = 61;
    public const int TRY = 70;
    public const int NAMESPACE = 38;
    public const int FI = 64;
    public const int WS = 124;
    public const int READ = 66;
    public const int OR = 31;
    public const int FIELD = 59;
    public const int QUOTED_CHARACTER = 122;
    public const int LDFLD = 109;
    public const int CALL = 108;
    public const int LOWER = 125;
    public const int CATCH = 71;
    public const int FALSE = 54;
    public const int LAND = 33;
    public const int CONSTRUCTOR = 60;
    public const int THROW = 74;
    public const int UPPER = 126;
    public const int PROTECTED = 78;
    public const int CLASS = 39;
    public const int WRITEVOID = 99;
    public const int FOR = 48;
    public const int FLOAT = 119;
    public const int ABSTRACT = 80;
    public const int VARDECL = 85;
    public const int SCOPEEXPR = 95;
    public const int AND = 30;
    public const int ALIST = 100;
    public const int NEWARRELEMS = 102;
    public const int DONTLD = 114;
    public const int USAGE = 94;
    public const int LPAREN = 6;
    public const int IF = 44;
    public const int MODIFIERS = 92;
    public const int AS = 68;
    public const int THEN = 45;
    public const int IN = 50;
    public const int ARRELEM = 104;
    public const int IMPLEMENTS = 63;
    public const int MULTIPLY = 22;
    public const int COMMA = 8;
    public const int IS = 69;
    public const int IDENTIFIER = 115;
    public const int RCURLYBRACE = 11;
    public const int ARGUMENT = 87;
    public const int TILDE = 15;
    public const int SLIST = 88;
    public const int LXOR = 32;
    public const int PLUS = 20;
    public const int DIGIT = 121;
    public const int RBRACKET = 13;
    public const int LCURLYBRACE = 10;
    public const int NEWARR = 101;
    public const int ADDEVENT = 17;
    public const int ICATCH = 106;
    public const int BECOMES = 19;
    public const int MINUS = 21;
    public const int TRUE = 53;
    public const int WRITE = 75;
    public const int PRINT = 65;
    public const int COLON = 4;
    public const int ENUMOPTION = 89;
    public const int NEQ = 29;
    public const int ENUM = 49;
    public const int QUESTION = 14;
    public const int FINALLY = 73;
    public const int FQUALIFIER = 90;
    public const int OVERRIDE = 82;
    public const int ARRELEMS = 103;
    public const int REMEVENT = 18;
    public const int PROGRAM = 84;
    public const int INTERFACE = 40;
    public const int CAREBOX = 72;
    public const int PUBLIC = 77;
    public const int EXTENDS = 62;
    public const int METHOD = 57;
    public const int LE = 24;
    public const int READVOID = 98;
    public const int STRING = 117;
    public const int LEQ = 25;
    public const int LDVIRTFTN = 112;

    // delegates
    // delegators



        public VnvdTreeWalker(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public VnvdTreeWalker(ITreeNodeStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return VnvdTreeWalker.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "VnvdTreeWalker.g"; }
    }


    	private AbstractHelper h;
    	public int SemanticErrorCount { get; private set; }
    	public String Filename { get; set; }

    	public VnvdTreeWalker(AbstractHelper helper, ITreeNodeStream input)
        		: this(input, new RecognizerSharedState())
    	{
    		this.h = helper;
        }


    public class program_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "program"
    // VnvdTreeWalker.g:61:1: program : ^(node= PROGRAM ( import_stat )* ( namespace_decl )* ) ;
    public VnvdTreeWalker.program_return program() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.program_return retval = new VnvdTreeWalker.program_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.import_stat_return import_stat1 = default(VnvdTreeWalker.import_stat_return);

        VnvdTreeWalker.namespace_decl_return namespace_decl2 = default(VnvdTreeWalker.namespace_decl_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:62:2: ( ^(node= PROGRAM ( import_stat )* ( namespace_decl )* ) )
            // VnvdTreeWalker.g:62:4: ^(node= PROGRAM ( import_stat )* ( namespace_decl )* )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,PROGRAM,FOLLOW_PROGRAM_in_program88); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // VnvdTreeWalker.g:62:19: ( import_stat )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);

            	        if ( (LA1_0 == USING) )
            	        {
            	            alt1 = 1;
            	        }


            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:62:19: import_stat
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_import_stat_in_program90);
            	    		    	import_stat1 = import_stat();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_1==null ) _first_1 = (TreeNode) import_stat1.Tree;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop1;
            	        }
            	    } while (true);

            	    loop1:
            	    	;	// Stops C# compiler whining that label 'loop1' has no statements

            	    if ( (state.backtracking==0) )
            	    {
            	       h.BeginProgram(node); 
            	    }
            	    // VnvdTreeWalker.g:62:58: ( namespace_decl )*
            	    do 
            	    {
            	        int alt2 = 2;
            	        int LA2_0 = input.LA(1);

            	        if ( (LA2_0 == NAMESPACE) )
            	        {
            	            alt2 = 1;
            	        }


            	        switch (alt2) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:62:58: namespace_decl
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_namespace_decl_in_program95);
            	    		    	namespace_decl2 = namespace_decl();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_1==null ) _first_1 = (TreeNode) namespace_decl2.Tree;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop2;
            	        }
            	    } while (true);

            	    loop2:
            	    	;	// Stops C# compiler whining that label 'loop2' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.Program(node);
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class import_stat_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "import_stat"
    // VnvdTreeWalker.g:68:1: import_stat : ^(node= USING qual= qualifier ) ;
    public VnvdTreeWalker.import_stat_return import_stat() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.import_stat_return retval = new VnvdTreeWalker.import_stat_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:69:2: ( ^(node= USING qual= qualifier ) )
            // VnvdTreeWalker.g:69:4: ^(node= USING qual= qualifier )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,USING,FOLLOW_USING_in_import_stat115); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_qualifier_in_import_stat119);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.Import(node, ((qual != null) ? qual.ids : default(Qualifier)));
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "import_stat"

    public class namespace_decl_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "namespace_decl"
    // VnvdTreeWalker.g:75:1: namespace_decl : ^(node= NAMESPACE qual= qualifier ( class_decl | interface_decl | enum_decl )* ) ;
    public VnvdTreeWalker.namespace_decl_return namespace_decl() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.namespace_decl_return retval = new VnvdTreeWalker.namespace_decl_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.class_decl_return class_decl3 = default(VnvdTreeWalker.class_decl_return);

        VnvdTreeWalker.interface_decl_return interface_decl4 = default(VnvdTreeWalker.interface_decl_return);

        VnvdTreeWalker.enum_decl_return enum_decl5 = default(VnvdTreeWalker.enum_decl_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:76:2: ( ^(node= NAMESPACE qual= qualifier ( class_decl | interface_decl | enum_decl )* ) )
            // VnvdTreeWalker.g:76:4: ^(node= NAMESPACE qual= qualifier ( class_decl | interface_decl | enum_decl )* )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,NAMESPACE,FOLLOW_NAMESPACE_in_namespace_decl138); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_qualifier_in_namespace_decl142);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;
            	if ( (state.backtracking==0) )
            	{
            	   h.BeginNamespace(node, ((qual != null) ? qual.ids : default(Qualifier))); 
            	}
            	// VnvdTreeWalker.g:76:75: ( class_decl | interface_decl | enum_decl )*
            	do 
            	{
            	    int alt3 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case CLASS:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    case INTERFACE:
            	    	{
            	        alt3 = 2;
            	        }
            	        break;
            	    case ENUM:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt3) 
            		{
            			case 1 :
            			    // VnvdTreeWalker.g:76:76: class_decl
            			    {
            			    	_last = (TreeNode)input.LT(1);
            			    	PushFollow(FOLLOW_class_decl_in_namespace_decl147);
            			    	class_decl3 = class_decl();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) 
            			    	 
            			    	if ( _first_1==null ) _first_1 = (TreeNode) class_decl3.Tree;

            			    	if ( (state.backtracking==0) ) {
            			    	retval.Tree = (TreeNode)_first_0;
            			    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            			    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            			    }
            			    break;
            			case 2 :
            			    // VnvdTreeWalker.g:76:89: interface_decl
            			    {
            			    	_last = (TreeNode)input.LT(1);
            			    	PushFollow(FOLLOW_interface_decl_in_namespace_decl151);
            			    	interface_decl4 = interface_decl();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) 
            			    	 
            			    	if ( _first_1==null ) _first_1 = (TreeNode) interface_decl4.Tree;

            			    	if ( (state.backtracking==0) ) {
            			    	retval.Tree = (TreeNode)_first_0;
            			    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            			    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            			    }
            			    break;
            			case 3 :
            			    // VnvdTreeWalker.g:76:106: enum_decl
            			    {
            			    	_last = (TreeNode)input.LT(1);
            			    	PushFollow(FOLLOW_enum_decl_in_namespace_decl155);
            			    	enum_decl5 = enum_decl();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) 
            			    	 
            			    	if ( _first_1==null ) _first_1 = (TreeNode) enum_decl5.Tree;

            			    	if ( (state.backtracking==0) ) {
            			    	retval.Tree = (TreeNode)_first_0;
            			    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            			    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.Namespace(node, ((qual != null) ? qual.ids : default(Qualifier)));
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "namespace_decl"

    public class class_decl_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "class_decl"
    // VnvdTreeWalker.g:83:1: class_decl : ^(node= CLASS ^(mod= MODIFIERS ( modifier )* ) qual= qualifier ( ^(ext= EXTENDS qualifier ) )? ( ^(imp= IMPLEMENTS ( qualifier )* ) )? ( class_element )* ) ;
    public VnvdTreeWalker.class_decl_return class_decl() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.class_decl_return retval = new VnvdTreeWalker.class_decl_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode mod = null;
        TreeNode ext = null;
        TreeNode imp = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.modifier_return modifier6 = default(VnvdTreeWalker.modifier_return);

        VnvdTreeWalker.qualifier_return qualifier7 = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.qualifier_return qualifier8 = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.class_element_return class_element9 = default(VnvdTreeWalker.class_element_return);


        TreeNode node_tree=null;
        TreeNode mod_tree=null;
        TreeNode ext_tree=null;
        TreeNode imp_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:84:2: ( ^(node= CLASS ^(mod= MODIFIERS ( modifier )* ) qual= qualifier ( ^(ext= EXTENDS qualifier ) )? ( ^(imp= IMPLEMENTS ( qualifier )* ) )? ( class_element )* ) )
            // VnvdTreeWalker.g:84:4: ^(node= CLASS ^(mod= MODIFIERS ( modifier )* ) qual= qualifier ( ^(ext= EXTENDS qualifier ) )? ( ^(imp= IMPLEMENTS ( qualifier )* ) )? ( class_element )* )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,CLASS,FOLLOW_CLASS_in_class_decl178); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_2 = _last;
            	TreeNode _first_2 = null;
            	_last = (TreeNode)input.LT(1);
            	mod=(TreeNode)Match(input,MODIFIERS,FOLLOW_MODIFIERS_in_class_decl183); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = mod;
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // VnvdTreeWalker.g:84:33: ( modifier )*
            	    do 
            	    {
            	        int alt4 = 2;
            	        int LA4_0 = input.LA(1);

            	        if ( (LA4_0 == STATIC || (LA4_0 >= PRIVATE && LA4_0 <= INITONLY)) )
            	        {
            	            alt4 = 1;
            	        }


            	        switch (alt4) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:84:33: modifier
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_modifier_in_class_decl185);
            	    		    	modifier6 = modifier();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_2==null ) _first_2 = (TreeNode) modifier6.Tree;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop4;
            	        }
            	    } while (true);

            	    loop4:
            	    	;	// Stops C# compiler whining that label 'loop4' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}_last = _save_last_2;
            	}

            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_qualifier_in_class_decl191);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;
            	// VnvdTreeWalker.g:84:59: ( ^(ext= EXTENDS qualifier ) )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == EXTENDS) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // VnvdTreeWalker.g:84:60: ^(ext= EXTENDS qualifier )
            	        {
            	        	_last = (TreeNode)input.LT(1);
            	        	{
            	        	TreeNode _save_last_2 = _last;
            	        	TreeNode _first_2 = null;
            	        	_last = (TreeNode)input.LT(1);
            	        	ext=(TreeNode)Match(input,EXTENDS,FOLLOW_EXTENDS_in_class_decl197); if (state.failed) return retval;


            	        	if ( (state.backtracking==0) )
            	        	if ( _first_1==null ) _first_1 = ext;
            	        	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        	_last = (TreeNode)input.LT(1);
            	        	PushFollow(FOLLOW_qualifier_in_class_decl199);
            	        	qualifier7 = qualifier();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) 
            	        	 
            	        	if ( _first_2==null ) _first_2 = (TreeNode) qualifier7.Tree;

            	        	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_2;
            	        	}


            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = (TreeNode)_first_0;
            	        	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        }
            	        break;

            	}

            	// VnvdTreeWalker.g:84:87: ( ^(imp= IMPLEMENTS ( qualifier )* ) )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == IMPLEMENTS) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // VnvdTreeWalker.g:84:88: ^(imp= IMPLEMENTS ( qualifier )* )
            	        {
            	        	_last = (TreeNode)input.LT(1);
            	        	{
            	        	TreeNode _save_last_2 = _last;
            	        	TreeNode _first_2 = null;
            	        	_last = (TreeNode)input.LT(1);
            	        	imp=(TreeNode)Match(input,IMPLEMENTS,FOLLOW_IMPLEMENTS_in_class_decl208); if (state.failed) return retval;


            	        	if ( (state.backtracking==0) )
            	        	if ( _first_1==null ) _first_1 = imp;
            	        	if ( input.LA(1) == Token.DOWN )
            	        	{
            	        	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        	    // VnvdTreeWalker.g:84:105: ( qualifier )*
            	        	    do 
            	        	    {
            	        	        int alt6 = 2;
            	        	        int LA6_0 = input.LA(1);

            	        	        if ( (LA6_0 == FQUALIFIER) )
            	        	        {
            	        	            alt6 = 1;
            	        	        }


            	        	        switch (alt6) 
            	        	    	{
            	        	    		case 1 :
            	        	    		    // VnvdTreeWalker.g:84:105: qualifier
            	        	    		    {
            	        	    		    	_last = (TreeNode)input.LT(1);
            	        	    		    	PushFollow(FOLLOW_qualifier_in_class_decl210);
            	        	    		    	qualifier8 = qualifier();
            	        	    		    	state.followingStackPointer--;
            	        	    		    	if (state.failed) return retval;
            	        	    		    	if ( (state.backtracking==0) ) 
            	        	    		    	 
            	        	    		    	if ( _first_2==null ) _first_2 = (TreeNode) qualifier8.Tree;

            	        	    		    	if ( (state.backtracking==0) ) {
            	        	    		    	retval.Tree = (TreeNode)_first_0;
            	        	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        	    		    }
            	        	    		    break;

            	        	    		default:
            	        	    		    goto loop6;
            	        	        }
            	        	    } while (true);

            	        	    loop6:
            	        	    	;	// Stops C# compiler whining that label 'loop6' has no statements


            	        	    Match(input, Token.UP, null); if (state.failed) return retval;
            	        	}_last = _save_last_2;
            	        	}


            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = (TreeNode)_first_0;
            	        	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        }
            	        break;

            	}

            	if ( (state.backtracking==0) )
            	{
            	   h.BeginClass(node, h.Modifiers(mod), ((qual != null) ? qual.ids : default(Qualifier)), h.Extendation(ext), h.Implements(imp)); 
            	}
            	// VnvdTreeWalker.g:85:95: ( class_element )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == METHOD || (LA8_0 >= FIELD && LA8_0 <= CONSTRUCTOR) || LA8_0 == SCONSTRUCTOR) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // VnvdTreeWalker.g:85:95: class_element
            			    {
            			    	_last = (TreeNode)input.LT(1);
            			    	PushFollow(FOLLOW_class_element_in_class_decl220);
            			    	class_element9 = class_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) 
            			    	 
            			    	if ( _first_1==null ) _first_1 = (TreeNode) class_element9.Tree;

            			    	if ( (state.backtracking==0) ) {
            			    	retval.Tree = (TreeNode)_first_0;
            			    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            			    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.Class(node, h.Modifiers(mod), ((qual != null) ? qual.ids : default(Qualifier)), h.Extendation(ext), h.Implements(imp));
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "class_decl"

    public class enum_decl_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "enum_decl"
    // VnvdTreeWalker.g:91:1: enum_decl : ^(node= ENUM ^(mod= MODIFIERS ( modifier )* ) qual= qualifier ( ^( ENUMOPTION IDENTIFIER ) )* ) ;
    public VnvdTreeWalker.enum_decl_return enum_decl() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.enum_decl_return retval = new VnvdTreeWalker.enum_decl_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode mod = null;
        TreeNode ENUMOPTION11 = null;
        TreeNode IDENTIFIER12 = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.modifier_return modifier10 = default(VnvdTreeWalker.modifier_return);


        TreeNode node_tree=null;
        TreeNode mod_tree=null;
        TreeNode ENUMOPTION11_tree=null;
        TreeNode IDENTIFIER12_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:92:2: ( ^(node= ENUM ^(mod= MODIFIERS ( modifier )* ) qual= qualifier ( ^( ENUMOPTION IDENTIFIER ) )* ) )
            // VnvdTreeWalker.g:92:4: ^(node= ENUM ^(mod= MODIFIERS ( modifier )* ) qual= qualifier ( ^( ENUMOPTION IDENTIFIER ) )* )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,ENUM,FOLLOW_ENUM_in_enum_decl240); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_2 = _last;
            	TreeNode _first_2 = null;
            	_last = (TreeNode)input.LT(1);
            	mod=(TreeNode)Match(input,MODIFIERS,FOLLOW_MODIFIERS_in_enum_decl245); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = mod;
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // VnvdTreeWalker.g:92:32: ( modifier )*
            	    do 
            	    {
            	        int alt9 = 2;
            	        int LA9_0 = input.LA(1);

            	        if ( (LA9_0 == STATIC || (LA9_0 >= PRIVATE && LA9_0 <= INITONLY)) )
            	        {
            	            alt9 = 1;
            	        }


            	        switch (alt9) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:92:32: modifier
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_modifier_in_enum_decl247);
            	    		    	modifier10 = modifier();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_2==null ) _first_2 = (TreeNode) modifier10.Tree;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop9;
            	        }
            	    } while (true);

            	    loop9:
            	    	;	// Stops C# compiler whining that label 'loop9' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}_last = _save_last_2;
            	}

            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_qualifier_in_enum_decl253);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;
            	// VnvdTreeWalker.g:92:58: ( ^( ENUMOPTION IDENTIFIER ) )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == ENUMOPTION) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // VnvdTreeWalker.g:92:59: ^( ENUMOPTION IDENTIFIER )
            			    {
            			    	_last = (TreeNode)input.LT(1);
            			    	{
            			    	TreeNode _save_last_2 = _last;
            			    	TreeNode _first_2 = null;
            			    	_last = (TreeNode)input.LT(1);
            			    	ENUMOPTION11=(TreeNode)Match(input,ENUMOPTION,FOLLOW_ENUMOPTION_in_enum_decl257); if (state.failed) return retval;


            			    	if ( (state.backtracking==0) )
            			    	if ( _first_1==null ) _first_1 = ENUMOPTION11;
            			    	Match(input, Token.DOWN, null); if (state.failed) return retval;
            			    	_last = (TreeNode)input.LT(1);
            			    	IDENTIFIER12=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_enum_decl259); if (state.failed) return retval;
            			    	 
            			    	if ( (state.backtracking==0) )
            			    	if ( _first_2==null ) _first_2 = IDENTIFIER12;

            			    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_2;
            			    	}


            			    	if ( (state.backtracking==0) ) {
            			    	retval.Tree = (TreeNode)_first_0;
            			    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            			    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}


            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "enum_decl"

    public class interface_decl_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "interface_decl"
    // VnvdTreeWalker.g:95:1: interface_decl : ^(node= INTERFACE ^(mod= MODIFIERS ( modifier )* ) qual= qualifier ( ^(ext= EXTENDS qualifier ) )? ( interface_method )* ) ;
    public VnvdTreeWalker.interface_decl_return interface_decl() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.interface_decl_return retval = new VnvdTreeWalker.interface_decl_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode mod = null;
        TreeNode ext = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.modifier_return modifier13 = default(VnvdTreeWalker.modifier_return);

        VnvdTreeWalker.qualifier_return qualifier14 = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.interface_method_return interface_method15 = default(VnvdTreeWalker.interface_method_return);


        TreeNode node_tree=null;
        TreeNode mod_tree=null;
        TreeNode ext_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:96:2: ( ^(node= INTERFACE ^(mod= MODIFIERS ( modifier )* ) qual= qualifier ( ^(ext= EXTENDS qualifier ) )? ( interface_method )* ) )
            // VnvdTreeWalker.g:96:4: ^(node= INTERFACE ^(mod= MODIFIERS ( modifier )* ) qual= qualifier ( ^(ext= EXTENDS qualifier ) )? ( interface_method )* )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,INTERFACE,FOLLOW_INTERFACE_in_interface_decl278); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_2 = _last;
            	TreeNode _first_2 = null;
            	_last = (TreeNode)input.LT(1);
            	mod=(TreeNode)Match(input,MODIFIERS,FOLLOW_MODIFIERS_in_interface_decl283); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = mod;
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // VnvdTreeWalker.g:96:37: ( modifier )*
            	    do 
            	    {
            	        int alt11 = 2;
            	        int LA11_0 = input.LA(1);

            	        if ( (LA11_0 == STATIC || (LA11_0 >= PRIVATE && LA11_0 <= INITONLY)) )
            	        {
            	            alt11 = 1;
            	        }


            	        switch (alt11) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:96:37: modifier
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_modifier_in_interface_decl285);
            	    		    	modifier13 = modifier();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_2==null ) _first_2 = (TreeNode) modifier13.Tree;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop11;
            	        }
            	    } while (true);

            	    loop11:
            	    	;	// Stops C# compiler whining that label 'loop11' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}_last = _save_last_2;
            	}

            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_qualifier_in_interface_decl291);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;
            	// VnvdTreeWalker.g:96:63: ( ^(ext= EXTENDS qualifier ) )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == EXTENDS) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // VnvdTreeWalker.g:96:64: ^(ext= EXTENDS qualifier )
            	        {
            	        	_last = (TreeNode)input.LT(1);
            	        	{
            	        	TreeNode _save_last_2 = _last;
            	        	TreeNode _first_2 = null;
            	        	_last = (TreeNode)input.LT(1);
            	        	ext=(TreeNode)Match(input,EXTENDS,FOLLOW_EXTENDS_in_interface_decl297); if (state.failed) return retval;


            	        	if ( (state.backtracking==0) )
            	        	if ( _first_1==null ) _first_1 = ext;
            	        	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        	_last = (TreeNode)input.LT(1);
            	        	PushFollow(FOLLOW_qualifier_in_interface_decl299);
            	        	qualifier14 = qualifier();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) 
            	        	 
            	        	if ( _first_2==null ) _first_2 = (TreeNode) qualifier14.Tree;

            	        	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_2;
            	        	}


            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = (TreeNode)_first_0;
            	        	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        }
            	        break;

            	}

            	if ( (state.backtracking==0) )
            	{
            	   h.BeginInterface(node, h.Modifiers(mod), ((qual != null) ? qual.ids : default(Qualifier)), h.Extendation(ext)); 
            	}
            	// VnvdTreeWalker.g:97:80: ( interface_method )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == IMETHOD) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // VnvdTreeWalker.g:97:80: interface_method
            			    {
            			    	_last = (TreeNode)input.LT(1);
            			    	PushFollow(FOLLOW_interface_method_in_interface_decl308);
            			    	interface_method15 = interface_method();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) 
            			    	 
            			    	if ( _first_1==null ) _first_1 = (TreeNode) interface_method15.Tree;

            			    	if ( (state.backtracking==0) ) {
            			    	retval.Tree = (TreeNode)_first_0;
            			    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            			    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements


            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.Interface(node, h.Modifiers(mod), ((qual != null) ? qual.ids : default(Qualifier)), h.Extendation(ext));
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "interface_decl"

    public class interface_method_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "interface_method"
    // VnvdTreeWalker.g:103:1: interface_method : ^(node= IMETHOD qual= type_qualifier id= IDENTIFIER ^(par= PARAMETER ( qualifier IDENTIFIER )* ) ) ;
    public VnvdTreeWalker.interface_method_return interface_method() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.interface_method_return retval = new VnvdTreeWalker.interface_method_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode id = null;
        TreeNode par = null;
        TreeNode IDENTIFIER17 = null;
        VnvdTreeWalker.type_qualifier_return qual = default(VnvdTreeWalker.type_qualifier_return);

        VnvdTreeWalker.qualifier_return qualifier16 = default(VnvdTreeWalker.qualifier_return);


        TreeNode node_tree=null;
        TreeNode id_tree=null;
        TreeNode par_tree=null;
        TreeNode IDENTIFIER17_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:104:2: ( ^(node= IMETHOD qual= type_qualifier id= IDENTIFIER ^(par= PARAMETER ( qualifier IDENTIFIER )* ) ) )
            // VnvdTreeWalker.g:104:4: ^(node= IMETHOD qual= type_qualifier id= IDENTIFIER ^(par= PARAMETER ( qualifier IDENTIFIER )* ) )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,IMETHOD,FOLLOW_IMETHOD_in_interface_method328); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_type_qualifier_in_interface_method332);
            	qual = type_qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;
            	_last = (TreeNode)input.LT(1);
            	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_interface_method336); if (state.failed) return retval;
            	 
            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = id;
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_2 = _last;
            	TreeNode _first_2 = null;
            	_last = (TreeNode)input.LT(1);
            	par=(TreeNode)Match(input,PARAMETER,FOLLOW_PARAMETER_in_interface_method341); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = par;
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // VnvdTreeWalker.g:104:69: ( qualifier IDENTIFIER )*
            	    do 
            	    {
            	        int alt14 = 2;
            	        int LA14_0 = input.LA(1);

            	        if ( (LA14_0 == FQUALIFIER) )
            	        {
            	            alt14 = 1;
            	        }


            	        switch (alt14) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:104:70: qualifier IDENTIFIER
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_qualifier_in_interface_method344);
            	    		    	qualifier16 = qualifier();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_2==null ) _first_2 = (TreeNode) qualifier16.Tree;
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	IDENTIFIER17=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_interface_method346); if (state.failed) return retval;
            	    		    	 
            	    		    	if ( (state.backtracking==0) )
            	    		    	if ( _first_2==null ) _first_2 = IDENTIFIER17;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop14;
            	        }
            	    } while (true);

            	    loop14:
            	    	;	// Stops C# compiler whining that label 'loop14' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}_last = _save_last_2;
            	}


            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.InterfaceMethod(node, ((qual != null) ? qual.ids : default(Qualifier)), id.Text, h.Parameters(par));
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "interface_method"

    public class class_element_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "class_element"
    // VnvdTreeWalker.g:110:1: class_element : ( method_decl | constructor_decl | field_decl | static_constructor );
    public VnvdTreeWalker.class_element_return class_element() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.class_element_return retval = new VnvdTreeWalker.class_element_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        VnvdTreeWalker.method_decl_return method_decl18 = default(VnvdTreeWalker.method_decl_return);

        VnvdTreeWalker.constructor_decl_return constructor_decl19 = default(VnvdTreeWalker.constructor_decl_return);

        VnvdTreeWalker.field_decl_return field_decl20 = default(VnvdTreeWalker.field_decl_return);

        VnvdTreeWalker.static_constructor_return static_constructor21 = default(VnvdTreeWalker.static_constructor_return);



        try 
    	{
            // VnvdTreeWalker.g:111:2: ( method_decl | constructor_decl | field_decl | static_constructor )
            int alt15 = 4;
            switch ( input.LA(1) ) 
            {
            case METHOD:
            	{
                alt15 = 1;
                }
                break;
            case CONSTRUCTOR:
            	{
                alt15 = 2;
                }
                break;
            case FIELD:
            	{
                alt15 = 3;
                }
                break;
            case SCONSTRUCTOR:
            	{
                alt15 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            }

            switch (alt15) 
            {
                case 1 :
                    // VnvdTreeWalker.g:111:4: method_decl
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_method_decl_in_class_element365);
                    	method_decl18 = method_decl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) method_decl18.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:112:4: constructor_decl
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_constructor_decl_in_class_element370);
                    	constructor_decl19 = constructor_decl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) constructor_decl19.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:113:4: field_decl
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_field_decl_in_class_element375);
                    	field_decl20 = field_decl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) field_decl20.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 4 :
                    // VnvdTreeWalker.g:114:4: static_constructor
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_static_constructor_in_class_element380);
                    	static_constructor21 = static_constructor();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) static_constructor21.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "class_element"

    public class literal_value_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "literal_value"
    // VnvdTreeWalker.g:117:1: literal_value : (node= NUMBER | node= STRING | node= FLOAT | node= CHAR | node= TRUE | node= FALSE );
    public VnvdTreeWalker.literal_value_return literal_value() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.literal_value_return retval = new VnvdTreeWalker.literal_value_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;

        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:118:2: (node= NUMBER | node= STRING | node= FLOAT | node= CHAR | node= TRUE | node= FALSE )
            int alt16 = 6;
            switch ( input.LA(1) ) 
            {
            case NUMBER:
            	{
                alt16 = 1;
                }
                break;
            case STRING:
            	{
                alt16 = 2;
                }
                break;
            case FLOAT:
            	{
                alt16 = 3;
                }
                break;
            case CHAR:
            	{
                alt16 = 4;
                }
                break;
            case TRUE:
            	{
                alt16 = 5;
                }
                break;
            case FALSE:
            	{
                alt16 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            }

            switch (alt16) 
            {
                case 1 :
                    // VnvdTreeWalker.g:118:4: node= NUMBER
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,NUMBER,FOLLOW_NUMBER_in_literal_value394); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LiteralNumber(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:122:4: node= STRING
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,STRING,FOLLOW_STRING_in_literal_value405); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LiteralString(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:126:4: node= FLOAT
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,FLOAT,FOLLOW_FLOAT_in_literal_value416); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LiteralFloat(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 4 :
                    // VnvdTreeWalker.g:130:4: node= CHAR
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,CHAR,FOLLOW_CHAR_in_literal_value427); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LiteralCharacter(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 5 :
                    // VnvdTreeWalker.g:134:4: node= TRUE
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,TRUE,FOLLOW_TRUE_in_literal_value438); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LiteralBoolean(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 6 :
                    // VnvdTreeWalker.g:138:4: node= FALSE
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,FALSE,FOLLOW_FALSE_in_literal_value449); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LiteralBoolean(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "literal_value"

    public class constant_literal_value_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "constant_literal_value"
    // VnvdTreeWalker.g:144:1: constant_literal_value : (node= NUMBER | node= STRING | node= FLOAT | node= CHAR | node= TRUE | node= FALSE );
    public VnvdTreeWalker.constant_literal_value_return constant_literal_value() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.constant_literal_value_return retval = new VnvdTreeWalker.constant_literal_value_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;

        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:145:2: (node= NUMBER | node= STRING | node= FLOAT | node= CHAR | node= TRUE | node= FALSE )
            int alt17 = 6;
            switch ( input.LA(1) ) 
            {
            case NUMBER:
            	{
                alt17 = 1;
                }
                break;
            case STRING:
            	{
                alt17 = 2;
                }
                break;
            case FLOAT:
            	{
                alt17 = 3;
                }
                break;
            case CHAR:
            	{
                alt17 = 4;
                }
                break;
            case TRUE:
            	{
                alt17 = 5;
                }
                break;
            case FALSE:
            	{
                alt17 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d17s0 =
            	        new NoViableAltException("", 17, 0, input);

            	    throw nvae_d17s0;
            }

            switch (alt17) 
            {
                case 1 :
                    // VnvdTreeWalker.g:145:4: node= NUMBER
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,NUMBER,FOLLOW_NUMBER_in_constant_literal_value466); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ConstLiteralNumber(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:149:4: node= STRING
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,STRING,FOLLOW_STRING_in_constant_literal_value477); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ConstLiteralString(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:153:4: node= FLOAT
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,FLOAT,FOLLOW_FLOAT_in_constant_literal_value488); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ConstLiteralFloat(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 4 :
                    // VnvdTreeWalker.g:157:4: node= CHAR
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,CHAR,FOLLOW_CHAR_in_constant_literal_value499); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ConstLiteralCharacter(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 5 :
                    // VnvdTreeWalker.g:161:4: node= TRUE
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,TRUE,FOLLOW_TRUE_in_constant_literal_value510); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ConstLiteralBoolean(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 6 :
                    // VnvdTreeWalker.g:165:4: node= FALSE
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,FALSE,FOLLOW_FALSE_in_constant_literal_value521); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ConstLiteralBoolean(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constant_literal_value"

    public class abstract_mod_list_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "abstract_mod_list"
    // VnvdTreeWalker.g:171:1: abstract_mod_list : ^( MODIFIERS access_modifier ABSTRACT ) ;
    public VnvdTreeWalker.abstract_mod_list_return abstract_mod_list() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.abstract_mod_list_return retval = new VnvdTreeWalker.abstract_mod_list_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode MODIFIERS22 = null;
        TreeNode ABSTRACT24 = null;
        VnvdTreeWalker.access_modifier_return access_modifier23 = default(VnvdTreeWalker.access_modifier_return);


        TreeNode MODIFIERS22_tree=null;
        TreeNode ABSTRACT24_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:172:2: ( ^( MODIFIERS access_modifier ABSTRACT ) )
            // VnvdTreeWalker.g:172:4: ^( MODIFIERS access_modifier ABSTRACT )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	MODIFIERS22=(TreeNode)Match(input,MODIFIERS,FOLLOW_MODIFIERS_in_abstract_mod_list539); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = MODIFIERS22;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_access_modifier_in_abstract_mod_list541);
            	access_modifier23 = access_modifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) access_modifier23.Tree;
            	_last = (TreeNode)input.LT(1);
            	ABSTRACT24=(TreeNode)Match(input,ABSTRACT,FOLLOW_ABSTRACT_in_abstract_mod_list543); if (state.failed) return retval;
            	 
            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = ABSTRACT24;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}


            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "abstract_mod_list"

    public class access_modifier_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "access_modifier"
    // VnvdTreeWalker.g:175:1: access_modifier : ( PRIVATE | PUBLIC | PROTECTED | INTERNAL );
    public VnvdTreeWalker.access_modifier_return access_modifier() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.access_modifier_return retval = new VnvdTreeWalker.access_modifier_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode set25 = null;

        TreeNode set25_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:176:2: ( PRIVATE | PUBLIC | PROTECTED | INTERNAL )
            // VnvdTreeWalker.g:
            {
            	_last = (TreeNode)input.LT(1);
            	set25 = (TreeNode)input.LT(1);
            	if ( (input.LA(1) >= PRIVATE && input.LA(1) <= INTERNAL) ) 
            	{
            	    input.Consume();


            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);} 

            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "access_modifier"

    public class field_decl_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "field_decl"
    // VnvdTreeWalker.g:179:1: field_decl : ^(node= FIELD ^(mod= MODIFIERS ( modifier )* ) qual= qualifier id= IDENTIFIER ) ;
    public VnvdTreeWalker.field_decl_return field_decl() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.field_decl_return retval = new VnvdTreeWalker.field_decl_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode mod = null;
        TreeNode id = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.modifier_return modifier26 = default(VnvdTreeWalker.modifier_return);


        TreeNode node_tree=null;
        TreeNode mod_tree=null;
        TreeNode id_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:180:2: ( ^(node= FIELD ^(mod= MODIFIERS ( modifier )* ) qual= qualifier id= IDENTIFIER ) )
            // VnvdTreeWalker.g:180:4: ^(node= FIELD ^(mod= MODIFIERS ( modifier )* ) qual= qualifier id= IDENTIFIER )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,FIELD,FOLLOW_FIELD_in_field_decl582); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_2 = _last;
            	TreeNode _first_2 = null;
            	_last = (TreeNode)input.LT(1);
            	mod=(TreeNode)Match(input,MODIFIERS,FOLLOW_MODIFIERS_in_field_decl587); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = mod;
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // VnvdTreeWalker.g:180:33: ( modifier )*
            	    do 
            	    {
            	        int alt18 = 2;
            	        int LA18_0 = input.LA(1);

            	        if ( (LA18_0 == STATIC || (LA18_0 >= PRIVATE && LA18_0 <= INITONLY)) )
            	        {
            	            alt18 = 1;
            	        }


            	        switch (alt18) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:180:33: modifier
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_modifier_in_field_decl589);
            	    		    	modifier26 = modifier();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_2==null ) _first_2 = (TreeNode) modifier26.Tree;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop18;
            	        }
            	    } while (true);

            	    loop18:
            	    	;	// Stops C# compiler whining that label 'loop18' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}_last = _save_last_2;
            	}

            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_qualifier_in_field_decl595);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;
            	_last = (TreeNode)input.LT(1);
            	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_field_decl599); if (state.failed) return retval;
            	 
            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = id;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.Field(node, h.Modifiers(mod), ((qual != null) ? qual.ids : default(Qualifier)), id.Text);
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "field_decl"

    public class method_decl_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "method_decl"
    // VnvdTreeWalker.g:186:1: method_decl : ^(node= METHOD ^(mod= MODIFIERS ( modifier )* ) return_= type_qualifier id= IDENTIFIER ^(par= PARAMETER ( qualifier IDENTIFIER )* ) ( block_expression )? ) ;
    public VnvdTreeWalker.method_decl_return method_decl() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.method_decl_return retval = new VnvdTreeWalker.method_decl_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode mod = null;
        TreeNode id = null;
        TreeNode par = null;
        TreeNode IDENTIFIER29 = null;
        VnvdTreeWalker.type_qualifier_return return_ = default(VnvdTreeWalker.type_qualifier_return);

        VnvdTreeWalker.modifier_return modifier27 = default(VnvdTreeWalker.modifier_return);

        VnvdTreeWalker.qualifier_return qualifier28 = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.block_expression_return block_expression30 = default(VnvdTreeWalker.block_expression_return);


        TreeNode node_tree=null;
        TreeNode mod_tree=null;
        TreeNode id_tree=null;
        TreeNode par_tree=null;
        TreeNode IDENTIFIER29_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:187:2: ( ^(node= METHOD ^(mod= MODIFIERS ( modifier )* ) return_= type_qualifier id= IDENTIFIER ^(par= PARAMETER ( qualifier IDENTIFIER )* ) ( block_expression )? ) )
            // VnvdTreeWalker.g:187:4: ^(node= METHOD ^(mod= MODIFIERS ( modifier )* ) return_= type_qualifier id= IDENTIFIER ^(par= PARAMETER ( qualifier IDENTIFIER )* ) ( block_expression )? )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,METHOD,FOLLOW_METHOD_in_method_decl619); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_2 = _last;
            	TreeNode _first_2 = null;
            	_last = (TreeNode)input.LT(1);
            	mod=(TreeNode)Match(input,MODIFIERS,FOLLOW_MODIFIERS_in_method_decl624); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = mod;
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // VnvdTreeWalker.g:187:34: ( modifier )*
            	    do 
            	    {
            	        int alt19 = 2;
            	        int LA19_0 = input.LA(1);

            	        if ( (LA19_0 == STATIC || (LA19_0 >= PRIVATE && LA19_0 <= INITONLY)) )
            	        {
            	            alt19 = 1;
            	        }


            	        switch (alt19) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:187:34: modifier
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_modifier_in_method_decl626);
            	    		    	modifier27 = modifier();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_2==null ) _first_2 = (TreeNode) modifier27.Tree;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop19;
            	        }
            	    } while (true);

            	    loop19:
            	    	;	// Stops C# compiler whining that label 'loop19' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}_last = _save_last_2;
            	}

            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_type_qualifier_in_method_decl632);
            	return_ = type_qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) return_.Tree;
            	_last = (TreeNode)input.LT(1);
            	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_method_decl636); if (state.failed) return retval;
            	 
            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = id;
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_2 = _last;
            	TreeNode _first_2 = null;
            	_last = (TreeNode)input.LT(1);
            	par=(TreeNode)Match(input,PARAMETER,FOLLOW_PARAMETER_in_method_decl641); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = par;
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // VnvdTreeWalker.g:187:98: ( qualifier IDENTIFIER )*
            	    do 
            	    {
            	        int alt20 = 2;
            	        int LA20_0 = input.LA(1);

            	        if ( (LA20_0 == FQUALIFIER) )
            	        {
            	            alt20 = 1;
            	        }


            	        switch (alt20) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:187:99: qualifier IDENTIFIER
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_qualifier_in_method_decl644);
            	    		    	qualifier28 = qualifier();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_2==null ) _first_2 = (TreeNode) qualifier28.Tree;
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	IDENTIFIER29=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_method_decl646); if (state.failed) return retval;
            	    		    	 
            	    		    	if ( (state.backtracking==0) )
            	    		    	if ( _first_2==null ) _first_2 = IDENTIFIER29;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop20;
            	        }
            	    } while (true);

            	    loop20:
            	    	;	// Stops C# compiler whining that label 'loop20' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}_last = _save_last_2;
            	}

            	if ( (state.backtracking==0) )
            	{
            	   h.BeginMethod(node, h.Modifiers(mod), ((return_ != null) ? return_.ids : default(Qualifier)), id.Text, h.Parameters(par));
            	}
            	// VnvdTreeWalker.g:187:207: ( block_expression )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( (LA21_0 == SLIST) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // VnvdTreeWalker.g:187:207: block_expression
            	        {
            	        	_last = (TreeNode)input.LT(1);
            	        	PushFollow(FOLLOW_block_expression_in_method_decl653);
            	        	block_expression30 = block_expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) 
            	        	 
            	        	if ( _first_1==null ) _first_1 = (TreeNode) block_expression30.Tree;

            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = (TreeNode)_first_0;
            	        	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.Method(node, h.Modifiers(mod), ((return_ != null) ? return_.ids : default(Qualifier)), id.Text, h.Parameters(par));
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "method_decl"

    public class constructor_decl_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "constructor_decl"
    // VnvdTreeWalker.g:193:1: constructor_decl : ^(node= CONSTRUCTOR ^(mod= MODIFIERS ( modifier )* ) id= IDENTIFIER ^(par= PARAMETER ( qualifier IDENTIFIER )* ) ( ^(bas= BASE ( ^( ALIST ( argument )* ) ) ) )? block_expression ) ;
    public VnvdTreeWalker.constructor_decl_return constructor_decl() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.constructor_decl_return retval = new VnvdTreeWalker.constructor_decl_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode mod = null;
        TreeNode id = null;
        TreeNode par = null;
        TreeNode bas = null;
        TreeNode IDENTIFIER33 = null;
        TreeNode ALIST34 = null;
        VnvdTreeWalker.modifier_return modifier31 = default(VnvdTreeWalker.modifier_return);

        VnvdTreeWalker.qualifier_return qualifier32 = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.argument_return argument35 = default(VnvdTreeWalker.argument_return);

        VnvdTreeWalker.block_expression_return block_expression36 = default(VnvdTreeWalker.block_expression_return);


        TreeNode node_tree=null;
        TreeNode mod_tree=null;
        TreeNode id_tree=null;
        TreeNode par_tree=null;
        TreeNode bas_tree=null;
        TreeNode IDENTIFIER33_tree=null;
        TreeNode ALIST34_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:194:2: ( ^(node= CONSTRUCTOR ^(mod= MODIFIERS ( modifier )* ) id= IDENTIFIER ^(par= PARAMETER ( qualifier IDENTIFIER )* ) ( ^(bas= BASE ( ^( ALIST ( argument )* ) ) ) )? block_expression ) )
            // VnvdTreeWalker.g:194:4: ^(node= CONSTRUCTOR ^(mod= MODIFIERS ( modifier )* ) id= IDENTIFIER ^(par= PARAMETER ( qualifier IDENTIFIER )* ) ( ^(bas= BASE ( ^( ALIST ( argument )* ) ) ) )? block_expression )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,CONSTRUCTOR,FOLLOW_CONSTRUCTOR_in_constructor_decl674); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_2 = _last;
            	TreeNode _first_2 = null;
            	_last = (TreeNode)input.LT(1);
            	mod=(TreeNode)Match(input,MODIFIERS,FOLLOW_MODIFIERS_in_constructor_decl679); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = mod;
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // VnvdTreeWalker.g:194:39: ( modifier )*
            	    do 
            	    {
            	        int alt22 = 2;
            	        int LA22_0 = input.LA(1);

            	        if ( (LA22_0 == STATIC || (LA22_0 >= PRIVATE && LA22_0 <= INITONLY)) )
            	        {
            	            alt22 = 1;
            	        }


            	        switch (alt22) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:194:39: modifier
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_modifier_in_constructor_decl681);
            	    		    	modifier31 = modifier();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_2==null ) _first_2 = (TreeNode) modifier31.Tree;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop22;
            	        }
            	    } while (true);

            	    loop22:
            	    	;	// Stops C# compiler whining that label 'loop22' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}_last = _save_last_2;
            	}

            	_last = (TreeNode)input.LT(1);
            	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_constructor_decl687); if (state.failed) return retval;
            	 
            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = id;
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_2 = _last;
            	TreeNode _first_2 = null;
            	_last = (TreeNode)input.LT(1);
            	par=(TreeNode)Match(input,PARAMETER,FOLLOW_PARAMETER_in_constructor_decl692); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = par;
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // VnvdTreeWalker.g:194:80: ( qualifier IDENTIFIER )*
            	    do 
            	    {
            	        int alt23 = 2;
            	        int LA23_0 = input.LA(1);

            	        if ( (LA23_0 == FQUALIFIER) )
            	        {
            	            alt23 = 1;
            	        }


            	        switch (alt23) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:194:81: qualifier IDENTIFIER
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_qualifier_in_constructor_decl695);
            	    		    	qualifier32 = qualifier();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_2==null ) _first_2 = (TreeNode) qualifier32.Tree;
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	IDENTIFIER33=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_constructor_decl697); if (state.failed) return retval;
            	    		    	 
            	    		    	if ( (state.backtracking==0) )
            	    		    	if ( _first_2==null ) _first_2 = IDENTIFIER33;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop23;
            	        }
            	    } while (true);

            	    loop23:
            	    	;	// Stops C# compiler whining that label 'loop23' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}_last = _save_last_2;
            	}

            	if ( (state.backtracking==0) )
            	{
            	   h.BeginConstructorBeforeBaseCall(node); 
            	}
            	// VnvdTreeWalker.g:194:149: ( ^(bas= BASE ( ^( ALIST ( argument )* ) ) ) )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( (LA25_0 == BASE) )
            	{
            	    alt25 = 1;
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // VnvdTreeWalker.g:194:150: ^(bas= BASE ( ^( ALIST ( argument )* ) ) )
            	        {
            	        	_last = (TreeNode)input.LT(1);
            	        	{
            	        	TreeNode _save_last_2 = _last;
            	        	TreeNode _first_2 = null;
            	        	_last = (TreeNode)input.LT(1);
            	        	bas=(TreeNode)Match(input,BASE,FOLLOW_BASE_in_constructor_decl708); if (state.failed) return retval;


            	        	if ( (state.backtracking==0) )
            	        	if ( _first_1==null ) _first_1 = bas;
            	        	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        	// VnvdTreeWalker.g:194:161: ( ^( ALIST ( argument )* ) )
            	        	// VnvdTreeWalker.g:194:162: ^( ALIST ( argument )* )
            	        	{
            	        		_last = (TreeNode)input.LT(1);
            	        		{
            	        		TreeNode _save_last_3 = _last;
            	        		TreeNode _first_3 = null;
            	        		_last = (TreeNode)input.LT(1);
            	        		ALIST34=(TreeNode)Match(input,ALIST,FOLLOW_ALIST_in_constructor_decl712); if (state.failed) return retval;


            	        		if ( (state.backtracking==0) )
            	        		if ( _first_2==null ) _first_2 = ALIST34;
            	        		if ( input.LA(1) == Token.DOWN )
            	        		{
            	        		    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        		    // VnvdTreeWalker.g:194:170: ( argument )*
            	        		    do 
            	        		    {
            	        		        int alt24 = 2;
            	        		        int LA24_0 = input.LA(1);

            	        		        if ( (LA24_0 == ARGUMENT) )
            	        		        {
            	        		            alt24 = 1;
            	        		        }


            	        		        switch (alt24) 
            	        		    	{
            	        		    		case 1 :
            	        		    		    // VnvdTreeWalker.g:194:170: argument
            	        		    		    {
            	        		    		    	_last = (TreeNode)input.LT(1);
            	        		    		    	PushFollow(FOLLOW_argument_in_constructor_decl714);
            	        		    		    	argument35 = argument();
            	        		    		    	state.followingStackPointer--;
            	        		    		    	if (state.failed) return retval;
            	        		    		    	if ( (state.backtracking==0) ) 
            	        		    		    	 
            	        		    		    	if ( _first_3==null ) _first_3 = (TreeNode) argument35.Tree;

            	        		    		    	if ( (state.backtracking==0) ) {
            	        		    		    	retval.Tree = (TreeNode)_first_0;
            	        		    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        		    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        		    		    }
            	        		    		    break;

            	        		    		default:
            	        		    		    goto loop24;
            	        		        }
            	        		    } while (true);

            	        		    loop24:
            	        		    	;	// Stops C# compiler whining that label 'loop24' has no statements


            	        		    Match(input, Token.UP, null); if (state.failed) return retval;
            	        		}_last = _save_last_3;
            	        		}


            	        		if ( (state.backtracking==0) ) {
            	        		retval.Tree = (TreeNode)_first_0;
            	        		if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        		    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        	}


            	        	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_2;
            	        	}


            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = (TreeNode)_first_0;
            	        	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        }
            	        break;

            	}

            	if ( (state.backtracking==0) )
            	{
            	   h.BeginConstructor(node, h.Modifiers(mod), h.Parameters(par), bas); 
            	}
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_block_expression_in_constructor_decl724);
            	block_expression36 = block_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) block_expression36.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.Constructor(node, h.Modifiers(mod), h.Parameters(par));
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constructor_decl"

    public class static_constructor_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "static_constructor"
    // VnvdTreeWalker.g:200:1: static_constructor : ^(node= SCONSTRUCTOR block_expression ) ;
    public VnvdTreeWalker.static_constructor_return static_constructor() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.static_constructor_return retval = new VnvdTreeWalker.static_constructor_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.block_expression_return block_expression37 = default(VnvdTreeWalker.block_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:201:2: ( ^(node= SCONSTRUCTOR block_expression ) )
            // VnvdTreeWalker.g:201:4: ^(node= SCONSTRUCTOR block_expression )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,SCONSTRUCTOR,FOLLOW_SCONSTRUCTOR_in_static_constructor744); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;if ( (state.backtracking==0) )
            	{
            	   h.BeginStaticConstructor(node); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_block_expression_in_static_constructor748);
            	block_expression37 = block_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) block_expression37.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  		h.EndStaticConstructor(node); 
            	  	
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "static_constructor"

    public class statement_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "statement"
    // VnvdTreeWalker.g:207:1: statement : ( expression | declaration_statement | const_decl_statement );
    public VnvdTreeWalker.statement_return statement() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.statement_return retval = new VnvdTreeWalker.statement_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        VnvdTreeWalker.expression_return expression38 = default(VnvdTreeWalker.expression_return);

        VnvdTreeWalker.declaration_statement_return declaration_statement39 = default(VnvdTreeWalker.declaration_statement_return);

        VnvdTreeWalker.const_decl_statement_return const_decl_statement40 = default(VnvdTreeWalker.const_decl_statement_return);



        try 
    	{
            // VnvdTreeWalker.g:208:2: ( expression | declaration_statement | const_decl_statement )
            int alt26 = 3;
            switch ( input.LA(1) ) 
            {
            case LBRACKET:
            case DCOLON:
            case ADDEVENT:
            case REMEVENT:
            case BECOMES:
            case PLUS:
            case MINUS:
            case MULTIPLY:
            case DIVISION:
            case LE:
            case LEQ:
            case GE:
            case GEQ:
            case EQ:
            case NEQ:
            case AND:
            case OR:
            case LXOR:
            case LAND:
            case LOR:
            case NOT:
            case MOD:
            case NEW:
            case IF:
            case WHILE:
            case FOR:
            case TRUE:
            case FALSE:
            case BASE:
            case THIS:
            case READ:
            case NULL:
            case AS:
            case IS:
            case TRY:
            case THROW:
            case WRITE:
            case SLIST:
            case EXPRBLOCK:
            case USAGE:
            case SCOPEEXPR:
            case CAST:
            case READVOID:
            case WRITEVOID:
            case NEWARR:
            case NEWARRELEMS:
            case CALLVIRT:
            case CALL:
            case LDFLD:
            case LDSFLD:
            case LDLITERAL:
            case LDVIRTFTN:
            case LDFTN:
            case DONTLD:
            case NUMBER:
            case STRING:
            case CHAR:
            case FLOAT:
            	{
                alt26 = 1;
                }
                break;
            case LOCAL:
            	{
                alt26 = 2;
                }
                break;
            case CONST:
            	{
                alt26 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d26s0 =
            	        new NoViableAltException("", 26, 0, input);

            	    throw nvae_d26s0;
            }

            switch (alt26) 
            {
                case 1 :
                    // VnvdTreeWalker.g:208:4: expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_statement764);
                    	expression38 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) expression38.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:209:4: declaration_statement
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_declaration_statement_in_statement769);
                    	declaration_statement39 = declaration_statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) declaration_statement39.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:210:4: const_decl_statement
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_const_decl_statement_in_statement774);
                    	const_decl_statement40 = const_decl_statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) const_decl_statement40.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class throw_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "throw_expression"
    // VnvdTreeWalker.g:213:1: throw_expression : ^(node= THROW expression ) ;
    public VnvdTreeWalker.throw_expression_return throw_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.throw_expression_return retval = new VnvdTreeWalker.throw_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.expression_return expression41 = default(VnvdTreeWalker.expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:214:2: ( ^(node= THROW expression ) )
            // VnvdTreeWalker.g:214:4: ^(node= THROW expression )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,THROW,FOLLOW_THROW_in_throw_expression788); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_expression_in_throw_expression790);
            	expression41 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) expression41.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.ThrowStatement(node);
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "throw_expression"

    public class try_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "try_expression"
    // VnvdTreeWalker.g:220:1: try_expression : ^(node= TRY expression ( catch_block )* ( finally_block )? ) ;
    public VnvdTreeWalker.try_expression_return try_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.try_expression_return retval = new VnvdTreeWalker.try_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.expression_return expression42 = default(VnvdTreeWalker.expression_return);

        VnvdTreeWalker.catch_block_return catch_block43 = default(VnvdTreeWalker.catch_block_return);

        VnvdTreeWalker.finally_block_return finally_block44 = default(VnvdTreeWalker.finally_block_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:221:2: ( ^(node= TRY expression ( catch_block )* ( finally_block )? ) )
            // VnvdTreeWalker.g:221:4: ^(node= TRY expression ( catch_block )* ( finally_block )? )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,TRY,FOLLOW_TRY_in_try_expression810); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;if ( (state.backtracking==0) )
            	{
            	   h.BeginTry(node); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_expression_in_try_expression814);
            	expression42 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) expression42.Tree;
            	// VnvdTreeWalker.g:221:48: ( catch_block )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( (LA27_0 == ICATCH) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // VnvdTreeWalker.g:221:48: catch_block
            			    {
            			    	_last = (TreeNode)input.LT(1);
            			    	PushFollow(FOLLOW_catch_block_in_try_expression816);
            			    	catch_block43 = catch_block();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) 
            			    	 
            			    	if ( _first_1==null ) _first_1 = (TreeNode) catch_block43.Tree;

            			    	if ( (state.backtracking==0) ) {
            			    	retval.Tree = (TreeNode)_first_0;
            			    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            			    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements

            	// VnvdTreeWalker.g:221:61: ( finally_block )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == FINALLY) )
            	{
            	    alt28 = 1;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // VnvdTreeWalker.g:221:61: finally_block
            	        {
            	        	_last = (TreeNode)input.LT(1);
            	        	PushFollow(FOLLOW_finally_block_in_try_expression819);
            	        	finally_block44 = finally_block();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) 
            	        	 
            	        	if ( _first_1==null ) _first_1 = (TreeNode) finally_block44.Tree;

            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = (TreeNode)_first_0;
            	        	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.EndTry(node);
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "try_expression"

    public class catch_block_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "catch_block"
    // VnvdTreeWalker.g:227:1: catch_block : ^(node= ICATCH ^(node2= LOCAL qual= qualifier id= IDENTIFIER ) expression ) ;
    public VnvdTreeWalker.catch_block_return catch_block() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.catch_block_return retval = new VnvdTreeWalker.catch_block_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode node2 = null;
        TreeNode id = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.expression_return expression45 = default(VnvdTreeWalker.expression_return);


        TreeNode node_tree=null;
        TreeNode node2_tree=null;
        TreeNode id_tree=null;

         h.OpenScope(); 
        try 
    	{
            // VnvdTreeWalker.g:229:2: ( ^(node= ICATCH ^(node2= LOCAL qual= qualifier id= IDENTIFIER ) expression ) )
            // VnvdTreeWalker.g:229:4: ^(node= ICATCH ^(node2= LOCAL qual= qualifier id= IDENTIFIER ) expression )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,ICATCH,FOLLOW_ICATCH_in_catch_block846); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_2 = _last;
            	TreeNode _first_2 = null;
            	_last = (TreeNode)input.LT(1);
            	node2=(TreeNode)Match(input,LOCAL,FOLLOW_LOCAL_in_catch_block851); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = node2;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_qualifier_in_catch_block855);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_2==null ) _first_2 = (TreeNode) qual.Tree;
            	_last = (TreeNode)input.LT(1);
            	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_catch_block859); if (state.failed) return retval;
            	 
            	if ( (state.backtracking==0) )
            	if ( _first_2==null ) _first_2 = id;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_2;
            	}

            	if ( (state.backtracking==0) )
            	{
            	   h.DeclarationStatement(node2, ((qual != null) ? qual.ids : default(Qualifier)), id.Text); h.BeginCatch(node, node2, ((qual != null) ? qual.ids : default(Qualifier)), id.Text); 
            	}
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_expression_in_catch_block864);
            	expression45 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) expression45.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.EndCatch(node, ((qual != null) ? qual.ids : default(Qualifier)), id.Text);
            	  			h.CloseScope();		
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "catch_block"

    public class finally_block_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "finally_block"
    // VnvdTreeWalker.g:236:1: finally_block : ^(node= FINALLY expression ) ;
    public VnvdTreeWalker.finally_block_return finally_block() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.finally_block_return retval = new VnvdTreeWalker.finally_block_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.expression_return expression46 = default(VnvdTreeWalker.expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:237:2: ( ^(node= FINALLY expression ) )
            // VnvdTreeWalker.g:237:4: ^(node= FINALLY expression )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,FINALLY,FOLLOW_FINALLY_in_finally_block883); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;if ( (state.backtracking==0) )
            	{
            	   h.BeginFinally(node); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_expression_in_finally_block887);
            	expression46 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) expression46.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.EndFinally(node);
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "finally_block"

    public class while_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "while_expression"
    // VnvdTreeWalker.g:243:1: while_expression : ^(node= WHILE scope_expr expression ) ;
    public VnvdTreeWalker.while_expression_return while_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.while_expression_return retval = new VnvdTreeWalker.while_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.scope_expr_return scope_expr47 = default(VnvdTreeWalker.scope_expr_return);

        VnvdTreeWalker.expression_return expression48 = default(VnvdTreeWalker.expression_return);


        TreeNode node_tree=null;

         h.OpenScope(); 
        try 
    	{
            // VnvdTreeWalker.g:245:2: ( ^(node= WHILE scope_expr expression ) )
            // VnvdTreeWalker.g:245:4: ^(node= WHILE scope_expr expression )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,WHILE,FOLLOW_WHILE_in_while_expression913); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;if ( (state.backtracking==0) )
            	{
            	   h.WhileStart(node); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_scope_expr_in_while_expression917);
            	scope_expr47 = scope_expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) scope_expr47.Tree;
            	if ( (state.backtracking==0) )
            	{
            	   h.WhileAfterExpr(node); 
            	}
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_expression_in_while_expression921);
            	expression48 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) expression48.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.WhileLoop(node);
            	  			h.CloseScope();
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "while_expression"

    public class for_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "for_expression"
    // VnvdTreeWalker.g:252:1: for_expression : ^(node= FOR ^(node2= LOCAL qual= qualifier id= IDENTIFIER ) expression expression ) ;
    public VnvdTreeWalker.for_expression_return for_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.for_expression_return retval = new VnvdTreeWalker.for_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode node2 = null;
        TreeNode id = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.expression_return expression49 = default(VnvdTreeWalker.expression_return);

        VnvdTreeWalker.expression_return expression50 = default(VnvdTreeWalker.expression_return);


        TreeNode node_tree=null;
        TreeNode node2_tree=null;
        TreeNode id_tree=null;

         h.OpenScope(); 
        try 
    	{
            // VnvdTreeWalker.g:254:2: ( ^(node= FOR ^(node2= LOCAL qual= qualifier id= IDENTIFIER ) expression expression ) )
            // VnvdTreeWalker.g:254:4: ^(node= FOR ^(node2= LOCAL qual= qualifier id= IDENTIFIER ) expression expression )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,FOR,FOLLOW_FOR_in_for_expression947); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_2 = _last;
            	TreeNode _first_2 = null;
            	_last = (TreeNode)input.LT(1);
            	node2=(TreeNode)Match(input,LOCAL,FOLLOW_LOCAL_in_for_expression952); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = node2;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_qualifier_in_for_expression956);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_2==null ) _first_2 = (TreeNode) qual.Tree;
            	_last = (TreeNode)input.LT(1);
            	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_for_expression960); if (state.failed) return retval;
            	 
            	if ( (state.backtracking==0) )
            	if ( _first_2==null ) _first_2 = id;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_2;
            	}

            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_expression_in_for_expression963);
            	expression49 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) expression49.Tree;
            	if ( (state.backtracking==0) )
            	{
            	   h.DeclarationStatement(node2, ((qual != null) ? qual.ids : default(Qualifier)), id.Text); h.BeginFor(node, node2, ((qual != null) ? qual.ids : default(Qualifier)), id.Text); 
            	}
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_expression_in_for_expression967);
            	expression50 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) expression50.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.ForLoop(node);
            	  			
            	  			h.CloseScope();
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "for_expression"

    public class scope_expr_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "scope_expr"
    // VnvdTreeWalker.g:262:1: scope_expr : ^(node= SCOPEEXPR ( statement )+ ) ;
    public VnvdTreeWalker.scope_expr_return scope_expr() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.scope_expr_return retval = new VnvdTreeWalker.scope_expr_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.statement_return statement51 = default(VnvdTreeWalker.statement_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:263:2: ( ^(node= SCOPEEXPR ( statement )+ ) )
            // VnvdTreeWalker.g:263:4: ^(node= SCOPEEXPR ( statement )+ )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,SCOPEEXPR,FOLLOW_SCOPEEXPR_in_scope_expr986); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	// VnvdTreeWalker.g:263:21: ( statement )+
            	int cnt29 = 0;
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == LBRACKET || (LA29_0 >= DCOLON && LA29_0 <= MOD) || LA29_0 == NEW || LA29_0 == IF || (LA29_0 >= WHILE && LA29_0 <= FOR) || (LA29_0 >= CONST && LA29_0 <= THIS) || LA29_0 == LOCAL || (LA29_0 >= READ && LA29_0 <= TRY) || (LA29_0 >= THROW && LA29_0 <= WRITE) || LA29_0 == SLIST || (LA29_0 >= EXPRBLOCK && LA29_0 <= CAST) || (LA29_0 >= READVOID && LA29_0 <= WRITEVOID) || (LA29_0 >= NEWARR && LA29_0 <= NEWARRELEMS) || (LA29_0 >= CALLVIRT && LA29_0 <= DONTLD) || (LA29_0 >= NUMBER && LA29_0 <= FLOAT)) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // VnvdTreeWalker.g:263:21: statement
            			    {
            			    	_last = (TreeNode)input.LT(1);
            			    	PushFollow(FOLLOW_statement_in_scope_expr988);
            			    	statement51 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) 
            			    	 
            			    	if ( _first_1==null ) _first_1 = (TreeNode) statement51.Tree;

            			    	if ( (state.backtracking==0) ) {
            			    	retval.Tree = (TreeNode)_first_0;
            			    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            			    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            			    }
            			    break;

            			default:
            			    if ( cnt29 >= 1 ) goto loop29;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee29 =
            		                new EarlyExitException(29, input);
            		            throw eee29;
            	    }
            	    cnt29++;
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements


            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  		h.ScopeExpr(node);
            	  	
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "scope_expr"

    public class declaration_statement_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "declaration_statement"
    // VnvdTreeWalker.g:269:1: declaration_statement : ^(node= LOCAL qual= qualifier id= IDENTIFIER ) ;
    public VnvdTreeWalker.declaration_statement_return declaration_statement() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.declaration_statement_return retval = new VnvdTreeWalker.declaration_statement_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode id = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);


        TreeNode node_tree=null;
        TreeNode id_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:270:2: ( ^(node= LOCAL qual= qualifier id= IDENTIFIER ) )
            // VnvdTreeWalker.g:270:4: ^(node= LOCAL qual= qualifier id= IDENTIFIER )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,LOCAL,FOLLOW_LOCAL_in_declaration_statement1008); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_qualifier_in_declaration_statement1012);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;
            	_last = (TreeNode)input.LT(1);
            	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_declaration_statement1016); if (state.failed) return retval;
            	 
            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = id;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.DeclarationStatement(node, ((qual != null) ? qual.ids : default(Qualifier)), id.Text);
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "declaration_statement"

    public class const_decl_statement_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "const_decl_statement"
    // VnvdTreeWalker.g:276:1: const_decl_statement : ^(node= CONST qual= qualifier id= IDENTIFIER const_value ) ;
    public VnvdTreeWalker.const_decl_statement_return const_decl_statement() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.const_decl_statement_return retval = new VnvdTreeWalker.const_decl_statement_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode id = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.const_value_return const_value52 = default(VnvdTreeWalker.const_value_return);


        TreeNode node_tree=null;
        TreeNode id_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:277:2: ( ^(node= CONST qual= qualifier id= IDENTIFIER const_value ) )
            // VnvdTreeWalker.g:277:4: ^(node= CONST qual= qualifier id= IDENTIFIER const_value )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,CONST,FOLLOW_CONST_in_const_decl_statement1035); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_qualifier_in_const_decl_statement1039);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;
            	_last = (TreeNode)input.LT(1);
            	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_const_decl_statement1043); if (state.failed) return retval;
            	 
            	if ( (state.backtracking==0) )
            	if ( _first_1==null ) _first_1 = id;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_const_value_in_const_decl_statement1045);
            	const_value52 = const_value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) const_value52.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.ConstantDeclaration(node, ((qual != null) ? qual.ids : default(Qualifier)), id.Text);
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "const_decl_statement"

    public class const_value_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "const_value"
    // VnvdTreeWalker.g:283:1: const_value : ( constant_literal_value | ^(node= ARRELEMS ( const_array_element )+ ) );
    public VnvdTreeWalker.const_value_return const_value() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.const_value_return retval = new VnvdTreeWalker.const_value_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.constant_literal_value_return constant_literal_value53 = default(VnvdTreeWalker.constant_literal_value_return);

        VnvdTreeWalker.const_array_element_return const_array_element54 = default(VnvdTreeWalker.const_array_element_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:284:2: ( constant_literal_value | ^(node= ARRELEMS ( const_array_element )+ ) )
            int alt31 = 2;
            int LA31_0 = input.LA(1);

            if ( ((LA31_0 >= TRUE && LA31_0 <= FALSE) || (LA31_0 >= NUMBER && LA31_0 <= FLOAT)) )
            {
                alt31 = 1;
            }
            else if ( (LA31_0 == ARRELEMS) )
            {
                alt31 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d31s0 =
                    new NoViableAltException("", 31, 0, input);

                throw nvae_d31s0;
            }
            switch (alt31) 
            {
                case 1 :
                    // VnvdTreeWalker.g:284:4: constant_literal_value
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_constant_literal_value_in_const_value1062);
                    	constant_literal_value53 = constant_literal_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) constant_literal_value53.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:285:4: ^(node= ARRELEMS ( const_array_element )+ )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,ARRELEMS,FOLLOW_ARRELEMS_in_const_value1070); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	// VnvdTreeWalker.g:285:20: ( const_array_element )+
                    	int cnt30 = 0;
                    	do 
                    	{
                    	    int alt30 = 2;
                    	    int LA30_0 = input.LA(1);

                    	    if ( (LA30_0 == ARRELEM) )
                    	    {
                    	        alt30 = 1;
                    	    }


                    	    switch (alt30) 
                    		{
                    			case 1 :
                    			    // VnvdTreeWalker.g:285:21: const_array_element
                    			    {
                    			    	_last = (TreeNode)input.LT(1);
                    			    	PushFollow(FOLLOW_const_array_element_in_const_value1073);
                    			    	const_array_element54 = const_array_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) 
                    			    	 
                    			    	if ( _first_1==null ) _first_1 = (TreeNode) const_array_element54.Tree;

                    			    	if ( (state.backtracking==0) ) {
                    			    	retval.Tree = (TreeNode)_first_0;
                    			    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    			    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    			    }
                    			    break;

                    			default:
                    			    if ( cnt30 >= 1 ) goto loop30;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee30 =
                    		                new EarlyExitException(30, input);
                    		            throw eee30;
                    	    }
                    	    cnt30++;
                    	} while (true);

                    	loop30:
                    		;	// Stops C# compiler whining that label 'loop30' has no statements


                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ConstantArray(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "const_value"

    public class const_array_element_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "const_array_element"
    // VnvdTreeWalker.g:291:1: const_array_element : ^(node= ARRELEM literal_value ) ;
    public VnvdTreeWalker.const_array_element_return const_array_element() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.const_array_element_return retval = new VnvdTreeWalker.const_array_element_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.literal_value_return literal_value55 = default(VnvdTreeWalker.literal_value_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:292:2: ( ^(node= ARRELEM literal_value ) )
            // VnvdTreeWalker.g:292:4: ^(node= ARRELEM literal_value )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,ARRELEM,FOLLOW_ARRELEM_in_const_array_element1095); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_literal_value_in_const_array_element1097);
            	literal_value55 = literal_value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) literal_value55.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.ConstantArrayElement(node);
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "const_array_element"

    public class expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "expression"
    // VnvdTreeWalker.g:298:1: expression : assignment_expression ;
    public VnvdTreeWalker.expression_return expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.expression_return retval = new VnvdTreeWalker.expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        VnvdTreeWalker.assignment_expression_return assignment_expression56 = default(VnvdTreeWalker.assignment_expression_return);



        try 
    	{
            // VnvdTreeWalker.g:299:2: ( assignment_expression )
            // VnvdTreeWalker.g:299:4: assignment_expression
            {
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_assignment_expression_in_expression1113);
            	assignment_expression56 = assignment_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_0==null ) _first_0 = (TreeNode) assignment_expression56.Tree;

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class assignment_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "assignment_expression"
    // VnvdTreeWalker.g:302:1: assignment_expression : ( control_expression | ^(node= BECOMES assignment_expression assignment_expression ) | ^(node= ADDEVENT assignment_expression assignment_expression ) | ^(node= REMEVENT assignment_expression assignment_expression ) );
    public VnvdTreeWalker.assignment_expression_return assignment_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.assignment_expression_return retval = new VnvdTreeWalker.assignment_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.control_expression_return control_expression57 = default(VnvdTreeWalker.control_expression_return);

        VnvdTreeWalker.assignment_expression_return assignment_expression58 = default(VnvdTreeWalker.assignment_expression_return);

        VnvdTreeWalker.assignment_expression_return assignment_expression59 = default(VnvdTreeWalker.assignment_expression_return);

        VnvdTreeWalker.assignment_expression_return assignment_expression60 = default(VnvdTreeWalker.assignment_expression_return);

        VnvdTreeWalker.assignment_expression_return assignment_expression61 = default(VnvdTreeWalker.assignment_expression_return);

        VnvdTreeWalker.assignment_expression_return assignment_expression62 = default(VnvdTreeWalker.assignment_expression_return);

        VnvdTreeWalker.assignment_expression_return assignment_expression63 = default(VnvdTreeWalker.assignment_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:303:2: ( control_expression | ^(node= BECOMES assignment_expression assignment_expression ) | ^(node= ADDEVENT assignment_expression assignment_expression ) | ^(node= REMEVENT assignment_expression assignment_expression ) )
            int alt32 = 4;
            switch ( input.LA(1) ) 
            {
            case LBRACKET:
            case DCOLON:
            case PLUS:
            case MINUS:
            case MULTIPLY:
            case DIVISION:
            case LE:
            case LEQ:
            case GE:
            case GEQ:
            case EQ:
            case NEQ:
            case AND:
            case OR:
            case LXOR:
            case LAND:
            case LOR:
            case NOT:
            case MOD:
            case NEW:
            case IF:
            case WHILE:
            case FOR:
            case TRUE:
            case FALSE:
            case BASE:
            case THIS:
            case READ:
            case NULL:
            case AS:
            case IS:
            case TRY:
            case THROW:
            case WRITE:
            case SLIST:
            case EXPRBLOCK:
            case USAGE:
            case SCOPEEXPR:
            case CAST:
            case READVOID:
            case WRITEVOID:
            case NEWARR:
            case NEWARRELEMS:
            case CALLVIRT:
            case CALL:
            case LDFLD:
            case LDSFLD:
            case LDLITERAL:
            case LDVIRTFTN:
            case LDFTN:
            case DONTLD:
            case NUMBER:
            case STRING:
            case CHAR:
            case FLOAT:
            	{
                alt32 = 1;
                }
                break;
            case BECOMES:
            	{
                alt32 = 2;
                }
                break;
            case ADDEVENT:
            	{
                alt32 = 3;
                }
                break;
            case REMEVENT:
            	{
                alt32 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d32s0 =
            	        new NoViableAltException("", 32, 0, input);

            	    throw nvae_d32s0;
            }

            switch (alt32) 
            {
                case 1 :
                    // VnvdTreeWalker.g:303:4: control_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_control_expression_in_assignment_expression1124);
                    	control_expression57 = control_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) control_expression57.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:304:4: ^(node= BECOMES assignment_expression assignment_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,BECOMES,FOLLOW_BECOMES_in_assignment_expression1132); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_assignment_expression_in_assignment_expression1134);
                    	assignment_expression58 = assignment_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) assignment_expression58.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_assignment_expression_in_assignment_expression1136);
                    	assignment_expression59 = assignment_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) assignment_expression59.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.AssignmentExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:308:4: ^(node= ADDEVENT assignment_expression assignment_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,ADDEVENT,FOLLOW_ADDEVENT_in_assignment_expression1149); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_assignment_expression_in_assignment_expression1151);
                    	assignment_expression60 = assignment_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) assignment_expression60.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_assignment_expression_in_assignment_expression1153);
                    	assignment_expression61 = assignment_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) assignment_expression61.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.AddEventExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 4 :
                    // VnvdTreeWalker.g:312:4: ^(node= REMEVENT assignment_expression assignment_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,REMEVENT,FOLLOW_REMEVENT_in_assignment_expression1166); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_assignment_expression_in_assignment_expression1168);
                    	assignment_expression62 = assignment_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) assignment_expression62.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_assignment_expression_in_assignment_expression1170);
                    	assignment_expression63 = assignment_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) assignment_expression63.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.RemoveEventExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment_expression"

    public class control_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "control_expression"
    // VnvdTreeWalker.g:318:1: control_expression : ( while_expression | for_expression | try_expression | throw_expression | ^(node= IF scope_expr expression ( expression )? ) | conditional_or_operator_expression );
    public VnvdTreeWalker.control_expression_return control_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.control_expression_return retval = new VnvdTreeWalker.control_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.while_expression_return while_expression64 = default(VnvdTreeWalker.while_expression_return);

        VnvdTreeWalker.for_expression_return for_expression65 = default(VnvdTreeWalker.for_expression_return);

        VnvdTreeWalker.try_expression_return try_expression66 = default(VnvdTreeWalker.try_expression_return);

        VnvdTreeWalker.throw_expression_return throw_expression67 = default(VnvdTreeWalker.throw_expression_return);

        VnvdTreeWalker.scope_expr_return scope_expr68 = default(VnvdTreeWalker.scope_expr_return);

        VnvdTreeWalker.expression_return expression69 = default(VnvdTreeWalker.expression_return);

        VnvdTreeWalker.expression_return expression70 = default(VnvdTreeWalker.expression_return);

        VnvdTreeWalker.conditional_or_operator_expression_return conditional_or_operator_expression71 = default(VnvdTreeWalker.conditional_or_operator_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:319:2: ( while_expression | for_expression | try_expression | throw_expression | ^(node= IF scope_expr expression ( expression )? ) | conditional_or_operator_expression )
            int alt34 = 6;
            switch ( input.LA(1) ) 
            {
            case WHILE:
            	{
                alt34 = 1;
                }
                break;
            case FOR:
            	{
                alt34 = 2;
                }
                break;
            case TRY:
            	{
                alt34 = 3;
                }
                break;
            case THROW:
            	{
                alt34 = 4;
                }
                break;
            case IF:
            	{
                alt34 = 5;
                }
                break;
            case LBRACKET:
            case DCOLON:
            case PLUS:
            case MINUS:
            case MULTIPLY:
            case DIVISION:
            case LE:
            case LEQ:
            case GE:
            case GEQ:
            case EQ:
            case NEQ:
            case AND:
            case OR:
            case LXOR:
            case LAND:
            case LOR:
            case NOT:
            case MOD:
            case NEW:
            case TRUE:
            case FALSE:
            case BASE:
            case THIS:
            case READ:
            case NULL:
            case AS:
            case IS:
            case WRITE:
            case SLIST:
            case EXPRBLOCK:
            case USAGE:
            case SCOPEEXPR:
            case CAST:
            case READVOID:
            case WRITEVOID:
            case NEWARR:
            case NEWARRELEMS:
            case CALLVIRT:
            case CALL:
            case LDFLD:
            case LDSFLD:
            case LDLITERAL:
            case LDVIRTFTN:
            case LDFTN:
            case DONTLD:
            case NUMBER:
            case STRING:
            case CHAR:
            case FLOAT:
            	{
                alt34 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d34s0 =
            	        new NoViableAltException("", 34, 0, input);

            	    throw nvae_d34s0;
            }

            switch (alt34) 
            {
                case 1 :
                    // VnvdTreeWalker.g:319:4: while_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_while_expression_in_control_expression1186);
                    	while_expression64 = while_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) while_expression64.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:320:4: for_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_for_expression_in_control_expression1191);
                    	for_expression65 = for_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) for_expression65.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:321:4: try_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_try_expression_in_control_expression1196);
                    	try_expression66 = try_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) try_expression66.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 4 :
                    // VnvdTreeWalker.g:322:4: throw_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_throw_expression_in_control_expression1201);
                    	throw_expression67 = throw_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) throw_expression67.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 5 :
                    // VnvdTreeWalker.g:323:4: ^(node= IF scope_expr expression ( expression )? )
                    {
                    	if ( (state.backtracking==0) )
                    	{
                    	   h.OpenScope(); 
                    	}
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,IF,FOLLOW_IF_in_control_expression1213); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_scope_expr_in_control_expression1215);
                    	scope_expr68 = scope_expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) scope_expr68.Tree;
                    	if ( (state.backtracking==0) )
                    	{
                    	   h.TernaryThen(node); 
                    	}
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_control_expression1219);
                    	expression69 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) expression69.Tree;
                    	if ( (state.backtracking==0) )
                    	{
                    	   h.TernaryElse(node); 
                    	}
                    	// VnvdTreeWalker.g:324:85: ( expression )?
                    	int alt33 = 2;
                    	int LA33_0 = input.LA(1);

                    	if ( (LA33_0 == LBRACKET || (LA33_0 >= DCOLON && LA33_0 <= MOD) || LA33_0 == NEW || LA33_0 == IF || (LA33_0 >= WHILE && LA33_0 <= FOR) || (LA33_0 >= TRUE && LA33_0 <= THIS) || (LA33_0 >= READ && LA33_0 <= TRY) || (LA33_0 >= THROW && LA33_0 <= WRITE) || LA33_0 == SLIST || (LA33_0 >= EXPRBLOCK && LA33_0 <= CAST) || (LA33_0 >= READVOID && LA33_0 <= WRITEVOID) || (LA33_0 >= NEWARR && LA33_0 <= NEWARRELEMS) || (LA33_0 >= CALLVIRT && LA33_0 <= DONTLD) || (LA33_0 >= NUMBER && LA33_0 <= FLOAT)) )
                    	{
                    	    alt33 = 1;
                    	}
                    	switch (alt33) 
                    	{
                    	    case 1 :
                    	        // VnvdTreeWalker.g:324:85: expression
                    	        {
                    	        	_last = (TreeNode)input.LT(1);
                    	        	PushFollow(FOLLOW_expression_in_control_expression1223);
                    	        	expression70 = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) 
                    	        	 
                    	        	if ( _first_1==null ) _first_1 = (TreeNode) expression70.Tree;

                    	        	if ( (state.backtracking==0) ) {
                    	        	retval.Tree = (TreeNode)_first_0;
                    	        	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	        	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.TernaryExpr(node);
                    	  			h.CloseScope();
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 6 :
                    // VnvdTreeWalker.g:329:4: conditional_or_operator_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_conditional_or_operator_expression_in_control_expression1234);
                    	conditional_or_operator_expression71 = conditional_or_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) conditional_or_operator_expression71.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "control_expression"

    public class conditional_or_operator_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "conditional_or_operator_expression"
    // VnvdTreeWalker.g:332:1: conditional_or_operator_expression : ( conditional_and_operator_expression | ^(node= OR conditional_or_operator_expression conditional_or_operator_expression ) );
    public VnvdTreeWalker.conditional_or_operator_expression_return conditional_or_operator_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.conditional_or_operator_expression_return retval = new VnvdTreeWalker.conditional_or_operator_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.conditional_and_operator_expression_return conditional_and_operator_expression72 = default(VnvdTreeWalker.conditional_and_operator_expression_return);

        VnvdTreeWalker.conditional_or_operator_expression_return conditional_or_operator_expression73 = default(VnvdTreeWalker.conditional_or_operator_expression_return);

        VnvdTreeWalker.conditional_or_operator_expression_return conditional_or_operator_expression74 = default(VnvdTreeWalker.conditional_or_operator_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:333:2: ( conditional_and_operator_expression | ^(node= OR conditional_or_operator_expression conditional_or_operator_expression ) )
            int alt35 = 2;
            int LA35_0 = input.LA(1);

            if ( (LA35_0 == LBRACKET || LA35_0 == DCOLON || (LA35_0 >= PLUS && LA35_0 <= AND) || (LA35_0 >= LXOR && LA35_0 <= MOD) || LA35_0 == NEW || (LA35_0 >= TRUE && LA35_0 <= THIS) || (LA35_0 >= READ && LA35_0 <= IS) || LA35_0 == WRITE || LA35_0 == SLIST || (LA35_0 >= EXPRBLOCK && LA35_0 <= CAST) || (LA35_0 >= READVOID && LA35_0 <= WRITEVOID) || (LA35_0 >= NEWARR && LA35_0 <= NEWARRELEMS) || (LA35_0 >= CALLVIRT && LA35_0 <= DONTLD) || (LA35_0 >= NUMBER && LA35_0 <= FLOAT)) )
            {
                alt35 = 1;
            }
            else if ( (LA35_0 == OR) )
            {
                alt35 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d35s0 =
                    new NoViableAltException("", 35, 0, input);

                throw nvae_d35s0;
            }
            switch (alt35) 
            {
                case 1 :
                    // VnvdTreeWalker.g:333:4: conditional_and_operator_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_conditional_and_operator_expression_in_conditional_or_operator_expression1245);
                    	conditional_and_operator_expression72 = conditional_and_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) conditional_and_operator_expression72.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:334:4: ^(node= OR conditional_or_operator_expression conditional_or_operator_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,OR,FOLLOW_OR_in_conditional_or_operator_expression1253); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;if ( (state.backtracking==0) )
                    	{
                    	   h.BeginCondOr(node); 
                    	}

                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_conditional_or_operator_expression_in_conditional_or_operator_expression1257);
                    	conditional_or_operator_expression73 = conditional_or_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) conditional_or_operator_expression73.Tree;
                    	if ( (state.backtracking==0) )
                    	{
                    	   h.MiddleCondOr(node); 
                    	}
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_conditional_or_operator_expression_in_conditional_or_operator_expression1261);
                    	conditional_or_operator_expression74 = conditional_or_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) conditional_or_operator_expression74.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.EndConditionalOrExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "conditional_or_operator_expression"

    public class conditional_and_operator_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "conditional_and_operator_expression"
    // VnvdTreeWalker.g:340:1: conditional_and_operator_expression : ( logic_or_operator_expression | ^(node= AND conditional_and_operator_expression conditional_and_operator_expression ) );
    public VnvdTreeWalker.conditional_and_operator_expression_return conditional_and_operator_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.conditional_and_operator_expression_return retval = new VnvdTreeWalker.conditional_and_operator_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.logic_or_operator_expression_return logic_or_operator_expression75 = default(VnvdTreeWalker.logic_or_operator_expression_return);

        VnvdTreeWalker.conditional_and_operator_expression_return conditional_and_operator_expression76 = default(VnvdTreeWalker.conditional_and_operator_expression_return);

        VnvdTreeWalker.conditional_and_operator_expression_return conditional_and_operator_expression77 = default(VnvdTreeWalker.conditional_and_operator_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:341:2: ( logic_or_operator_expression | ^(node= AND conditional_and_operator_expression conditional_and_operator_expression ) )
            int alt36 = 2;
            int LA36_0 = input.LA(1);

            if ( (LA36_0 == LBRACKET || LA36_0 == DCOLON || (LA36_0 >= PLUS && LA36_0 <= NEQ) || (LA36_0 >= LXOR && LA36_0 <= MOD) || LA36_0 == NEW || (LA36_0 >= TRUE && LA36_0 <= THIS) || (LA36_0 >= READ && LA36_0 <= IS) || LA36_0 == WRITE || LA36_0 == SLIST || (LA36_0 >= EXPRBLOCK && LA36_0 <= CAST) || (LA36_0 >= READVOID && LA36_0 <= WRITEVOID) || (LA36_0 >= NEWARR && LA36_0 <= NEWARRELEMS) || (LA36_0 >= CALLVIRT && LA36_0 <= DONTLD) || (LA36_0 >= NUMBER && LA36_0 <= FLOAT)) )
            {
                alt36 = 1;
            }
            else if ( (LA36_0 == AND) )
            {
                alt36 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d36s0 =
                    new NoViableAltException("", 36, 0, input);

                throw nvae_d36s0;
            }
            switch (alt36) 
            {
                case 1 :
                    // VnvdTreeWalker.g:341:4: logic_or_operator_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logic_or_operator_expression_in_conditional_and_operator_expression1277);
                    	logic_or_operator_expression75 = logic_or_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) logic_or_operator_expression75.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:342:4: ^(node= AND conditional_and_operator_expression conditional_and_operator_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,AND,FOLLOW_AND_in_conditional_and_operator_expression1285); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;if ( (state.backtracking==0) )
                    	{
                    	   h.BeginCondAnd(node); 
                    	}

                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_conditional_and_operator_expression_in_conditional_and_operator_expression1289);
                    	conditional_and_operator_expression76 = conditional_and_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) conditional_and_operator_expression76.Tree;
                    	if ( (state.backtracking==0) )
                    	{
                    	   h.MiddleCondAnd(node); 
                    	}
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_conditional_and_operator_expression_in_conditional_and_operator_expression1293);
                    	conditional_and_operator_expression77 = conditional_and_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) conditional_and_operator_expression77.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.EndConditionalAndExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "conditional_and_operator_expression"

    public class logic_or_operator_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "logic_or_operator_expression"
    // VnvdTreeWalker.g:348:1: logic_or_operator_expression : ( logic_xor_operator_expression | ^(node= LOR logic_or_operator_expression logic_or_operator_expression ) );
    public VnvdTreeWalker.logic_or_operator_expression_return logic_or_operator_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.logic_or_operator_expression_return retval = new VnvdTreeWalker.logic_or_operator_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.logic_xor_operator_expression_return logic_xor_operator_expression78 = default(VnvdTreeWalker.logic_xor_operator_expression_return);

        VnvdTreeWalker.logic_or_operator_expression_return logic_or_operator_expression79 = default(VnvdTreeWalker.logic_or_operator_expression_return);

        VnvdTreeWalker.logic_or_operator_expression_return logic_or_operator_expression80 = default(VnvdTreeWalker.logic_or_operator_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:349:2: ( logic_xor_operator_expression | ^(node= LOR logic_or_operator_expression logic_or_operator_expression ) )
            int alt37 = 2;
            int LA37_0 = input.LA(1);

            if ( (LA37_0 == LBRACKET || LA37_0 == DCOLON || (LA37_0 >= PLUS && LA37_0 <= NEQ) || (LA37_0 >= LXOR && LA37_0 <= LAND) || (LA37_0 >= NOT && LA37_0 <= MOD) || LA37_0 == NEW || (LA37_0 >= TRUE && LA37_0 <= THIS) || (LA37_0 >= READ && LA37_0 <= IS) || LA37_0 == WRITE || LA37_0 == SLIST || (LA37_0 >= EXPRBLOCK && LA37_0 <= CAST) || (LA37_0 >= READVOID && LA37_0 <= WRITEVOID) || (LA37_0 >= NEWARR && LA37_0 <= NEWARRELEMS) || (LA37_0 >= CALLVIRT && LA37_0 <= DONTLD) || (LA37_0 >= NUMBER && LA37_0 <= FLOAT)) )
            {
                alt37 = 1;
            }
            else if ( (LA37_0 == LOR) )
            {
                alt37 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d37s0 =
                    new NoViableAltException("", 37, 0, input);

                throw nvae_d37s0;
            }
            switch (alt37) 
            {
                case 1 :
                    // VnvdTreeWalker.g:349:4: logic_xor_operator_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logic_xor_operator_expression_in_logic_or_operator_expression1309);
                    	logic_xor_operator_expression78 = logic_xor_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) logic_xor_operator_expression78.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:350:4: ^(node= LOR logic_or_operator_expression logic_or_operator_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,LOR,FOLLOW_LOR_in_logic_or_operator_expression1317); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logic_or_operator_expression_in_logic_or_operator_expression1319);
                    	logic_or_operator_expression79 = logic_or_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) logic_or_operator_expression79.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logic_or_operator_expression_in_logic_or_operator_expression1321);
                    	logic_or_operator_expression80 = logic_or_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) logic_or_operator_expression80.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LogicOrExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logic_or_operator_expression"

    public class logic_xor_operator_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "logic_xor_operator_expression"
    // VnvdTreeWalker.g:356:1: logic_xor_operator_expression : ( logic_and_operator_expression | ^(node= LXOR logic_xor_operator_expression logic_xor_operator_expression ) );
    public VnvdTreeWalker.logic_xor_operator_expression_return logic_xor_operator_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.logic_xor_operator_expression_return retval = new VnvdTreeWalker.logic_xor_operator_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.logic_and_operator_expression_return logic_and_operator_expression81 = default(VnvdTreeWalker.logic_and_operator_expression_return);

        VnvdTreeWalker.logic_xor_operator_expression_return logic_xor_operator_expression82 = default(VnvdTreeWalker.logic_xor_operator_expression_return);

        VnvdTreeWalker.logic_xor_operator_expression_return logic_xor_operator_expression83 = default(VnvdTreeWalker.logic_xor_operator_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:357:2: ( logic_and_operator_expression | ^(node= LXOR logic_xor_operator_expression logic_xor_operator_expression ) )
            int alt38 = 2;
            int LA38_0 = input.LA(1);

            if ( (LA38_0 == LBRACKET || LA38_0 == DCOLON || (LA38_0 >= PLUS && LA38_0 <= NEQ) || LA38_0 == LAND || (LA38_0 >= NOT && LA38_0 <= MOD) || LA38_0 == NEW || (LA38_0 >= TRUE && LA38_0 <= THIS) || (LA38_0 >= READ && LA38_0 <= IS) || LA38_0 == WRITE || LA38_0 == SLIST || (LA38_0 >= EXPRBLOCK && LA38_0 <= CAST) || (LA38_0 >= READVOID && LA38_0 <= WRITEVOID) || (LA38_0 >= NEWARR && LA38_0 <= NEWARRELEMS) || (LA38_0 >= CALLVIRT && LA38_0 <= DONTLD) || (LA38_0 >= NUMBER && LA38_0 <= FLOAT)) )
            {
                alt38 = 1;
            }
            else if ( (LA38_0 == LXOR) )
            {
                alt38 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d38s0 =
                    new NoViableAltException("", 38, 0, input);

                throw nvae_d38s0;
            }
            switch (alt38) 
            {
                case 1 :
                    // VnvdTreeWalker.g:357:4: logic_and_operator_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logic_and_operator_expression_in_logic_xor_operator_expression1338);
                    	logic_and_operator_expression81 = logic_and_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) logic_and_operator_expression81.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:358:4: ^(node= LXOR logic_xor_operator_expression logic_xor_operator_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,LXOR,FOLLOW_LXOR_in_logic_xor_operator_expression1346); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logic_xor_operator_expression_in_logic_xor_operator_expression1348);
                    	logic_xor_operator_expression82 = logic_xor_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) logic_xor_operator_expression82.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logic_xor_operator_expression_in_logic_xor_operator_expression1350);
                    	logic_xor_operator_expression83 = logic_xor_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) logic_xor_operator_expression83.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LogicXorExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logic_xor_operator_expression"

    public class logic_and_operator_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "logic_and_operator_expression"
    // VnvdTreeWalker.g:364:1: logic_and_operator_expression : ( logic_expression | ^(node= LAND logic_and_operator_expression logic_and_operator_expression ) );
    public VnvdTreeWalker.logic_and_operator_expression_return logic_and_operator_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.logic_and_operator_expression_return retval = new VnvdTreeWalker.logic_and_operator_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.logic_expression_return logic_expression84 = default(VnvdTreeWalker.logic_expression_return);

        VnvdTreeWalker.logic_and_operator_expression_return logic_and_operator_expression85 = default(VnvdTreeWalker.logic_and_operator_expression_return);

        VnvdTreeWalker.logic_and_operator_expression_return logic_and_operator_expression86 = default(VnvdTreeWalker.logic_and_operator_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:365:2: ( logic_expression | ^(node= LAND logic_and_operator_expression logic_and_operator_expression ) )
            int alt39 = 2;
            int LA39_0 = input.LA(1);

            if ( (LA39_0 == LBRACKET || LA39_0 == DCOLON || (LA39_0 >= PLUS && LA39_0 <= NEQ) || (LA39_0 >= NOT && LA39_0 <= MOD) || LA39_0 == NEW || (LA39_0 >= TRUE && LA39_0 <= THIS) || (LA39_0 >= READ && LA39_0 <= IS) || LA39_0 == WRITE || LA39_0 == SLIST || (LA39_0 >= EXPRBLOCK && LA39_0 <= CAST) || (LA39_0 >= READVOID && LA39_0 <= WRITEVOID) || (LA39_0 >= NEWARR && LA39_0 <= NEWARRELEMS) || (LA39_0 >= CALLVIRT && LA39_0 <= DONTLD) || (LA39_0 >= NUMBER && LA39_0 <= FLOAT)) )
            {
                alt39 = 1;
            }
            else if ( (LA39_0 == LAND) )
            {
                alt39 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d39s0 =
                    new NoViableAltException("", 39, 0, input);

                throw nvae_d39s0;
            }
            switch (alt39) 
            {
                case 1 :
                    // VnvdTreeWalker.g:365:4: logic_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logic_expression_in_logic_and_operator_expression1367);
                    	logic_expression84 = logic_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) logic_expression84.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:366:4: ^(node= LAND logic_and_operator_expression logic_and_operator_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,LAND,FOLLOW_LAND_in_logic_and_operator_expression1375); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logic_and_operator_expression_in_logic_and_operator_expression1377);
                    	logic_and_operator_expression85 = logic_and_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) logic_and_operator_expression85.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logic_and_operator_expression_in_logic_and_operator_expression1379);
                    	logic_and_operator_expression86 = logic_and_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) logic_and_operator_expression86.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LogicAndExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logic_and_operator_expression"

    public class logic_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "logic_expression"
    // VnvdTreeWalker.g:372:1: logic_expression : ( cast_as_expression | ^(node= LE primary_expression primary_expression ) | ^(node= LEQ primary_expression primary_expression ) | ^(node= GE primary_expression primary_expression ) | ^(node= GEQ primary_expression primary_expression ) | ^(node= EQ primary_expression primary_expression ) | ^(node= NEQ primary_expression primary_expression ) );
    public VnvdTreeWalker.logic_expression_return logic_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.logic_expression_return retval = new VnvdTreeWalker.logic_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.cast_as_expression_return cast_as_expression87 = default(VnvdTreeWalker.cast_as_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression88 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression89 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression90 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression91 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression92 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression93 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression94 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression95 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression96 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression97 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression98 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression99 = default(VnvdTreeWalker.primary_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:373:2: ( cast_as_expression | ^(node= LE primary_expression primary_expression ) | ^(node= LEQ primary_expression primary_expression ) | ^(node= GE primary_expression primary_expression ) | ^(node= GEQ primary_expression primary_expression ) | ^(node= EQ primary_expression primary_expression ) | ^(node= NEQ primary_expression primary_expression ) )
            int alt40 = 7;
            switch ( input.LA(1) ) 
            {
            case LBRACKET:
            case DCOLON:
            case PLUS:
            case MINUS:
            case MULTIPLY:
            case DIVISION:
            case NOT:
            case MOD:
            case NEW:
            case TRUE:
            case FALSE:
            case BASE:
            case THIS:
            case READ:
            case NULL:
            case AS:
            case IS:
            case WRITE:
            case SLIST:
            case EXPRBLOCK:
            case USAGE:
            case SCOPEEXPR:
            case CAST:
            case READVOID:
            case WRITEVOID:
            case NEWARR:
            case NEWARRELEMS:
            case CALLVIRT:
            case CALL:
            case LDFLD:
            case LDSFLD:
            case LDLITERAL:
            case LDVIRTFTN:
            case LDFTN:
            case DONTLD:
            case NUMBER:
            case STRING:
            case CHAR:
            case FLOAT:
            	{
                alt40 = 1;
                }
                break;
            case LE:
            	{
                alt40 = 2;
                }
                break;
            case LEQ:
            	{
                alt40 = 3;
                }
                break;
            case GE:
            	{
                alt40 = 4;
                }
                break;
            case GEQ:
            	{
                alt40 = 5;
                }
                break;
            case EQ:
            	{
                alt40 = 6;
                }
                break;
            case NEQ:
            	{
                alt40 = 7;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d40s0 =
            	        new NoViableAltException("", 40, 0, input);

            	    throw nvae_d40s0;
            }

            switch (alt40) 
            {
                case 1 :
                    // VnvdTreeWalker.g:373:4: cast_as_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_cast_as_expression_in_logic_expression1395);
                    	cast_as_expression87 = cast_as_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) cast_as_expression87.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:374:4: ^(node= LE primary_expression primary_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,LE,FOLLOW_LE_in_logic_expression1403); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1405);
                    	primary_expression88 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression88.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1407);
                    	primary_expression89 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression89.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LessExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:378:4: ^(node= LEQ primary_expression primary_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,LEQ,FOLLOW_LEQ_in_logic_expression1420); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1422);
                    	primary_expression90 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression90.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1424);
                    	primary_expression91 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression91.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LessEqualExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 4 :
                    // VnvdTreeWalker.g:382:4: ^(node= GE primary_expression primary_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,GE,FOLLOW_GE_in_logic_expression1437); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1439);
                    	primary_expression92 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression92.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1441);
                    	primary_expression93 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression93.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.GreaterExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 5 :
                    // VnvdTreeWalker.g:386:4: ^(node= GEQ primary_expression primary_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,GEQ,FOLLOW_GEQ_in_logic_expression1454); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1456);
                    	primary_expression94 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression94.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1458);
                    	primary_expression95 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression95.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.GreaterEqualExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 6 :
                    // VnvdTreeWalker.g:390:4: ^(node= EQ primary_expression primary_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,EQ,FOLLOW_EQ_in_logic_expression1471); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1473);
                    	primary_expression96 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression96.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1475);
                    	primary_expression97 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression97.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.EqualExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 7 :
                    // VnvdTreeWalker.g:394:4: ^(node= NEQ primary_expression primary_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,NEQ,FOLLOW_NEQ_in_logic_expression1488); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1490);
                    	primary_expression98 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression98.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_logic_expression1492);
                    	primary_expression99 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression99.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.NotEqualExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logic_expression"

    public class cast_as_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "cast_as_expression"
    // VnvdTreeWalker.g:400:1: cast_as_expression : ( ^(node= AS cast_as_expression qual= qualifier ) | ^(node= IS cast_as_expression qual= qualifier ) | primary_expression );
    public VnvdTreeWalker.cast_as_expression_return cast_as_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.cast_as_expression_return retval = new VnvdTreeWalker.cast_as_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.cast_as_expression_return cast_as_expression100 = default(VnvdTreeWalker.cast_as_expression_return);

        VnvdTreeWalker.cast_as_expression_return cast_as_expression101 = default(VnvdTreeWalker.cast_as_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression102 = default(VnvdTreeWalker.primary_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:401:2: ( ^(node= AS cast_as_expression qual= qualifier ) | ^(node= IS cast_as_expression qual= qualifier ) | primary_expression )
            int alt41 = 3;
            switch ( input.LA(1) ) 
            {
            case AS:
            	{
                alt41 = 1;
                }
                break;
            case IS:
            	{
                alt41 = 2;
                }
                break;
            case LBRACKET:
            case DCOLON:
            case PLUS:
            case MINUS:
            case MULTIPLY:
            case DIVISION:
            case NOT:
            case MOD:
            case NEW:
            case TRUE:
            case FALSE:
            case BASE:
            case THIS:
            case READ:
            case NULL:
            case WRITE:
            case SLIST:
            case EXPRBLOCK:
            case USAGE:
            case SCOPEEXPR:
            case CAST:
            case READVOID:
            case WRITEVOID:
            case NEWARR:
            case NEWARRELEMS:
            case CALLVIRT:
            case CALL:
            case LDFLD:
            case LDSFLD:
            case LDLITERAL:
            case LDVIRTFTN:
            case LDFTN:
            case DONTLD:
            case NUMBER:
            case STRING:
            case CHAR:
            case FLOAT:
            	{
                alt41 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d41s0 =
            	        new NoViableAltException("", 41, 0, input);

            	    throw nvae_d41s0;
            }

            switch (alt41) 
            {
                case 1 :
                    // VnvdTreeWalker.g:401:4: ^(node= AS cast_as_expression qual= qualifier )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,AS,FOLLOW_AS_in_cast_as_expression1511); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_cast_as_expression_in_cast_as_expression1513);
                    	cast_as_expression100 = cast_as_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) cast_as_expression100.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_qualifier_in_cast_as_expression1517);
                    	qual = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.CastAsExpression(node, ((qual != null) ? qual.ids : default(Qualifier)));
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:405:4: ^(node= IS cast_as_expression qual= qualifier )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,IS,FOLLOW_IS_in_cast_as_expression1530); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_cast_as_expression_in_cast_as_expression1532);
                    	cast_as_expression101 = cast_as_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) cast_as_expression101.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_qualifier_in_cast_as_expression1536);
                    	qual = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.IsTypeExpression(node, ((qual != null) ? qual.ids : default(Qualifier)));
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:409:4: primary_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_cast_as_expression1546);
                    	primary_expression102 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) primary_expression102.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cast_as_expression"

    public class primary_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "primary_expression"
    // VnvdTreeWalker.g:412:1: primary_expression : ( ( ^( PLUS primary_expression primary_expression ) )=> ^(node= PLUS primary_expression primary_expression ) | ( ^( MINUS primary_expression primary_expression ) )=> ^(node= MINUS primary_expression primary_expression ) | secundary_expression );
    public VnvdTreeWalker.primary_expression_return primary_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.primary_expression_return retval = new VnvdTreeWalker.primary_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.primary_expression_return primary_expression103 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression104 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression105 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.primary_expression_return primary_expression106 = default(VnvdTreeWalker.primary_expression_return);

        VnvdTreeWalker.secundary_expression_return secundary_expression107 = default(VnvdTreeWalker.secundary_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:413:2: ( ( ^( PLUS primary_expression primary_expression ) )=> ^(node= PLUS primary_expression primary_expression ) | ( ^( MINUS primary_expression primary_expression ) )=> ^(node= MINUS primary_expression primary_expression ) | secundary_expression )
            int alt42 = 3;
            alt42 = dfa42.Predict(input);
            switch (alt42) 
            {
                case 1 :
                    // VnvdTreeWalker.g:413:4: ( ^( PLUS primary_expression primary_expression ) )=> ^(node= PLUS primary_expression primary_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,PLUS,FOLLOW_PLUS_in_primary_expression1573); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_primary_expression1575);
                    	primary_expression103 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression103.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_primary_expression1577);
                    	primary_expression104 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression104.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.PlusExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:417:4: ( ^( MINUS primary_expression primary_expression ) )=> ^(node= MINUS primary_expression primary_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,MINUS,FOLLOW_MINUS_in_primary_expression1602); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_primary_expression1604);
                    	primary_expression105 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression105.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_primary_expression_in_primary_expression1606);
                    	primary_expression106 = primary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) primary_expression106.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.MinusExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:421:4: secundary_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_secundary_expression_in_primary_expression1616);
                    	secundary_expression107 = secundary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) secundary_expression107.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "primary_expression"

    public class secundary_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "secundary_expression"
    // VnvdTreeWalker.g:424:1: secundary_expression : ( ^(node= MULTIPLY secundary_expression secundary_expression ) | ^(node= DIVISION secundary_expression secundary_expression ) | ^(node= MOD secundary_expression secundary_expression ) | logicnotoperator_expression );
    public VnvdTreeWalker.secundary_expression_return secundary_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.secundary_expression_return retval = new VnvdTreeWalker.secundary_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.secundary_expression_return secundary_expression108 = default(VnvdTreeWalker.secundary_expression_return);

        VnvdTreeWalker.secundary_expression_return secundary_expression109 = default(VnvdTreeWalker.secundary_expression_return);

        VnvdTreeWalker.secundary_expression_return secundary_expression110 = default(VnvdTreeWalker.secundary_expression_return);

        VnvdTreeWalker.secundary_expression_return secundary_expression111 = default(VnvdTreeWalker.secundary_expression_return);

        VnvdTreeWalker.secundary_expression_return secundary_expression112 = default(VnvdTreeWalker.secundary_expression_return);

        VnvdTreeWalker.secundary_expression_return secundary_expression113 = default(VnvdTreeWalker.secundary_expression_return);

        VnvdTreeWalker.logicnotoperator_expression_return logicnotoperator_expression114 = default(VnvdTreeWalker.logicnotoperator_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:425:2: ( ^(node= MULTIPLY secundary_expression secundary_expression ) | ^(node= DIVISION secundary_expression secundary_expression ) | ^(node= MOD secundary_expression secundary_expression ) | logicnotoperator_expression )
            int alt43 = 4;
            switch ( input.LA(1) ) 
            {
            case MULTIPLY:
            	{
                alt43 = 1;
                }
                break;
            case DIVISION:
            	{
                alt43 = 2;
                }
                break;
            case MOD:
            	{
                alt43 = 3;
                }
                break;
            case LBRACKET:
            case DCOLON:
            case PLUS:
            case MINUS:
            case NOT:
            case NEW:
            case TRUE:
            case FALSE:
            case BASE:
            case THIS:
            case READ:
            case NULL:
            case WRITE:
            case SLIST:
            case EXPRBLOCK:
            case USAGE:
            case SCOPEEXPR:
            case CAST:
            case READVOID:
            case WRITEVOID:
            case NEWARR:
            case NEWARRELEMS:
            case CALLVIRT:
            case CALL:
            case LDFLD:
            case LDSFLD:
            case LDLITERAL:
            case LDVIRTFTN:
            case LDFTN:
            case DONTLD:
            case NUMBER:
            case STRING:
            case CHAR:
            case FLOAT:
            	{
                alt43 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d43s0 =
            	        new NoViableAltException("", 43, 0, input);

            	    throw nvae_d43s0;
            }

            switch (alt43) 
            {
                case 1 :
                    // VnvdTreeWalker.g:425:4: ^(node= MULTIPLY secundary_expression secundary_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_secundary_expression1631); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_secundary_expression_in_secundary_expression1633);
                    	secundary_expression108 = secundary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) secundary_expression108.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_secundary_expression_in_secundary_expression1635);
                    	secundary_expression109 = secundary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) secundary_expression109.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.MultiplyExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:429:4: ^(node= DIVISION secundary_expression secundary_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,DIVISION,FOLLOW_DIVISION_in_secundary_expression1648); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_secundary_expression_in_secundary_expression1650);
                    	secundary_expression110 = secundary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) secundary_expression110.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_secundary_expression_in_secundary_expression1652);
                    	secundary_expression111 = secundary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) secundary_expression111.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.DivisionExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:433:4: ^(node= MOD secundary_expression secundary_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,MOD,FOLLOW_MOD_in_secundary_expression1665); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_secundary_expression_in_secundary_expression1667);
                    	secundary_expression112 = secundary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) secundary_expression112.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_secundary_expression_in_secundary_expression1669);
                    	secundary_expression113 = secundary_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) secundary_expression113.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ModExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 4 :
                    // VnvdTreeWalker.g:437:4: logicnotoperator_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logicnotoperator_expression_in_secundary_expression1679);
                    	logicnotoperator_expression114 = logicnotoperator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) logicnotoperator_expression114.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "secundary_expression"

    public class logicnotoperator_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "logicnotoperator_expression"
    // VnvdTreeWalker.g:440:1: logicnotoperator_expression : ( ^(node= NOT logicnotoperator_expression ) | ^(node= PLUS logicnotoperator_expression ) | ^(node= MINUS logicnotoperator_expression ) | cast_expression );
    public VnvdTreeWalker.logicnotoperator_expression_return logicnotoperator_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.logicnotoperator_expression_return retval = new VnvdTreeWalker.logicnotoperator_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.logicnotoperator_expression_return logicnotoperator_expression115 = default(VnvdTreeWalker.logicnotoperator_expression_return);

        VnvdTreeWalker.logicnotoperator_expression_return logicnotoperator_expression116 = default(VnvdTreeWalker.logicnotoperator_expression_return);

        VnvdTreeWalker.logicnotoperator_expression_return logicnotoperator_expression117 = default(VnvdTreeWalker.logicnotoperator_expression_return);

        VnvdTreeWalker.cast_expression_return cast_expression118 = default(VnvdTreeWalker.cast_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:441:2: ( ^(node= NOT logicnotoperator_expression ) | ^(node= PLUS logicnotoperator_expression ) | ^(node= MINUS logicnotoperator_expression ) | cast_expression )
            int alt44 = 4;
            switch ( input.LA(1) ) 
            {
            case NOT:
            	{
                alt44 = 1;
                }
                break;
            case PLUS:
            	{
                alt44 = 2;
                }
                break;
            case MINUS:
            	{
                alt44 = 3;
                }
                break;
            case LBRACKET:
            case DCOLON:
            case NEW:
            case TRUE:
            case FALSE:
            case BASE:
            case THIS:
            case READ:
            case NULL:
            case WRITE:
            case SLIST:
            case EXPRBLOCK:
            case USAGE:
            case SCOPEEXPR:
            case CAST:
            case READVOID:
            case WRITEVOID:
            case NEWARR:
            case NEWARRELEMS:
            case CALLVIRT:
            case CALL:
            case LDFLD:
            case LDSFLD:
            case LDLITERAL:
            case LDVIRTFTN:
            case LDFTN:
            case DONTLD:
            case NUMBER:
            case STRING:
            case CHAR:
            case FLOAT:
            	{
                alt44 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d44s0 =
            	        new NoViableAltException("", 44, 0, input);

            	    throw nvae_d44s0;
            }

            switch (alt44) 
            {
                case 1 :
                    // VnvdTreeWalker.g:441:4: ^(node= NOT logicnotoperator_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,NOT,FOLLOW_NOT_in_logicnotoperator_expression1693); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logicnotoperator_expression_in_logicnotoperator_expression1695);
                    	logicnotoperator_expression115 = logicnotoperator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) logicnotoperator_expression115.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LogicNotExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:445:4: ^(node= PLUS logicnotoperator_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,PLUS,FOLLOW_PLUS_in_logicnotoperator_expression1708); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logicnotoperator_expression_in_logicnotoperator_expression1710);
                    	logicnotoperator_expression116 = logicnotoperator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) logicnotoperator_expression116.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.UnaryPlusExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:449:4: ^(node= MINUS logicnotoperator_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,MINUS,FOLLOW_MINUS_in_logicnotoperator_expression1723); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_logicnotoperator_expression_in_logicnotoperator_expression1725);
                    	logicnotoperator_expression117 = logicnotoperator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) logicnotoperator_expression117.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.UnaryMinusExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 4 :
                    // VnvdTreeWalker.g:453:4: cast_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_cast_expression_in_logicnotoperator_expression1735);
                    	cast_expression118 = cast_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) cast_expression118.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicnotoperator_expression"

    public class cast_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "cast_expression"
    // VnvdTreeWalker.g:456:1: cast_expression : ( ^(node= CAST qual= qualifier cast_expression ) | invocation_or_load_expression );
    public VnvdTreeWalker.cast_expression_return cast_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.cast_expression_return retval = new VnvdTreeWalker.cast_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.cast_expression_return cast_expression119 = default(VnvdTreeWalker.cast_expression_return);

        VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression120 = default(VnvdTreeWalker.invocation_or_load_expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:457:2: ( ^(node= CAST qual= qualifier cast_expression ) | invocation_or_load_expression )
            int alt45 = 2;
            int LA45_0 = input.LA(1);

            if ( (LA45_0 == CAST) )
            {
                alt45 = 1;
            }
            else if ( (LA45_0 == LBRACKET || LA45_0 == DCOLON || LA45_0 == NEW || (LA45_0 >= TRUE && LA45_0 <= THIS) || (LA45_0 >= READ && LA45_0 <= NULL) || LA45_0 == WRITE || LA45_0 == SLIST || (LA45_0 >= EXPRBLOCK && LA45_0 <= SCOPEEXPR) || (LA45_0 >= READVOID && LA45_0 <= WRITEVOID) || (LA45_0 >= NEWARR && LA45_0 <= NEWARRELEMS) || (LA45_0 >= CALLVIRT && LA45_0 <= DONTLD) || (LA45_0 >= NUMBER && LA45_0 <= FLOAT)) )
            {
                alt45 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d45s0 =
                    new NoViableAltException("", 45, 0, input);

                throw nvae_d45s0;
            }
            switch (alt45) 
            {
                case 1 :
                    // VnvdTreeWalker.g:457:4: ^(node= CAST qual= qualifier cast_expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,CAST,FOLLOW_CAST_in_cast_expression1749); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_qualifier_in_cast_expression1753);
                    	qual = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_cast_expression_in_cast_expression1755);
                    	cast_expression119 = cast_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) cast_expression119.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  		h.CastExpression(node, ((qual != null) ? qual.ids : default(Qualifier)));
                    	  	
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:461:4: invocation_or_load_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_invocation_or_load_expression_in_cast_expression1764);
                    	invocation_or_load_expression120 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) invocation_or_load_expression120.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cast_expression"

    public class invocation_or_load_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "invocation_or_load_expression"
    // VnvdTreeWalker.g:464:1: invocation_or_load_expression : ( ^(node= DCOLON invocation_or_load_expression id= IDENTIFIER ( ^( ALIST ( argument )* ) )? ) | ^(node= LBRACKET invocation_or_load_expression expression ) | ^(node= CALLVIRT invocation_or_load_expression id= IDENTIFIER ( ^( ALIST ( argument )* ) ) ) | ^(node= CALL invocation_or_load_expression id= IDENTIFIER ( ^( ALIST ( argument )* ) ) ) | ^(node= LDFLD invocation_or_load_expression id= IDENTIFIER ) | ^(node= LDSFLD invocation_or_load_expression id= IDENTIFIER ) | ^(node= LDLITERAL invocation_or_load_expression id= IDENTIFIER ) | ^(node= LDVIRTFTN invocation_or_load_expression id= IDENTIFIER ) | ^(node= LDFTN invocation_or_load_expression id= IDENTIFIER ) | ^(node= DONTLD invocation_or_load_expression id= IDENTIFIER ) | operand );
    public VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.invocation_or_load_expression_return retval = new VnvdTreeWalker.invocation_or_load_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode id = null;
        TreeNode ALIST122 = null;
        TreeNode ALIST127 = null;
        TreeNode ALIST130 = null;
        VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression121 = default(VnvdTreeWalker.invocation_or_load_expression_return);

        VnvdTreeWalker.argument_return argument123 = default(VnvdTreeWalker.argument_return);

        VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression124 = default(VnvdTreeWalker.invocation_or_load_expression_return);

        VnvdTreeWalker.expression_return expression125 = default(VnvdTreeWalker.expression_return);

        VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression126 = default(VnvdTreeWalker.invocation_or_load_expression_return);

        VnvdTreeWalker.argument_return argument128 = default(VnvdTreeWalker.argument_return);

        VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression129 = default(VnvdTreeWalker.invocation_or_load_expression_return);

        VnvdTreeWalker.argument_return argument131 = default(VnvdTreeWalker.argument_return);

        VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression132 = default(VnvdTreeWalker.invocation_or_load_expression_return);

        VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression133 = default(VnvdTreeWalker.invocation_or_load_expression_return);

        VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression134 = default(VnvdTreeWalker.invocation_or_load_expression_return);

        VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression135 = default(VnvdTreeWalker.invocation_or_load_expression_return);

        VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression136 = default(VnvdTreeWalker.invocation_or_load_expression_return);

        VnvdTreeWalker.invocation_or_load_expression_return invocation_or_load_expression137 = default(VnvdTreeWalker.invocation_or_load_expression_return);

        VnvdTreeWalker.operand_return operand138 = default(VnvdTreeWalker.operand_return);


        TreeNode node_tree=null;
        TreeNode id_tree=null;
        TreeNode ALIST122_tree=null;
        TreeNode ALIST127_tree=null;
        TreeNode ALIST130_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:465:2: ( ^(node= DCOLON invocation_or_load_expression id= IDENTIFIER ( ^( ALIST ( argument )* ) )? ) | ^(node= LBRACKET invocation_or_load_expression expression ) | ^(node= CALLVIRT invocation_or_load_expression id= IDENTIFIER ( ^( ALIST ( argument )* ) ) ) | ^(node= CALL invocation_or_load_expression id= IDENTIFIER ( ^( ALIST ( argument )* ) ) ) | ^(node= LDFLD invocation_or_load_expression id= IDENTIFIER ) | ^(node= LDSFLD invocation_or_load_expression id= IDENTIFIER ) | ^(node= LDLITERAL invocation_or_load_expression id= IDENTIFIER ) | ^(node= LDVIRTFTN invocation_or_load_expression id= IDENTIFIER ) | ^(node= LDFTN invocation_or_load_expression id= IDENTIFIER ) | ^(node= DONTLD invocation_or_load_expression id= IDENTIFIER ) | operand )
            int alt50 = 11;
            switch ( input.LA(1) ) 
            {
            case DCOLON:
            	{
                alt50 = 1;
                }
                break;
            case LBRACKET:
            	{
                alt50 = 2;
                }
                break;
            case CALLVIRT:
            	{
                alt50 = 3;
                }
                break;
            case CALL:
            	{
                alt50 = 4;
                }
                break;
            case LDFLD:
            	{
                alt50 = 5;
                }
                break;
            case LDSFLD:
            	{
                alt50 = 6;
                }
                break;
            case LDLITERAL:
            	{
                alt50 = 7;
                }
                break;
            case LDVIRTFTN:
            	{
                alt50 = 8;
                }
                break;
            case LDFTN:
            	{
                alt50 = 9;
                }
                break;
            case DONTLD:
            	{
                alt50 = 10;
                }
                break;
            case NEW:
            case TRUE:
            case FALSE:
            case BASE:
            case THIS:
            case READ:
            case NULL:
            case WRITE:
            case SLIST:
            case EXPRBLOCK:
            case USAGE:
            case SCOPEEXPR:
            case READVOID:
            case WRITEVOID:
            case NEWARR:
            case NEWARRELEMS:
            case NUMBER:
            case STRING:
            case CHAR:
            case FLOAT:
            	{
                alt50 = 11;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d50s0 =
            	        new NoViableAltException("", 50, 0, input);

            	    throw nvae_d50s0;
            }

            switch (alt50) 
            {
                case 1 :
                    // VnvdTreeWalker.g:465:4: ^(node= DCOLON invocation_or_load_expression id= IDENTIFIER ( ^( ALIST ( argument )* ) )? )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,DCOLON,FOLLOW_DCOLON_in_invocation_or_load_expression1779); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1781);
                    	invocation_or_load_expression121 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) invocation_or_load_expression121.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_invocation_or_load_expression1785); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = id;
                    	// VnvdTreeWalker.g:465:62: ( ^( ALIST ( argument )* ) )?
                    	int alt47 = 2;
                    	int LA47_0 = input.LA(1);

                    	if ( (LA47_0 == ALIST) )
                    	{
                    	    alt47 = 1;
                    	}
                    	switch (alt47) 
                    	{
                    	    case 1 :
                    	        // VnvdTreeWalker.g:465:63: ^( ALIST ( argument )* )
                    	        {
                    	        	_last = (TreeNode)input.LT(1);
                    	        	{
                    	        	TreeNode _save_last_2 = _last;
                    	        	TreeNode _first_2 = null;
                    	        	_last = (TreeNode)input.LT(1);
                    	        	ALIST122=(TreeNode)Match(input,ALIST,FOLLOW_ALIST_in_invocation_or_load_expression1789); if (state.failed) return retval;


                    	        	if ( (state.backtracking==0) )
                    	        	if ( _first_1==null ) _first_1 = ALIST122;
                    	        	if ( input.LA(1) == Token.DOWN )
                    	        	{
                    	        	    Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	        	    // VnvdTreeWalker.g:465:71: ( argument )*
                    	        	    do 
                    	        	    {
                    	        	        int alt46 = 2;
                    	        	        int LA46_0 = input.LA(1);

                    	        	        if ( (LA46_0 == ARGUMENT) )
                    	        	        {
                    	        	            alt46 = 1;
                    	        	        }


                    	        	        switch (alt46) 
                    	        	    	{
                    	        	    		case 1 :
                    	        	    		    // VnvdTreeWalker.g:465:71: argument
                    	        	    		    {
                    	        	    		    	_last = (TreeNode)input.LT(1);
                    	        	    		    	PushFollow(FOLLOW_argument_in_invocation_or_load_expression1791);
                    	        	    		    	argument123 = argument();
                    	        	    		    	state.followingStackPointer--;
                    	        	    		    	if (state.failed) return retval;
                    	        	    		    	if ( (state.backtracking==0) ) 
                    	        	    		    	 
                    	        	    		    	if ( _first_2==null ) _first_2 = (TreeNode) argument123.Tree;

                    	        	    		    	if ( (state.backtracking==0) ) {
                    	        	    		    	retval.Tree = (TreeNode)_first_0;
                    	        	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	        	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    	        	    		    }
                    	        	    		    break;

                    	        	    		default:
                    	        	    		    goto loop46;
                    	        	        }
                    	        	    } while (true);

                    	        	    loop46:
                    	        	    	;	// Stops C# compiler whining that label 'loop46' has no statements


                    	        	    Match(input, Token.UP, null); if (state.failed) return retval;
                    	        	}_last = _save_last_2;
                    	        	}


                    	        	if ( (state.backtracking==0) ) {
                    	        	retval.Tree = (TreeNode)_first_0;
                    	        	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	        	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.InvocationExpr(node, id.Text);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:469:4: ^(node= LBRACKET invocation_or_load_expression expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,LBRACKET,FOLLOW_LBRACKET_in_invocation_or_load_expression1808); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1810);
                    	invocation_or_load_expression124 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) invocation_or_load_expression124.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_invocation_or_load_expression1812);
                    	expression125 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) expression125.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.AccessArray(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:473:4: ^(node= CALLVIRT invocation_or_load_expression id= IDENTIFIER ( ^( ALIST ( argument )* ) ) )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,CALLVIRT,FOLLOW_CALLVIRT_in_invocation_or_load_expression1825); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1827);
                    	invocation_or_load_expression126 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) invocation_or_load_expression126.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_invocation_or_load_expression1831); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = id;
                    	// VnvdTreeWalker.g:473:64: ( ^( ALIST ( argument )* ) )
                    	// VnvdTreeWalker.g:473:65: ^( ALIST ( argument )* )
                    	{
                    		_last = (TreeNode)input.LT(1);
                    		{
                    		TreeNode _save_last_2 = _last;
                    		TreeNode _first_2 = null;
                    		_last = (TreeNode)input.LT(1);
                    		ALIST127=(TreeNode)Match(input,ALIST,FOLLOW_ALIST_in_invocation_or_load_expression1835); if (state.failed) return retval;


                    		if ( (state.backtracking==0) )
                    		if ( _first_1==null ) _first_1 = ALIST127;
                    		if ( input.LA(1) == Token.DOWN )
                    		{
                    		    Match(input, Token.DOWN, null); if (state.failed) return retval;
                    		    // VnvdTreeWalker.g:473:73: ( argument )*
                    		    do 
                    		    {
                    		        int alt48 = 2;
                    		        int LA48_0 = input.LA(1);

                    		        if ( (LA48_0 == ARGUMENT) )
                    		        {
                    		            alt48 = 1;
                    		        }


                    		        switch (alt48) 
                    		    	{
                    		    		case 1 :
                    		    		    // VnvdTreeWalker.g:473:73: argument
                    		    		    {
                    		    		    	_last = (TreeNode)input.LT(1);
                    		    		    	PushFollow(FOLLOW_argument_in_invocation_or_load_expression1837);
                    		    		    	argument128 = argument();
                    		    		    	state.followingStackPointer--;
                    		    		    	if (state.failed) return retval;
                    		    		    	if ( (state.backtracking==0) ) 
                    		    		    	 
                    		    		    	if ( _first_2==null ) _first_2 = (TreeNode) argument128.Tree;

                    		    		    	if ( (state.backtracking==0) ) {
                    		    		    	retval.Tree = (TreeNode)_first_0;
                    		    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    		    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    		    		    }
                    		    		    break;

                    		    		default:
                    		    		    goto loop48;
                    		        }
                    		    } while (true);

                    		    loop48:
                    		    	;	// Stops C# compiler whining that label 'loop48' has no statements


                    		    Match(input, Token.UP, null); if (state.failed) return retval;
                    		}_last = _save_last_2;
                    		}


                    		if ( (state.backtracking==0) ) {
                    		retval.Tree = (TreeNode)_first_0;
                    		if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    		    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    	}


                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.CallVirtual(node, id.Text);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 4 :
                    // VnvdTreeWalker.g:477:4: ^(node= CALL invocation_or_load_expression id= IDENTIFIER ( ^( ALIST ( argument )* ) ) )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,CALL,FOLLOW_CALL_in_invocation_or_load_expression1853); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1855);
                    	invocation_or_load_expression129 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) invocation_or_load_expression129.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_invocation_or_load_expression1859); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = id;
                    	// VnvdTreeWalker.g:477:60: ( ^( ALIST ( argument )* ) )
                    	// VnvdTreeWalker.g:477:61: ^( ALIST ( argument )* )
                    	{
                    		_last = (TreeNode)input.LT(1);
                    		{
                    		TreeNode _save_last_2 = _last;
                    		TreeNode _first_2 = null;
                    		_last = (TreeNode)input.LT(1);
                    		ALIST130=(TreeNode)Match(input,ALIST,FOLLOW_ALIST_in_invocation_or_load_expression1863); if (state.failed) return retval;


                    		if ( (state.backtracking==0) )
                    		if ( _first_1==null ) _first_1 = ALIST130;
                    		if ( input.LA(1) == Token.DOWN )
                    		{
                    		    Match(input, Token.DOWN, null); if (state.failed) return retval;
                    		    // VnvdTreeWalker.g:477:69: ( argument )*
                    		    do 
                    		    {
                    		        int alt49 = 2;
                    		        int LA49_0 = input.LA(1);

                    		        if ( (LA49_0 == ARGUMENT) )
                    		        {
                    		            alt49 = 1;
                    		        }


                    		        switch (alt49) 
                    		    	{
                    		    		case 1 :
                    		    		    // VnvdTreeWalker.g:477:69: argument
                    		    		    {
                    		    		    	_last = (TreeNode)input.LT(1);
                    		    		    	PushFollow(FOLLOW_argument_in_invocation_or_load_expression1865);
                    		    		    	argument131 = argument();
                    		    		    	state.followingStackPointer--;
                    		    		    	if (state.failed) return retval;
                    		    		    	if ( (state.backtracking==0) ) 
                    		    		    	 
                    		    		    	if ( _first_2==null ) _first_2 = (TreeNode) argument131.Tree;

                    		    		    	if ( (state.backtracking==0) ) {
                    		    		    	retval.Tree = (TreeNode)_first_0;
                    		    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    		    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    		    		    }
                    		    		    break;

                    		    		default:
                    		    		    goto loop49;
                    		        }
                    		    } while (true);

                    		    loop49:
                    		    	;	// Stops C# compiler whining that label 'loop49' has no statements


                    		    Match(input, Token.UP, null); if (state.failed) return retval;
                    		}_last = _save_last_2;
                    		}


                    		if ( (state.backtracking==0) ) {
                    		retval.Tree = (TreeNode)_first_0;
                    		if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    		    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    	}


                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.Call(node, id.Text);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 5 :
                    // VnvdTreeWalker.g:481:4: ^(node= LDFLD invocation_or_load_expression id= IDENTIFIER )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,LDFLD,FOLLOW_LDFLD_in_invocation_or_load_expression1881); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1883);
                    	invocation_or_load_expression132 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) invocation_or_load_expression132.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_invocation_or_load_expression1887); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = id;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LoadField(node, id.Text);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 6 :
                    // VnvdTreeWalker.g:485:4: ^(node= LDSFLD invocation_or_load_expression id= IDENTIFIER )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,LDSFLD,FOLLOW_LDSFLD_in_invocation_or_load_expression1900); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1902);
                    	invocation_or_load_expression133 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) invocation_or_load_expression133.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_invocation_or_load_expression1906); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = id;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LoadStaticField(node, id.Text);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 7 :
                    // VnvdTreeWalker.g:489:4: ^(node= LDLITERAL invocation_or_load_expression id= IDENTIFIER )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,LDLITERAL,FOLLOW_LDLITERAL_in_invocation_or_load_expression1919); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1921);
                    	invocation_or_load_expression134 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) invocation_or_load_expression134.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_invocation_or_load_expression1925); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = id;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LoadLiteral(node, id.Text);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 8 :
                    // VnvdTreeWalker.g:493:4: ^(node= LDVIRTFTN invocation_or_load_expression id= IDENTIFIER )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,LDVIRTFTN,FOLLOW_LDVIRTFTN_in_invocation_or_load_expression1938); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1940);
                    	invocation_or_load_expression135 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) invocation_or_load_expression135.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_invocation_or_load_expression1944); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = id;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LoadVirtualFunction(node, id.Text);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 9 :
                    // VnvdTreeWalker.g:497:4: ^(node= LDFTN invocation_or_load_expression id= IDENTIFIER )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,LDFTN,FOLLOW_LDFTN_in_invocation_or_load_expression1957); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1959);
                    	invocation_or_load_expression136 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) invocation_or_load_expression136.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_invocation_or_load_expression1963); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = id;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LoadFunction(node, id.Text);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 10 :
                    // VnvdTreeWalker.g:501:4: ^(node= DONTLD invocation_or_load_expression id= IDENTIFIER )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,DONTLD,FOLLOW_DONTLD_in_invocation_or_load_expression1976); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1978);
                    	invocation_or_load_expression137 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) invocation_or_load_expression137.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	id=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_invocation_or_load_expression1982); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = id;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.FieldAssignment(node, id.Text);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 11 :
                    // VnvdTreeWalker.g:505:4: operand
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_operand_in_invocation_or_load_expression1992);
                    	operand138 = operand();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) operand138.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "invocation_or_load_expression"

    public class operand_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "operand"
    // VnvdTreeWalker.g:508:1: operand : ( ^(node= USAGE qual= qualifier ) | literal_value | node= THIS | node= BASE | node= NULL | read_write_expression | object_creation_expression | array_creation_expression | ^(node= EXPRBLOCK expression ) | block_expression | scope_expr );
    public VnvdTreeWalker.operand_return operand() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.operand_return retval = new VnvdTreeWalker.operand_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.literal_value_return literal_value139 = default(VnvdTreeWalker.literal_value_return);

        VnvdTreeWalker.read_write_expression_return read_write_expression140 = default(VnvdTreeWalker.read_write_expression_return);

        VnvdTreeWalker.object_creation_expression_return object_creation_expression141 = default(VnvdTreeWalker.object_creation_expression_return);

        VnvdTreeWalker.array_creation_expression_return array_creation_expression142 = default(VnvdTreeWalker.array_creation_expression_return);

        VnvdTreeWalker.expression_return expression143 = default(VnvdTreeWalker.expression_return);

        VnvdTreeWalker.block_expression_return block_expression144 = default(VnvdTreeWalker.block_expression_return);

        VnvdTreeWalker.scope_expr_return scope_expr145 = default(VnvdTreeWalker.scope_expr_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:509:2: ( ^(node= USAGE qual= qualifier ) | literal_value | node= THIS | node= BASE | node= NULL | read_write_expression | object_creation_expression | array_creation_expression | ^(node= EXPRBLOCK expression ) | block_expression | scope_expr )
            int alt51 = 11;
            switch ( input.LA(1) ) 
            {
            case USAGE:
            	{
                alt51 = 1;
                }
                break;
            case TRUE:
            case FALSE:
            case NUMBER:
            case STRING:
            case CHAR:
            case FLOAT:
            	{
                alt51 = 2;
                }
                break;
            case THIS:
            	{
                alt51 = 3;
                }
                break;
            case BASE:
            	{
                alt51 = 4;
                }
                break;
            case NULL:
            	{
                alt51 = 5;
                }
                break;
            case READ:
            case WRITE:
            case READVOID:
            case WRITEVOID:
            	{
                alt51 = 6;
                }
                break;
            case NEW:
            	{
                alt51 = 7;
                }
                break;
            case NEWARR:
            case NEWARRELEMS:
            	{
                alt51 = 8;
                }
                break;
            case EXPRBLOCK:
            	{
                alt51 = 9;
                }
                break;
            case SLIST:
            	{
                alt51 = 10;
                }
                break;
            case SCOPEEXPR:
            	{
                alt51 = 11;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d51s0 =
            	        new NoViableAltException("", 51, 0, input);

            	    throw nvae_d51s0;
            }

            switch (alt51) 
            {
                case 1 :
                    // VnvdTreeWalker.g:509:4: ^(node= USAGE qual= qualifier )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,USAGE,FOLLOW_USAGE_in_operand2006); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_qualifier_in_operand2010);
                    	qual = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.VariableUsed(node, ((qual != null) ? qual.ids : default(Qualifier)));
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:513:4: literal_value
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_literal_value_in_operand2020);
                    	literal_value139 = literal_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) literal_value139.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:514:4: node= THIS
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,THIS,FOLLOW_THIS_in_operand2027); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LiteralThis(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 4 :
                    // VnvdTreeWalker.g:518:4: node= BASE
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,BASE,FOLLOW_BASE_in_operand2038); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LiteralBase(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 5 :
                    // VnvdTreeWalker.g:522:4: node= NULL
                    {
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,NULL,FOLLOW_NULL_in_operand2049); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.LiteralNull(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 6 :
                    // VnvdTreeWalker.g:526:4: read_write_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_read_write_expression_in_operand2058);
                    	read_write_expression140 = read_write_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) read_write_expression140.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 7 :
                    // VnvdTreeWalker.g:527:4: object_creation_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_object_creation_expression_in_operand2063);
                    	object_creation_expression141 = object_creation_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) object_creation_expression141.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 8 :
                    // VnvdTreeWalker.g:528:4: array_creation_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_array_creation_expression_in_operand2068);
                    	array_creation_expression142 = array_creation_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) array_creation_expression142.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 9 :
                    // VnvdTreeWalker.g:529:4: ^(node= EXPRBLOCK expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,EXPRBLOCK,FOLLOW_EXPRBLOCK_in_operand2076); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_operand2078);
                    	expression143 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) expression143.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ExpressionBlock(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 10 :
                    // VnvdTreeWalker.g:533:4: block_expression
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_block_expression_in_operand2088);
                    	block_expression144 = block_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) block_expression144.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 11 :
                    // VnvdTreeWalker.g:534:4: scope_expr
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_scope_expr_in_operand2093);
                    	scope_expr145 = scope_expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) scope_expr145.Tree;

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "operand"

    public class read_write_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "read_write_expression"
    // VnvdTreeWalker.g:537:1: read_write_expression : ( ^(node= READ qual= IDENTIFIER ) | ^(node= READVOID qual= IDENTIFIER ) | ^(node= WRITE expression ) | ^(node= WRITEVOID expression ) );
    public VnvdTreeWalker.read_write_expression_return read_write_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.read_write_expression_return retval = new VnvdTreeWalker.read_write_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode qual = null;
        VnvdTreeWalker.expression_return expression146 = default(VnvdTreeWalker.expression_return);

        VnvdTreeWalker.expression_return expression147 = default(VnvdTreeWalker.expression_return);


        TreeNode node_tree=null;
        TreeNode qual_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:538:2: ( ^(node= READ qual= IDENTIFIER ) | ^(node= READVOID qual= IDENTIFIER ) | ^(node= WRITE expression ) | ^(node= WRITEVOID expression ) )
            int alt52 = 4;
            switch ( input.LA(1) ) 
            {
            case READ:
            	{
                alt52 = 1;
                }
                break;
            case READVOID:
            	{
                alt52 = 2;
                }
                break;
            case WRITE:
            	{
                alt52 = 3;
                }
                break;
            case WRITEVOID:
            	{
                alt52 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d52s0 =
            	        new NoViableAltException("", 52, 0, input);

            	    throw nvae_d52s0;
            }

            switch (alt52) 
            {
                case 1 :
                    // VnvdTreeWalker.g:538:4: ^(node= READ qual= IDENTIFIER )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,READ,FOLLOW_READ_in_read_write_expression2107); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	qual=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_read_write_expression2111); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = qual;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ReadExpression(node, qual.Text);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:542:4: ^(node= READVOID qual= IDENTIFIER )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,READVOID,FOLLOW_READVOID_in_read_write_expression2124); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	qual=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_read_write_expression2128); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = qual;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ReadVoidExpression(node, qual.Text);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 3 :
                    // VnvdTreeWalker.g:546:4: ^(node= WRITE expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,WRITE,FOLLOW_WRITE_in_read_write_expression2141); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_read_write_expression2143);
                    	expression146 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) expression146.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.WriteExpression(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 4 :
                    // VnvdTreeWalker.g:550:4: ^(node= WRITEVOID expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,WRITEVOID,FOLLOW_WRITEVOID_in_read_write_expression2156); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_read_write_expression2158);
                    	expression147 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) expression147.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.WriteVoidExpression(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "read_write_expression"

    public class array_creation_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "array_creation_expression"
    // VnvdTreeWalker.g:556:1: array_creation_expression : ( ^(node= NEWARR qualifier expression ) | ^(node= NEWARRELEMS qualifier ^( ARRELEMS ( array_initial_elements )* ) ) );
    public VnvdTreeWalker.array_creation_expression_return array_creation_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.array_creation_expression_return retval = new VnvdTreeWalker.array_creation_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode ARRELEMS151 = null;
        VnvdTreeWalker.qualifier_return qualifier148 = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.expression_return expression149 = default(VnvdTreeWalker.expression_return);

        VnvdTreeWalker.qualifier_return qualifier150 = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.array_initial_elements_return array_initial_elements152 = default(VnvdTreeWalker.array_initial_elements_return);


        TreeNode node_tree=null;
        TreeNode ARRELEMS151_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:557:2: ( ^(node= NEWARR qualifier expression ) | ^(node= NEWARRELEMS qualifier ^( ARRELEMS ( array_initial_elements )* ) ) )
            int alt54 = 2;
            int LA54_0 = input.LA(1);

            if ( (LA54_0 == NEWARR) )
            {
                alt54 = 1;
            }
            else if ( (LA54_0 == NEWARRELEMS) )
            {
                alt54 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d54s0 =
                    new NoViableAltException("", 54, 0, input);

                throw nvae_d54s0;
            }
            switch (alt54) 
            {
                case 1 :
                    // VnvdTreeWalker.g:557:4: ^(node= NEWARR qualifier expression )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,NEWARR,FOLLOW_NEWARR_in_array_creation_expression2177); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_qualifier_in_array_creation_expression2179);
                    	qualifier148 = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) qualifier148.Tree;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_array_creation_expression2181);
                    	expression149 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) expression149.Tree;

                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ArrayCreationExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:561:4: ^(node= NEWARRELEMS qualifier ^( ARRELEMS ( array_initial_elements )* ) )
                    {
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_1 = _last;
                    	TreeNode _first_1 = null;
                    	_last = (TreeNode)input.LT(1);
                    	node=(TreeNode)Match(input,NEWARRELEMS,FOLLOW_NEWARRELEMS_in_array_creation_expression2194); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = node;
                    	Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_qualifier_in_array_creation_expression2196);
                    	qualifier150 = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_1==null ) _first_1 = (TreeNode) qualifier150.Tree;
                    	if ( (state.backtracking==0) )
                    	{
                    	   h.BeforeArrayElementedCreationExpr(node); 
                    	}
                    	_last = (TreeNode)input.LT(1);
                    	{
                    	TreeNode _save_last_2 = _last;
                    	TreeNode _first_2 = null;
                    	_last = (TreeNode)input.LT(1);
                    	ARRELEMS151=(TreeNode)Match(input,ARRELEMS,FOLLOW_ARRELEMS_in_array_creation_expression2201); if (state.failed) return retval;


                    	if ( (state.backtracking==0) )
                    	if ( _first_1==null ) _first_1 = ARRELEMS151;
                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); if (state.failed) return retval;
                    	    // VnvdTreeWalker.g:561:90: ( array_initial_elements )*
                    	    do 
                    	    {
                    	        int alt53 = 2;
                    	        int LA53_0 = input.LA(1);

                    	        if ( (LA53_0 == ARRELEM) )
                    	        {
                    	            alt53 = 1;
                    	        }


                    	        switch (alt53) 
                    	    	{
                    	    		case 1 :
                    	    		    // VnvdTreeWalker.g:561:90: array_initial_elements
                    	    		    {
                    	    		    	_last = (TreeNode)input.LT(1);
                    	    		    	PushFollow(FOLLOW_array_initial_elements_in_array_creation_expression2203);
                    	    		    	array_initial_elements152 = array_initial_elements();
                    	    		    	state.followingStackPointer--;
                    	    		    	if (state.failed) return retval;
                    	    		    	if ( (state.backtracking==0) ) 
                    	    		    	 
                    	    		    	if ( _first_2==null ) _first_2 = (TreeNode) array_initial_elements152.Tree;

                    	    		    	if ( (state.backtracking==0) ) {
                    	    		    	retval.Tree = (TreeNode)_first_0;
                    	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    	    		    }
                    	    		    break;

                    	    		default:
                    	    		    goto loop53;
                    	        }
                    	    } while (true);

                    	    loop53:
                    	    	;	// Stops C# compiler whining that label 'loop53' has no statements


                    	    Match(input, Token.UP, null); if (state.failed) return retval;
                    	}_last = _save_last_2;
                    	}


                    	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
                    	}

                    	if ( (state.backtracking==0) )
                    	{

                    	  			h.ArrayElementedCreationExpr(node);
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "array_creation_expression"

    public class array_initial_elements_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "array_initial_elements"
    // VnvdTreeWalker.g:567:1: array_initial_elements : ^(node= ARRELEM expression ) ;
    public VnvdTreeWalker.array_initial_elements_return array_initial_elements() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.array_initial_elements_return retval = new VnvdTreeWalker.array_initial_elements_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.expression_return expression153 = default(VnvdTreeWalker.expression_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:568:2: ( ^(node= ARRELEM expression ) )
            // VnvdTreeWalker.g:568:4: ^(node= ARRELEM expression )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,ARRELEM,FOLLOW_ARRELEM_in_array_initial_elements2225); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;if ( (state.backtracking==0) )
            	{
            	   h.BeforeArrayElementedElement(node); 
            	}

            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_expression_in_array_initial_elements2229);
            	expression153 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) expression153.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.ArrayElementedElement(node);
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "array_initial_elements"

    public class object_creation_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "object_creation_expression"
    // VnvdTreeWalker.g:574:1: object_creation_expression : ^(node= NEW qual= qualifier ( ^( ALIST ( argument )* ) )? ) ;
    public VnvdTreeWalker.object_creation_expression_return object_creation_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.object_creation_expression_return retval = new VnvdTreeWalker.object_creation_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        TreeNode ALIST154 = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);

        VnvdTreeWalker.argument_return argument155 = default(VnvdTreeWalker.argument_return);


        TreeNode node_tree=null;
        TreeNode ALIST154_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:575:2: ( ^(node= NEW qual= qualifier ( ^( ALIST ( argument )* ) )? ) )
            // VnvdTreeWalker.g:575:4: ^(node= NEW qual= qualifier ( ^( ALIST ( argument )* ) )? )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,NEW,FOLLOW_NEW_in_object_creation_expression2248); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_qualifier_in_object_creation_expression2252);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) qual.Tree;
            	// VnvdTreeWalker.g:575:30: ( ^( ALIST ( argument )* ) )?
            	int alt56 = 2;
            	int LA56_0 = input.LA(1);

            	if ( (LA56_0 == ALIST) )
            	{
            	    alt56 = 1;
            	}
            	switch (alt56) 
            	{
            	    case 1 :
            	        // VnvdTreeWalker.g:575:31: ^( ALIST ( argument )* )
            	        {
            	        	_last = (TreeNode)input.LT(1);
            	        	{
            	        	TreeNode _save_last_2 = _last;
            	        	TreeNode _first_2 = null;
            	        	_last = (TreeNode)input.LT(1);
            	        	ALIST154=(TreeNode)Match(input,ALIST,FOLLOW_ALIST_in_object_creation_expression2256); if (state.failed) return retval;


            	        	if ( (state.backtracking==0) )
            	        	if ( _first_1==null ) _first_1 = ALIST154;
            	        	if ( input.LA(1) == Token.DOWN )
            	        	{
            	        	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	        	    // VnvdTreeWalker.g:575:39: ( argument )*
            	        	    do 
            	        	    {
            	        	        int alt55 = 2;
            	        	        int LA55_0 = input.LA(1);

            	        	        if ( (LA55_0 == ARGUMENT) )
            	        	        {
            	        	            alt55 = 1;
            	        	        }


            	        	        switch (alt55) 
            	        	    	{
            	        	    		case 1 :
            	        	    		    // VnvdTreeWalker.g:575:39: argument
            	        	    		    {
            	        	    		    	_last = (TreeNode)input.LT(1);
            	        	    		    	PushFollow(FOLLOW_argument_in_object_creation_expression2258);
            	        	    		    	argument155 = argument();
            	        	    		    	state.followingStackPointer--;
            	        	    		    	if (state.failed) return retval;
            	        	    		    	if ( (state.backtracking==0) ) 
            	        	    		    	 
            	        	    		    	if ( _first_2==null ) _first_2 = (TreeNode) argument155.Tree;

            	        	    		    	if ( (state.backtracking==0) ) {
            	        	    		    	retval.Tree = (TreeNode)_first_0;
            	        	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        	    		    }
            	        	    		    break;

            	        	    		default:
            	        	    		    goto loop55;
            	        	        }
            	        	    } while (true);

            	        	    loop55:
            	        	    	;	// Stops C# compiler whining that label 'loop55' has no statements


            	        	    Match(input, Token.UP, null); if (state.failed) return retval;
            	        	}_last = _save_last_2;
            	        	}


            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = (TreeNode)_first_0;
            	        	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.ObjectCreation(node, ((qual != null) ? qual.ids : default(Qualifier)));
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "object_creation_expression"

    public class block_expression_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "block_expression"
    // VnvdTreeWalker.g:581:1: block_expression : ^(node= SLIST ( statement )* ) ;
    public VnvdTreeWalker.block_expression_return block_expression() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.block_expression_return retval = new VnvdTreeWalker.block_expression_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode node = null;
        VnvdTreeWalker.statement_return statement156 = default(VnvdTreeWalker.statement_return);


        TreeNode node_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:582:2: ( ^(node= SLIST ( statement )* ) )
            // VnvdTreeWalker.g:582:4: ^(node= SLIST ( statement )* )
            {
            	if ( (state.backtracking==0) )
            	{
            	   h.OpenScope(); 
            	}
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	node=(TreeNode)Match(input,SLIST,FOLLOW_SLIST_in_block_expression2284); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = node;
            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); if (state.failed) return retval;
            	    // VnvdTreeWalker.g:582:36: ( statement )*
            	    do 
            	    {
            	        int alt57 = 2;
            	        int LA57_0 = input.LA(1);

            	        if ( (LA57_0 == LBRACKET || (LA57_0 >= DCOLON && LA57_0 <= MOD) || LA57_0 == NEW || LA57_0 == IF || (LA57_0 >= WHILE && LA57_0 <= FOR) || (LA57_0 >= CONST && LA57_0 <= THIS) || LA57_0 == LOCAL || (LA57_0 >= READ && LA57_0 <= TRY) || (LA57_0 >= THROW && LA57_0 <= WRITE) || LA57_0 == SLIST || (LA57_0 >= EXPRBLOCK && LA57_0 <= CAST) || (LA57_0 >= READVOID && LA57_0 <= WRITEVOID) || (LA57_0 >= NEWARR && LA57_0 <= NEWARRELEMS) || (LA57_0 >= CALLVIRT && LA57_0 <= DONTLD) || (LA57_0 >= NUMBER && LA57_0 <= FLOAT)) )
            	        {
            	            alt57 = 1;
            	        }


            	        switch (alt57) 
            	    	{
            	    		case 1 :
            	    		    // VnvdTreeWalker.g:582:36: statement
            	    		    {
            	    		    	_last = (TreeNode)input.LT(1);
            	    		    	PushFollow(FOLLOW_statement_in_block_expression2286);
            	    		    	statement156 = statement();
            	    		    	state.followingStackPointer--;
            	    		    	if (state.failed) return retval;
            	    		    	if ( (state.backtracking==0) ) 
            	    		    	 
            	    		    	if ( _first_1==null ) _first_1 = (TreeNode) statement156.Tree;

            	    		    	if ( (state.backtracking==0) ) {
            	    		    	retval.Tree = (TreeNode)_first_0;
            	    		    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    		    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop57;
            	        }
            	    } while (true);

            	    loop57:
            	    	;	// Stops C# compiler whining that label 'loop57' has no statements


            	    Match(input, Token.UP, null); if (state.failed) return retval;
            	}_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			h.StatementBlock(node);
            	  			h.CloseScope();
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "block_expression"

    public class argument_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "argument"
    // VnvdTreeWalker.g:589:1: argument : ^( ARGUMENT expression ) ;
    public VnvdTreeWalker.argument_return argument() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.argument_return retval = new VnvdTreeWalker.argument_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode ARGUMENT157 = null;
        VnvdTreeWalker.expression_return expression158 = default(VnvdTreeWalker.expression_return);


        TreeNode ARGUMENT157_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:590:2: ( ^( ARGUMENT expression ) )
            // VnvdTreeWalker.g:590:4: ^( ARGUMENT expression )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	ARGUMENT157=(TreeNode)Match(input,ARGUMENT,FOLLOW_ARGUMENT_in_argument2304); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = ARGUMENT157;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	_last = (TreeNode)input.LT(1);
            	PushFollow(FOLLOW_expression_in_argument2306);
            	expression158 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) 
            	 
            	if ( _first_1==null ) _first_1 = (TreeNode) expression158.Tree;

            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}


            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "argument"

    public class qualifier_return : TreeRuleReturnScope
    {
        public Qualifier ids;
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "qualifier"
    // VnvdTreeWalker.g:593:1: qualifier returns [Qualifier ids] : ^(fqual= FQUALIFIER ( IDENTIFIER )+ ( ARRAY )? ) ;
    public VnvdTreeWalker.qualifier_return qualifier() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.qualifier_return retval = new VnvdTreeWalker.qualifier_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode fqual = null;
        TreeNode IDENTIFIER159 = null;
        TreeNode ARRAY160 = null;

        TreeNode fqual_tree=null;
        TreeNode IDENTIFIER159_tree=null;
        TreeNode ARRAY160_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:594:2: ( ^(fqual= FQUALIFIER ( IDENTIFIER )+ ( ARRAY )? ) )
            // VnvdTreeWalker.g:594:4: ^(fqual= FQUALIFIER ( IDENTIFIER )+ ( ARRAY )? )
            {
            	_last = (TreeNode)input.LT(1);
            	{
            	TreeNode _save_last_1 = _last;
            	TreeNode _first_1 = null;
            	_last = (TreeNode)input.LT(1);
            	fqual=(TreeNode)Match(input,FQUALIFIER,FOLLOW_FQUALIFIER_in_qualifier2325); if (state.failed) return retval;


            	if ( (state.backtracking==0) )
            	if ( _first_0==null ) _first_0 = fqual;
            	Match(input, Token.DOWN, null); if (state.failed) return retval;
            	// VnvdTreeWalker.g:594:23: ( IDENTIFIER )+
            	int cnt58 = 0;
            	do 
            	{
            	    int alt58 = 2;
            	    int LA58_0 = input.LA(1);

            	    if ( (LA58_0 == IDENTIFIER) )
            	    {
            	        alt58 = 1;
            	    }


            	    switch (alt58) 
            		{
            			case 1 :
            			    // VnvdTreeWalker.g:594:23: IDENTIFIER
            			    {
            			    	_last = (TreeNode)input.LT(1);
            			    	IDENTIFIER159=(TreeNode)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_qualifier2327); if (state.failed) return retval;
            			    	 
            			    	if ( (state.backtracking==0) )
            			    	if ( _first_1==null ) _first_1 = IDENTIFIER159;

            			    	if ( (state.backtracking==0) ) {
            			    	retval.Tree = (TreeNode)_first_0;
            			    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            			    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            			    }
            			    break;

            			default:
            			    if ( cnt58 >= 1 ) goto loop58;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee58 =
            		                new EarlyExitException(58, input);
            		            throw eee58;
            	    }
            	    cnt58++;
            	} while (true);

            	loop58:
            		;	// Stops C# compiler whining that label 'loop58' has no statements

            	// VnvdTreeWalker.g:594:35: ( ARRAY )?
            	int alt59 = 2;
            	int LA59_0 = input.LA(1);

            	if ( (LA59_0 == ARRAY) )
            	{
            	    alt59 = 1;
            	}
            	switch (alt59) 
            	{
            	    case 1 :
            	        // VnvdTreeWalker.g:594:35: ARRAY
            	        {
            	        	_last = (TreeNode)input.LT(1);
            	        	ARRAY160=(TreeNode)Match(input,ARRAY,FOLLOW_ARRAY_in_qualifier2330); if (state.failed) return retval;
            	        	 
            	        	if ( (state.backtracking==0) )
            	        	if ( _first_1==null ) _first_1 = ARRAY160;

            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = (TreeNode)_first_0;
            	        	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	        	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); if (state.failed) return retval;_last = _save_last_1;
            	}

            	if ( (state.backtracking==0) )
            	{

            	  			retval.ids =  h.FullQualifier(fqual);
            	  		
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "qualifier"

    public class type_qualifier_return : TreeRuleReturnScope
    {
        public Qualifier ids;
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "type_qualifier"
    // VnvdTreeWalker.g:600:1: type_qualifier returns [Qualifier ids] : (v= VOID | qual= qualifier );
    public VnvdTreeWalker.type_qualifier_return type_qualifier() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.type_qualifier_return retval = new VnvdTreeWalker.type_qualifier_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode v = null;
        VnvdTreeWalker.qualifier_return qual = default(VnvdTreeWalker.qualifier_return);


        TreeNode v_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:601:2: (v= VOID | qual= qualifier )
            int alt60 = 2;
            int LA60_0 = input.LA(1);

            if ( (LA60_0 == VOID) )
            {
                alt60 = 1;
            }
            else if ( (LA60_0 == FQUALIFIER) )
            {
                alt60 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d60s0 =
                    new NoViableAltException("", 60, 0, input);

                throw nvae_d60s0;
            }
            switch (alt60) 
            {
                case 1 :
                    // VnvdTreeWalker.g:601:4: v= VOID
                    {
                    	_last = (TreeNode)input.LT(1);
                    	v=(TreeNode)Match(input,VOID,FOLLOW_VOID_in_type_qualifier2354); if (state.failed) return retval;
                    	 
                    	if ( (state.backtracking==0) )
                    	if ( _first_0==null ) _first_0 = v;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			retval.ids =  new Qualifier() { "System", "Void" };
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;
                case 2 :
                    // VnvdTreeWalker.g:605:4: qual= qualifier
                    {
                    	_last = (TreeNode)input.LT(1);
                    	PushFollow(FOLLOW_qualifier_in_type_qualifier2365);
                    	qual = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) 
                    	 
                    	if ( _first_0==null ) _first_0 = (TreeNode) qual.Tree;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			retval.ids =  h.TypeQualifier(((qual != null) ? qual.ids : default(Qualifier)));
                    	  		
                    	}

                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = (TreeNode)_first_0;
                    	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
                    	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);}
                    }
                    break;

            }
        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type_qualifier"

    public class modifier_return : TreeRuleReturnScope
    {
        private TreeNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (TreeNode) value; }
        }
    };

    // $ANTLR start "modifier"
    // VnvdTreeWalker.g:611:1: modifier : ( PRIVATE | PUBLIC | PROTECTED | INTERNAL | ABSTRACT | STATIC | VIRTUAL | OVERRIDE | INITONLY );
    public VnvdTreeWalker.modifier_return modifier() // throws RecognitionException [1]
    {   
        VnvdTreeWalker.modifier_return retval = new VnvdTreeWalker.modifier_return();
        retval.Start = input.LT(1);

        TreeNode root_0 = null;

        TreeNode _first_0 = null;
        TreeNode _last = null;

        TreeNode set161 = null;

        TreeNode set161_tree=null;

        try 
    	{
            // VnvdTreeWalker.g:612:2: ( PRIVATE | PUBLIC | PROTECTED | INTERNAL | ABSTRACT | STATIC | VIRTUAL | OVERRIDE | INITONLY )
            // VnvdTreeWalker.g:
            {
            	_last = (TreeNode)input.LT(1);
            	set161 = (TreeNode)input.LT(1);
            	if ( input.LA(1) == STATIC || (input.LA(1) >= PRIVATE && input.LA(1) <= INITONLY) ) 
            	{
            	    input.Consume();


            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	if ( (state.backtracking==0) ) {
            	retval.Tree = (TreeNode)_first_0;
            	if ( adaptor.GetParent(retval.Tree)!=null && adaptor.IsNil( adaptor.GetParent(retval.Tree) ) )
            	    retval.Tree = (TreeNode)adaptor.GetParent(retval.Tree);} 

            }

        }

        	catch (RecognitionException re)
        	{
        		ReportError(re);
        		Recover(input,re);
        	}
        	catch (CheckerException ex)
        	{
        		if (ex.GetLastError() != null)
        		{
        			ex.GetLastError().First.Entry = ErrorType.DefaultEntry;
        			ex.GetLastError().First.ReturnType = ErrorType.Default;
        		}
        		Console.WriteLine(Filename + "\t" + ex.ToString());
        		SemanticErrorCount++;
        	}
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modifier"

    // $ANTLR start "synpred1_VnvdTreeWalker"
    public void synpred1_VnvdTreeWalker_fragment() {
        // VnvdTreeWalker.g:413:4: ( ^( PLUS primary_expression primary_expression ) )
        // VnvdTreeWalker.g:413:5: ^( PLUS primary_expression primary_expression )
        {
        	Match(input,PLUS,FOLLOW_PLUS_in_synpred1_VnvdTreeWalker1560); if (state.failed) return ;

        	Match(input, Token.DOWN, null); if (state.failed) return ;
        	PushFollow(FOLLOW_primary_expression_in_synpred1_VnvdTreeWalker1562);
        	primary_expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_primary_expression_in_synpred1_VnvdTreeWalker1564);
        	primary_expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        	Match(input, Token.UP, null); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_VnvdTreeWalker"

    // $ANTLR start "synpred2_VnvdTreeWalker"
    public void synpred2_VnvdTreeWalker_fragment() {
        // VnvdTreeWalker.g:417:4: ( ^( MINUS primary_expression primary_expression ) )
        // VnvdTreeWalker.g:417:5: ^( MINUS primary_expression primary_expression )
        {
        	Match(input,MINUS,FOLLOW_MINUS_in_synpred2_VnvdTreeWalker1589); if (state.failed) return ;

        	Match(input, Token.DOWN, null); if (state.failed) return ;
        	PushFollow(FOLLOW_primary_expression_in_synpred2_VnvdTreeWalker1591);
        	primary_expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_primary_expression_in_synpred2_VnvdTreeWalker1593);
        	primary_expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        	Match(input, Token.UP, null); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_VnvdTreeWalker"

    // Delegated rules

   	public bool synpred1_VnvdTreeWalker() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_VnvdTreeWalker_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred2_VnvdTreeWalker() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_VnvdTreeWalker_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA42 dfa42;
	private void InitializeCyclicDFAs()
	{
    	this.dfa42 = new DFA42(this);
	    this.dfa42.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA42_SpecialStateTransition);
	}

    const string DFA42_eotS =
        "\x28\uffff";
    const string DFA42_eofS =
        "\x28\uffff";
    const string DFA42_minS =
        "\x01\x0c\x02\x00\x25\uffff";
    const string DFA42_maxS =
        "\x01\x77\x02\x00\x25\uffff";
    const string DFA42_acceptS =
        "\x03\uffff\x01\x03\x22\uffff\x01\x01\x01\x02";
    const string DFA42_specialS =
        "\x01\uffff\x01\x00\x01\x01\x25\uffff}>";
    static readonly string[] DFA42_transitionS = {
            "\x01\x03\x03\uffff\x01\x03\x03\uffff\x01\x01\x01\x02\x02\x03"+
            "\x0b\uffff\x02\x03\x04\uffff\x01\x03\x0b\uffff\x04\x03\x09\uffff"+
            "\x02\x03\x07\uffff\x01\x03\x0c\uffff\x01\x03\x04\uffff\x04\x03"+
            "\x01\uffff\x02\x03\x01\uffff\x02\x03\x04\uffff\x08\x03\x01\uffff"+
            "\x04\x03",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA42_eot = DFA.UnpackEncodedString(DFA42_eotS);
    static readonly short[] DFA42_eof = DFA.UnpackEncodedString(DFA42_eofS);
    static readonly char[] DFA42_min = DFA.UnpackEncodedStringToUnsignedChars(DFA42_minS);
    static readonly char[] DFA42_max = DFA.UnpackEncodedStringToUnsignedChars(DFA42_maxS);
    static readonly short[] DFA42_accept = DFA.UnpackEncodedString(DFA42_acceptS);
    static readonly short[] DFA42_special = DFA.UnpackEncodedString(DFA42_specialS);
    static readonly short[][] DFA42_transition = DFA.UnpackEncodedStringArray(DFA42_transitionS);

    protected class DFA42 : DFA
    {
        public DFA42(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 42;
            this.eot = DFA42_eot;
            this.eof = DFA42_eof;
            this.min = DFA42_min;
            this.max = DFA42_max;
            this.accept = DFA42_accept;
            this.special = DFA42_special;
            this.transition = DFA42_transition;

        }

        override public string Description
        {
            get { return "412:1: primary_expression : ( ( ^( PLUS primary_expression primary_expression ) )=> ^(node= PLUS primary_expression primary_expression ) | ( ^( MINUS primary_expression primary_expression ) )=> ^(node= MINUS primary_expression primary_expression ) | secundary_expression );"; }
        }

    }


    protected internal int DFA42_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITreeNodeStream input = (ITreeNodeStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA42_1 = input.LA(1);

                   	 
                   	int index42_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_VnvdTreeWalker()) ) { s = 38; }

                   	else if ( (true) ) { s = 3; }

                   	 
                   	input.Seek(index42_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA42_2 = input.LA(1);

                   	 
                   	int index42_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_VnvdTreeWalker()) ) { s = 39; }

                   	else if ( (true) ) { s = 3; }

                   	 
                   	input.Seek(index42_2);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae42 =
            new NoViableAltException(dfa.Description, 42, _s, input);
        dfa.Error(nvae42);
        throw nvae42;
    }
 

    public static readonly BitSet FOLLOW_PROGRAM_in_program88 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_import_stat_in_program90 = new BitSet(new ulong[]{0x0000006000000008UL});
    public static readonly BitSet FOLLOW_namespace_decl_in_program95 = new BitSet(new ulong[]{0x0000004000000008UL});
    public static readonly BitSet FOLLOW_USING_in_import_stat115 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_import_stat119 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NAMESPACE_in_namespace_decl138 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_namespace_decl142 = new BitSet(new ulong[]{0x0002018000000008UL});
    public static readonly BitSet FOLLOW_class_decl_in_namespace_decl147 = new BitSet(new ulong[]{0x0002018000000008UL});
    public static readonly BitSet FOLLOW_interface_decl_in_namespace_decl151 = new BitSet(new ulong[]{0x0002018000000008UL});
    public static readonly BitSet FOLLOW_enum_decl_in_namespace_decl155 = new BitSet(new ulong[]{0x0002018000000008UL});
    public static readonly BitSet FOLLOW_CLASS_in_class_decl178 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_MODIFIERS_in_class_decl183 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_modifier_in_class_decl185 = new BitSet(new ulong[]{0x0000040000000008UL,0x00000000000FF000UL});
    public static readonly BitSet FOLLOW_qualifier_in_class_decl191 = new BitSet(new ulong[]{0xDA00000000000008UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_EXTENDS_in_class_decl197 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_class_decl199 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IMPLEMENTS_in_class_decl208 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_class_decl210 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_class_element_in_class_decl220 = new BitSet(new ulong[]{0x1A00000000000008UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_ENUM_in_enum_decl240 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_MODIFIERS_in_enum_decl245 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_modifier_in_enum_decl247 = new BitSet(new ulong[]{0x0000040000000008UL,0x00000000000FF000UL});
    public static readonly BitSet FOLLOW_qualifier_in_enum_decl253 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_ENUMOPTION_in_enum_decl257 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_enum_decl259 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_INTERFACE_in_interface_decl278 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_MODIFIERS_in_interface_decl283 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_modifier_in_interface_decl285 = new BitSet(new ulong[]{0x0000040000000008UL,0x00000000000FF000UL});
    public static readonly BitSet FOLLOW_qualifier_in_interface_decl291 = new BitSet(new ulong[]{0x4400000000000008UL});
    public static readonly BitSet FOLLOW_EXTENDS_in_interface_decl297 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_interface_decl299 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_interface_method_in_interface_decl308 = new BitSet(new ulong[]{0x0400000000000008UL});
    public static readonly BitSet FOLLOW_IMETHOD_in_interface_method328 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_type_qualifier_in_interface_method332 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_interface_method336 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_PARAMETER_in_interface_method341 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_interface_method344 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_interface_method346 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_method_decl_in_class_element365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constructor_decl_in_class_element370 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_field_decl_in_class_element375 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_static_constructor_in_class_element380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_literal_value394 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_literal_value405 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FLOAT_in_literal_value416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_in_literal_value427 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_in_literal_value438 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_in_literal_value449 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_constant_literal_value466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_constant_literal_value477 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FLOAT_in_constant_literal_value488 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_in_constant_literal_value499 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_in_constant_literal_value510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_in_constant_literal_value521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MODIFIERS_in_abstract_mod_list539 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_access_modifier_in_abstract_mod_list541 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ABSTRACT_in_abstract_mod_list543 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_set_in_access_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FIELD_in_field_decl582 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_MODIFIERS_in_field_decl587 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_modifier_in_field_decl589 = new BitSet(new ulong[]{0x0000040000000008UL,0x00000000000FF000UL});
    public static readonly BitSet FOLLOW_qualifier_in_field_decl595 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_field_decl599 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_METHOD_in_method_decl619 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_MODIFIERS_in_method_decl624 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_modifier_in_method_decl626 = new BitSet(new ulong[]{0x0000040000000008UL,0x00000000000FF000UL});
    public static readonly BitSet FOLLOW_type_qualifier_in_method_decl632 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_method_decl636 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_PARAMETER_in_method_decl641 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_method_decl644 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_method_decl646 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_block_expression_in_method_decl653 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_CONSTRUCTOR_in_constructor_decl674 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_MODIFIERS_in_constructor_decl679 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_modifier_in_constructor_decl681 = new BitSet(new ulong[]{0x0000040000000008UL,0x00000000000FF000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_constructor_decl687 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_PARAMETER_in_constructor_decl692 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_constructor_decl695 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_constructor_decl697 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_BASE_in_constructor_decl708 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ALIST_in_constructor_decl712 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_argument_in_constructor_decl714 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_block_expression_in_constructor_decl724 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_SCONSTRUCTOR_in_static_constructor744 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_expression_in_static_constructor748 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expression_in_statement764 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_declaration_statement_in_statement769 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_const_decl_statement_in_statement774 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_THROW_in_throw_expression788 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_throw_expression790 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_TRY_in_try_expression810 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_try_expression814 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000040000000200UL});
    public static readonly BitSet FOLLOW_catch_block_in_try_expression816 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000040000000200UL});
    public static readonly BitSet FOLLOW_finally_block_in_try_expression819 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ICATCH_in_catch_block846 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_LOCAL_in_catch_block851 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_catch_block855 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_catch_block859 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expression_in_catch_block864 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FINALLY_in_finally_block883 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_finally_block887 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_WHILE_in_while_expression913 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_scope_expr_in_while_expression917 = new BitSet(new ulong[]{0x01E1921FFFFF1000UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_expression_in_while_expression921 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FOR_in_for_expression947 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_LOCAL_in_for_expression952 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_for_expression956 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_for_expression960 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expression_in_for_expression963 = new BitSet(new ulong[]{0x01E1921FFFFF1000UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_expression_in_for_expression967 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_SCOPEEXPR_in_scope_expr986 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_scope_expr988 = new BitSet(new ulong[]{0x21F1921FFFFF1008UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_LOCAL_in_declaration_statement1008 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_declaration_statement1012 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_declaration_statement1016 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_CONST_in_const_decl_statement1035 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_const_decl_statement1039 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_const_decl_statement1043 = new BitSet(new ulong[]{0x0060000000000000UL,0x00F0008000000000UL});
    public static readonly BitSet FOLLOW_const_value_in_const_decl_statement1045 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_constant_literal_value_in_const_value1062 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRELEMS_in_const_value1070 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_const_array_element_in_const_value1073 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000010000000000UL});
    public static readonly BitSet FOLLOW_ARRELEM_in_const_array_element1095 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_literal_value_in_const_array_element1097 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_assignment_expression_in_expression1113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_control_expression_in_assignment_expression1124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BECOMES_in_assignment_expression1132 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_assignment_expression_in_assignment_expression1134 = new BitSet(new ulong[]{0x01E1921FFFFF1000UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_assignment_expression_in_assignment_expression1136 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ADDEVENT_in_assignment_expression1149 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_assignment_expression_in_assignment_expression1151 = new BitSet(new ulong[]{0x01E1921FFFFF1000UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_assignment_expression_in_assignment_expression1153 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_REMEVENT_in_assignment_expression1166 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_assignment_expression_in_assignment_expression1168 = new BitSet(new ulong[]{0x01E1921FFFFF1000UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_assignment_expression_in_assignment_expression1170 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_while_expression_in_control_expression1186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_for_expression_in_control_expression1191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_try_expression_in_control_expression1196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_throw_expression_in_control_expression1201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_control_expression1213 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_scope_expr_in_control_expression1215 = new BitSet(new ulong[]{0x01E1921FFFFF1000UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_expression_in_control_expression1219 = new BitSet(new ulong[]{0x01E1921FFFFF1008UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_expression_in_control_expression1223 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_conditional_or_operator_expression_in_control_expression1234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditional_and_operator_expression_in_conditional_or_operator_expression1245 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OR_in_conditional_or_operator_expression1253 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_conditional_or_operator_expression_in_conditional_or_operator_expression1257 = new BitSet(new ulong[]{0x01E1921FFFF11000UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_conditional_or_operator_expression_in_conditional_or_operator_expression1261 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_logic_or_operator_expression_in_conditional_and_operator_expression1277 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AND_in_conditional_and_operator_expression1285 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_conditional_and_operator_expression_in_conditional_and_operator_expression1289 = new BitSet(new ulong[]{0x01E0021F7FF11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_conditional_and_operator_expression_in_conditional_and_operator_expression1293 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_logic_xor_operator_expression_in_logic_or_operator_expression1309 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOR_in_logic_or_operator_expression1317 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_logic_or_operator_expression_in_logic_or_operator_expression1319 = new BitSet(new ulong[]{0x01E0021F3FF11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_logic_or_operator_expression_in_logic_or_operator_expression1321 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_logic_and_operator_expression_in_logic_xor_operator_expression1338 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LXOR_in_logic_xor_operator_expression1346 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_logic_xor_operator_expression_in_logic_xor_operator_expression1348 = new BitSet(new ulong[]{0x01E0021B3FF11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_logic_xor_operator_expression_in_logic_xor_operator_expression1350 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_logic_expression_in_logic_and_operator_expression1367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LAND_in_logic_and_operator_expression1375 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_logic_and_operator_expression_in_logic_and_operator_expression1377 = new BitSet(new ulong[]{0x01E0021A3FF11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_logic_and_operator_expression_in_logic_and_operator_expression1379 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_cast_as_expression_in_logic_expression1395 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LE_in_logic_expression1403 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1405 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1407 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LEQ_in_logic_expression1420 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1422 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1424 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GE_in_logic_expression1437 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1439 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1441 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GEQ_in_logic_expression1454 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1456 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1458 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EQ_in_logic_expression1471 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1473 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1475 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEQ_in_logic_expression1488 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1490 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_primary_expression_in_logic_expression1492 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_AS_in_cast_as_expression1511 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_cast_as_expression_in_cast_as_expression1513 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_cast_as_expression1517 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IS_in_cast_as_expression1530 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_cast_as_expression_in_cast_as_expression1532 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_cast_as_expression1536 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_primary_expression_in_cast_as_expression1546 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_primary_expression1573 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_primary_expression_in_primary_expression1575 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_primary_expression_in_primary_expression1577 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_in_primary_expression1602 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_primary_expression_in_primary_expression1604 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_primary_expression_in_primary_expression1606 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_secundary_expression_in_primary_expression1616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_secundary_expression1631 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_secundary_expression_in_secundary_expression1633 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_secundary_expression_in_secundary_expression1635 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIVISION_in_secundary_expression1648 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_secundary_expression_in_secundary_expression1650 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_secundary_expression_in_secundary_expression1652 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MOD_in_secundary_expression1665 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_secundary_expression_in_secundary_expression1667 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_secundary_expression_in_secundary_expression1669 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_logicnotoperator_expression_in_secundary_expression1679 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOT_in_logicnotoperator_expression1693 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_logicnotoperator_expression_in_logicnotoperator_expression1695 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_PLUS_in_logicnotoperator_expression1708 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_logicnotoperator_expression_in_logicnotoperator_expression1710 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_in_logicnotoperator_expression1723 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_logicnotoperator_expression_in_logicnotoperator_expression1725 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_cast_expression_in_logicnotoperator_expression1735 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CAST_in_cast_expression1749 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_cast_expression1753 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_cast_expression_in_cast_expression1755 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_cast_expression1764 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DCOLON_in_invocation_or_load_expression1779 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1781 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_invocation_or_load_expression1785 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_ALIST_in_invocation_or_load_expression1789 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_argument_in_invocation_or_load_expression1791 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LBRACKET_in_invocation_or_load_expression1808 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1810 = new BitSet(new ulong[]{0x01E1921FFFFF1000UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_expression_in_invocation_or_load_expression1812 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_CALLVIRT_in_invocation_or_load_expression1825 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1827 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_invocation_or_load_expression1831 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_ALIST_in_invocation_or_load_expression1835 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_argument_in_invocation_or_load_expression1837 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_CALL_in_invocation_or_load_expression1853 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1855 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_invocation_or_load_expression1859 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_ALIST_in_invocation_or_load_expression1863 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_argument_in_invocation_or_load_expression1865 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LDFLD_in_invocation_or_load_expression1881 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1883 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_invocation_or_load_expression1887 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LDSFLD_in_invocation_or_load_expression1900 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1902 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_invocation_or_load_expression1906 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LDLITERAL_in_invocation_or_load_expression1919 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1921 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_invocation_or_load_expression1925 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LDVIRTFTN_in_invocation_or_load_expression1938 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1940 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_invocation_or_load_expression1944 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LDFTN_in_invocation_or_load_expression1957 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1959 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_invocation_or_load_expression1963 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DONTLD_in_invocation_or_load_expression1976 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_invocation_or_load_expression1978 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_invocation_or_load_expression1982 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_operand_in_invocation_or_load_expression1992 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_USAGE_in_operand2006 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_operand2010 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_literal_value_in_operand2020 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_THIS_in_operand2027 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BASE_in_operand2038 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_in_operand2049 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_read_write_expression_in_operand2058 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_object_creation_expression_in_operand2063 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_array_creation_expression_in_operand2068 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXPRBLOCK_in_operand2076 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_operand2078 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_block_expression_in_operand2088 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scope_expr_in_operand2093 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_READ_in_read_write_expression2107 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_read_write_expression2111 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_READVOID_in_read_write_expression2124 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_read_write_expression2128 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_WRITE_in_read_write_expression2141 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_read_write_expression2143 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_WRITEVOID_in_read_write_expression2156 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_read_write_expression2158 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEWARR_in_array_creation_expression2177 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_array_creation_expression2179 = new BitSet(new ulong[]{0x01E1921FFFFF1000UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_expression_in_array_creation_expression2181 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEWARRELEMS_in_array_creation_expression2194 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_array_creation_expression2196 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ARRELEMS_in_array_creation_expression2201 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_array_initial_elements_in_array_creation_expression2203 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000010000000000UL});
    public static readonly BitSet FOLLOW_ARRELEM_in_array_initial_elements2225 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_array_initial_elements2229 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEW_in_object_creation_expression2248 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_qualifier_in_object_creation_expression2252 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_ALIST_in_object_creation_expression2256 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_argument_in_object_creation_expression2258 = new BitSet(new ulong[]{0x0000000000000008UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_SLIST_in_block_expression2284 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_block_expression2286 = new BitSet(new ulong[]{0x21F1921FFFFF1008UL,0x00F7F86DE1000C7CUL});
    public static readonly BitSet FOLLOW_ARGUMENT_in_argument2304 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_argument2306 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FQUALIFIER_in_qualifier2325 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_qualifier2327 = new BitSet(new ulong[]{0x0000000000000008UL,0x0008000200000000UL});
    public static readonly BitSet FOLLOW_ARRAY_in_qualifier2330 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VOID_in_type_qualifier2354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qualifier_in_type_qualifier2365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_synpred1_VnvdTreeWalker1560 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_primary_expression_in_synpred1_VnvdTreeWalker1562 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_primary_expression_in_synpred1_VnvdTreeWalker1564 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_in_synpred2_VnvdTreeWalker1589 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_primary_expression_in_synpred2_VnvdTreeWalker1591 = new BitSet(new ulong[]{0x01E0021800F11000UL,0x00F7F86DE100083CUL});
    public static readonly BitSet FOLLOW_primary_expression_in_synpred2_VnvdTreeWalker1593 = new BitSet(new ulong[]{0x0000000000000008UL});

}
}