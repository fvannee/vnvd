// $ANTLR 3.2 Sep 23, 2009 12:02:23 Vnvd.g 2010-03-17 00:16:58

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace 
	Vnvd.Antlr

{
public partial class VnvdParser : Parser
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

    public const int CAST = 96;
    public const int LOR = 34;
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
    public const int RETURN = 51;
    public const int THIS = 56;
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
    public const int GE = 26;
    public const int IMETHOD = 58;
    public const int STATIC = 42;
    public const int PERIOD = 9;
    public const int PRIVATE = 76;
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
    public const int ICATCH = 106;
    public const int ADDEVENT = 17;
    public const int BECOMES = 19;
    public const int MINUS = 21;
    public const int TRUE = 53;
    public const int PRINT = 65;
    public const int WRITE = 75;
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
    public const int EXTENDS = 62;
    public const int PUBLIC = 77;
    public const int METHOD = 57;
    public const int READVOID = 98;
    public const int LE = 24;
    public const int STRING = 117;
    public const int LDVIRTFTN = 112;
    public const int LEQ = 25;

    // delegates
    // delegators



        public VnvdParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public VnvdParser(ITokenStream input, RecognizerSharedState state)
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
		get { return VnvdParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Vnvd.g"; }
    }


    public class program_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // Vnvd.g:155:1: program : ( import_stat )* ( namespace_decl )* EOF -> ^( PROGRAM ( import_stat )* ( namespace_decl )* ) ;
    public VnvdParser.program_return program() // throws RecognitionException [1]
    {   
        VnvdParser.program_return retval = new VnvdParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF3 = null;
        VnvdParser.import_stat_return import_stat1 = default(VnvdParser.import_stat_return);

        VnvdParser.namespace_decl_return namespace_decl2 = default(VnvdParser.namespace_decl_return);


        object EOF3_tree=null;
        RewriteRuleTokenStream stream_EOF = new RewriteRuleTokenStream(adaptor,"token EOF");
        RewriteRuleSubtreeStream stream_namespace_decl = new RewriteRuleSubtreeStream(adaptor,"rule namespace_decl");
        RewriteRuleSubtreeStream stream_import_stat = new RewriteRuleSubtreeStream(adaptor,"rule import_stat");
        try 
    	{
            // Vnvd.g:156:2: ( ( import_stat )* ( namespace_decl )* EOF -> ^( PROGRAM ( import_stat )* ( namespace_decl )* ) )
            // Vnvd.g:156:4: ( import_stat )* ( namespace_decl )* EOF
            {
            	// Vnvd.g:156:4: ( import_stat )*
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
            			    // Vnvd.g:156:4: import_stat
            			    {
            			    	PushFollow(FOLLOW_import_stat_in_program997);
            			    	import_stat1 = import_stat();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_import_stat.Add(import_stat1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	// Vnvd.g:156:17: ( namespace_decl )*
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
            			    // Vnvd.g:156:17: namespace_decl
            			    {
            			    	PushFollow(FOLLOW_namespace_decl_in_program1000);
            			    	namespace_decl2 = namespace_decl();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_namespace_decl.Add(namespace_decl2.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_program1003); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EOF.Add(EOF3);



            	// AST REWRITE
            	// elements:          namespace_decl, import_stat
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 157:2: -> ^( PROGRAM ( import_stat )* ( namespace_decl )* )
            	{
            	    // Vnvd.g:157:5: ^( PROGRAM ( import_stat )* ( namespace_decl )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

            	    // Vnvd.g:157:15: ( import_stat )*
            	    while ( stream_import_stat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_import_stat.NextTree());

            	    }
            	    stream_import_stat.Reset();
            	    // Vnvd.g:157:28: ( namespace_decl )*
            	    while ( stream_namespace_decl.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_namespace_decl.NextTree());

            	    }
            	    stream_namespace_decl.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class import_stat_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "import_stat"
    // Vnvd.g:160:1: import_stat : USING qualifier SEMICOLON -> ^( USING qualifier ) ;
    public VnvdParser.import_stat_return import_stat() // throws RecognitionException [1]
    {   
        VnvdParser.import_stat_return retval = new VnvdParser.import_stat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken USING4 = null;
        IToken SEMICOLON6 = null;
        VnvdParser.qualifier_return qualifier5 = default(VnvdParser.qualifier_return);


        object USING4_tree=null;
        object SEMICOLON6_tree=null;
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_USING = new RewriteRuleTokenStream(adaptor,"token USING");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:161:2: ( USING qualifier SEMICOLON -> ^( USING qualifier ) )
            // Vnvd.g:161:4: USING qualifier SEMICOLON
            {
            	USING4=(IToken)Match(input,USING,FOLLOW_USING_in_import_stat1027); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_USING.Add(USING4);

            	PushFollow(FOLLOW_qualifier_in_import_stat1029);
            	qualifier5 = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qualifier.Add(qualifier5.Tree);
            	SEMICOLON6=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_import_stat1031); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON6);



            	// AST REWRITE
            	// elements:          qualifier, USING
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 162:2: -> ^( USING qualifier )
            	{
            	    // Vnvd.g:162:5: ^( USING qualifier )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_USING.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_qualifier.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "import_stat"

    public class namespace_decl_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "namespace_decl"
    // Vnvd.g:165:1: namespace_decl : NAMESPACE qualifier LCURLYBRACE namespace_body RCURLYBRACE -> ^( NAMESPACE qualifier ( namespace_body )? ) ;
    public VnvdParser.namespace_decl_return namespace_decl() // throws RecognitionException [1]
    {   
        VnvdParser.namespace_decl_return retval = new VnvdParser.namespace_decl_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NAMESPACE7 = null;
        IToken LCURLYBRACE9 = null;
        IToken RCURLYBRACE11 = null;
        VnvdParser.qualifier_return qualifier8 = default(VnvdParser.qualifier_return);

        VnvdParser.namespace_body_return namespace_body10 = default(VnvdParser.namespace_body_return);


        object NAMESPACE7_tree=null;
        object LCURLYBRACE9_tree=null;
        object RCURLYBRACE11_tree=null;
        RewriteRuleTokenStream stream_LCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token LCURLYBRACE");
        RewriteRuleTokenStream stream_RCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token RCURLYBRACE");
        RewriteRuleTokenStream stream_NAMESPACE = new RewriteRuleTokenStream(adaptor,"token NAMESPACE");
        RewriteRuleSubtreeStream stream_namespace_body = new RewriteRuleSubtreeStream(adaptor,"rule namespace_body");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:166:2: ( NAMESPACE qualifier LCURLYBRACE namespace_body RCURLYBRACE -> ^( NAMESPACE qualifier ( namespace_body )? ) )
            // Vnvd.g:166:4: NAMESPACE qualifier LCURLYBRACE namespace_body RCURLYBRACE
            {
            	NAMESPACE7=(IToken)Match(input,NAMESPACE,FOLLOW_NAMESPACE_in_namespace_decl1051); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NAMESPACE.Add(NAMESPACE7);

            	PushFollow(FOLLOW_qualifier_in_namespace_decl1053);
            	qualifier8 = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qualifier.Add(qualifier8.Tree);
            	LCURLYBRACE9=(IToken)Match(input,LCURLYBRACE,FOLLOW_LCURLYBRACE_in_namespace_decl1055); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LCURLYBRACE.Add(LCURLYBRACE9);

            	PushFollow(FOLLOW_namespace_body_in_namespace_decl1057);
            	namespace_body10 = namespace_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_namespace_body.Add(namespace_body10.Tree);
            	RCURLYBRACE11=(IToken)Match(input,RCURLYBRACE,FOLLOW_RCURLYBRACE_in_namespace_decl1059); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RCURLYBRACE.Add(RCURLYBRACE11);



            	// AST REWRITE
            	// elements:          namespace_body, NAMESPACE, qualifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 167:2: -> ^( NAMESPACE qualifier ( namespace_body )? )
            	{
            	    // Vnvd.g:167:5: ^( NAMESPACE qualifier ( namespace_body )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_NAMESPACE.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_qualifier.NextTree());
            	    // Vnvd.g:167:27: ( namespace_body )?
            	    if ( stream_namespace_body.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_namespace_body.NextTree());

            	    }
            	    stream_namespace_body.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "namespace_decl"

    public class namespace_body_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "namespace_body"
    // Vnvd.g:170:1: namespace_body : ( class_decl | interface_decl | enum_decl )* ;
    public VnvdParser.namespace_body_return namespace_body() // throws RecognitionException [1]
    {   
        VnvdParser.namespace_body_return retval = new VnvdParser.namespace_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        VnvdParser.class_decl_return class_decl12 = default(VnvdParser.class_decl_return);

        VnvdParser.interface_decl_return interface_decl13 = default(VnvdParser.interface_decl_return);

        VnvdParser.enum_decl_return enum_decl14 = default(VnvdParser.enum_decl_return);



        try 
    	{
            // Vnvd.g:171:2: ( ( class_decl | interface_decl | enum_decl )* )
            // Vnvd.g:171:4: ( class_decl | interface_decl | enum_decl )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Vnvd.g:171:4: ( class_decl | interface_decl | enum_decl )*
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
            			    // Vnvd.g:171:5: class_decl
            			    {
            			    	PushFollow(FOLLOW_class_decl_in_namespace_body1083);
            			    	class_decl12 = class_decl();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, class_decl12.Tree);

            			    }
            			    break;
            			case 2 :
            			    // Vnvd.g:171:18: interface_decl
            			    {
            			    	PushFollow(FOLLOW_interface_decl_in_namespace_body1087);
            			    	interface_decl13 = interface_decl();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, interface_decl13.Tree);

            			    }
            			    break;
            			case 3 :
            			    // Vnvd.g:171:35: enum_decl
            			    {
            			    	PushFollow(FOLLOW_enum_decl_in_namespace_body1091);
            			    	enum_decl14 = enum_decl();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, enum_decl14.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "namespace_body"

    public class class_decl_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "class_decl"
    // Vnvd.g:174:1: class_decl : CLASS mod= class_mod_list name= qualifier ( EXTENDS base_= qualifier )? ( IMPLEMENTS interface_= type_list )? class_body -> ^( CLASS ^( MODIFIERS $mod) $name ( ^( EXTENDS $base_) )? ( ^( IMPLEMENTS $interface_) )? ( class_body )? ) ;
    public VnvdParser.class_decl_return class_decl() // throws RecognitionException [1]
    {   
        VnvdParser.class_decl_return retval = new VnvdParser.class_decl_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CLASS15 = null;
        IToken EXTENDS16 = null;
        IToken IMPLEMENTS17 = null;
        VnvdParser.class_mod_list_return mod = default(VnvdParser.class_mod_list_return);

        VnvdParser.qualifier_return name = default(VnvdParser.qualifier_return);

        VnvdParser.qualifier_return base_ = default(VnvdParser.qualifier_return);

        VnvdParser.type_list_return interface_ = default(VnvdParser.type_list_return);

        VnvdParser.class_body_return class_body18 = default(VnvdParser.class_body_return);


        object CLASS15_tree=null;
        object EXTENDS16_tree=null;
        object IMPLEMENTS17_tree=null;
        RewriteRuleTokenStream stream_CLASS = new RewriteRuleTokenStream(adaptor,"token CLASS");
        RewriteRuleTokenStream stream_IMPLEMENTS = new RewriteRuleTokenStream(adaptor,"token IMPLEMENTS");
        RewriteRuleTokenStream stream_EXTENDS = new RewriteRuleTokenStream(adaptor,"token EXTENDS");
        RewriteRuleSubtreeStream stream_class_body = new RewriteRuleSubtreeStream(adaptor,"rule class_body");
        RewriteRuleSubtreeStream stream_class_mod_list = new RewriteRuleSubtreeStream(adaptor,"rule class_mod_list");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        RewriteRuleSubtreeStream stream_type_list = new RewriteRuleSubtreeStream(adaptor,"rule type_list");
        try 
    	{
            // Vnvd.g:175:2: ( CLASS mod= class_mod_list name= qualifier ( EXTENDS base_= qualifier )? ( IMPLEMENTS interface_= type_list )? class_body -> ^( CLASS ^( MODIFIERS $mod) $name ( ^( EXTENDS $base_) )? ( ^( IMPLEMENTS $interface_) )? ( class_body )? ) )
            // Vnvd.g:175:4: CLASS mod= class_mod_list name= qualifier ( EXTENDS base_= qualifier )? ( IMPLEMENTS interface_= type_list )? class_body
            {
            	CLASS15=(IToken)Match(input,CLASS,FOLLOW_CLASS_in_class_decl1105); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_CLASS.Add(CLASS15);

            	PushFollow(FOLLOW_class_mod_list_in_class_decl1109);
            	mod = class_mod_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_class_mod_list.Add(mod.Tree);
            	PushFollow(FOLLOW_qualifier_in_class_decl1113);
            	name = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qualifier.Add(name.Tree);
            	// Vnvd.g:175:44: ( EXTENDS base_= qualifier )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == EXTENDS) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Vnvd.g:175:45: EXTENDS base_= qualifier
            	        {
            	        	EXTENDS16=(IToken)Match(input,EXTENDS,FOLLOW_EXTENDS_in_class_decl1116); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_EXTENDS.Add(EXTENDS16);

            	        	PushFollow(FOLLOW_qualifier_in_class_decl1120);
            	        	base_ = qualifier();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_qualifier.Add(base_.Tree);

            	        }
            	        break;

            	}

            	// Vnvd.g:175:71: ( IMPLEMENTS interface_= type_list )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == IMPLEMENTS) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // Vnvd.g:175:72: IMPLEMENTS interface_= type_list
            	        {
            	        	IMPLEMENTS17=(IToken)Match(input,IMPLEMENTS,FOLLOW_IMPLEMENTS_in_class_decl1125); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_IMPLEMENTS.Add(IMPLEMENTS17);

            	        	PushFollow(FOLLOW_type_list_in_class_decl1129);
            	        	interface_ = type_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_type_list.Add(interface_.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_class_body_in_class_decl1133);
            	class_body18 = class_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_class_body.Add(class_body18.Tree);


            	// AST REWRITE
            	// elements:          base_, CLASS, name, IMPLEMENTS, class_body, interface_, mod, EXTENDS
            	// token labels:      
            	// rule labels:       retval, base_, interface_, mod, name
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_base_ = new RewriteRuleSubtreeStream(adaptor, "rule base_", base_!=null ? base_.Tree : null);
            	RewriteRuleSubtreeStream stream_interface_ = new RewriteRuleSubtreeStream(adaptor, "rule interface_", interface_!=null ? interface_.Tree : null);
            	RewriteRuleSubtreeStream stream_mod = new RewriteRuleSubtreeStream(adaptor, "rule mod", mod!=null ? mod.Tree : null);
            	RewriteRuleSubtreeStream stream_name = new RewriteRuleSubtreeStream(adaptor, "rule name", name!=null ? name.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 176:2: -> ^( CLASS ^( MODIFIERS $mod) $name ( ^( EXTENDS $base_) )? ( ^( IMPLEMENTS $interface_) )? ( class_body )? )
            	{
            	    // Vnvd.g:176:5: ^( CLASS ^( MODIFIERS $mod) $name ( ^( EXTENDS $base_) )? ( ^( IMPLEMENTS $interface_) )? ( class_body )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_CLASS.NextNode(), root_1);

            	    // Vnvd.g:176:13: ^( MODIFIERS $mod)
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(MODIFIERS, "MODIFIERS"), root_2);

            	    adaptor.AddChild(root_2, stream_mod.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_name.NextTree());
            	    // Vnvd.g:176:37: ( ^( EXTENDS $base_) )?
            	    if ( stream_base_.HasNext() || stream_EXTENDS.HasNext() )
            	    {
            	        // Vnvd.g:176:37: ^( EXTENDS $base_)
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot(stream_EXTENDS.NextNode(), root_2);

            	        adaptor.AddChild(root_2, stream_base_.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_base_.Reset();
            	    stream_EXTENDS.Reset();
            	    // Vnvd.g:176:56: ( ^( IMPLEMENTS $interface_) )?
            	    if ( stream_IMPLEMENTS.HasNext() || stream_interface_.HasNext() )
            	    {
            	        // Vnvd.g:176:56: ^( IMPLEMENTS $interface_)
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot(stream_IMPLEMENTS.NextNode(), root_2);

            	        adaptor.AddChild(root_2, stream_interface_.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_IMPLEMENTS.Reset();
            	    stream_interface_.Reset();
            	    // Vnvd.g:176:83: ( class_body )?
            	    if ( stream_class_body.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_class_body.NextTree());

            	    }
            	    stream_class_body.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "class_decl"

    public class enum_decl_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "enum_decl"
    // Vnvd.g:179:1: enum_decl : ENUM mod= access_modifier name= qualifier enum_body -> ^( ENUM ^( MODIFIERS $mod) $name ( enum_body )? ) ;
    public VnvdParser.enum_decl_return enum_decl() // throws RecognitionException [1]
    {   
        VnvdParser.enum_decl_return retval = new VnvdParser.enum_decl_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ENUM19 = null;
        VnvdParser.access_modifier_return mod = default(VnvdParser.access_modifier_return);

        VnvdParser.qualifier_return name = default(VnvdParser.qualifier_return);

        VnvdParser.enum_body_return enum_body20 = default(VnvdParser.enum_body_return);


        object ENUM19_tree=null;
        RewriteRuleTokenStream stream_ENUM = new RewriteRuleTokenStream(adaptor,"token ENUM");
        RewriteRuleSubtreeStream stream_access_modifier = new RewriteRuleSubtreeStream(adaptor,"rule access_modifier");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        RewriteRuleSubtreeStream stream_enum_body = new RewriteRuleSubtreeStream(adaptor,"rule enum_body");
        try 
    	{
            // Vnvd.g:180:2: ( ENUM mod= access_modifier name= qualifier enum_body -> ^( ENUM ^( MODIFIERS $mod) $name ( enum_body )? ) )
            // Vnvd.g:180:4: ENUM mod= access_modifier name= qualifier enum_body
            {
            	ENUM19=(IToken)Match(input,ENUM,FOLLOW_ENUM_in_enum_decl1180); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ENUM.Add(ENUM19);

            	PushFollow(FOLLOW_access_modifier_in_enum_decl1184);
            	mod = access_modifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_access_modifier.Add(mod.Tree);
            	PushFollow(FOLLOW_qualifier_in_enum_decl1188);
            	name = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qualifier.Add(name.Tree);
            	PushFollow(FOLLOW_enum_body_in_enum_decl1190);
            	enum_body20 = enum_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_enum_body.Add(enum_body20.Tree);


            	// AST REWRITE
            	// elements:          name, mod, ENUM, enum_body
            	// token labels:      
            	// rule labels:       retval, mod, name
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_mod = new RewriteRuleSubtreeStream(adaptor, "rule mod", mod!=null ? mod.Tree : null);
            	RewriteRuleSubtreeStream stream_name = new RewriteRuleSubtreeStream(adaptor, "rule name", name!=null ? name.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 181:2: -> ^( ENUM ^( MODIFIERS $mod) $name ( enum_body )? )
            	{
            	    // Vnvd.g:181:5: ^( ENUM ^( MODIFIERS $mod) $name ( enum_body )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_ENUM.NextNode(), root_1);

            	    // Vnvd.g:181:12: ^( MODIFIERS $mod)
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(MODIFIERS, "MODIFIERS"), root_2);

            	    adaptor.AddChild(root_2, stream_mod.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_name.NextTree());
            	    // Vnvd.g:181:36: ( enum_body )?
            	    if ( stream_enum_body.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_enum_body.NextTree());

            	    }
            	    stream_enum_body.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "enum_decl"

    public class enum_body_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "enum_body"
    // Vnvd.g:184:1: enum_body : LCURLYBRACE ( IDENTIFIER ( COMMA IDENTIFIER )* )? RCURLYBRACE -> ( ^( ENUMOPTION IDENTIFIER ) )* ;
    public VnvdParser.enum_body_return enum_body() // throws RecognitionException [1]
    {   
        VnvdParser.enum_body_return retval = new VnvdParser.enum_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LCURLYBRACE21 = null;
        IToken IDENTIFIER22 = null;
        IToken COMMA23 = null;
        IToken IDENTIFIER24 = null;
        IToken RCURLYBRACE25 = null;

        object LCURLYBRACE21_tree=null;
        object IDENTIFIER22_tree=null;
        object COMMA23_tree=null;
        object IDENTIFIER24_tree=null;
        object RCURLYBRACE25_tree=null;
        RewriteRuleTokenStream stream_LCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token LCURLYBRACE");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleTokenStream stream_RCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token RCURLYBRACE");

        try 
    	{
            // Vnvd.g:185:2: ( LCURLYBRACE ( IDENTIFIER ( COMMA IDENTIFIER )* )? RCURLYBRACE -> ( ^( ENUMOPTION IDENTIFIER ) )* )
            // Vnvd.g:185:4: LCURLYBRACE ( IDENTIFIER ( COMMA IDENTIFIER )* )? RCURLYBRACE
            {
            	LCURLYBRACE21=(IToken)Match(input,LCURLYBRACE,FOLLOW_LCURLYBRACE_in_enum_body1221); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LCURLYBRACE.Add(LCURLYBRACE21);

            	// Vnvd.g:185:16: ( IDENTIFIER ( COMMA IDENTIFIER )* )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == IDENTIFIER) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // Vnvd.g:185:17: IDENTIFIER ( COMMA IDENTIFIER )*
            	        {
            	        	IDENTIFIER22=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_enum_body1224); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER22);

            	        	// Vnvd.g:185:28: ( COMMA IDENTIFIER )*
            	        	do 
            	        	{
            	        	    int alt6 = 2;
            	        	    int LA6_0 = input.LA(1);

            	        	    if ( (LA6_0 == COMMA) )
            	        	    {
            	        	        alt6 = 1;
            	        	    }


            	        	    switch (alt6) 
            	        		{
            	        			case 1 :
            	        			    // Vnvd.g:185:29: COMMA IDENTIFIER
            	        			    {
            	        			    	COMMA23=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_enum_body1227); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA23);

            	        			    	IDENTIFIER24=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_enum_body1229); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER24);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop6;
            	        	    }
            	        	} while (true);

            	        	loop6:
            	        		;	// Stops C# compiler whining that label 'loop6' has no statements


            	        }
            	        break;

            	}

            	RCURLYBRACE25=(IToken)Match(input,RCURLYBRACE,FOLLOW_RCURLYBRACE_in_enum_body1235); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RCURLYBRACE.Add(RCURLYBRACE25);



            	// AST REWRITE
            	// elements:          IDENTIFIER
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 186:2: -> ( ^( ENUMOPTION IDENTIFIER ) )*
            	{
            	    // Vnvd.g:186:5: ( ^( ENUMOPTION IDENTIFIER ) )*
            	    while ( stream_IDENTIFIER.HasNext() )
            	    {
            	        // Vnvd.g:186:5: ^( ENUMOPTION IDENTIFIER )
            	        {
            	        object root_1 = (object)adaptor.GetNilNode();
            	        root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ENUMOPTION, "ENUMOPTION"), root_1);

            	        adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_IDENTIFIER.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "enum_body"

    public class interface_decl_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "interface_decl"
    // Vnvd.g:189:1: interface_decl : INTERFACE mod= class_mod_list name= qualifier ( EXTENDS base_= qualifier )? interface_body -> ^( INTERFACE ^( MODIFIERS $mod) $name ( ^( EXTENDS $base_) )? ( interface_body )? ) ;
    public VnvdParser.interface_decl_return interface_decl() // throws RecognitionException [1]
    {   
        VnvdParser.interface_decl_return retval = new VnvdParser.interface_decl_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INTERFACE26 = null;
        IToken EXTENDS27 = null;
        VnvdParser.class_mod_list_return mod = default(VnvdParser.class_mod_list_return);

        VnvdParser.qualifier_return name = default(VnvdParser.qualifier_return);

        VnvdParser.qualifier_return base_ = default(VnvdParser.qualifier_return);

        VnvdParser.interface_body_return interface_body28 = default(VnvdParser.interface_body_return);


        object INTERFACE26_tree=null;
        object EXTENDS27_tree=null;
        RewriteRuleTokenStream stream_INTERFACE = new RewriteRuleTokenStream(adaptor,"token INTERFACE");
        RewriteRuleTokenStream stream_EXTENDS = new RewriteRuleTokenStream(adaptor,"token EXTENDS");
        RewriteRuleSubtreeStream stream_interface_body = new RewriteRuleSubtreeStream(adaptor,"rule interface_body");
        RewriteRuleSubtreeStream stream_class_mod_list = new RewriteRuleSubtreeStream(adaptor,"rule class_mod_list");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:190:2: ( INTERFACE mod= class_mod_list name= qualifier ( EXTENDS base_= qualifier )? interface_body -> ^( INTERFACE ^( MODIFIERS $mod) $name ( ^( EXTENDS $base_) )? ( interface_body )? ) )
            // Vnvd.g:190:4: INTERFACE mod= class_mod_list name= qualifier ( EXTENDS base_= qualifier )? interface_body
            {
            	INTERFACE26=(IToken)Match(input,INTERFACE,FOLLOW_INTERFACE_in_interface_decl1257); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_INTERFACE.Add(INTERFACE26);

            	PushFollow(FOLLOW_class_mod_list_in_interface_decl1261);
            	mod = class_mod_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_class_mod_list.Add(mod.Tree);
            	PushFollow(FOLLOW_qualifier_in_interface_decl1265);
            	name = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qualifier.Add(name.Tree);
            	// Vnvd.g:190:48: ( EXTENDS base_= qualifier )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == EXTENDS) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // Vnvd.g:190:49: EXTENDS base_= qualifier
            	        {
            	        	EXTENDS27=(IToken)Match(input,EXTENDS,FOLLOW_EXTENDS_in_interface_decl1268); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_EXTENDS.Add(EXTENDS27);

            	        	PushFollow(FOLLOW_qualifier_in_interface_decl1272);
            	        	base_ = qualifier();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_qualifier.Add(base_.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_interface_body_in_interface_decl1276);
            	interface_body28 = interface_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_interface_body.Add(interface_body28.Tree);


            	// AST REWRITE
            	// elements:          INTERFACE, EXTENDS, interface_body, base_, name, mod
            	// token labels:      
            	// rule labels:       retval, base_, mod, name
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_base_ = new RewriteRuleSubtreeStream(adaptor, "rule base_", base_!=null ? base_.Tree : null);
            	RewriteRuleSubtreeStream stream_mod = new RewriteRuleSubtreeStream(adaptor, "rule mod", mod!=null ? mod.Tree : null);
            	RewriteRuleSubtreeStream stream_name = new RewriteRuleSubtreeStream(adaptor, "rule name", name!=null ? name.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 191:2: -> ^( INTERFACE ^( MODIFIERS $mod) $name ( ^( EXTENDS $base_) )? ( interface_body )? )
            	{
            	    // Vnvd.g:191:5: ^( INTERFACE ^( MODIFIERS $mod) $name ( ^( EXTENDS $base_) )? ( interface_body )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_INTERFACE.NextNode(), root_1);

            	    // Vnvd.g:191:17: ^( MODIFIERS $mod)
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(MODIFIERS, "MODIFIERS"), root_2);

            	    adaptor.AddChild(root_2, stream_mod.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_name.NextTree());
            	    // Vnvd.g:191:41: ( ^( EXTENDS $base_) )?
            	    if ( stream_EXTENDS.HasNext() || stream_base_.HasNext() )
            	    {
            	        // Vnvd.g:191:41: ^( EXTENDS $base_)
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot(stream_EXTENDS.NextNode(), root_2);

            	        adaptor.AddChild(root_2, stream_base_.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_EXTENDS.Reset();
            	    stream_base_.Reset();
            	    // Vnvd.g:191:60: ( interface_body )?
            	    if ( stream_interface_body.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_interface_body.NextTree());

            	    }
            	    stream_interface_body.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "interface_decl"

    public class interface_body_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "interface_body"
    // Vnvd.g:194:1: interface_body : LCURLYBRACE ( interface_method )* RCURLYBRACE -> ( interface_method )* ;
    public VnvdParser.interface_body_return interface_body() // throws RecognitionException [1]
    {   
        VnvdParser.interface_body_return retval = new VnvdParser.interface_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LCURLYBRACE29 = null;
        IToken RCURLYBRACE31 = null;
        VnvdParser.interface_method_return interface_method30 = default(VnvdParser.interface_method_return);


        object LCURLYBRACE29_tree=null;
        object RCURLYBRACE31_tree=null;
        RewriteRuleTokenStream stream_LCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token LCURLYBRACE");
        RewriteRuleTokenStream stream_RCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token RCURLYBRACE");
        RewriteRuleSubtreeStream stream_interface_method = new RewriteRuleSubtreeStream(adaptor,"rule interface_method");
        try 
    	{
            // Vnvd.g:195:2: ( LCURLYBRACE ( interface_method )* RCURLYBRACE -> ( interface_method )* )
            // Vnvd.g:195:4: LCURLYBRACE ( interface_method )* RCURLYBRACE
            {
            	LCURLYBRACE29=(IToken)Match(input,LCURLYBRACE,FOLLOW_LCURLYBRACE_in_interface_body1315); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LCURLYBRACE.Add(LCURLYBRACE29);

            	// Vnvd.g:195:16: ( interface_method )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == VOID || LA9_0 == IDENTIFIER) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // Vnvd.g:195:16: interface_method
            			    {
            			    	PushFollow(FOLLOW_interface_method_in_interface_body1317);
            			    	interface_method30 = interface_method();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_interface_method.Add(interface_method30.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	RCURLYBRACE31=(IToken)Match(input,RCURLYBRACE,FOLLOW_RCURLYBRACE_in_interface_body1320); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RCURLYBRACE.Add(RCURLYBRACE31);



            	// AST REWRITE
            	// elements:          interface_method
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 196:2: -> ( interface_method )*
            	{
            	    // Vnvd.g:196:5: ( interface_method )*
            	    while ( stream_interface_method.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_interface_method.NextTree());

            	    }
            	    stream_interface_method.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "interface_body"

    public class interface_method_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "interface_method"
    // Vnvd.g:199:1: interface_method : type_qualifier IDENTIFIER LPAREN parameter_list RPAREN SEMICOLON -> ^( IMETHOD type_qualifier IDENTIFIER parameter_list ) ;
    public VnvdParser.interface_method_return interface_method() // throws RecognitionException [1]
    {   
        VnvdParser.interface_method_return retval = new VnvdParser.interface_method_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER33 = null;
        IToken LPAREN34 = null;
        IToken RPAREN36 = null;
        IToken SEMICOLON37 = null;
        VnvdParser.type_qualifier_return type_qualifier32 = default(VnvdParser.type_qualifier_return);

        VnvdParser.parameter_list_return parameter_list35 = default(VnvdParser.parameter_list_return);


        object IDENTIFIER33_tree=null;
        object LPAREN34_tree=null;
        object RPAREN36_tree=null;
        object SEMICOLON37_tree=null;
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_type_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule type_qualifier");
        RewriteRuleSubtreeStream stream_parameter_list = new RewriteRuleSubtreeStream(adaptor,"rule parameter_list");
        try 
    	{
            // Vnvd.g:200:2: ( type_qualifier IDENTIFIER LPAREN parameter_list RPAREN SEMICOLON -> ^( IMETHOD type_qualifier IDENTIFIER parameter_list ) )
            // Vnvd.g:200:4: type_qualifier IDENTIFIER LPAREN parameter_list RPAREN SEMICOLON
            {
            	PushFollow(FOLLOW_type_qualifier_in_interface_method1337);
            	type_qualifier32 = type_qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type_qualifier.Add(type_qualifier32.Tree);
            	IDENTIFIER33=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_interface_method1339); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER33);

            	LPAREN34=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_interface_method1341); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN34);

            	PushFollow(FOLLOW_parameter_list_in_interface_method1343);
            	parameter_list35 = parameter_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_parameter_list.Add(parameter_list35.Tree);
            	RPAREN36=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_interface_method1345); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN36);

            	SEMICOLON37=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_interface_method1347); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON37);



            	// AST REWRITE
            	// elements:          type_qualifier, parameter_list, IDENTIFIER
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 201:2: -> ^( IMETHOD type_qualifier IDENTIFIER parameter_list )
            	{
            	    // Vnvd.g:201:5: ^( IMETHOD type_qualifier IDENTIFIER parameter_list )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IMETHOD, "IMETHOD"), root_1);

            	    adaptor.AddChild(root_1, stream_type_qualifier.NextTree());
            	    adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());
            	    adaptor.AddChild(root_1, stream_parameter_list.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "interface_method"

    public class class_mod_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "class_mod_list"
    // Vnvd.g:204:1: class_mod_list : access_modifier ( ABSTRACT )? ;
    public VnvdParser.class_mod_list_return class_mod_list() // throws RecognitionException [1]
    {   
        VnvdParser.class_mod_list_return retval = new VnvdParser.class_mod_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ABSTRACT39 = null;
        VnvdParser.access_modifier_return access_modifier38 = default(VnvdParser.access_modifier_return);


        object ABSTRACT39_tree=null;

        try 
    	{
            // Vnvd.g:205:2: ( access_modifier ( ABSTRACT )? )
            // Vnvd.g:205:4: access_modifier ( ABSTRACT )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_access_modifier_in_class_mod_list1372);
            	access_modifier38 = access_modifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, access_modifier38.Tree);
            	// Vnvd.g:205:20: ( ABSTRACT )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == ABSTRACT) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // Vnvd.g:205:21: ABSTRACT
            	        {
            	        	ABSTRACT39=(IToken)Match(input,ABSTRACT,FOLLOW_ABSTRACT_in_class_mod_list1375); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ABSTRACT39_tree = (object)adaptor.Create(ABSTRACT39);
            	        		adaptor.AddChild(root_0, ABSTRACT39_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "class_mod_list"

    public class method_mod_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "method_mod_list"
    // Vnvd.g:208:1: method_mod_list : access_modifier ( STATIC | virtual_modifier )? ;
    public VnvdParser.method_mod_list_return method_mod_list() // throws RecognitionException [1]
    {   
        VnvdParser.method_mod_list_return retval = new VnvdParser.method_mod_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken STATIC41 = null;
        VnvdParser.access_modifier_return access_modifier40 = default(VnvdParser.access_modifier_return);

        VnvdParser.virtual_modifier_return virtual_modifier42 = default(VnvdParser.virtual_modifier_return);


        object STATIC41_tree=null;

        try 
    	{
            // Vnvd.g:209:2: ( access_modifier ( STATIC | virtual_modifier )? )
            // Vnvd.g:209:4: access_modifier ( STATIC | virtual_modifier )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_access_modifier_in_method_mod_list1388);
            	access_modifier40 = access_modifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, access_modifier40.Tree);
            	// Vnvd.g:209:20: ( STATIC | virtual_modifier )?
            	int alt11 = 3;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == STATIC) )
            	{
            	    alt11 = 1;
            	}
            	else if ( ((LA11_0 >= VIRTUAL && LA11_0 <= OVERRIDE)) )
            	{
            	    alt11 = 2;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // Vnvd.g:209:21: STATIC
            	        {
            	        	STATIC41=(IToken)Match(input,STATIC,FOLLOW_STATIC_in_method_mod_list1391); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{STATIC41_tree = (object)adaptor.Create(STATIC41);
            	        		adaptor.AddChild(root_0, STATIC41_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // Vnvd.g:209:30: virtual_modifier
            	        {
            	        	PushFollow(FOLLOW_virtual_modifier_in_method_mod_list1395);
            	        	virtual_modifier42 = virtual_modifier();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, virtual_modifier42.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "method_mod_list"

    public class field_mod_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "field_mod_list"
    // Vnvd.g:212:1: field_mod_list : access_modifier ( STATIC )? ( INITONLY )? ;
    public VnvdParser.field_mod_list_return field_mod_list() // throws RecognitionException [1]
    {   
        VnvdParser.field_mod_list_return retval = new VnvdParser.field_mod_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken STATIC44 = null;
        IToken INITONLY45 = null;
        VnvdParser.access_modifier_return access_modifier43 = default(VnvdParser.access_modifier_return);


        object STATIC44_tree=null;
        object INITONLY45_tree=null;

        try 
    	{
            // Vnvd.g:213:2: ( access_modifier ( STATIC )? ( INITONLY )? )
            // Vnvd.g:213:4: access_modifier ( STATIC )? ( INITONLY )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_access_modifier_in_field_mod_list1409);
            	access_modifier43 = access_modifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, access_modifier43.Tree);
            	// Vnvd.g:213:20: ( STATIC )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == STATIC) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // Vnvd.g:213:20: STATIC
            	        {
            	        	STATIC44=(IToken)Match(input,STATIC,FOLLOW_STATIC_in_field_mod_list1411); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{STATIC44_tree = (object)adaptor.Create(STATIC44);
            	        		adaptor.AddChild(root_0, STATIC44_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Vnvd.g:213:28: ( INITONLY )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == INITONLY) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // Vnvd.g:213:28: INITONLY
            	        {
            	        	INITONLY45=(IToken)Match(input,INITONLY,FOLLOW_INITONLY_in_field_mod_list1414); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{INITONLY45_tree = (object)adaptor.Create(INITONLY45);
            	        		adaptor.AddChild(root_0, INITONLY45_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "field_mod_list"

    public class constructor_mod_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "constructor_mod_list"
    // Vnvd.g:216:1: constructor_mod_list : access_modifier ;
    public VnvdParser.constructor_mod_list_return constructor_mod_list() // throws RecognitionException [1]
    {   
        VnvdParser.constructor_mod_list_return retval = new VnvdParser.constructor_mod_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        VnvdParser.access_modifier_return access_modifier46 = default(VnvdParser.access_modifier_return);



        try 
    	{
            // Vnvd.g:217:2: ( access_modifier )
            // Vnvd.g:217:4: access_modifier
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_access_modifier_in_constructor_mod_list1426);
            	access_modifier46 = access_modifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, access_modifier46.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constructor_mod_list"

    public class abstract_mod_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "abstract_mod_list"
    // Vnvd.g:220:1: abstract_mod_list : access_modifier ABSTRACT ;
    public VnvdParser.abstract_mod_list_return abstract_mod_list() // throws RecognitionException [1]
    {   
        VnvdParser.abstract_mod_list_return retval = new VnvdParser.abstract_mod_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ABSTRACT48 = null;
        VnvdParser.access_modifier_return access_modifier47 = default(VnvdParser.access_modifier_return);


        object ABSTRACT48_tree=null;

        try 
    	{
            // Vnvd.g:221:2: ( access_modifier ABSTRACT )
            // Vnvd.g:221:4: access_modifier ABSTRACT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_access_modifier_in_abstract_mod_list1438);
            	access_modifier47 = access_modifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, access_modifier47.Tree);
            	ABSTRACT48=(IToken)Match(input,ABSTRACT,FOLLOW_ABSTRACT_in_abstract_mod_list1440); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ABSTRACT48_tree = (object)adaptor.Create(ABSTRACT48);
            		adaptor.AddChild(root_0, ABSTRACT48_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "abstract_mod_list"

    public class type_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "type_list"
    // Vnvd.g:224:1: type_list : qualifier ( COMMA qualifier )* ;
    public VnvdParser.type_list_return type_list() // throws RecognitionException [1]
    {   
        VnvdParser.type_list_return retval = new VnvdParser.type_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA50 = null;
        VnvdParser.qualifier_return qualifier49 = default(VnvdParser.qualifier_return);

        VnvdParser.qualifier_return qualifier51 = default(VnvdParser.qualifier_return);


        object COMMA50_tree=null;

        try 
    	{
            // Vnvd.g:225:2: ( qualifier ( COMMA qualifier )* )
            // Vnvd.g:225:4: qualifier ( COMMA qualifier )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_qualifier_in_type_list1452);
            	qualifier49 = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, qualifier49.Tree);
            	// Vnvd.g:225:14: ( COMMA qualifier )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == COMMA) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // Vnvd.g:225:15: COMMA qualifier
            			    {
            			    	COMMA50=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_type_list1455); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_qualifier_in_type_list1458);
            			    	qualifier51 = qualifier();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, qualifier51.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type_list"

    public class class_body_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "class_body"
    // Vnvd.g:228:1: class_body : LCURLYBRACE ( class_element )* RCURLYBRACE ;
    public VnvdParser.class_body_return class_body() // throws RecognitionException [1]
    {   
        VnvdParser.class_body_return retval = new VnvdParser.class_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LCURLYBRACE52 = null;
        IToken RCURLYBRACE54 = null;
        VnvdParser.class_element_return class_element53 = default(VnvdParser.class_element_return);


        object LCURLYBRACE52_tree=null;
        object RCURLYBRACE54_tree=null;

        try 
    	{
            // Vnvd.g:229:2: ( LCURLYBRACE ( class_element )* RCURLYBRACE )
            // Vnvd.g:229:4: LCURLYBRACE ( class_element )* RCURLYBRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LCURLYBRACE52=(IToken)Match(input,LCURLYBRACE,FOLLOW_LCURLYBRACE_in_class_body1472); if (state.failed) return retval;
            	// Vnvd.g:229:17: ( class_element )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == STATIC || (LA15_0 >= PRIVATE && LA15_0 <= INTERNAL)) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // Vnvd.g:229:17: class_element
            			    {
            			    	PushFollow(FOLLOW_class_element_in_class_body1475);
            			    	class_element53 = class_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, class_element53.Tree);

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	RCURLYBRACE54=(IToken)Match(input,RCURLYBRACE,FOLLOW_RCURLYBRACE_in_class_body1478); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "class_body"

    public class class_element_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "class_element"
    // Vnvd.g:232:1: class_element : ( ( method_mod_list type_qualifier IDENTIFIER LPAREN )=> method_decl | ( constructor_mod_list IDENTIFIER LPAREN )=> constructor_decl | ( abstract_mod_list )=> abstract_method_decl | field_decl | static_constructor );
    public VnvdParser.class_element_return class_element() // throws RecognitionException [1]
    {   
        VnvdParser.class_element_return retval = new VnvdParser.class_element_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        VnvdParser.method_decl_return method_decl55 = default(VnvdParser.method_decl_return);

        VnvdParser.constructor_decl_return constructor_decl56 = default(VnvdParser.constructor_decl_return);

        VnvdParser.abstract_method_decl_return abstract_method_decl57 = default(VnvdParser.abstract_method_decl_return);

        VnvdParser.field_decl_return field_decl58 = default(VnvdParser.field_decl_return);

        VnvdParser.static_constructor_return static_constructor59 = default(VnvdParser.static_constructor_return);



        try 
    	{
            // Vnvd.g:233:2: ( ( method_mod_list type_qualifier IDENTIFIER LPAREN )=> method_decl | ( constructor_mod_list IDENTIFIER LPAREN )=> constructor_decl | ( abstract_mod_list )=> abstract_method_decl | field_decl | static_constructor )
            int alt16 = 5;
            int LA16_0 = input.LA(1);

            if ( ((LA16_0 >= PRIVATE && LA16_0 <= INTERNAL)) )
            {
                int LA16_1 = input.LA(2);

                if ( (synpred1_Vnvd()) )
                {
                    alt16 = 1;
                }
                else if ( (synpred2_Vnvd()) )
                {
                    alt16 = 2;
                }
                else if ( (synpred3_Vnvd()) )
                {
                    alt16 = 3;
                }
                else if ( (true) )
                {
                    alt16 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d16s1 =
                        new NoViableAltException("", 16, 1, input);

                    throw nvae_d16s1;
                }
            }
            else if ( (LA16_0 == STATIC) )
            {
                alt16 = 5;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("", 16, 0, input);

                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // Vnvd.g:233:4: ( method_mod_list type_qualifier IDENTIFIER LPAREN )=> method_decl
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_method_decl_in_class_element1502);
                    	method_decl55 = method_decl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, method_decl55.Tree);

                    }
                    break;
                case 2 :
                    // Vnvd.g:234:4: ( constructor_mod_list IDENTIFIER LPAREN )=> constructor_decl
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_constructor_decl_in_class_element1517);
                    	constructor_decl56 = constructor_decl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constructor_decl56.Tree);

                    }
                    break;
                case 3 :
                    // Vnvd.g:235:4: ( abstract_mod_list )=> abstract_method_decl
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_abstract_method_decl_in_class_element1528);
                    	abstract_method_decl57 = abstract_method_decl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, abstract_method_decl57.Tree);

                    }
                    break;
                case 4 :
                    // Vnvd.g:236:4: field_decl
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_field_decl_in_class_element1533);
                    	field_decl58 = field_decl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, field_decl58.Tree);

                    }
                    break;
                case 5 :
                    // Vnvd.g:237:4: static_constructor
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_static_constructor_in_class_element1538);
                    	static_constructor59 = static_constructor();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, static_constructor59.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "class_element"

    public class static_constructor_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "static_constructor"
    // Vnvd.g:240:1: static_constructor : STATIC block_expression -> ^( SCONSTRUCTOR block_expression ) ;
    public VnvdParser.static_constructor_return static_constructor() // throws RecognitionException [1]
    {   
        VnvdParser.static_constructor_return retval = new VnvdParser.static_constructor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken STATIC60 = null;
        VnvdParser.block_expression_return block_expression61 = default(VnvdParser.block_expression_return);


        object STATIC60_tree=null;
        RewriteRuleTokenStream stream_STATIC = new RewriteRuleTokenStream(adaptor,"token STATIC");
        RewriteRuleSubtreeStream stream_block_expression = new RewriteRuleSubtreeStream(adaptor,"rule block_expression");
        try 
    	{
            // Vnvd.g:241:2: ( STATIC block_expression -> ^( SCONSTRUCTOR block_expression ) )
            // Vnvd.g:241:4: STATIC block_expression
            {
            	STATIC60=(IToken)Match(input,STATIC,FOLLOW_STATIC_in_static_constructor1549); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_STATIC.Add(STATIC60);

            	PushFollow(FOLLOW_block_expression_in_static_constructor1551);
            	block_expression61 = block_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block_expression.Add(block_expression61.Tree);


            	// AST REWRITE
            	// elements:          block_expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 242:2: -> ^( SCONSTRUCTOR block_expression )
            	{
            	    // Vnvd.g:242:5: ^( SCONSTRUCTOR block_expression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SCONSTRUCTOR, "SCONSTRUCTOR"), root_1);

            	    adaptor.AddChild(root_1, stream_block_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "static_constructor"

    public class literal_value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "literal_value"
    // Vnvd.g:245:1: literal_value : ( NUMBER | STRING | CHAR | TRUE | FALSE | NULL );
    public VnvdParser.literal_value_return literal_value() // throws RecognitionException [1]
    {   
        VnvdParser.literal_value_return retval = new VnvdParser.literal_value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set62 = null;

        object set62_tree=null;

        try 
    	{
            // Vnvd.g:246:2: ( NUMBER | STRING | CHAR | TRUE | FALSE | NULL )
            // Vnvd.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set62 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= TRUE && input.LA(1) <= FALSE) || input.LA(1) == NULL || (input.LA(1) >= NUMBER && input.LA(1) <= CHAR) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set62));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "literal_value"

    public class field_decl_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "field_decl"
    // Vnvd.g:254:1: field_decl : mod= field_mod_list qual= qualifier IDENTIFIER ( COMMA IDENTIFIER )* SEMICOLON -> ( ^( FIELD ^( MODIFIERS $mod) $qual IDENTIFIER ) )+ ;
    public VnvdParser.field_decl_return field_decl() // throws RecognitionException [1]
    {   
        VnvdParser.field_decl_return retval = new VnvdParser.field_decl_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER63 = null;
        IToken COMMA64 = null;
        IToken IDENTIFIER65 = null;
        IToken SEMICOLON66 = null;
        VnvdParser.field_mod_list_return mod = default(VnvdParser.field_mod_list_return);

        VnvdParser.qualifier_return qual = default(VnvdParser.qualifier_return);


        object IDENTIFIER63_tree=null;
        object COMMA64_tree=null;
        object IDENTIFIER65_tree=null;
        object SEMICOLON66_tree=null;
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleSubtreeStream stream_field_mod_list = new RewriteRuleSubtreeStream(adaptor,"rule field_mod_list");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:255:2: (mod= field_mod_list qual= qualifier IDENTIFIER ( COMMA IDENTIFIER )* SEMICOLON -> ( ^( FIELD ^( MODIFIERS $mod) $qual IDENTIFIER ) )+ )
            // Vnvd.g:255:4: mod= field_mod_list qual= qualifier IDENTIFIER ( COMMA IDENTIFIER )* SEMICOLON
            {
            	PushFollow(FOLLOW_field_mod_list_in_field_decl1611);
            	mod = field_mod_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_field_mod_list.Add(mod.Tree);
            	PushFollow(FOLLOW_qualifier_in_field_decl1615);
            	qual = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qualifier.Add(qual.Tree);
            	IDENTIFIER63=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_field_decl1617); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER63);

            	// Vnvd.g:255:49: ( COMMA IDENTIFIER )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == COMMA) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // Vnvd.g:255:50: COMMA IDENTIFIER
            			    {
            			    	COMMA64=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_field_decl1620); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA64);

            			    	IDENTIFIER65=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_field_decl1622); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER65);


            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements

            	SEMICOLON66=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_field_decl1626); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON66);



            	// AST REWRITE
            	// elements:          mod, IDENTIFIER, qual
            	// token labels:      
            	// rule labels:       retval, mod, qual
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_mod = new RewriteRuleSubtreeStream(adaptor, "rule mod", mod!=null ? mod.Tree : null);
            	RewriteRuleSubtreeStream stream_qual = new RewriteRuleSubtreeStream(adaptor, "rule qual", qual!=null ? qual.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 256:2: -> ( ^( FIELD ^( MODIFIERS $mod) $qual IDENTIFIER ) )+
            	{
            	    if ( !(stream_mod.HasNext() || stream_IDENTIFIER.HasNext() || stream_qual.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_mod.HasNext() || stream_IDENTIFIER.HasNext() || stream_qual.HasNext() )
            	    {
            	        // Vnvd.g:256:5: ^( FIELD ^( MODIFIERS $mod) $qual IDENTIFIER )
            	        {
            	        object root_1 = (object)adaptor.GetNilNode();
            	        root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FIELD, "FIELD"), root_1);

            	        // Vnvd.g:256:13: ^( MODIFIERS $mod)
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(MODIFIERS, "MODIFIERS"), root_2);

            	        adaptor.AddChild(root_2, stream_mod.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }
            	        adaptor.AddChild(root_1, stream_qual.NextTree());
            	        adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_mod.Reset();
            	    stream_IDENTIFIER.Reset();
            	    stream_qual.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "field_decl"

    public class method_decl_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "method_decl"
    // Vnvd.g:259:1: method_decl : mod= method_mod_list type_qualifier IDENTIFIER LPAREN parameter_list RPAREN block_expression -> ^( METHOD ^( MODIFIERS $mod) type_qualifier IDENTIFIER parameter_list block_expression ) ;
    public VnvdParser.method_decl_return method_decl() // throws RecognitionException [1]
    {   
        VnvdParser.method_decl_return retval = new VnvdParser.method_decl_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER68 = null;
        IToken LPAREN69 = null;
        IToken RPAREN71 = null;
        VnvdParser.method_mod_list_return mod = default(VnvdParser.method_mod_list_return);

        VnvdParser.type_qualifier_return type_qualifier67 = default(VnvdParser.type_qualifier_return);

        VnvdParser.parameter_list_return parameter_list70 = default(VnvdParser.parameter_list_return);

        VnvdParser.block_expression_return block_expression72 = default(VnvdParser.block_expression_return);


        object IDENTIFIER68_tree=null;
        object LPAREN69_tree=null;
        object RPAREN71_tree=null;
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_method_mod_list = new RewriteRuleSubtreeStream(adaptor,"rule method_mod_list");
        RewriteRuleSubtreeStream stream_block_expression = new RewriteRuleSubtreeStream(adaptor,"rule block_expression");
        RewriteRuleSubtreeStream stream_type_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule type_qualifier");
        RewriteRuleSubtreeStream stream_parameter_list = new RewriteRuleSubtreeStream(adaptor,"rule parameter_list");
        try 
    	{
            // Vnvd.g:260:2: (mod= method_mod_list type_qualifier IDENTIFIER LPAREN parameter_list RPAREN block_expression -> ^( METHOD ^( MODIFIERS $mod) type_qualifier IDENTIFIER parameter_list block_expression ) )
            // Vnvd.g:260:4: mod= method_mod_list type_qualifier IDENTIFIER LPAREN parameter_list RPAREN block_expression
            {
            	PushFollow(FOLLOW_method_mod_list_in_method_decl1660);
            	mod = method_mod_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_method_mod_list.Add(mod.Tree);
            	PushFollow(FOLLOW_type_qualifier_in_method_decl1662);
            	type_qualifier67 = type_qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type_qualifier.Add(type_qualifier67.Tree);
            	IDENTIFIER68=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_method_decl1664); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER68);

            	LPAREN69=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_method_decl1666); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN69);

            	PushFollow(FOLLOW_parameter_list_in_method_decl1668);
            	parameter_list70 = parameter_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_parameter_list.Add(parameter_list70.Tree);
            	RPAREN71=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_method_decl1670); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN71);

            	PushFollow(FOLLOW_block_expression_in_method_decl1672);
            	block_expression72 = block_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block_expression.Add(block_expression72.Tree);


            	// AST REWRITE
            	// elements:          block_expression, IDENTIFIER, mod, parameter_list, type_qualifier
            	// token labels:      
            	// rule labels:       retval, mod
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_mod = new RewriteRuleSubtreeStream(adaptor, "rule mod", mod!=null ? mod.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 261:2: -> ^( METHOD ^( MODIFIERS $mod) type_qualifier IDENTIFIER parameter_list block_expression )
            	{
            	    // Vnvd.g:261:5: ^( METHOD ^( MODIFIERS $mod) type_qualifier IDENTIFIER parameter_list block_expression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METHOD, "METHOD"), root_1);

            	    // Vnvd.g:261:14: ^( MODIFIERS $mod)
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(MODIFIERS, "MODIFIERS"), root_2);

            	    adaptor.AddChild(root_2, stream_mod.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_type_qualifier.NextTree());
            	    adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());
            	    adaptor.AddChild(root_1, stream_parameter_list.NextTree());
            	    adaptor.AddChild(root_1, stream_block_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "method_decl"

    public class abstract_method_decl_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "abstract_method_decl"
    // Vnvd.g:264:1: abstract_method_decl : mod= abstract_mod_list type_qualifier IDENTIFIER LPAREN parameter_list RPAREN SEMICOLON -> ^( METHOD ^( MODIFIERS $mod) type_qualifier IDENTIFIER parameter_list ) ;
    public VnvdParser.abstract_method_decl_return abstract_method_decl() // throws RecognitionException [1]
    {   
        VnvdParser.abstract_method_decl_return retval = new VnvdParser.abstract_method_decl_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER74 = null;
        IToken LPAREN75 = null;
        IToken RPAREN77 = null;
        IToken SEMICOLON78 = null;
        VnvdParser.abstract_mod_list_return mod = default(VnvdParser.abstract_mod_list_return);

        VnvdParser.type_qualifier_return type_qualifier73 = default(VnvdParser.type_qualifier_return);

        VnvdParser.parameter_list_return parameter_list76 = default(VnvdParser.parameter_list_return);


        object IDENTIFIER74_tree=null;
        object LPAREN75_tree=null;
        object RPAREN77_tree=null;
        object SEMICOLON78_tree=null;
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_abstract_mod_list = new RewriteRuleSubtreeStream(adaptor,"rule abstract_mod_list");
        RewriteRuleSubtreeStream stream_type_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule type_qualifier");
        RewriteRuleSubtreeStream stream_parameter_list = new RewriteRuleSubtreeStream(adaptor,"rule parameter_list");
        try 
    	{
            // Vnvd.g:265:2: (mod= abstract_mod_list type_qualifier IDENTIFIER LPAREN parameter_list RPAREN SEMICOLON -> ^( METHOD ^( MODIFIERS $mod) type_qualifier IDENTIFIER parameter_list ) )
            // Vnvd.g:265:4: mod= abstract_mod_list type_qualifier IDENTIFIER LPAREN parameter_list RPAREN SEMICOLON
            {
            	PushFollow(FOLLOW_abstract_mod_list_in_abstract_method_decl1707);
            	mod = abstract_mod_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_abstract_mod_list.Add(mod.Tree);
            	PushFollow(FOLLOW_type_qualifier_in_abstract_method_decl1709);
            	type_qualifier73 = type_qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type_qualifier.Add(type_qualifier73.Tree);
            	IDENTIFIER74=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_abstract_method_decl1711); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER74);

            	LPAREN75=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_abstract_method_decl1713); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN75);

            	PushFollow(FOLLOW_parameter_list_in_abstract_method_decl1715);
            	parameter_list76 = parameter_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_parameter_list.Add(parameter_list76.Tree);
            	RPAREN77=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_abstract_method_decl1717); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN77);

            	SEMICOLON78=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_abstract_method_decl1719); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON78);



            	// AST REWRITE
            	// elements:          IDENTIFIER, parameter_list, mod, type_qualifier
            	// token labels:      
            	// rule labels:       retval, mod
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_mod = new RewriteRuleSubtreeStream(adaptor, "rule mod", mod!=null ? mod.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 266:2: -> ^( METHOD ^( MODIFIERS $mod) type_qualifier IDENTIFIER parameter_list )
            	{
            	    // Vnvd.g:266:5: ^( METHOD ^( MODIFIERS $mod) type_qualifier IDENTIFIER parameter_list )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METHOD, "METHOD"), root_1);

            	    // Vnvd.g:266:14: ^( MODIFIERS $mod)
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(MODIFIERS, "MODIFIERS"), root_2);

            	    adaptor.AddChild(root_2, stream_mod.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_type_qualifier.NextTree());
            	    adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());
            	    adaptor.AddChild(root_1, stream_parameter_list.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "abstract_method_decl"

    public class constructor_decl_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "constructor_decl"
    // Vnvd.g:269:1: constructor_decl : mod= constructor_mod_list IDENTIFIER LPAREN parameter_list RPAREN ( COLON BASE LPAREN argument_list RPAREN )? block_expression -> ^( CONSTRUCTOR ^( MODIFIERS $mod) IDENTIFIER parameter_list ( ^( BASE ( argument_list )? ) )? block_expression ) ;
    public VnvdParser.constructor_decl_return constructor_decl() // throws RecognitionException [1]
    {   
        VnvdParser.constructor_decl_return retval = new VnvdParser.constructor_decl_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER79 = null;
        IToken LPAREN80 = null;
        IToken RPAREN82 = null;
        IToken COLON83 = null;
        IToken BASE84 = null;
        IToken LPAREN85 = null;
        IToken RPAREN87 = null;
        VnvdParser.constructor_mod_list_return mod = default(VnvdParser.constructor_mod_list_return);

        VnvdParser.parameter_list_return parameter_list81 = default(VnvdParser.parameter_list_return);

        VnvdParser.argument_list_return argument_list86 = default(VnvdParser.argument_list_return);

        VnvdParser.block_expression_return block_expression88 = default(VnvdParser.block_expression_return);


        object IDENTIFIER79_tree=null;
        object LPAREN80_tree=null;
        object RPAREN82_tree=null;
        object COLON83_tree=null;
        object BASE84_tree=null;
        object LPAREN85_tree=null;
        object RPAREN87_tree=null;
        RewriteRuleTokenStream stream_COLON = new RewriteRuleTokenStream(adaptor,"token COLON");
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_BASE = new RewriteRuleTokenStream(adaptor,"token BASE");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_argument_list = new RewriteRuleSubtreeStream(adaptor,"rule argument_list");
        RewriteRuleSubtreeStream stream_constructor_mod_list = new RewriteRuleSubtreeStream(adaptor,"rule constructor_mod_list");
        RewriteRuleSubtreeStream stream_block_expression = new RewriteRuleSubtreeStream(adaptor,"rule block_expression");
        RewriteRuleSubtreeStream stream_parameter_list = new RewriteRuleSubtreeStream(adaptor,"rule parameter_list");
        try 
    	{
            // Vnvd.g:270:2: (mod= constructor_mod_list IDENTIFIER LPAREN parameter_list RPAREN ( COLON BASE LPAREN argument_list RPAREN )? block_expression -> ^( CONSTRUCTOR ^( MODIFIERS $mod) IDENTIFIER parameter_list ( ^( BASE ( argument_list )? ) )? block_expression ) )
            // Vnvd.g:270:4: mod= constructor_mod_list IDENTIFIER LPAREN parameter_list RPAREN ( COLON BASE LPAREN argument_list RPAREN )? block_expression
            {
            	PushFollow(FOLLOW_constructor_mod_list_in_constructor_decl1753);
            	mod = constructor_mod_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_constructor_mod_list.Add(mod.Tree);
            	IDENTIFIER79=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_constructor_decl1755); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER79);

            	LPAREN80=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_constructor_decl1757); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN80);

            	PushFollow(FOLLOW_parameter_list_in_constructor_decl1759);
            	parameter_list81 = parameter_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_parameter_list.Add(parameter_list81.Tree);
            	RPAREN82=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_constructor_decl1761); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN82);

            	// Vnvd.g:270:69: ( COLON BASE LPAREN argument_list RPAREN )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == COLON) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // Vnvd.g:270:70: COLON BASE LPAREN argument_list RPAREN
            	        {
            	        	COLON83=(IToken)Match(input,COLON,FOLLOW_COLON_in_constructor_decl1764); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_COLON.Add(COLON83);

            	        	BASE84=(IToken)Match(input,BASE,FOLLOW_BASE_in_constructor_decl1766); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_BASE.Add(BASE84);

            	        	LPAREN85=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_constructor_decl1768); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN85);

            	        	PushFollow(FOLLOW_argument_list_in_constructor_decl1770);
            	        	argument_list86 = argument_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_argument_list.Add(argument_list86.Tree);
            	        	RPAREN87=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_constructor_decl1772); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN87);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_block_expression_in_constructor_decl1776);
            	block_expression88 = block_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block_expression.Add(block_expression88.Tree);


            	// AST REWRITE
            	// elements:          argument_list, block_expression, BASE, parameter_list, IDENTIFIER, mod
            	// token labels:      
            	// rule labels:       retval, mod
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_mod = new RewriteRuleSubtreeStream(adaptor, "rule mod", mod!=null ? mod.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 271:2: -> ^( CONSTRUCTOR ^( MODIFIERS $mod) IDENTIFIER parameter_list ( ^( BASE ( argument_list )? ) )? block_expression )
            	{
            	    // Vnvd.g:271:5: ^( CONSTRUCTOR ^( MODIFIERS $mod) IDENTIFIER parameter_list ( ^( BASE ( argument_list )? ) )? block_expression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONSTRUCTOR, "CONSTRUCTOR"), root_1);

            	    // Vnvd.g:271:19: ^( MODIFIERS $mod)
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(MODIFIERS, "MODIFIERS"), root_2);

            	    adaptor.AddChild(root_2, stream_mod.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());
            	    adaptor.AddChild(root_1, stream_parameter_list.NextTree());
            	    // Vnvd.g:271:63: ( ^( BASE ( argument_list )? ) )?
            	    if ( stream_argument_list.HasNext() || stream_BASE.HasNext() )
            	    {
            	        // Vnvd.g:271:63: ^( BASE ( argument_list )? )
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot(stream_BASE.NextNode(), root_2);

            	        // Vnvd.g:271:70: ( argument_list )?
            	        if ( stream_argument_list.HasNext() )
            	        {
            	            adaptor.AddChild(root_2, stream_argument_list.NextTree());

            	        }
            	        stream_argument_list.Reset();

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_argument_list.Reset();
            	    stream_BASE.Reset();
            	    adaptor.AddChild(root_1, stream_block_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constructor_decl"

    public class statement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statement"
    // Vnvd.g:274:1: statement : ( ( qualifier IDENTIFIER )=> declaration_statement SEMICOLON | const_decl_statement SEMICOLON | expression SEMICOLON | SEMICOLON );
    public VnvdParser.statement_return statement() // throws RecognitionException [1]
    {   
        VnvdParser.statement_return retval = new VnvdParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SEMICOLON90 = null;
        IToken SEMICOLON92 = null;
        IToken SEMICOLON94 = null;
        IToken SEMICOLON95 = null;
        VnvdParser.declaration_statement_return declaration_statement89 = default(VnvdParser.declaration_statement_return);

        VnvdParser.const_decl_statement_return const_decl_statement91 = default(VnvdParser.const_decl_statement_return);

        VnvdParser.expression_return expression93 = default(VnvdParser.expression_return);


        object SEMICOLON90_tree=null;
        object SEMICOLON92_tree=null;
        object SEMICOLON94_tree=null;
        object SEMICOLON95_tree=null;

        try 
    	{
            // Vnvd.g:275:2: ( ( qualifier IDENTIFIER )=> declaration_statement SEMICOLON | const_decl_statement SEMICOLON | expression SEMICOLON | SEMICOLON )
            int alt19 = 4;
            alt19 = dfa19.Predict(input);
            switch (alt19) 
            {
                case 1 :
                    // Vnvd.g:275:4: ( qualifier IDENTIFIER )=> declaration_statement SEMICOLON
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_declaration_statement_in_statement1823);
                    	declaration_statement89 = declaration_statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration_statement89.Tree);
                    	SEMICOLON90=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_statement1825); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // Vnvd.g:276:4: const_decl_statement SEMICOLON
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_const_decl_statement_in_statement1831);
                    	const_decl_statement91 = const_decl_statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_decl_statement91.Tree);
                    	SEMICOLON92=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_statement1833); if (state.failed) return retval;

                    }
                    break;
                case 3 :
                    // Vnvd.g:277:4: expression SEMICOLON
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_statement1839);
                    	expression93 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression93.Tree);
                    	SEMICOLON94=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_statement1841); if (state.failed) return retval;

                    }
                    break;
                case 4 :
                    // Vnvd.g:278:4: SEMICOLON
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	SEMICOLON95=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_statement1847); if (state.failed) return retval;

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class catch_block_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "catch_block"
    // Vnvd.g:281:1: catch_block : ( CATCH | CAREBOX ) LPAREN qualifier IDENTIFIER RPAREN expression -> ^( ICATCH ^( LOCAL qualifier IDENTIFIER ) expression ) ;
    public VnvdParser.catch_block_return catch_block() // throws RecognitionException [1]
    {   
        VnvdParser.catch_block_return retval = new VnvdParser.catch_block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CATCH96 = null;
        IToken CAREBOX97 = null;
        IToken LPAREN98 = null;
        IToken IDENTIFIER100 = null;
        IToken RPAREN101 = null;
        VnvdParser.qualifier_return qualifier99 = default(VnvdParser.qualifier_return);

        VnvdParser.expression_return expression102 = default(VnvdParser.expression_return);


        object CATCH96_tree=null;
        object CAREBOX97_tree=null;
        object LPAREN98_tree=null;
        object IDENTIFIER100_tree=null;
        object RPAREN101_tree=null;
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_CAREBOX = new RewriteRuleTokenStream(adaptor,"token CAREBOX");
        RewriteRuleTokenStream stream_CATCH = new RewriteRuleTokenStream(adaptor,"token CATCH");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:282:2: ( ( CATCH | CAREBOX ) LPAREN qualifier IDENTIFIER RPAREN expression -> ^( ICATCH ^( LOCAL qualifier IDENTIFIER ) expression ) )
            // Vnvd.g:282:4: ( CATCH | CAREBOX ) LPAREN qualifier IDENTIFIER RPAREN expression
            {
            	// Vnvd.g:282:4: ( CATCH | CAREBOX )
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == CATCH) )
            	{
            	    alt20 = 1;
            	}
            	else if ( (LA20_0 == CAREBOX) )
            	{
            	    alt20 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d20s0 =
            	        new NoViableAltException("", 20, 0, input);

            	    throw nvae_d20s0;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // Vnvd.g:282:5: CATCH
            	        {
            	        	CATCH96=(IToken)Match(input,CATCH,FOLLOW_CATCH_in_catch_block1860); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_CATCH.Add(CATCH96);


            	        }
            	        break;
            	    case 2 :
            	        // Vnvd.g:282:13: CAREBOX
            	        {
            	        	CAREBOX97=(IToken)Match(input,CAREBOX,FOLLOW_CAREBOX_in_catch_block1864); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_CAREBOX.Add(CAREBOX97);


            	        }
            	        break;

            	}

            	LPAREN98=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_catch_block1867); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN98);

            	PushFollow(FOLLOW_qualifier_in_catch_block1869);
            	qualifier99 = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qualifier.Add(qualifier99.Tree);
            	IDENTIFIER100=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_catch_block1871); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER100);

            	RPAREN101=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_catch_block1873); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN101);

            	PushFollow(FOLLOW_expression_in_catch_block1875);
            	expression102 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression102.Tree);


            	// AST REWRITE
            	// elements:          IDENTIFIER, expression, qualifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 283:2: -> ^( ICATCH ^( LOCAL qualifier IDENTIFIER ) expression )
            	{
            	    // Vnvd.g:283:5: ^( ICATCH ^( LOCAL qualifier IDENTIFIER ) expression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ICATCH, "ICATCH"), root_1);

            	    // Vnvd.g:283:14: ^( LOCAL qualifier IDENTIFIER )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOCAL, "LOCAL"), root_2);

            	    adaptor.AddChild(root_2, stream_qualifier.NextTree());
            	    adaptor.AddChild(root_2, stream_IDENTIFIER.NextNode());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "catch_block"

    public class finally_block_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "finally_block"
    // Vnvd.g:286:1: finally_block : FINALLY expression -> ^( FINALLY expression ) ;
    public VnvdParser.finally_block_return finally_block() // throws RecognitionException [1]
    {   
        VnvdParser.finally_block_return retval = new VnvdParser.finally_block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FINALLY103 = null;
        VnvdParser.expression_return expression104 = default(VnvdParser.expression_return);


        object FINALLY103_tree=null;
        RewriteRuleTokenStream stream_FINALLY = new RewriteRuleTokenStream(adaptor,"token FINALLY");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
            // Vnvd.g:287:2: ( FINALLY expression -> ^( FINALLY expression ) )
            // Vnvd.g:287:4: FINALLY expression
            {
            	FINALLY103=(IToken)Match(input,FINALLY,FOLLOW_FINALLY_in_finally_block1903); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FINALLY.Add(FINALLY103);

            	PushFollow(FOLLOW_expression_in_finally_block1905);
            	expression104 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression104.Tree);


            	// AST REWRITE
            	// elements:          expression, FINALLY
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 288:2: -> ^( FINALLY expression )
            	{
            	    // Vnvd.g:288:5: ^( FINALLY expression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_FINALLY.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "finally_block"

    public class scope_expr_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "scope_expr"
    // Vnvd.g:291:1: scope_expr : ( statement )+ -> ^( SCOPEEXPR ( statement )+ ) ;
    public VnvdParser.scope_expr_return scope_expr() // throws RecognitionException [1]
    {   
        VnvdParser.scope_expr_return retval = new VnvdParser.scope_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        VnvdParser.statement_return statement105 = default(VnvdParser.statement_return);


        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // Vnvd.g:292:2: ( ( statement )+ -> ^( SCOPEEXPR ( statement )+ ) )
            // Vnvd.g:292:4: ( statement )+
            {
            	// Vnvd.g:292:4: ( statement )+
            	int cnt21 = 0;
            	do 
            	{
            	    int alt21 = 2;
            	    alt21 = dfa21.Predict(input);
            	    switch (alt21) 
            		{
            			case 1 :
            			    // Vnvd.g:292:4: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_scope_expr1925);
            			    	statement105 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(statement105.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt21 >= 1 ) goto loop21;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee21 =
            		                new EarlyExitException(21, input);
            		            throw eee21;
            	    }
            	    cnt21++;
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements



            	// AST REWRITE
            	// elements:          statement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 293:2: -> ^( SCOPEEXPR ( statement )+ )
            	{
            	    // Vnvd.g:293:5: ^( SCOPEEXPR ( statement )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SCOPEEXPR, "SCOPEEXPR"), root_1);

            	    if ( !(stream_statement.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_statement.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_statement.NextTree());

            	    }
            	    stream_statement.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "scope_expr"

    public class declaration_statement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "declaration_statement"
    // Vnvd.g:296:1: declaration_statement : ( ( qualifier IDENTIFIER BECOMES )=>type_= qualifier IDENTIFIER BECOMES expression -> ^( LOCAL $type_ IDENTIFIER ) ^( BECOMES ^( USAGE ^( FQUALIFIER IDENTIFIER ) ) expression ) | type_= qualifier IDENTIFIER ( COMMA IDENTIFIER )* -> ( ^( LOCAL $type_ IDENTIFIER ) )+ );
    public VnvdParser.declaration_statement_return declaration_statement() // throws RecognitionException [1]
    {   
        VnvdParser.declaration_statement_return retval = new VnvdParser.declaration_statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER106 = null;
        IToken BECOMES107 = null;
        IToken IDENTIFIER109 = null;
        IToken COMMA110 = null;
        IToken IDENTIFIER111 = null;
        VnvdParser.qualifier_return type_ = default(VnvdParser.qualifier_return);

        VnvdParser.expression_return expression108 = default(VnvdParser.expression_return);


        object IDENTIFIER106_tree=null;
        object BECOMES107_tree=null;
        object IDENTIFIER109_tree=null;
        object COMMA110_tree=null;
        object IDENTIFIER111_tree=null;
        RewriteRuleTokenStream stream_BECOMES = new RewriteRuleTokenStream(adaptor,"token BECOMES");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:297:2: ( ( qualifier IDENTIFIER BECOMES )=>type_= qualifier IDENTIFIER BECOMES expression -> ^( LOCAL $type_ IDENTIFIER ) ^( BECOMES ^( USAGE ^( FQUALIFIER IDENTIFIER ) ) expression ) | type_= qualifier IDENTIFIER ( COMMA IDENTIFIER )* -> ( ^( LOCAL $type_ IDENTIFIER ) )+ )
            int alt23 = 2;
            int LA23_0 = input.LA(1);

            if ( (LA23_0 == IDENTIFIER) )
            {
                int LA23_1 = input.LA(2);

                if ( (synpred5_Vnvd()) )
                {
                    alt23 = 1;
                }
                else if ( (true) )
                {
                    alt23 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d23s1 =
                        new NoViableAltException("", 23, 1, input);

                    throw nvae_d23s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d23s0 =
                    new NoViableAltException("", 23, 0, input);

                throw nvae_d23s0;
            }
            switch (alt23) 
            {
                case 1 :
                    // Vnvd.g:297:4: ( qualifier IDENTIFIER BECOMES )=>type_= qualifier IDENTIFIER BECOMES expression
                    {
                    	PushFollow(FOLLOW_qualifier_in_declaration_statement1960);
                    	type_ = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_qualifier.Add(type_.Tree);
                    	IDENTIFIER106=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_declaration_statement1962); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER106);

                    	BECOMES107=(IToken)Match(input,BECOMES,FOLLOW_BECOMES_in_declaration_statement1964); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BECOMES.Add(BECOMES107);

                    	PushFollow(FOLLOW_expression_in_declaration_statement1966);
                    	expression108 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression108.Tree);


                    	// AST REWRITE
                    	// elements:          type_, expression, IDENTIFIER, IDENTIFIER, BECOMES
                    	// token labels:      
                    	// rule labels:       type_, retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_type_ = new RewriteRuleSubtreeStream(adaptor, "rule type_", type_!=null ? type_.Tree : null);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 298:2: -> ^( LOCAL $type_ IDENTIFIER ) ^( BECOMES ^( USAGE ^( FQUALIFIER IDENTIFIER ) ) expression )
                    	{
                    	    // Vnvd.g:298:5: ^( LOCAL $type_ IDENTIFIER )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOCAL, "LOCAL"), root_1);

                    	    adaptor.AddChild(root_1, stream_type_.NextTree());
                    	    adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }
                    	    // Vnvd.g:298:32: ^( BECOMES ^( USAGE ^( FQUALIFIER IDENTIFIER ) ) expression )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_BECOMES.NextNode(), root_1);

                    	    // Vnvd.g:298:42: ^( USAGE ^( FQUALIFIER IDENTIFIER ) )
                    	    {
                    	    object root_2 = (object)adaptor.GetNilNode();
                    	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(USAGE, "USAGE"), root_2);

                    	    // Vnvd.g:298:50: ^( FQUALIFIER IDENTIFIER )
                    	    {
                    	    object root_3 = (object)adaptor.GetNilNode();
                    	    root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(FQUALIFIER, "FQUALIFIER"), root_3);

                    	    adaptor.AddChild(root_3, stream_IDENTIFIER.NextNode());

                    	    adaptor.AddChild(root_2, root_3);
                    	    }

                    	    adaptor.AddChild(root_1, root_2);
                    	    }
                    	    adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Vnvd.g:299:4: type_= qualifier IDENTIFIER ( COMMA IDENTIFIER )*
                    {
                    	PushFollow(FOLLOW_qualifier_in_declaration_statement2001);
                    	type_ = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_qualifier.Add(type_.Tree);
                    	IDENTIFIER109=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_declaration_statement2003); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER109);

                    	// Vnvd.g:299:31: ( COMMA IDENTIFIER )*
                    	do 
                    	{
                    	    int alt22 = 2;
                    	    int LA22_0 = input.LA(1);

                    	    if ( (LA22_0 == COMMA) )
                    	    {
                    	        alt22 = 1;
                    	    }


                    	    switch (alt22) 
                    		{
                    			case 1 :
                    			    // Vnvd.g:299:32: COMMA IDENTIFIER
                    			    {
                    			    	COMMA110=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_declaration_statement2006); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA110);

                    			    	IDENTIFIER111=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_declaration_statement2008); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER111);


                    			    }
                    			    break;

                    			default:
                    			    goto loop22;
                    	    }
                    	} while (true);

                    	loop22:
                    		;	// Stops C# compiler whining that label 'loop22' has no statements



                    	// AST REWRITE
                    	// elements:          IDENTIFIER, type_
                    	// token labels:      
                    	// rule labels:       type_, retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_type_ = new RewriteRuleSubtreeStream(adaptor, "rule type_", type_!=null ? type_.Tree : null);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 300:2: -> ( ^( LOCAL $type_ IDENTIFIER ) )+
                    	{
                    	    if ( !(stream_IDENTIFIER.HasNext() || stream_type_.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_IDENTIFIER.HasNext() || stream_type_.HasNext() )
                    	    {
                    	        // Vnvd.g:300:5: ^( LOCAL $type_ IDENTIFIER )
                    	        {
                    	        object root_1 = (object)adaptor.GetNilNode();
                    	        root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOCAL, "LOCAL"), root_1);

                    	        adaptor.AddChild(root_1, stream_type_.NextTree());
                    	        adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());

                    	        adaptor.AddChild(root_0, root_1);
                    	        }

                    	    }
                    	    stream_IDENTIFIER.Reset();
                    	    stream_type_.Reset();

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "declaration_statement"

    public class const_decl_statement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "const_decl_statement"
    // Vnvd.g:303:1: const_decl_statement : CONST qualifier IDENTIFIER BECOMES const_value ( COMMA IDENTIFIER BECOMES const_value )* -> ( ^( CONST qualifier IDENTIFIER const_value ) )+ ;
    public VnvdParser.const_decl_statement_return const_decl_statement() // throws RecognitionException [1]
    {   
        VnvdParser.const_decl_statement_return retval = new VnvdParser.const_decl_statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CONST112 = null;
        IToken IDENTIFIER114 = null;
        IToken BECOMES115 = null;
        IToken COMMA117 = null;
        IToken IDENTIFIER118 = null;
        IToken BECOMES119 = null;
        VnvdParser.qualifier_return qualifier113 = default(VnvdParser.qualifier_return);

        VnvdParser.const_value_return const_value116 = default(VnvdParser.const_value_return);

        VnvdParser.const_value_return const_value120 = default(VnvdParser.const_value_return);


        object CONST112_tree=null;
        object IDENTIFIER114_tree=null;
        object BECOMES115_tree=null;
        object COMMA117_tree=null;
        object IDENTIFIER118_tree=null;
        object BECOMES119_tree=null;
        RewriteRuleTokenStream stream_BECOMES = new RewriteRuleTokenStream(adaptor,"token BECOMES");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_CONST = new RewriteRuleTokenStream(adaptor,"token CONST");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleSubtreeStream stream_const_value = new RewriteRuleSubtreeStream(adaptor,"rule const_value");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:304:2: ( CONST qualifier IDENTIFIER BECOMES const_value ( COMMA IDENTIFIER BECOMES const_value )* -> ( ^( CONST qualifier IDENTIFIER const_value ) )+ )
            // Vnvd.g:304:4: CONST qualifier IDENTIFIER BECOMES const_value ( COMMA IDENTIFIER BECOMES const_value )*
            {
            	CONST112=(IToken)Match(input,CONST,FOLLOW_CONST_in_const_decl_statement2034); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_CONST.Add(CONST112);

            	PushFollow(FOLLOW_qualifier_in_const_decl_statement2036);
            	qualifier113 = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qualifier.Add(qualifier113.Tree);
            	IDENTIFIER114=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_const_decl_statement2038); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER114);

            	BECOMES115=(IToken)Match(input,BECOMES,FOLLOW_BECOMES_in_const_decl_statement2040); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BECOMES.Add(BECOMES115);

            	PushFollow(FOLLOW_const_value_in_const_decl_statement2042);
            	const_value116 = const_value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_const_value.Add(const_value116.Tree);
            	// Vnvd.g:304:51: ( COMMA IDENTIFIER BECOMES const_value )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == COMMA) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // Vnvd.g:304:52: COMMA IDENTIFIER BECOMES const_value
            			    {
            			    	COMMA117=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_const_decl_statement2045); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA117);

            			    	IDENTIFIER118=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_const_decl_statement2047); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER118);

            			    	BECOMES119=(IToken)Match(input,BECOMES,FOLLOW_BECOMES_in_const_decl_statement2049); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_BECOMES.Add(BECOMES119);

            			    	PushFollow(FOLLOW_const_value_in_const_decl_statement2051);
            			    	const_value120 = const_value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_const_value.Add(const_value120.Tree);

            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements



            	// AST REWRITE
            	// elements:          IDENTIFIER, qualifier, CONST, const_value
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 305:2: -> ( ^( CONST qualifier IDENTIFIER const_value ) )+
            	{
            	    if ( !(stream_IDENTIFIER.HasNext() || stream_qualifier.HasNext() || stream_CONST.HasNext() || stream_const_value.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_IDENTIFIER.HasNext() || stream_qualifier.HasNext() || stream_CONST.HasNext() || stream_const_value.HasNext() )
            	    {
            	        // Vnvd.g:305:5: ^( CONST qualifier IDENTIFIER const_value )
            	        {
            	        object root_1 = (object)adaptor.GetNilNode();
            	        root_1 = (object)adaptor.BecomeRoot(stream_CONST.NextNode(), root_1);

            	        adaptor.AddChild(root_1, stream_qualifier.NextTree());
            	        adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());
            	        adaptor.AddChild(root_1, stream_const_value.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_IDENTIFIER.Reset();
            	    stream_qualifier.Reset();
            	    stream_CONST.Reset();
            	    stream_const_value.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "const_decl_statement"

    public class const_value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "const_value"
    // Vnvd.g:308:1: const_value : ( literal_value | LCURLYBRACE literal_value ( COMMA literal_value )* RCURLYBRACE -> ^( ARRELEMS ( ^( ARRELEM literal_value ) )+ ) );
    public VnvdParser.const_value_return const_value() // throws RecognitionException [1]
    {   
        VnvdParser.const_value_return retval = new VnvdParser.const_value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LCURLYBRACE122 = null;
        IToken COMMA124 = null;
        IToken RCURLYBRACE126 = null;
        VnvdParser.literal_value_return literal_value121 = default(VnvdParser.literal_value_return);

        VnvdParser.literal_value_return literal_value123 = default(VnvdParser.literal_value_return);

        VnvdParser.literal_value_return literal_value125 = default(VnvdParser.literal_value_return);


        object LCURLYBRACE122_tree=null;
        object COMMA124_tree=null;
        object RCURLYBRACE126_tree=null;
        RewriteRuleTokenStream stream_LCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token LCURLYBRACE");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_RCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token RCURLYBRACE");
        RewriteRuleSubtreeStream stream_literal_value = new RewriteRuleSubtreeStream(adaptor,"rule literal_value");
        try 
    	{
            // Vnvd.g:309:2: ( literal_value | LCURLYBRACE literal_value ( COMMA literal_value )* RCURLYBRACE -> ^( ARRELEMS ( ^( ARRELEM literal_value ) )+ ) )
            int alt26 = 2;
            int LA26_0 = input.LA(1);

            if ( ((LA26_0 >= TRUE && LA26_0 <= FALSE) || LA26_0 == NULL || (LA26_0 >= NUMBER && LA26_0 <= CHAR)) )
            {
                alt26 = 1;
            }
            else if ( (LA26_0 == LCURLYBRACE) )
            {
                alt26 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d26s0 =
                    new NoViableAltException("", 26, 0, input);

                throw nvae_d26s0;
            }
            switch (alt26) 
            {
                case 1 :
                    // Vnvd.g:309:4: literal_value
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_value_in_const_value2079);
                    	literal_value121 = literal_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal_value121.Tree);

                    }
                    break;
                case 2 :
                    // Vnvd.g:310:4: LCURLYBRACE literal_value ( COMMA literal_value )* RCURLYBRACE
                    {
                    	LCURLYBRACE122=(IToken)Match(input,LCURLYBRACE,FOLLOW_LCURLYBRACE_in_const_value2084); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LCURLYBRACE.Add(LCURLYBRACE122);

                    	PushFollow(FOLLOW_literal_value_in_const_value2086);
                    	literal_value123 = literal_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_literal_value.Add(literal_value123.Tree);
                    	// Vnvd.g:310:30: ( COMMA literal_value )*
                    	do 
                    	{
                    	    int alt25 = 2;
                    	    int LA25_0 = input.LA(1);

                    	    if ( (LA25_0 == COMMA) )
                    	    {
                    	        alt25 = 1;
                    	    }


                    	    switch (alt25) 
                    		{
                    			case 1 :
                    			    // Vnvd.g:310:31: COMMA literal_value
                    			    {
                    			    	COMMA124=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_const_value2089); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA124);

                    			    	PushFollow(FOLLOW_literal_value_in_const_value2091);
                    			    	literal_value125 = literal_value();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_literal_value.Add(literal_value125.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop25;
                    	    }
                    	} while (true);

                    	loop25:
                    		;	// Stops C# compiler whining that label 'loop25' has no statements

                    	RCURLYBRACE126=(IToken)Match(input,RCURLYBRACE,FOLLOW_RCURLYBRACE_in_const_value2095); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RCURLYBRACE.Add(RCURLYBRACE126);



                    	// AST REWRITE
                    	// elements:          literal_value
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 311:2: -> ^( ARRELEMS ( ^( ARRELEM literal_value ) )+ )
                    	{
                    	    // Vnvd.g:311:5: ^( ARRELEMS ( ^( ARRELEM literal_value ) )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRELEMS, "ARRELEMS"), root_1);

                    	    if ( !(stream_literal_value.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_literal_value.HasNext() )
                    	    {
                    	        // Vnvd.g:311:17: ^( ARRELEM literal_value )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRELEM, "ARRELEM"), root_2);

                    	        adaptor.AddChild(root_2, stream_literal_value.NextTree());

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_literal_value.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "const_value"

    public class object_creation_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "object_creation_expression"
    // Vnvd.g:314:1: object_creation_expression : NEW qualifier LPAREN argument_list RPAREN -> ^( NEW qualifier ( argument_list )? ) ;
    public VnvdParser.object_creation_expression_return object_creation_expression() // throws RecognitionException [1]
    {   
        VnvdParser.object_creation_expression_return retval = new VnvdParser.object_creation_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEW127 = null;
        IToken LPAREN129 = null;
        IToken RPAREN131 = null;
        VnvdParser.qualifier_return qualifier128 = default(VnvdParser.qualifier_return);

        VnvdParser.argument_list_return argument_list130 = default(VnvdParser.argument_list_return);


        object NEW127_tree=null;
        object LPAREN129_tree=null;
        object RPAREN131_tree=null;
        RewriteRuleTokenStream stream_NEW = new RewriteRuleTokenStream(adaptor,"token NEW");
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_argument_list = new RewriteRuleSubtreeStream(adaptor,"rule argument_list");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:315:2: ( NEW qualifier LPAREN argument_list RPAREN -> ^( NEW qualifier ( argument_list )? ) )
            // Vnvd.g:315:4: NEW qualifier LPAREN argument_list RPAREN
            {
            	NEW127=(IToken)Match(input,NEW,FOLLOW_NEW_in_object_creation_expression2123); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NEW.Add(NEW127);

            	PushFollow(FOLLOW_qualifier_in_object_creation_expression2125);
            	qualifier128 = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qualifier.Add(qualifier128.Tree);
            	LPAREN129=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_object_creation_expression2127); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN129);

            	PushFollow(FOLLOW_argument_list_in_object_creation_expression2129);
            	argument_list130 = argument_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_argument_list.Add(argument_list130.Tree);
            	RPAREN131=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_object_creation_expression2131); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN131);



            	// AST REWRITE
            	// elements:          qualifier, NEW, argument_list
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 316:2: -> ^( NEW qualifier ( argument_list )? )
            	{
            	    // Vnvd.g:316:5: ^( NEW qualifier ( argument_list )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_NEW.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_qualifier.NextTree());
            	    // Vnvd.g:316:21: ( argument_list )?
            	    if ( stream_argument_list.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_argument_list.NextTree());

            	    }
            	    stream_argument_list.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "object_creation_expression"

    public class array_creation_expression_elemented_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "array_creation_expression_elemented"
    // Vnvd.g:319:1: array_creation_expression_elemented : NEW qualifier LCURLYBRACE expression ( COMMA expression )* RCURLYBRACE -> ^( NEWARRELEMS qualifier ^( ARRELEMS ( ^( ARRELEM expression ) )* ) ) ;
    public VnvdParser.array_creation_expression_elemented_return array_creation_expression_elemented() // throws RecognitionException [1]
    {   
        VnvdParser.array_creation_expression_elemented_return retval = new VnvdParser.array_creation_expression_elemented_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEW132 = null;
        IToken LCURLYBRACE134 = null;
        IToken COMMA136 = null;
        IToken RCURLYBRACE138 = null;
        VnvdParser.qualifier_return qualifier133 = default(VnvdParser.qualifier_return);

        VnvdParser.expression_return expression135 = default(VnvdParser.expression_return);

        VnvdParser.expression_return expression137 = default(VnvdParser.expression_return);


        object NEW132_tree=null;
        object LCURLYBRACE134_tree=null;
        object COMMA136_tree=null;
        object RCURLYBRACE138_tree=null;
        RewriteRuleTokenStream stream_NEW = new RewriteRuleTokenStream(adaptor,"token NEW");
        RewriteRuleTokenStream stream_LCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token LCURLYBRACE");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_RCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token RCURLYBRACE");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:320:2: ( NEW qualifier LCURLYBRACE expression ( COMMA expression )* RCURLYBRACE -> ^( NEWARRELEMS qualifier ^( ARRELEMS ( ^( ARRELEM expression ) )* ) ) )
            // Vnvd.g:320:4: NEW qualifier LCURLYBRACE expression ( COMMA expression )* RCURLYBRACE
            {
            	NEW132=(IToken)Match(input,NEW,FOLLOW_NEW_in_array_creation_expression_elemented2155); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NEW.Add(NEW132);

            	PushFollow(FOLLOW_qualifier_in_array_creation_expression_elemented2157);
            	qualifier133 = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qualifier.Add(qualifier133.Tree);
            	LCURLYBRACE134=(IToken)Match(input,LCURLYBRACE,FOLLOW_LCURLYBRACE_in_array_creation_expression_elemented2159); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LCURLYBRACE.Add(LCURLYBRACE134);

            	PushFollow(FOLLOW_expression_in_array_creation_expression_elemented2161);
            	expression135 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression135.Tree);
            	// Vnvd.g:320:41: ( COMMA expression )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( (LA27_0 == COMMA) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // Vnvd.g:320:42: COMMA expression
            			    {
            			    	COMMA136=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_array_creation_expression_elemented2164); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA136);

            			    	PushFollow(FOLLOW_expression_in_array_creation_expression_elemented2166);
            			    	expression137 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression137.Tree);

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements

            	RCURLYBRACE138=(IToken)Match(input,RCURLYBRACE,FOLLOW_RCURLYBRACE_in_array_creation_expression_elemented2170); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RCURLYBRACE.Add(RCURLYBRACE138);



            	// AST REWRITE
            	// elements:          expression, qualifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 321:2: -> ^( NEWARRELEMS qualifier ^( ARRELEMS ( ^( ARRELEM expression ) )* ) )
            	{
            	    // Vnvd.g:321:5: ^( NEWARRELEMS qualifier ^( ARRELEMS ( ^( ARRELEM expression ) )* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWARRELEMS, "NEWARRELEMS"), root_1);

            	    adaptor.AddChild(root_1, stream_qualifier.NextTree());
            	    // Vnvd.g:321:29: ^( ARRELEMS ( ^( ARRELEM expression ) )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRELEMS, "ARRELEMS"), root_2);

            	    // Vnvd.g:321:40: ( ^( ARRELEM expression ) )*
            	    while ( stream_expression.HasNext() )
            	    {
            	        // Vnvd.g:321:41: ^( ARRELEM expression )
            	        {
            	        object root_3 = (object)adaptor.GetNilNode();
            	        root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRELEM, "ARRELEM"), root_3);

            	        adaptor.AddChild(root_3, stream_expression.NextTree());

            	        adaptor.AddChild(root_2, root_3);
            	        }

            	    }
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "array_creation_expression_elemented"

    public class array_creation_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "array_creation_expression"
    // Vnvd.g:324:1: array_creation_expression : NEW qualifier LBRACKET expression RBRACKET -> ^( NEWARR qualifier expression ) ;
    public VnvdParser.array_creation_expression_return array_creation_expression() // throws RecognitionException [1]
    {   
        VnvdParser.array_creation_expression_return retval = new VnvdParser.array_creation_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEW139 = null;
        IToken LBRACKET141 = null;
        IToken RBRACKET143 = null;
        VnvdParser.qualifier_return qualifier140 = default(VnvdParser.qualifier_return);

        VnvdParser.expression_return expression142 = default(VnvdParser.expression_return);


        object NEW139_tree=null;
        object LBRACKET141_tree=null;
        object RBRACKET143_tree=null;
        RewriteRuleTokenStream stream_NEW = new RewriteRuleTokenStream(adaptor,"token NEW");
        RewriteRuleTokenStream stream_LBRACKET = new RewriteRuleTokenStream(adaptor,"token LBRACKET");
        RewriteRuleTokenStream stream_RBRACKET = new RewriteRuleTokenStream(adaptor,"token RBRACKET");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:325:2: ( NEW qualifier LBRACKET expression RBRACKET -> ^( NEWARR qualifier expression ) )
            // Vnvd.g:325:4: NEW qualifier LBRACKET expression RBRACKET
            {
            	NEW139=(IToken)Match(input,NEW,FOLLOW_NEW_in_array_creation_expression2204); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NEW.Add(NEW139);

            	PushFollow(FOLLOW_qualifier_in_array_creation_expression2206);
            	qualifier140 = qualifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qualifier.Add(qualifier140.Tree);
            	LBRACKET141=(IToken)Match(input,LBRACKET,FOLLOW_LBRACKET_in_array_creation_expression2208); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRACKET.Add(LBRACKET141);

            	PushFollow(FOLLOW_expression_in_array_creation_expression2210);
            	expression142 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression142.Tree);
            	RBRACKET143=(IToken)Match(input,RBRACKET,FOLLOW_RBRACKET_in_array_creation_expression2212); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRACKET.Add(RBRACKET143);



            	// AST REWRITE
            	// elements:          qualifier, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 326:2: -> ^( NEWARR qualifier expression )
            	{
            	    // Vnvd.g:326:5: ^( NEWARR qualifier expression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEWARR, "NEWARR"), root_1);

            	    adaptor.AddChild(root_1, stream_qualifier.NextTree());
            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "array_creation_expression"

    public class expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expression"
    // Vnvd.g:329:1: expression : assignment_expression ;
    public VnvdParser.expression_return expression() // throws RecognitionException [1]
    {   
        VnvdParser.expression_return retval = new VnvdParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        VnvdParser.assignment_expression_return assignment_expression144 = default(VnvdParser.assignment_expression_return);



        try 
    	{
            // Vnvd.g:330:2: ( assignment_expression )
            // Vnvd.g:330:4: assignment_expression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_assignment_expression_in_expression2234);
            	assignment_expression144 = assignment_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment_expression144.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class assignment_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignment_expression"
    // Vnvd.g:333:1: assignment_expression : t1= control_expression ( options {greedy=true; } : (b= BECOMES | ADDEVENT | REMEVENT ) t2= assignment_expression )? ;
    public VnvdParser.assignment_expression_return assignment_expression() // throws RecognitionException [1]
    {   
        VnvdParser.assignment_expression_return retval = new VnvdParser.assignment_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken b = null;
        IToken ADDEVENT145 = null;
        IToken REMEVENT146 = null;
        VnvdParser.control_expression_return t1 = default(VnvdParser.control_expression_return);

        VnvdParser.assignment_expression_return t2 = default(VnvdParser.assignment_expression_return);


        object b_tree=null;
        object ADDEVENT145_tree=null;
        object REMEVENT146_tree=null;

        try 
    	{
            // Vnvd.g:334:2: (t1= control_expression ( options {greedy=true; } : (b= BECOMES | ADDEVENT | REMEVENT ) t2= assignment_expression )? )
            // Vnvd.g:334:4: t1= control_expression ( options {greedy=true; } : (b= BECOMES | ADDEVENT | REMEVENT ) t2= assignment_expression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_control_expression_in_assignment_expression2248);
            	t1 = control_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, t1.Tree);
            	// Vnvd.g:334:26: ( options {greedy=true; } : (b= BECOMES | ADDEVENT | REMEVENT ) t2= assignment_expression )?
            	int alt29 = 2;
            	alt29 = dfa29.Predict(input);
            	switch (alt29) 
            	{
            	    case 1 :
            	        // Vnvd.g:334:52: (b= BECOMES | ADDEVENT | REMEVENT ) t2= assignment_expression
            	        {
            	        	// Vnvd.g:334:52: (b= BECOMES | ADDEVENT | REMEVENT )
            	        	int alt28 = 3;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	case BECOMES:
            	        		{
            	        	    alt28 = 1;
            	        	    }
            	        	    break;
            	        	case ADDEVENT:
            	        		{
            	        	    alt28 = 2;
            	        	    }
            	        	    break;
            	        	case REMEVENT:
            	        		{
            	        	    alt28 = 3;
            	        	    }
            	        	    break;
            	        		default:
            	        		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        		    NoViableAltException nvae_d28s0 =
            	        		        new NoViableAltException("", 28, 0, input);

            	        		    throw nvae_d28s0;
            	        	}

            	        	switch (alt28) 
            	        	{
            	        	    case 1 :
            	        	        // Vnvd.g:334:53: b= BECOMES
            	        	        {
            	        	        	b=(IToken)Match(input,BECOMES,FOLLOW_BECOMES_in_assignment_expression2263); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{b_tree = (object)adaptor.Create(b);
            	        	        		root_0 = (object)adaptor.BecomeRoot(b_tree, root_0);
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // Vnvd.g:334:66: ADDEVENT
            	        	        {
            	        	        	ADDEVENT145=(IToken)Match(input,ADDEVENT,FOLLOW_ADDEVENT_in_assignment_expression2268); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{ADDEVENT145_tree = (object)adaptor.Create(ADDEVENT145);
            	        	        		root_0 = (object)adaptor.BecomeRoot(ADDEVENT145_tree, root_0);
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 3 :
            	        	        // Vnvd.g:334:78: REMEVENT
            	        	        {
            	        	        	REMEVENT146=(IToken)Match(input,REMEVENT,FOLLOW_REMEVENT_in_assignment_expression2273); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{REMEVENT146_tree = (object)adaptor.Create(REMEVENT146);
            	        	        		root_0 = (object)adaptor.BecomeRoot(REMEVENT146_tree, root_0);
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	PushFollow(FOLLOW_assignment_expression_in_assignment_expression2279);
            	        	t2 = assignment_expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, t2.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment_expression"

    public class control_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "control_expression"
    // Vnvd.g:337:1: control_expression : ( WHILE LPAREN scope_expr RPAREN expression -> ^( WHILE scope_expr expression ) | FOR LPAREN type_= qualifier IDENTIFIER IN expression RPAREN do_= expression -> ^( FOR ^( LOCAL $type_ IDENTIFIER ) expression $do_) | TRY expression ( finally_block | ( options {greedy=true; } : ( catch_block )+ ( finally_block )? ) ) -> ^( TRY expression ( catch_block )* ( finally_block )? ) | IF LPAREN scope_expr RPAREN THEN expression ( options {greedy=true; } : ELSE expression )? -> ^( IF scope_expr expression ( expression )? ) | THROW expression -> ^( THROW expression ) | conditional_or_operator_expression );
    public VnvdParser.control_expression_return control_expression() // throws RecognitionException [1]
    {   
        VnvdParser.control_expression_return retval = new VnvdParser.control_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE147 = null;
        IToken LPAREN148 = null;
        IToken RPAREN150 = null;
        IToken FOR152 = null;
        IToken LPAREN153 = null;
        IToken IDENTIFIER154 = null;
        IToken IN155 = null;
        IToken RPAREN157 = null;
        IToken TRY158 = null;
        IToken IF163 = null;
        IToken LPAREN164 = null;
        IToken RPAREN166 = null;
        IToken THEN167 = null;
        IToken ELSE169 = null;
        IToken THROW171 = null;
        VnvdParser.qualifier_return type_ = default(VnvdParser.qualifier_return);

        VnvdParser.expression_return do_ = default(VnvdParser.expression_return);

        VnvdParser.scope_expr_return scope_expr149 = default(VnvdParser.scope_expr_return);

        VnvdParser.expression_return expression151 = default(VnvdParser.expression_return);

        VnvdParser.expression_return expression156 = default(VnvdParser.expression_return);

        VnvdParser.expression_return expression159 = default(VnvdParser.expression_return);

        VnvdParser.finally_block_return finally_block160 = default(VnvdParser.finally_block_return);

        VnvdParser.catch_block_return catch_block161 = default(VnvdParser.catch_block_return);

        VnvdParser.finally_block_return finally_block162 = default(VnvdParser.finally_block_return);

        VnvdParser.scope_expr_return scope_expr165 = default(VnvdParser.scope_expr_return);

        VnvdParser.expression_return expression168 = default(VnvdParser.expression_return);

        VnvdParser.expression_return expression170 = default(VnvdParser.expression_return);

        VnvdParser.expression_return expression172 = default(VnvdParser.expression_return);

        VnvdParser.conditional_or_operator_expression_return conditional_or_operator_expression173 = default(VnvdParser.conditional_or_operator_expression_return);


        object WHILE147_tree=null;
        object LPAREN148_tree=null;
        object RPAREN150_tree=null;
        object FOR152_tree=null;
        object LPAREN153_tree=null;
        object IDENTIFIER154_tree=null;
        object IN155_tree=null;
        object RPAREN157_tree=null;
        object TRY158_tree=null;
        object IF163_tree=null;
        object LPAREN164_tree=null;
        object RPAREN166_tree=null;
        object THEN167_tree=null;
        object ELSE169_tree=null;
        object THROW171_tree=null;
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_THEN = new RewriteRuleTokenStream(adaptor,"token THEN");
        RewriteRuleTokenStream stream_IN = new RewriteRuleTokenStream(adaptor,"token IN");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleTokenStream stream_THROW = new RewriteRuleTokenStream(adaptor,"token THROW");
        RewriteRuleTokenStream stream_TRY = new RewriteRuleTokenStream(adaptor,"token TRY");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_ELSE = new RewriteRuleTokenStream(adaptor,"token ELSE");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_finally_block = new RewriteRuleSubtreeStream(adaptor,"rule finally_block");
        RewriteRuleSubtreeStream stream_catch_block = new RewriteRuleSubtreeStream(adaptor,"rule catch_block");
        RewriteRuleSubtreeStream stream_scope_expr = new RewriteRuleSubtreeStream(adaptor,"rule scope_expr");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:338:2: ( WHILE LPAREN scope_expr RPAREN expression -> ^( WHILE scope_expr expression ) | FOR LPAREN type_= qualifier IDENTIFIER IN expression RPAREN do_= expression -> ^( FOR ^( LOCAL $type_ IDENTIFIER ) expression $do_) | TRY expression ( finally_block | ( options {greedy=true; } : ( catch_block )+ ( finally_block )? ) ) -> ^( TRY expression ( catch_block )* ( finally_block )? ) | IF LPAREN scope_expr RPAREN THEN expression ( options {greedy=true; } : ELSE expression )? -> ^( IF scope_expr expression ( expression )? ) | THROW expression -> ^( THROW expression ) | conditional_or_operator_expression )
            int alt34 = 6;
            alt34 = dfa34.Predict(input);
            switch (alt34) 
            {
                case 1 :
                    // Vnvd.g:338:4: WHILE LPAREN scope_expr RPAREN expression
                    {
                    	WHILE147=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_control_expression2292); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE147);

                    	LPAREN148=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_control_expression2294); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN148);

                    	PushFollow(FOLLOW_scope_expr_in_control_expression2296);
                    	scope_expr149 = scope_expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_scope_expr.Add(scope_expr149.Tree);
                    	RPAREN150=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_control_expression2298); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN150);

                    	PushFollow(FOLLOW_expression_in_control_expression2300);
                    	expression151 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression151.Tree);


                    	// AST REWRITE
                    	// elements:          scope_expr, expression, WHILE
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 339:2: -> ^( WHILE scope_expr expression )
                    	{
                    	    // Vnvd.g:339:5: ^( WHILE scope_expr expression )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_scope_expr.NextTree());
                    	    adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Vnvd.g:340:4: FOR LPAREN type_= qualifier IDENTIFIER IN expression RPAREN do_= expression
                    {
                    	FOR152=(IToken)Match(input,FOR,FOLLOW_FOR_in_control_expression2316); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_FOR.Add(FOR152);

                    	LPAREN153=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_control_expression2318); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN153);

                    	PushFollow(FOLLOW_qualifier_in_control_expression2322);
                    	type_ = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_qualifier.Add(type_.Tree);
                    	IDENTIFIER154=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_control_expression2324); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER154);

                    	IN155=(IToken)Match(input,IN,FOLLOW_IN_in_control_expression2326); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IN.Add(IN155);

                    	PushFollow(FOLLOW_expression_in_control_expression2328);
                    	expression156 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression156.Tree);
                    	RPAREN157=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_control_expression2330); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN157);

                    	PushFollow(FOLLOW_expression_in_control_expression2334);
                    	do_ = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(do_.Tree);


                    	// AST REWRITE
                    	// elements:          type_, IDENTIFIER, FOR, do_, expression
                    	// token labels:      
                    	// rule labels:       type_, retval, do_
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_type_ = new RewriteRuleSubtreeStream(adaptor, "rule type_", type_!=null ? type_.Tree : null);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
                    	RewriteRuleSubtreeStream stream_do_ = new RewriteRuleSubtreeStream(adaptor, "rule do_", do_!=null ? do_.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 341:2: -> ^( FOR ^( LOCAL $type_ IDENTIFIER ) expression $do_)
                    	{
                    	    // Vnvd.g:341:5: ^( FOR ^( LOCAL $type_ IDENTIFIER ) expression $do_)
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

                    	    // Vnvd.g:341:11: ^( LOCAL $type_ IDENTIFIER )
                    	    {
                    	    object root_2 = (object)adaptor.GetNilNode();
                    	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOCAL, "LOCAL"), root_2);

                    	    adaptor.AddChild(root_2, stream_type_.NextTree());
                    	    adaptor.AddChild(root_2, stream_IDENTIFIER.NextNode());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }
                    	    adaptor.AddChild(root_1, stream_expression.NextTree());
                    	    adaptor.AddChild(root_1, stream_do_.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // Vnvd.g:342:4: TRY expression ( finally_block | ( options {greedy=true; } : ( catch_block )+ ( finally_block )? ) )
                    {
                    	TRY158=(IToken)Match(input,TRY,FOLLOW_TRY_in_control_expression2360); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_TRY.Add(TRY158);

                    	PushFollow(FOLLOW_expression_in_control_expression2362);
                    	expression159 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression159.Tree);
                    	// Vnvd.g:342:19: ( finally_block | ( options {greedy=true; } : ( catch_block )+ ( finally_block )? ) )
                    	int alt32 = 2;
                    	int LA32_0 = input.LA(1);

                    	if ( (LA32_0 == FINALLY) )
                    	{
                    	    alt32 = 1;
                    	}
                    	else if ( ((LA32_0 >= CATCH && LA32_0 <= CAREBOX)) )
                    	{
                    	    alt32 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d32s0 =
                    	        new NoViableAltException("", 32, 0, input);

                    	    throw nvae_d32s0;
                    	}
                    	switch (alt32) 
                    	{
                    	    case 1 :
                    	        // Vnvd.g:342:20: finally_block
                    	        {
                    	        	PushFollow(FOLLOW_finally_block_in_control_expression2365);
                    	        	finally_block160 = finally_block();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_finally_block.Add(finally_block160.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Vnvd.g:342:36: ( options {greedy=true; } : ( catch_block )+ ( finally_block )? )
                    	        {
                    	        	// Vnvd.g:342:36: ( options {greedy=true; } : ( catch_block )+ ( finally_block )? )
                    	        	// Vnvd.g:342:62: ( catch_block )+ ( finally_block )?
                    	        	{
                    	        		// Vnvd.g:342:62: ( catch_block )+
                    	        		int cnt30 = 0;
                    	        		do 
                    	        		{
                    	        		    int alt30 = 2;
                    	        		    alt30 = dfa30.Predict(input);
                    	        		    switch (alt30) 
                    	        			{
                    	        				case 1 :
                    	        				    // Vnvd.g:342:62: catch_block
                    	        				    {
                    	        				    	PushFollow(FOLLOW_catch_block_in_control_expression2379);
                    	        				    	catch_block161 = catch_block();
                    	        				    	state.followingStackPointer--;
                    	        				    	if (state.failed) return retval;
                    	        				    	if ( (state.backtracking==0) ) stream_catch_block.Add(catch_block161.Tree);

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

                    	        		// Vnvd.g:342:75: ( finally_block )?
                    	        		int alt31 = 2;
                    	        		alt31 = dfa31.Predict(input);
                    	        		switch (alt31) 
                    	        		{
                    	        		    case 1 :
                    	        		        // Vnvd.g:342:75: finally_block
                    	        		        {
                    	        		        	PushFollow(FOLLOW_finally_block_in_control_expression2382);
                    	        		        	finally_block162 = finally_block();
                    	        		        	state.followingStackPointer--;
                    	        		        	if (state.failed) return retval;
                    	        		        	if ( (state.backtracking==0) ) stream_finally_block.Add(finally_block162.Tree);

                    	        		        }
                    	        		        break;

                    	        		}


                    	        	}


                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          expression, TRY, finally_block, catch_block
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 343:2: -> ^( TRY expression ( catch_block )* ( finally_block )? )
                    	{
                    	    // Vnvd.g:343:5: ^( TRY expression ( catch_block )* ( finally_block )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_TRY.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expression.NextTree());
                    	    // Vnvd.g:343:22: ( catch_block )*
                    	    while ( stream_catch_block.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_catch_block.NextTree());

                    	    }
                    	    stream_catch_block.Reset();
                    	    // Vnvd.g:343:35: ( finally_block )?
                    	    if ( stream_finally_block.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_finally_block.NextTree());

                    	    }
                    	    stream_finally_block.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // Vnvd.g:344:4: IF LPAREN scope_expr RPAREN THEN expression ( options {greedy=true; } : ELSE expression )?
                    {
                    	IF163=(IToken)Match(input,IF,FOLLOW_IF_in_control_expression2405); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IF.Add(IF163);

                    	LPAREN164=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_control_expression2407); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN164);

                    	PushFollow(FOLLOW_scope_expr_in_control_expression2409);
                    	scope_expr165 = scope_expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_scope_expr.Add(scope_expr165.Tree);
                    	RPAREN166=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_control_expression2411); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN166);

                    	THEN167=(IToken)Match(input,THEN,FOLLOW_THEN_in_control_expression2413); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_THEN.Add(THEN167);

                    	PushFollow(FOLLOW_expression_in_control_expression2415);
                    	expression168 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression168.Tree);
                    	// Vnvd.g:344:48: ( options {greedy=true; } : ELSE expression )?
                    	int alt33 = 2;
                    	alt33 = dfa33.Predict(input);
                    	switch (alt33) 
                    	{
                    	    case 1 :
                    	        // Vnvd.g:344:74: ELSE expression
                    	        {
                    	        	ELSE169=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_control_expression2427); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_ELSE.Add(ELSE169);

                    	        	PushFollow(FOLLOW_expression_in_control_expression2429);
                    	        	expression170 = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_expression.Add(expression170.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          expression, scope_expr, expression, IF
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 345:2: -> ^( IF scope_expr expression ( expression )? )
                    	{
                    	    // Vnvd.g:345:5: ^( IF scope_expr expression ( expression )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_scope_expr.NextTree());
                    	    adaptor.AddChild(root_1, stream_expression.NextTree());
                    	    // Vnvd.g:345:32: ( expression )?
                    	    if ( stream_expression.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    }
                    	    stream_expression.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 5 :
                    // Vnvd.g:346:4: THROW expression
                    {
                    	THROW171=(IToken)Match(input,THROW,FOLLOW_THROW_in_control_expression2450); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_THROW.Add(THROW171);

                    	PushFollow(FOLLOW_expression_in_control_expression2452);
                    	expression172 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression172.Tree);


                    	// AST REWRITE
                    	// elements:          THROW, expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 347:2: -> ^( THROW expression )
                    	{
                    	    // Vnvd.g:347:5: ^( THROW expression )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_THROW.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 6 :
                    // Vnvd.g:348:4: conditional_or_operator_expression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditional_or_operator_expression_in_control_expression2466);
                    	conditional_or_operator_expression173 = conditional_or_operator_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditional_or_operator_expression173.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "control_expression"

    public class conditional_or_operator_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "conditional_or_operator_expression"
    // Vnvd.g:351:1: conditional_or_operator_expression : conditional_and_operator_expression ( OR conditional_and_operator_expression )* ;
    public VnvdParser.conditional_or_operator_expression_return conditional_or_operator_expression() // throws RecognitionException [1]
    {   
        VnvdParser.conditional_or_operator_expression_return retval = new VnvdParser.conditional_or_operator_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OR175 = null;
        VnvdParser.conditional_and_operator_expression_return conditional_and_operator_expression174 = default(VnvdParser.conditional_and_operator_expression_return);

        VnvdParser.conditional_and_operator_expression_return conditional_and_operator_expression176 = default(VnvdParser.conditional_and_operator_expression_return);


        object OR175_tree=null;

        try 
    	{
            // Vnvd.g:352:2: ( conditional_and_operator_expression ( OR conditional_and_operator_expression )* )
            // Vnvd.g:352:4: conditional_and_operator_expression ( OR conditional_and_operator_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditional_and_operator_expression_in_conditional_or_operator_expression2478);
            	conditional_and_operator_expression174 = conditional_and_operator_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditional_and_operator_expression174.Tree);
            	// Vnvd.g:352:40: ( OR conditional_and_operator_expression )*
            	do 
            	{
            	    int alt35 = 2;
            	    int LA35_0 = input.LA(1);

            	    if ( (LA35_0 == OR) )
            	    {
            	        alt35 = 1;
            	    }


            	    switch (alt35) 
            		{
            			case 1 :
            			    // Vnvd.g:352:41: OR conditional_and_operator_expression
            			    {
            			    	OR175=(IToken)Match(input,OR,FOLLOW_OR_in_conditional_or_operator_expression2481); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{OR175_tree = (object)adaptor.Create(OR175);
            			    		root_0 = (object)adaptor.BecomeRoot(OR175_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditional_and_operator_expression_in_conditional_or_operator_expression2484);
            			    	conditional_and_operator_expression176 = conditional_and_operator_expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditional_and_operator_expression176.Tree);

            			    }
            			    break;

            			default:
            			    goto loop35;
            	    }
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "conditional_or_operator_expression"

    public class conditional_and_operator_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "conditional_and_operator_expression"
    // Vnvd.g:355:1: conditional_and_operator_expression : logic_or_operator_expression ( AND logic_or_operator_expression )* ;
    public VnvdParser.conditional_and_operator_expression_return conditional_and_operator_expression() // throws RecognitionException [1]
    {   
        VnvdParser.conditional_and_operator_expression_return retval = new VnvdParser.conditional_and_operator_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken AND178 = null;
        VnvdParser.logic_or_operator_expression_return logic_or_operator_expression177 = default(VnvdParser.logic_or_operator_expression_return);

        VnvdParser.logic_or_operator_expression_return logic_or_operator_expression179 = default(VnvdParser.logic_or_operator_expression_return);


        object AND178_tree=null;

        try 
    	{
            // Vnvd.g:356:2: ( logic_or_operator_expression ( AND logic_or_operator_expression )* )
            // Vnvd.g:356:4: logic_or_operator_expression ( AND logic_or_operator_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logic_or_operator_expression_in_conditional_and_operator_expression2497);
            	logic_or_operator_expression177 = logic_or_operator_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_or_operator_expression177.Tree);
            	// Vnvd.g:356:33: ( AND logic_or_operator_expression )*
            	do 
            	{
            	    int alt36 = 2;
            	    int LA36_0 = input.LA(1);

            	    if ( (LA36_0 == AND) )
            	    {
            	        alt36 = 1;
            	    }


            	    switch (alt36) 
            		{
            			case 1 :
            			    // Vnvd.g:356:34: AND logic_or_operator_expression
            			    {
            			    	AND178=(IToken)Match(input,AND,FOLLOW_AND_in_conditional_and_operator_expression2500); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{AND178_tree = (object)adaptor.Create(AND178);
            			    		root_0 = (object)adaptor.BecomeRoot(AND178_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_logic_or_operator_expression_in_conditional_and_operator_expression2503);
            			    	logic_or_operator_expression179 = logic_or_operator_expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_or_operator_expression179.Tree);

            			    }
            			    break;

            			default:
            			    goto loop36;
            	    }
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whining that label 'loop36' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "conditional_and_operator_expression"

    public class logic_or_operator_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logic_or_operator_expression"
    // Vnvd.g:359:1: logic_or_operator_expression : logic_xor_operator_expression ( LOR logic_xor_operator_expression )* ;
    public VnvdParser.logic_or_operator_expression_return logic_or_operator_expression() // throws RecognitionException [1]
    {   
        VnvdParser.logic_or_operator_expression_return retval = new VnvdParser.logic_or_operator_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOR181 = null;
        VnvdParser.logic_xor_operator_expression_return logic_xor_operator_expression180 = default(VnvdParser.logic_xor_operator_expression_return);

        VnvdParser.logic_xor_operator_expression_return logic_xor_operator_expression182 = default(VnvdParser.logic_xor_operator_expression_return);


        object LOR181_tree=null;

        try 
    	{
            // Vnvd.g:360:2: ( logic_xor_operator_expression ( LOR logic_xor_operator_expression )* )
            // Vnvd.g:360:4: logic_xor_operator_expression ( LOR logic_xor_operator_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logic_xor_operator_expression_in_logic_or_operator_expression2516);
            	logic_xor_operator_expression180 = logic_xor_operator_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_xor_operator_expression180.Tree);
            	// Vnvd.g:360:34: ( LOR logic_xor_operator_expression )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == LOR) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // Vnvd.g:360:35: LOR logic_xor_operator_expression
            			    {
            			    	LOR181=(IToken)Match(input,LOR,FOLLOW_LOR_in_logic_or_operator_expression2519); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LOR181_tree = (object)adaptor.Create(LOR181);
            			    		root_0 = (object)adaptor.BecomeRoot(LOR181_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_logic_xor_operator_expression_in_logic_or_operator_expression2522);
            			    	logic_xor_operator_expression182 = logic_xor_operator_expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_xor_operator_expression182.Tree);

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logic_or_operator_expression"

    public class logic_xor_operator_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logic_xor_operator_expression"
    // Vnvd.g:363:1: logic_xor_operator_expression : logic_and_operator_expression ( LXOR logic_and_operator_expression )* ;
    public VnvdParser.logic_xor_operator_expression_return logic_xor_operator_expression() // throws RecognitionException [1]
    {   
        VnvdParser.logic_xor_operator_expression_return retval = new VnvdParser.logic_xor_operator_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LXOR184 = null;
        VnvdParser.logic_and_operator_expression_return logic_and_operator_expression183 = default(VnvdParser.logic_and_operator_expression_return);

        VnvdParser.logic_and_operator_expression_return logic_and_operator_expression185 = default(VnvdParser.logic_and_operator_expression_return);


        object LXOR184_tree=null;

        try 
    	{
            // Vnvd.g:364:2: ( logic_and_operator_expression ( LXOR logic_and_operator_expression )* )
            // Vnvd.g:364:4: logic_and_operator_expression ( LXOR logic_and_operator_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logic_and_operator_expression_in_logic_xor_operator_expression2535);
            	logic_and_operator_expression183 = logic_and_operator_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_and_operator_expression183.Tree);
            	// Vnvd.g:364:34: ( LXOR logic_and_operator_expression )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == LXOR) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // Vnvd.g:364:35: LXOR logic_and_operator_expression
            			    {
            			    	LXOR184=(IToken)Match(input,LXOR,FOLLOW_LXOR_in_logic_xor_operator_expression2538); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LXOR184_tree = (object)adaptor.Create(LXOR184);
            			    		root_0 = (object)adaptor.BecomeRoot(LXOR184_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_logic_and_operator_expression_in_logic_xor_operator_expression2541);
            			    	logic_and_operator_expression185 = logic_and_operator_expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_and_operator_expression185.Tree);

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logic_xor_operator_expression"

    public class logic_and_operator_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logic_and_operator_expression"
    // Vnvd.g:367:1: logic_and_operator_expression : logic_expression ( LAND logic_expression )* ;
    public VnvdParser.logic_and_operator_expression_return logic_and_operator_expression() // throws RecognitionException [1]
    {   
        VnvdParser.logic_and_operator_expression_return retval = new VnvdParser.logic_and_operator_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LAND187 = null;
        VnvdParser.logic_expression_return logic_expression186 = default(VnvdParser.logic_expression_return);

        VnvdParser.logic_expression_return logic_expression188 = default(VnvdParser.logic_expression_return);


        object LAND187_tree=null;

        try 
    	{
            // Vnvd.g:368:2: ( logic_expression ( LAND logic_expression )* )
            // Vnvd.g:368:4: logic_expression ( LAND logic_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logic_expression_in_logic_and_operator_expression2554);
            	logic_expression186 = logic_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_expression186.Tree);
            	// Vnvd.g:368:21: ( LAND logic_expression )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( (LA39_0 == LAND) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // Vnvd.g:368:22: LAND logic_expression
            			    {
            			    	LAND187=(IToken)Match(input,LAND,FOLLOW_LAND_in_logic_and_operator_expression2557); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LAND187_tree = (object)adaptor.Create(LAND187);
            			    		root_0 = (object)adaptor.BecomeRoot(LAND187_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_logic_expression_in_logic_and_operator_expression2560);
            			    	logic_expression188 = logic_expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_expression188.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logic_and_operator_expression"

    public class logic_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logic_expression"
    // Vnvd.g:371:1: logic_expression : cast_as_expression ( ( LE | LEQ | GE | GEQ | EQ | NEQ ) cast_as_expression )* ;
    public VnvdParser.logic_expression_return logic_expression() // throws RecognitionException [1]
    {   
        VnvdParser.logic_expression_return retval = new VnvdParser.logic_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LE190 = null;
        IToken LEQ191 = null;
        IToken GE192 = null;
        IToken GEQ193 = null;
        IToken EQ194 = null;
        IToken NEQ195 = null;
        VnvdParser.cast_as_expression_return cast_as_expression189 = default(VnvdParser.cast_as_expression_return);

        VnvdParser.cast_as_expression_return cast_as_expression196 = default(VnvdParser.cast_as_expression_return);


        object LE190_tree=null;
        object LEQ191_tree=null;
        object GE192_tree=null;
        object GEQ193_tree=null;
        object EQ194_tree=null;
        object NEQ195_tree=null;

        try 
    	{
            // Vnvd.g:372:2: ( cast_as_expression ( ( LE | LEQ | GE | GEQ | EQ | NEQ ) cast_as_expression )* )
            // Vnvd.g:372:4: cast_as_expression ( ( LE | LEQ | GE | GEQ | EQ | NEQ ) cast_as_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_cast_as_expression_in_logic_expression2573);
            	cast_as_expression189 = cast_as_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast_as_expression189.Tree);
            	// Vnvd.g:372:23: ( ( LE | LEQ | GE | GEQ | EQ | NEQ ) cast_as_expression )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( ((LA41_0 >= LE && LA41_0 <= NEQ)) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // Vnvd.g:372:24: ( LE | LEQ | GE | GEQ | EQ | NEQ ) cast_as_expression
            			    {
            			    	// Vnvd.g:372:24: ( LE | LEQ | GE | GEQ | EQ | NEQ )
            			    	int alt40 = 6;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case LE:
            			    		{
            			    	    alt40 = 1;
            			    	    }
            			    	    break;
            			    	case LEQ:
            			    		{
            			    	    alt40 = 2;
            			    	    }
            			    	    break;
            			    	case GE:
            			    		{
            			    	    alt40 = 3;
            			    	    }
            			    	    break;
            			    	case GEQ:
            			    		{
            			    	    alt40 = 4;
            			    	    }
            			    	    break;
            			    	case EQ:
            			    		{
            			    	    alt40 = 5;
            			    	    }
            			    	    break;
            			    	case NEQ:
            			    		{
            			    	    alt40 = 6;
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
            			    	        // Vnvd.g:372:25: LE
            			    	        {
            			    	        	LE190=(IToken)Match(input,LE,FOLLOW_LE_in_logic_expression2577); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{LE190_tree = (object)adaptor.Create(LE190);
            			    	        		root_0 = (object)adaptor.BecomeRoot(LE190_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // Vnvd.g:372:31: LEQ
            			    	        {
            			    	        	LEQ191=(IToken)Match(input,LEQ,FOLLOW_LEQ_in_logic_expression2582); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{LEQ191_tree = (object)adaptor.Create(LEQ191);
            			    	        		root_0 = (object)adaptor.BecomeRoot(LEQ191_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // Vnvd.g:372:38: GE
            			    	        {
            			    	        	GE192=(IToken)Match(input,GE,FOLLOW_GE_in_logic_expression2587); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{GE192_tree = (object)adaptor.Create(GE192);
            			    	        		root_0 = (object)adaptor.BecomeRoot(GE192_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // Vnvd.g:372:44: GEQ
            			    	        {
            			    	        	GEQ193=(IToken)Match(input,GEQ,FOLLOW_GEQ_in_logic_expression2592); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{GEQ193_tree = (object)adaptor.Create(GEQ193);
            			    	        		root_0 = (object)adaptor.BecomeRoot(GEQ193_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 5 :
            			    	        // Vnvd.g:372:51: EQ
            			    	        {
            			    	        	EQ194=(IToken)Match(input,EQ,FOLLOW_EQ_in_logic_expression2597); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{EQ194_tree = (object)adaptor.Create(EQ194);
            			    	        		root_0 = (object)adaptor.BecomeRoot(EQ194_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 6 :
            			    	        // Vnvd.g:372:57: NEQ
            			    	        {
            			    	        	NEQ195=(IToken)Match(input,NEQ,FOLLOW_NEQ_in_logic_expression2602); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{NEQ195_tree = (object)adaptor.Create(NEQ195);
            			    	        		root_0 = (object)adaptor.BecomeRoot(NEQ195_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_cast_as_expression_in_logic_expression2606);
            			    	cast_as_expression196 = cast_as_expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast_as_expression196.Tree);

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logic_expression"

    public class cast_as_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "cast_as_expression"
    // Vnvd.g:375:1: cast_as_expression : primary_expression ( ( AS | IS ) qualifier )* ;
    public VnvdParser.cast_as_expression_return cast_as_expression() // throws RecognitionException [1]
    {   
        VnvdParser.cast_as_expression_return retval = new VnvdParser.cast_as_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken AS198 = null;
        IToken IS199 = null;
        VnvdParser.primary_expression_return primary_expression197 = default(VnvdParser.primary_expression_return);

        VnvdParser.qualifier_return qualifier200 = default(VnvdParser.qualifier_return);


        object AS198_tree=null;
        object IS199_tree=null;

        try 
    	{
            // Vnvd.g:376:2: ( primary_expression ( ( AS | IS ) qualifier )* )
            // Vnvd.g:376:4: primary_expression ( ( AS | IS ) qualifier )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_primary_expression_in_cast_as_expression2619);
            	primary_expression197 = primary_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primary_expression197.Tree);
            	// Vnvd.g:376:23: ( ( AS | IS ) qualifier )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( ((LA43_0 >= AS && LA43_0 <= IS)) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // Vnvd.g:376:24: ( AS | IS ) qualifier
            			    {
            			    	// Vnvd.g:376:24: ( AS | IS )
            			    	int alt42 = 2;
            			    	int LA42_0 = input.LA(1);

            			    	if ( (LA42_0 == AS) )
            			    	{
            			    	    alt42 = 1;
            			    	}
            			    	else if ( (LA42_0 == IS) )
            			    	{
            			    	    alt42 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    NoViableAltException nvae_d42s0 =
            			    	        new NoViableAltException("", 42, 0, input);

            			    	    throw nvae_d42s0;
            			    	}
            			    	switch (alt42) 
            			    	{
            			    	    case 1 :
            			    	        // Vnvd.g:376:25: AS
            			    	        {
            			    	        	AS198=(IToken)Match(input,AS,FOLLOW_AS_in_cast_as_expression2623); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{AS198_tree = (object)adaptor.Create(AS198);
            			    	        		root_0 = (object)adaptor.BecomeRoot(AS198_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // Vnvd.g:376:31: IS
            			    	        {
            			    	        	IS199=(IToken)Match(input,IS,FOLLOW_IS_in_cast_as_expression2628); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{IS199_tree = (object)adaptor.Create(IS199);
            			    	        		root_0 = (object)adaptor.BecomeRoot(IS199_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_qualifier_in_cast_as_expression2632);
            			    	qualifier200 = qualifier();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, qualifier200.Tree);

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cast_as_expression"

    public class primary_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "primary_expression"
    // Vnvd.g:379:1: primary_expression : secundary_expression ( ( PLUS | MINUS ) secundary_expression )* ;
    public VnvdParser.primary_expression_return primary_expression() // throws RecognitionException [1]
    {   
        VnvdParser.primary_expression_return retval = new VnvdParser.primary_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS202 = null;
        IToken MINUS203 = null;
        VnvdParser.secundary_expression_return secundary_expression201 = default(VnvdParser.secundary_expression_return);

        VnvdParser.secundary_expression_return secundary_expression204 = default(VnvdParser.secundary_expression_return);


        object PLUS202_tree=null;
        object MINUS203_tree=null;

        try 
    	{
            // Vnvd.g:380:2: ( secundary_expression ( ( PLUS | MINUS ) secundary_expression )* )
            // Vnvd.g:380:4: secundary_expression ( ( PLUS | MINUS ) secundary_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_secundary_expression_in_primary_expression2646);
            	secundary_expression201 = secundary_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, secundary_expression201.Tree);
            	// Vnvd.g:380:25: ( ( PLUS | MINUS ) secundary_expression )*
            	do 
            	{
            	    int alt45 = 2;
            	    int LA45_0 = input.LA(1);

            	    if ( ((LA45_0 >= PLUS && LA45_0 <= MINUS)) )
            	    {
            	        alt45 = 1;
            	    }


            	    switch (alt45) 
            		{
            			case 1 :
            			    // Vnvd.g:380:26: ( PLUS | MINUS ) secundary_expression
            			    {
            			    	// Vnvd.g:380:26: ( PLUS | MINUS )
            			    	int alt44 = 2;
            			    	int LA44_0 = input.LA(1);

            			    	if ( (LA44_0 == PLUS) )
            			    	{
            			    	    alt44 = 1;
            			    	}
            			    	else if ( (LA44_0 == MINUS) )
            			    	{
            			    	    alt44 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    NoViableAltException nvae_d44s0 =
            			    	        new NoViableAltException("", 44, 0, input);

            			    	    throw nvae_d44s0;
            			    	}
            			    	switch (alt44) 
            			    	{
            			    	    case 1 :
            			    	        // Vnvd.g:380:27: PLUS
            			    	        {
            			    	        	PLUS202=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_primary_expression2650); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{PLUS202_tree = (object)adaptor.Create(PLUS202);
            			    	        		root_0 = (object)adaptor.BecomeRoot(PLUS202_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // Vnvd.g:380:35: MINUS
            			    	        {
            			    	        	MINUS203=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_primary_expression2655); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{MINUS203_tree = (object)adaptor.Create(MINUS203);
            			    	        		root_0 = (object)adaptor.BecomeRoot(MINUS203_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_secundary_expression_in_primary_expression2659);
            			    	secundary_expression204 = secundary_expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, secundary_expression204.Tree);

            			    }
            			    break;

            			default:
            			    goto loop45;
            	    }
            	} while (true);

            	loop45:
            		;	// Stops C# compiler whining that label 'loop45' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "primary_expression"

    public class secundary_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "secundary_expression"
    // Vnvd.g:383:1: secundary_expression : logicnotoperator_expression ( ( MULTIPLY | DIVISION | MOD ) logicnotoperator_expression )* ;
    public VnvdParser.secundary_expression_return secundary_expression() // throws RecognitionException [1]
    {   
        VnvdParser.secundary_expression_return retval = new VnvdParser.secundary_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULTIPLY206 = null;
        IToken DIVISION207 = null;
        IToken MOD208 = null;
        VnvdParser.logicnotoperator_expression_return logicnotoperator_expression205 = default(VnvdParser.logicnotoperator_expression_return);

        VnvdParser.logicnotoperator_expression_return logicnotoperator_expression209 = default(VnvdParser.logicnotoperator_expression_return);


        object MULTIPLY206_tree=null;
        object DIVISION207_tree=null;
        object MOD208_tree=null;

        try 
    	{
            // Vnvd.g:384:2: ( logicnotoperator_expression ( ( MULTIPLY | DIVISION | MOD ) logicnotoperator_expression )* )
            // Vnvd.g:384:4: logicnotoperator_expression ( ( MULTIPLY | DIVISION | MOD ) logicnotoperator_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logicnotoperator_expression_in_secundary_expression2673);
            	logicnotoperator_expression205 = logicnotoperator_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicnotoperator_expression205.Tree);
            	// Vnvd.g:384:32: ( ( MULTIPLY | DIVISION | MOD ) logicnotoperator_expression )*
            	do 
            	{
            	    int alt47 = 2;
            	    int LA47_0 = input.LA(1);

            	    if ( ((LA47_0 >= MULTIPLY && LA47_0 <= DIVISION) || LA47_0 == MOD) )
            	    {
            	        alt47 = 1;
            	    }


            	    switch (alt47) 
            		{
            			case 1 :
            			    // Vnvd.g:384:33: ( MULTIPLY | DIVISION | MOD ) logicnotoperator_expression
            			    {
            			    	// Vnvd.g:384:33: ( MULTIPLY | DIVISION | MOD )
            			    	int alt46 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case MULTIPLY:
            			    		{
            			    	    alt46 = 1;
            			    	    }
            			    	    break;
            			    	case DIVISION:
            			    		{
            			    	    alt46 = 2;
            			    	    }
            			    	    break;
            			    	case MOD:
            			    		{
            			    	    alt46 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d46s0 =
            			    		        new NoViableAltException("", 46, 0, input);

            			    		    throw nvae_d46s0;
            			    	}

            			    	switch (alt46) 
            			    	{
            			    	    case 1 :
            			    	        // Vnvd.g:384:34: MULTIPLY
            			    	        {
            			    	        	MULTIPLY206=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_secundary_expression2677); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{MULTIPLY206_tree = (object)adaptor.Create(MULTIPLY206);
            			    	        		root_0 = (object)adaptor.BecomeRoot(MULTIPLY206_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // Vnvd.g:384:46: DIVISION
            			    	        {
            			    	        	DIVISION207=(IToken)Match(input,DIVISION,FOLLOW_DIVISION_in_secundary_expression2682); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{DIVISION207_tree = (object)adaptor.Create(DIVISION207);
            			    	        		root_0 = (object)adaptor.BecomeRoot(DIVISION207_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // Vnvd.g:384:58: MOD
            			    	        {
            			    	        	MOD208=(IToken)Match(input,MOD,FOLLOW_MOD_in_secundary_expression2687); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{MOD208_tree = (object)adaptor.Create(MOD208);
            			    	        		root_0 = (object)adaptor.BecomeRoot(MOD208_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_logicnotoperator_expression_in_secundary_expression2691);
            			    	logicnotoperator_expression209 = logicnotoperator_expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicnotoperator_expression209.Tree);

            			    }
            			    break;

            			default:
            			    goto loop47;
            	    }
            	} while (true);

            	loop47:
            		;	// Stops C# compiler whining that label 'loop47' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "secundary_expression"

    public class logicnotoperator_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logicnotoperator_expression"
    // Vnvd.g:387:1: logicnotoperator_expression : ( NOT | PLUS | MINUS )* cast_expression ;
    public VnvdParser.logicnotoperator_expression_return logicnotoperator_expression() // throws RecognitionException [1]
    {   
        VnvdParser.logicnotoperator_expression_return retval = new VnvdParser.logicnotoperator_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NOT210 = null;
        IToken PLUS211 = null;
        IToken MINUS212 = null;
        VnvdParser.cast_expression_return cast_expression213 = default(VnvdParser.cast_expression_return);


        object NOT210_tree=null;
        object PLUS211_tree=null;
        object MINUS212_tree=null;

        try 
    	{
            // Vnvd.g:388:2: ( ( NOT | PLUS | MINUS )* cast_expression )
            // Vnvd.g:388:4: ( NOT | PLUS | MINUS )* cast_expression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Vnvd.g:388:4: ( NOT | PLUS | MINUS )*
            	do 
            	{
            	    int alt48 = 4;
            	    alt48 = dfa48.Predict(input);
            	    switch (alt48) 
            		{
            			case 1 :
            			    // Vnvd.g:388:5: NOT
            			    {
            			    	NOT210=(IToken)Match(input,NOT,FOLLOW_NOT_in_logicnotoperator_expression2706); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{NOT210_tree = (object)adaptor.Create(NOT210);
            			    		root_0 = (object)adaptor.BecomeRoot(NOT210_tree, root_0);
            			    	}

            			    }
            			    break;
            			case 2 :
            			    // Vnvd.g:388:12: PLUS
            			    {
            			    	PLUS211=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_logicnotoperator_expression2711); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{PLUS211_tree = (object)adaptor.Create(PLUS211);
            			    		root_0 = (object)adaptor.BecomeRoot(PLUS211_tree, root_0);
            			    	}

            			    }
            			    break;
            			case 3 :
            			    // Vnvd.g:388:20: MINUS
            			    {
            			    	MINUS212=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_logicnotoperator_expression2716); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{MINUS212_tree = (object)adaptor.Create(MINUS212);
            			    		root_0 = (object)adaptor.BecomeRoot(MINUS212_tree, root_0);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop48;
            	    }
            	} while (true);

            	loop48:
            		;	// Stops C# compiler whining that label 'loop48' has no statements

            	PushFollow(FOLLOW_cast_expression_in_logicnotoperator_expression2721);
            	cast_expression213 = cast_expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast_expression213.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicnotoperator_expression"

    public class cast_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "cast_expression"
    // Vnvd.g:391:1: cast_expression : ( ( LPAREN qualifier RPAREN cast_expression )=> ( LPAREN qualifier RPAREN cast_expression ) -> ^( CAST qualifier cast_expression ) | invocation_or_load_expression );
    public VnvdParser.cast_expression_return cast_expression() // throws RecognitionException [1]
    {   
        VnvdParser.cast_expression_return retval = new VnvdParser.cast_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LPAREN214 = null;
        IToken RPAREN216 = null;
        VnvdParser.qualifier_return qualifier215 = default(VnvdParser.qualifier_return);

        VnvdParser.cast_expression_return cast_expression217 = default(VnvdParser.cast_expression_return);

        VnvdParser.invocation_or_load_expression_return invocation_or_load_expression218 = default(VnvdParser.invocation_or_load_expression_return);


        object LPAREN214_tree=null;
        object RPAREN216_tree=null;
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_cast_expression = new RewriteRuleSubtreeStream(adaptor,"rule cast_expression");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:392:2: ( ( LPAREN qualifier RPAREN cast_expression )=> ( LPAREN qualifier RPAREN cast_expression ) -> ^( CAST qualifier cast_expression ) | invocation_or_load_expression )
            int alt49 = 2;
            alt49 = dfa49.Predict(input);
            switch (alt49) 
            {
                case 1 :
                    // Vnvd.g:392:4: ( LPAREN qualifier RPAREN cast_expression )=> ( LPAREN qualifier RPAREN cast_expression )
                    {
                    	// Vnvd.g:392:49: ( LPAREN qualifier RPAREN cast_expression )
                    	// Vnvd.g:392:50: LPAREN qualifier RPAREN cast_expression
                    	{
                    		LPAREN214=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_cast_expression2745); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN214);

                    		PushFollow(FOLLOW_qualifier_in_cast_expression2747);
                    		qualifier215 = qualifier();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_qualifier.Add(qualifier215.Tree);
                    		RPAREN216=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_cast_expression2749); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN216);

                    		PushFollow(FOLLOW_cast_expression_in_cast_expression2751);
                    		cast_expression217 = cast_expression();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_cast_expression.Add(cast_expression217.Tree);

                    	}



                    	// AST REWRITE
                    	// elements:          qualifier, cast_expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 393:2: -> ^( CAST qualifier cast_expression )
                    	{
                    	    // Vnvd.g:393:5: ^( CAST qualifier cast_expression )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CAST, "CAST"), root_1);

                    	    adaptor.AddChild(root_1, stream_qualifier.NextTree());
                    	    adaptor.AddChild(root_1, stream_cast_expression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Vnvd.g:394:4: invocation_or_load_expression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_invocation_or_load_expression_in_cast_expression2768);
                    	invocation_or_load_expression218 = invocation_or_load_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, invocation_or_load_expression218.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cast_expression"

    public class invocation_or_load_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "invocation_or_load_expression"
    // Vnvd.g:397:1: invocation_or_load_expression : operand ( ( DCOLON IDENTIFIER ( LPAREN argument_list RPAREN )? ) | ( LBRACKET expression RBRACKET ) )* ;
    public VnvdParser.invocation_or_load_expression_return invocation_or_load_expression() // throws RecognitionException [1]
    {   
        VnvdParser.invocation_or_load_expression_return retval = new VnvdParser.invocation_or_load_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DCOLON220 = null;
        IToken IDENTIFIER221 = null;
        IToken LPAREN222 = null;
        IToken RPAREN224 = null;
        IToken LBRACKET225 = null;
        IToken RBRACKET227 = null;
        VnvdParser.operand_return operand219 = default(VnvdParser.operand_return);

        VnvdParser.argument_list_return argument_list223 = default(VnvdParser.argument_list_return);

        VnvdParser.expression_return expression226 = default(VnvdParser.expression_return);


        object DCOLON220_tree=null;
        object IDENTIFIER221_tree=null;
        object LPAREN222_tree=null;
        object RPAREN224_tree=null;
        object LBRACKET225_tree=null;
        object RBRACKET227_tree=null;

        try 
    	{
            // Vnvd.g:398:2: ( operand ( ( DCOLON IDENTIFIER ( LPAREN argument_list RPAREN )? ) | ( LBRACKET expression RBRACKET ) )* )
            // Vnvd.g:398:4: operand ( ( DCOLON IDENTIFIER ( LPAREN argument_list RPAREN )? ) | ( LBRACKET expression RBRACKET ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_operand_in_invocation_or_load_expression2779);
            	operand219 = operand();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operand219.Tree);
            	// Vnvd.g:398:12: ( ( DCOLON IDENTIFIER ( LPAREN argument_list RPAREN )? ) | ( LBRACKET expression RBRACKET ) )*
            	do 
            	{
            	    int alt51 = 3;
            	    int LA51_0 = input.LA(1);

            	    if ( (LA51_0 == DCOLON) )
            	    {
            	        alt51 = 1;
            	    }
            	    else if ( (LA51_0 == LBRACKET) )
            	    {
            	        alt51 = 2;
            	    }


            	    switch (alt51) 
            		{
            			case 1 :
            			    // Vnvd.g:398:13: ( DCOLON IDENTIFIER ( LPAREN argument_list RPAREN )? )
            			    {
            			    	// Vnvd.g:398:13: ( DCOLON IDENTIFIER ( LPAREN argument_list RPAREN )? )
            			    	// Vnvd.g:398:14: DCOLON IDENTIFIER ( LPAREN argument_list RPAREN )?
            			    	{
            			    		DCOLON220=(IToken)Match(input,DCOLON,FOLLOW_DCOLON_in_invocation_or_load_expression2783); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{DCOLON220_tree = (object)adaptor.Create(DCOLON220);
            			    			root_0 = (object)adaptor.BecomeRoot(DCOLON220_tree, root_0);
            			    		}
            			    		IDENTIFIER221=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_invocation_or_load_expression2786); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{IDENTIFIER221_tree = (object)adaptor.Create(IDENTIFIER221);
            			    			adaptor.AddChild(root_0, IDENTIFIER221_tree);
            			    		}
            			    		// Vnvd.g:398:33: ( LPAREN argument_list RPAREN )?
            			    		int alt50 = 2;
            			    		int LA50_0 = input.LA(1);

            			    		if ( (LA50_0 == LPAREN) )
            			    		{
            			    		    alt50 = 1;
            			    		}
            			    		switch (alt50) 
            			    		{
            			    		    case 1 :
            			    		        // Vnvd.g:398:34: LPAREN argument_list RPAREN
            			    		        {
            			    		        	LPAREN222=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_invocation_or_load_expression2789); if (state.failed) return retval;
            			    		        	PushFollow(FOLLOW_argument_list_in_invocation_or_load_expression2792);
            			    		        	argument_list223 = argument_list();
            			    		        	state.followingStackPointer--;
            			    		        	if (state.failed) return retval;
            			    		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, argument_list223.Tree);
            			    		        	RPAREN224=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_invocation_or_load_expression2794); if (state.failed) return retval;

            			    		        }
            			    		        break;

            			    		}


            			    	}


            			    }
            			    break;
            			case 2 :
            			    // Vnvd.g:398:69: ( LBRACKET expression RBRACKET )
            			    {
            			    	// Vnvd.g:398:69: ( LBRACKET expression RBRACKET )
            			    	// Vnvd.g:398:70: LBRACKET expression RBRACKET
            			    	{
            			    		LBRACKET225=(IToken)Match(input,LBRACKET,FOLLOW_LBRACKET_in_invocation_or_load_expression2803); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{LBRACKET225_tree = (object)adaptor.Create(LBRACKET225);
            			    			root_0 = (object)adaptor.BecomeRoot(LBRACKET225_tree, root_0);
            			    		}
            			    		PushFollow(FOLLOW_expression_in_invocation_or_load_expression2806);
            			    		expression226 = expression();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression226.Tree);
            			    		RBRACKET227=(IToken)Match(input,RBRACKET,FOLLOW_RBRACKET_in_invocation_or_load_expression2808); if (state.failed) return retval;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop51;
            	    }
            	} while (true);

            	loop51:
            		;	// Stops C# compiler whining that label 'loop51' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "invocation_or_load_expression"

    public class operand_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "operand"
    // Vnvd.g:401:1: operand : ( qualifier -> ^( USAGE qualifier ) | NUMBER | FLOAT | STRING | CHAR | TRUE | FALSE | NULL | THIS | BASE | ( NEW qualifier LPAREN )=> object_creation_expression | ( NEW qualifier LBRACKET )=> array_creation_expression | ( NEW qualifier LCURLYBRACE )=> array_creation_expression_elemented | ( READ LPAREN IDENTIFIER RPAREN )=> READ LPAREN IDENTIFIER RPAREN -> ^( READ IDENTIFIER ) | READ LPAREN IDENTIFIER ( COMMA IDENTIFIER )+ RPAREN -> ^( SCOPEEXPR ( ^( READVOID IDENTIFIER ) )+ ) | ( WRITE LPAREN expression RPAREN )=> WRITE LPAREN expression RPAREN -> ^( WRITE expression ) | WRITE LPAREN expression ( COMMA expression )+ RPAREN -> ^( SCOPEEXPR ( ^( WRITEVOID expression ) )+ ) | LPAREN expression RPAREN -> ^( EXPRBLOCK expression ) | block_expression );
    public VnvdParser.operand_return operand() // throws RecognitionException [1]
    {   
        VnvdParser.operand_return retval = new VnvdParser.operand_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NUMBER229 = null;
        IToken FLOAT230 = null;
        IToken STRING231 = null;
        IToken CHAR232 = null;
        IToken TRUE233 = null;
        IToken FALSE234 = null;
        IToken NULL235 = null;
        IToken THIS236 = null;
        IToken BASE237 = null;
        IToken READ241 = null;
        IToken LPAREN242 = null;
        IToken IDENTIFIER243 = null;
        IToken RPAREN244 = null;
        IToken READ245 = null;
        IToken LPAREN246 = null;
        IToken IDENTIFIER247 = null;
        IToken COMMA248 = null;
        IToken IDENTIFIER249 = null;
        IToken RPAREN250 = null;
        IToken WRITE251 = null;
        IToken LPAREN252 = null;
        IToken RPAREN254 = null;
        IToken WRITE255 = null;
        IToken LPAREN256 = null;
        IToken COMMA258 = null;
        IToken RPAREN260 = null;
        IToken LPAREN261 = null;
        IToken RPAREN263 = null;
        VnvdParser.qualifier_return qualifier228 = default(VnvdParser.qualifier_return);

        VnvdParser.object_creation_expression_return object_creation_expression238 = default(VnvdParser.object_creation_expression_return);

        VnvdParser.array_creation_expression_return array_creation_expression239 = default(VnvdParser.array_creation_expression_return);

        VnvdParser.array_creation_expression_elemented_return array_creation_expression_elemented240 = default(VnvdParser.array_creation_expression_elemented_return);

        VnvdParser.expression_return expression253 = default(VnvdParser.expression_return);

        VnvdParser.expression_return expression257 = default(VnvdParser.expression_return);

        VnvdParser.expression_return expression259 = default(VnvdParser.expression_return);

        VnvdParser.expression_return expression262 = default(VnvdParser.expression_return);

        VnvdParser.block_expression_return block_expression264 = default(VnvdParser.block_expression_return);


        object NUMBER229_tree=null;
        object FLOAT230_tree=null;
        object STRING231_tree=null;
        object CHAR232_tree=null;
        object TRUE233_tree=null;
        object FALSE234_tree=null;
        object NULL235_tree=null;
        object THIS236_tree=null;
        object BASE237_tree=null;
        object READ241_tree=null;
        object LPAREN242_tree=null;
        object IDENTIFIER243_tree=null;
        object RPAREN244_tree=null;
        object READ245_tree=null;
        object LPAREN246_tree=null;
        object IDENTIFIER247_tree=null;
        object COMMA248_tree=null;
        object IDENTIFIER249_tree=null;
        object RPAREN250_tree=null;
        object WRITE251_tree=null;
        object LPAREN252_tree=null;
        object RPAREN254_tree=null;
        object WRITE255_tree=null;
        object LPAREN256_tree=null;
        object COMMA258_tree=null;
        object RPAREN260_tree=null;
        object LPAREN261_tree=null;
        object RPAREN263_tree=null;
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_READ = new RewriteRuleTokenStream(adaptor,"token READ");
        RewriteRuleTokenStream stream_WRITE = new RewriteRuleTokenStream(adaptor,"token WRITE");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:402:2: ( qualifier -> ^( USAGE qualifier ) | NUMBER | FLOAT | STRING | CHAR | TRUE | FALSE | NULL | THIS | BASE | ( NEW qualifier LPAREN )=> object_creation_expression | ( NEW qualifier LBRACKET )=> array_creation_expression | ( NEW qualifier LCURLYBRACE )=> array_creation_expression_elemented | ( READ LPAREN IDENTIFIER RPAREN )=> READ LPAREN IDENTIFIER RPAREN -> ^( READ IDENTIFIER ) | READ LPAREN IDENTIFIER ( COMMA IDENTIFIER )+ RPAREN -> ^( SCOPEEXPR ( ^( READVOID IDENTIFIER ) )+ ) | ( WRITE LPAREN expression RPAREN )=> WRITE LPAREN expression RPAREN -> ^( WRITE expression ) | WRITE LPAREN expression ( COMMA expression )+ RPAREN -> ^( SCOPEEXPR ( ^( WRITEVOID expression ) )+ ) | LPAREN expression RPAREN -> ^( EXPRBLOCK expression ) | block_expression )
            int alt54 = 19;
            alt54 = dfa54.Predict(input);
            switch (alt54) 
            {
                case 1 :
                    // Vnvd.g:402:4: qualifier
                    {
                    	PushFollow(FOLLOW_qualifier_in_operand2824);
                    	qualifier228 = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_qualifier.Add(qualifier228.Tree);


                    	// AST REWRITE
                    	// elements:          qualifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 403:2: -> ^( USAGE qualifier )
                    	{
                    	    // Vnvd.g:403:6: ^( USAGE qualifier )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(USAGE, "USAGE"), root_1);

                    	    adaptor.AddChild(root_1, stream_qualifier.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Vnvd.g:404:4: NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	NUMBER229=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_operand2839); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER229_tree = (object)adaptor.Create(NUMBER229);
                    		adaptor.AddChild(root_0, NUMBER229_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Vnvd.g:405:4: FLOAT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FLOAT230=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_operand2844); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FLOAT230_tree = (object)adaptor.Create(FLOAT230);
                    		adaptor.AddChild(root_0, FLOAT230_tree);
                    	}

                    }
                    break;
                case 4 :
                    // Vnvd.g:406:4: STRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	STRING231=(IToken)Match(input,STRING,FOLLOW_STRING_in_operand2849); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRING231_tree = (object)adaptor.Create(STRING231);
                    		adaptor.AddChild(root_0, STRING231_tree);
                    	}

                    }
                    break;
                case 5 :
                    // Vnvd.g:407:4: CHAR
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CHAR232=(IToken)Match(input,CHAR,FOLLOW_CHAR_in_operand2854); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{CHAR232_tree = (object)adaptor.Create(CHAR232);
                    		adaptor.AddChild(root_0, CHAR232_tree);
                    	}

                    }
                    break;
                case 6 :
                    // Vnvd.g:408:4: TRUE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	TRUE233=(IToken)Match(input,TRUE,FOLLOW_TRUE_in_operand2859); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{TRUE233_tree = (object)adaptor.Create(TRUE233);
                    		adaptor.AddChild(root_0, TRUE233_tree);
                    	}

                    }
                    break;
                case 7 :
                    // Vnvd.g:409:4: FALSE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FALSE234=(IToken)Match(input,FALSE,FOLLOW_FALSE_in_operand2864); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FALSE234_tree = (object)adaptor.Create(FALSE234);
                    		adaptor.AddChild(root_0, FALSE234_tree);
                    	}

                    }
                    break;
                case 8 :
                    // Vnvd.g:410:4: NULL
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	NULL235=(IToken)Match(input,NULL,FOLLOW_NULL_in_operand2869); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NULL235_tree = (object)adaptor.Create(NULL235);
                    		adaptor.AddChild(root_0, NULL235_tree);
                    	}

                    }
                    break;
                case 9 :
                    // Vnvd.g:411:4: THIS
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	THIS236=(IToken)Match(input,THIS,FOLLOW_THIS_in_operand2874); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{THIS236_tree = (object)adaptor.Create(THIS236);
                    		adaptor.AddChild(root_0, THIS236_tree);
                    	}

                    }
                    break;
                case 10 :
                    // Vnvd.g:412:4: BASE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BASE237=(IToken)Match(input,BASE,FOLLOW_BASE_in_operand2879); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BASE237_tree = (object)adaptor.Create(BASE237);
                    		adaptor.AddChild(root_0, BASE237_tree);
                    	}

                    }
                    break;
                case 11 :
                    // Vnvd.g:413:4: ( NEW qualifier LPAREN )=> object_creation_expression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_object_creation_expression_in_operand2894);
                    	object_creation_expression238 = object_creation_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, object_creation_expression238.Tree);

                    }
                    break;
                case 12 :
                    // Vnvd.g:414:4: ( NEW qualifier LBRACKET )=> array_creation_expression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_array_creation_expression_in_operand2909);
                    	array_creation_expression239 = array_creation_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_creation_expression239.Tree);

                    }
                    break;
                case 13 :
                    // Vnvd.g:415:4: ( NEW qualifier LCURLYBRACE )=> array_creation_expression_elemented
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_array_creation_expression_elemented_in_operand2924);
                    	array_creation_expression_elemented240 = array_creation_expression_elemented();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_creation_expression_elemented240.Tree);

                    }
                    break;
                case 14 :
                    // Vnvd.g:416:4: ( READ LPAREN IDENTIFIER RPAREN )=> READ LPAREN IDENTIFIER RPAREN
                    {
                    	READ241=(IToken)Match(input,READ,FOLLOW_READ_in_operand2941); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_READ.Add(READ241);

                    	LPAREN242=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_operand2943); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN242);

                    	IDENTIFIER243=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_operand2945); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER243);

                    	RPAREN244=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_operand2947); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN244);



                    	// AST REWRITE
                    	// elements:          IDENTIFIER, READ
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 417:2: -> ^( READ IDENTIFIER )
                    	{
                    	    // Vnvd.g:417:5: ^( READ IDENTIFIER )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_READ.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 15 :
                    // Vnvd.g:418:4: READ LPAREN IDENTIFIER ( COMMA IDENTIFIER )+ RPAREN
                    {
                    	READ245=(IToken)Match(input,READ,FOLLOW_READ_in_operand2961); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_READ.Add(READ245);

                    	LPAREN246=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_operand2963); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN246);

                    	IDENTIFIER247=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_operand2965); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER247);

                    	// Vnvd.g:418:27: ( COMMA IDENTIFIER )+
                    	int cnt52 = 0;
                    	do 
                    	{
                    	    int alt52 = 2;
                    	    int LA52_0 = input.LA(1);

                    	    if ( (LA52_0 == COMMA) )
                    	    {
                    	        alt52 = 1;
                    	    }


                    	    switch (alt52) 
                    		{
                    			case 1 :
                    			    // Vnvd.g:418:28: COMMA IDENTIFIER
                    			    {
                    			    	COMMA248=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_operand2968); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA248);

                    			    	IDENTIFIER249=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_operand2970); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER249);


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt52 >= 1 ) goto loop52;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee52 =
                    		                new EarlyExitException(52, input);
                    		            throw eee52;
                    	    }
                    	    cnt52++;
                    	} while (true);

                    	loop52:
                    		;	// Stops C# compiler whining that label 'loop52' has no statements

                    	RPAREN250=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_operand2974); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN250);



                    	// AST REWRITE
                    	// elements:          IDENTIFIER
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 419:2: -> ^( SCOPEEXPR ( ^( READVOID IDENTIFIER ) )+ )
                    	{
                    	    // Vnvd.g:419:5: ^( SCOPEEXPR ( ^( READVOID IDENTIFIER ) )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SCOPEEXPR, "SCOPEEXPR"), root_1);

                    	    if ( !(stream_IDENTIFIER.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_IDENTIFIER.HasNext() )
                    	    {
                    	        // Vnvd.g:419:17: ^( READVOID IDENTIFIER )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(READVOID, "READVOID"), root_2);

                    	        adaptor.AddChild(root_2, stream_IDENTIFIER.NextNode());

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_IDENTIFIER.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 16 :
                    // Vnvd.g:420:4: ( WRITE LPAREN expression RPAREN )=> WRITE LPAREN expression RPAREN
                    {
                    	WRITE251=(IToken)Match(input,WRITE,FOLLOW_WRITE_in_operand3005); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_WRITE.Add(WRITE251);

                    	LPAREN252=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_operand3007); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN252);

                    	PushFollow(FOLLOW_expression_in_operand3009);
                    	expression253 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression253.Tree);
                    	RPAREN254=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_operand3011); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN254);



                    	// AST REWRITE
                    	// elements:          WRITE, expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 421:2: -> ^( WRITE expression )
                    	{
                    	    // Vnvd.g:421:5: ^( WRITE expression )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_WRITE.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 17 :
                    // Vnvd.g:422:4: WRITE LPAREN expression ( COMMA expression )+ RPAREN
                    {
                    	WRITE255=(IToken)Match(input,WRITE,FOLLOW_WRITE_in_operand3025); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_WRITE.Add(WRITE255);

                    	LPAREN256=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_operand3027); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN256);

                    	PushFollow(FOLLOW_expression_in_operand3029);
                    	expression257 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression257.Tree);
                    	// Vnvd.g:422:28: ( COMMA expression )+
                    	int cnt53 = 0;
                    	do 
                    	{
                    	    int alt53 = 2;
                    	    int LA53_0 = input.LA(1);

                    	    if ( (LA53_0 == COMMA) )
                    	    {
                    	        alt53 = 1;
                    	    }


                    	    switch (alt53) 
                    		{
                    			case 1 :
                    			    // Vnvd.g:422:29: COMMA expression
                    			    {
                    			    	COMMA258=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_operand3032); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA258);

                    			    	PushFollow(FOLLOW_expression_in_operand3034);
                    			    	expression259 = expression();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_expression.Add(expression259.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt53 >= 1 ) goto loop53;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee53 =
                    		                new EarlyExitException(53, input);
                    		            throw eee53;
                    	    }
                    	    cnt53++;
                    	} while (true);

                    	loop53:
                    		;	// Stops C# compiler whining that label 'loop53' has no statements

                    	RPAREN260=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_operand3038); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN260);



                    	// AST REWRITE
                    	// elements:          expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 423:2: -> ^( SCOPEEXPR ( ^( WRITEVOID expression ) )+ )
                    	{
                    	    // Vnvd.g:423:5: ^( SCOPEEXPR ( ^( WRITEVOID expression ) )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SCOPEEXPR, "SCOPEEXPR"), root_1);

                    	    if ( !(stream_expression.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_expression.HasNext() )
                    	    {
                    	        // Vnvd.g:423:17: ^( WRITEVOID expression )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(WRITEVOID, "WRITEVOID"), root_2);

                    	        adaptor.AddChild(root_2, stream_expression.NextTree());

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_expression.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 18 :
                    // Vnvd.g:424:4: LPAREN expression RPAREN
                    {
                    	LPAREN261=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_operand3057); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN261);

                    	PushFollow(FOLLOW_expression_in_operand3059);
                    	expression262 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression262.Tree);
                    	RPAREN263=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_operand3061); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN263);



                    	// AST REWRITE
                    	// elements:          expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 425:2: -> ^( EXPRBLOCK expression )
                    	{
                    	    // Vnvd.g:425:5: ^( EXPRBLOCK expression )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXPRBLOCK, "EXPRBLOCK"), root_1);

                    	    adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 19 :
                    // Vnvd.g:426:4: block_expression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_expression_in_operand3075);
                    	block_expression264 = block_expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block_expression264.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "operand"

    public class block_expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "block_expression"
    // Vnvd.g:429:1: block_expression : LCURLYBRACE ( statement )* RCURLYBRACE -> ^( SLIST ( statement )* ) ;
    public VnvdParser.block_expression_return block_expression() // throws RecognitionException [1]
    {   
        VnvdParser.block_expression_return retval = new VnvdParser.block_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LCURLYBRACE265 = null;
        IToken RCURLYBRACE267 = null;
        VnvdParser.statement_return statement266 = default(VnvdParser.statement_return);


        object LCURLYBRACE265_tree=null;
        object RCURLYBRACE267_tree=null;
        RewriteRuleTokenStream stream_LCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token LCURLYBRACE");
        RewriteRuleTokenStream stream_RCURLYBRACE = new RewriteRuleTokenStream(adaptor,"token RCURLYBRACE");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // Vnvd.g:430:2: ( LCURLYBRACE ( statement )* RCURLYBRACE -> ^( SLIST ( statement )* ) )
            // Vnvd.g:430:4: LCURLYBRACE ( statement )* RCURLYBRACE
            {
            	LCURLYBRACE265=(IToken)Match(input,LCURLYBRACE,FOLLOW_LCURLYBRACE_in_block_expression3087); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LCURLYBRACE.Add(LCURLYBRACE265);

            	// Vnvd.g:430:16: ( statement )*
            	do 
            	{
            	    int alt55 = 2;
            	    alt55 = dfa55.Predict(input);
            	    switch (alt55) 
            		{
            			case 1 :
            			    // Vnvd.g:430:16: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block_expression3089);
            			    	statement266 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(statement266.Tree);

            			    }
            			    break;

            			default:
            			    goto loop55;
            	    }
            	} while (true);

            	loop55:
            		;	// Stops C# compiler whining that label 'loop55' has no statements

            	RCURLYBRACE267=(IToken)Match(input,RCURLYBRACE,FOLLOW_RCURLYBRACE_in_block_expression3092); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RCURLYBRACE.Add(RCURLYBRACE267);



            	// AST REWRITE
            	// elements:          statement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 431:2: -> ^( SLIST ( statement )* )
            	{
            	    // Vnvd.g:431:5: ^( SLIST ( statement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SLIST, "SLIST"), root_1);

            	    // Vnvd.g:431:13: ( statement )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_statement.NextTree());

            	    }
            	    stream_statement.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "block_expression"

    public class parameter_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parameter_list"
    // Vnvd.g:434:1: parameter_list : ( qualifier IDENTIFIER ( COMMA qualifier IDENTIFIER )* )? -> ^( PARAMETER ( qualifier IDENTIFIER )* ) ;
    public VnvdParser.parameter_list_return parameter_list() // throws RecognitionException [1]
    {   
        VnvdParser.parameter_list_return retval = new VnvdParser.parameter_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER269 = null;
        IToken COMMA270 = null;
        IToken IDENTIFIER272 = null;
        VnvdParser.qualifier_return qualifier268 = default(VnvdParser.qualifier_return);

        VnvdParser.qualifier_return qualifier271 = default(VnvdParser.qualifier_return);


        object IDENTIFIER269_tree=null;
        object COMMA270_tree=null;
        object IDENTIFIER272_tree=null;
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");
        RewriteRuleSubtreeStream stream_qualifier = new RewriteRuleSubtreeStream(adaptor,"rule qualifier");
        try 
    	{
            // Vnvd.g:435:2: ( ( qualifier IDENTIFIER ( COMMA qualifier IDENTIFIER )* )? -> ^( PARAMETER ( qualifier IDENTIFIER )* ) )
            // Vnvd.g:435:4: ( qualifier IDENTIFIER ( COMMA qualifier IDENTIFIER )* )?
            {
            	// Vnvd.g:435:4: ( qualifier IDENTIFIER ( COMMA qualifier IDENTIFIER )* )?
            	int alt57 = 2;
            	int LA57_0 = input.LA(1);

            	if ( (LA57_0 == IDENTIFIER) )
            	{
            	    alt57 = 1;
            	}
            	switch (alt57) 
            	{
            	    case 1 :
            	        // Vnvd.g:435:5: qualifier IDENTIFIER ( COMMA qualifier IDENTIFIER )*
            	        {
            	        	PushFollow(FOLLOW_qualifier_in_parameter_list3114);
            	        	qualifier268 = qualifier();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_qualifier.Add(qualifier268.Tree);
            	        	IDENTIFIER269=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_parameter_list3116); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER269);

            	        	// Vnvd.g:435:26: ( COMMA qualifier IDENTIFIER )*
            	        	do 
            	        	{
            	        	    int alt56 = 2;
            	        	    int LA56_0 = input.LA(1);

            	        	    if ( (LA56_0 == COMMA) )
            	        	    {
            	        	        alt56 = 1;
            	        	    }


            	        	    switch (alt56) 
            	        		{
            	        			case 1 :
            	        			    // Vnvd.g:435:27: COMMA qualifier IDENTIFIER
            	        			    {
            	        			    	COMMA270=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_parameter_list3119); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA270);

            	        			    	PushFollow(FOLLOW_qualifier_in_parameter_list3121);
            	        			    	qualifier271 = qualifier();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_qualifier.Add(qualifier271.Tree);
            	        			    	IDENTIFIER272=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_parameter_list3123); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER272);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop56;
            	        	    }
            	        	} while (true);

            	        	loop56:
            	        		;	// Stops C# compiler whining that label 'loop56' has no statements


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          qualifier, IDENTIFIER
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 436:2: -> ^( PARAMETER ( qualifier IDENTIFIER )* )
            	{
            	    // Vnvd.g:436:5: ^( PARAMETER ( qualifier IDENTIFIER )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETER, "PARAMETER"), root_1);

            	    // Vnvd.g:436:17: ( qualifier IDENTIFIER )*
            	    while ( stream_qualifier.HasNext() || stream_IDENTIFIER.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_qualifier.NextTree());
            	        adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());

            	    }
            	    stream_qualifier.Reset();
            	    stream_IDENTIFIER.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parameter_list"

    public class argument_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "argument_list"
    // Vnvd.g:439:1: argument_list : ( expression ( COMMA expression )* )? -> ^( ALIST ( ^( ARGUMENT expression ) )* ) ;
    public VnvdParser.argument_list_return argument_list() // throws RecognitionException [1]
    {   
        VnvdParser.argument_list_return retval = new VnvdParser.argument_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA274 = null;
        VnvdParser.expression_return expression273 = default(VnvdParser.expression_return);

        VnvdParser.expression_return expression275 = default(VnvdParser.expression_return);


        object COMMA274_tree=null;
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
            // Vnvd.g:440:2: ( ( expression ( COMMA expression )* )? -> ^( ALIST ( ^( ARGUMENT expression ) )* ) )
            // Vnvd.g:440:4: ( expression ( COMMA expression )* )?
            {
            	// Vnvd.g:440:4: ( expression ( COMMA expression )* )?
            	int alt59 = 2;
            	alt59 = dfa59.Predict(input);
            	switch (alt59) 
            	{
            	    case 1 :
            	        // Vnvd.g:440:5: expression ( COMMA expression )*
            	        {
            	        	PushFollow(FOLLOW_expression_in_argument_list3153);
            	        	expression273 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression273.Tree);
            	        	// Vnvd.g:440:16: ( COMMA expression )*
            	        	do 
            	        	{
            	        	    int alt58 = 2;
            	        	    int LA58_0 = input.LA(1);

            	        	    if ( (LA58_0 == COMMA) )
            	        	    {
            	        	        alt58 = 1;
            	        	    }


            	        	    switch (alt58) 
            	        		{
            	        			case 1 :
            	        			    // Vnvd.g:440:17: COMMA expression
            	        			    {
            	        			    	COMMA274=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_argument_list3156); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA274);

            	        			    	PushFollow(FOLLOW_expression_in_argument_list3158);
            	        			    	expression275 = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_expression.Add(expression275.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop58;
            	        	    }
            	        	} while (true);

            	        	loop58:
            	        		;	// Stops C# compiler whining that label 'loop58' has no statements


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 441:2: -> ^( ALIST ( ^( ARGUMENT expression ) )* )
            	{
            	    // Vnvd.g:441:5: ^( ALIST ( ^( ARGUMENT expression ) )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ALIST, "ALIST"), root_1);

            	    // Vnvd.g:441:13: ( ^( ARGUMENT expression ) )*
            	    while ( stream_expression.HasNext() )
            	    {
            	        // Vnvd.g:441:13: ^( ARGUMENT expression )
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARGUMENT, "ARGUMENT"), root_2);

            	        adaptor.AddChild(root_2, stream_expression.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "argument_list"

    public class type_qualifier_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "type_qualifier"
    // Vnvd.g:444:1: type_qualifier : ( VOID | qualifier );
    public VnvdParser.type_qualifier_return type_qualifier() // throws RecognitionException [1]
    {   
        VnvdParser.type_qualifier_return retval = new VnvdParser.type_qualifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VOID276 = null;
        VnvdParser.qualifier_return qualifier277 = default(VnvdParser.qualifier_return);


        object VOID276_tree=null;

        try 
    	{
            // Vnvd.g:445:2: ( VOID | qualifier )
            int alt60 = 2;
            int LA60_0 = input.LA(1);

            if ( (LA60_0 == VOID) )
            {
                alt60 = 1;
            }
            else if ( (LA60_0 == IDENTIFIER) )
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
                    // Vnvd.g:445:4: VOID
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	VOID276=(IToken)Match(input,VOID,FOLLOW_VOID_in_type_qualifier3188); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{VOID276_tree = (object)adaptor.Create(VOID276);
                    		adaptor.AddChild(root_0, VOID276_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Vnvd.g:446:4: qualifier
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_qualifier_in_type_qualifier3193);
                    	qualifier277 = qualifier();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, qualifier277.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type_qualifier"

    public class qualifier_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "qualifier"
    // Vnvd.g:449:1: qualifier : ( ( IDENTIFIER ( PERIOD IDENTIFIER )* ( LBRACKET RBRACKET ) )=> ( IDENTIFIER ( PERIOD IDENTIFIER )* ( LBRACKET RBRACKET ) ) -> ^( FQUALIFIER ( IDENTIFIER )+ ARRAY ) | IDENTIFIER ( PERIOD IDENTIFIER )* -> ^( FQUALIFIER ( IDENTIFIER )+ ) );
    public VnvdParser.qualifier_return qualifier() // throws RecognitionException [1]
    {   
        VnvdParser.qualifier_return retval = new VnvdParser.qualifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER278 = null;
        IToken PERIOD279 = null;
        IToken IDENTIFIER280 = null;
        IToken LBRACKET281 = null;
        IToken RBRACKET282 = null;
        IToken IDENTIFIER283 = null;
        IToken PERIOD284 = null;
        IToken IDENTIFIER285 = null;

        object IDENTIFIER278_tree=null;
        object PERIOD279_tree=null;
        object IDENTIFIER280_tree=null;
        object LBRACKET281_tree=null;
        object RBRACKET282_tree=null;
        object IDENTIFIER283_tree=null;
        object PERIOD284_tree=null;
        object IDENTIFIER285_tree=null;
        RewriteRuleTokenStream stream_LBRACKET = new RewriteRuleTokenStream(adaptor,"token LBRACKET");
        RewriteRuleTokenStream stream_RBRACKET = new RewriteRuleTokenStream(adaptor,"token RBRACKET");
        RewriteRuleTokenStream stream_PERIOD = new RewriteRuleTokenStream(adaptor,"token PERIOD");
        RewriteRuleTokenStream stream_IDENTIFIER = new RewriteRuleTokenStream(adaptor,"token IDENTIFIER");

        try 
    	{
            // Vnvd.g:450:2: ( ( IDENTIFIER ( PERIOD IDENTIFIER )* ( LBRACKET RBRACKET ) )=> ( IDENTIFIER ( PERIOD IDENTIFIER )* ( LBRACKET RBRACKET ) ) -> ^( FQUALIFIER ( IDENTIFIER )+ ARRAY ) | IDENTIFIER ( PERIOD IDENTIFIER )* -> ^( FQUALIFIER ( IDENTIFIER )+ ) )
            int alt63 = 2;
            int LA63_0 = input.LA(1);

            if ( (LA63_0 == IDENTIFIER) )
            {
                int LA63_1 = input.LA(2);

                if ( (synpred12_Vnvd()) )
                {
                    alt63 = 1;
                }
                else if ( (true) )
                {
                    alt63 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d63s1 =
                        new NoViableAltException("", 63, 1, input);

                    throw nvae_d63s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d63s0 =
                    new NoViableAltException("", 63, 0, input);

                throw nvae_d63s0;
            }
            switch (alt63) 
            {
                case 1 :
                    // Vnvd.g:450:4: ( IDENTIFIER ( PERIOD IDENTIFIER )* ( LBRACKET RBRACKET ) )=> ( IDENTIFIER ( PERIOD IDENTIFIER )* ( LBRACKET RBRACKET ) )
                    {
                    	// Vnvd.g:450:61: ( IDENTIFIER ( PERIOD IDENTIFIER )* ( LBRACKET RBRACKET ) )
                    	// Vnvd.g:450:62: IDENTIFIER ( PERIOD IDENTIFIER )* ( LBRACKET RBRACKET )
                    	{
                    		IDENTIFIER278=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_qualifier3225); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER278);

                    		// Vnvd.g:450:73: ( PERIOD IDENTIFIER )*
                    		do 
                    		{
                    		    int alt61 = 2;
                    		    int LA61_0 = input.LA(1);

                    		    if ( (LA61_0 == PERIOD) )
                    		    {
                    		        alt61 = 1;
                    		    }


                    		    switch (alt61) 
                    			{
                    				case 1 :
                    				    // Vnvd.g:450:74: PERIOD IDENTIFIER
                    				    {
                    				    	PERIOD279=(IToken)Match(input,PERIOD,FOLLOW_PERIOD_in_qualifier3228); if (state.failed) return retval; 
                    				    	if ( (state.backtracking==0) ) stream_PERIOD.Add(PERIOD279);

                    				    	IDENTIFIER280=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_qualifier3230); if (state.failed) return retval; 
                    				    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER280);


                    				    }
                    				    break;

                    				default:
                    				    goto loop61;
                    		    }
                    		} while (true);

                    		loop61:
                    			;	// Stops C# compiler whining that label 'loop61' has no statements

                    		// Vnvd.g:450:94: ( LBRACKET RBRACKET )
                    		// Vnvd.g:450:95: LBRACKET RBRACKET
                    		{
                    			LBRACKET281=(IToken)Match(input,LBRACKET,FOLLOW_LBRACKET_in_qualifier3235); if (state.failed) return retval; 
                    			if ( (state.backtracking==0) ) stream_LBRACKET.Add(LBRACKET281);

                    			RBRACKET282=(IToken)Match(input,RBRACKET,FOLLOW_RBRACKET_in_qualifier3237); if (state.failed) return retval; 
                    			if ( (state.backtracking==0) ) stream_RBRACKET.Add(RBRACKET282);


                    		}


                    	}



                    	// AST REWRITE
                    	// elements:          IDENTIFIER
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 451:2: -> ^( FQUALIFIER ( IDENTIFIER )+ ARRAY )
                    	{
                    	    // Vnvd.g:451:5: ^( FQUALIFIER ( IDENTIFIER )+ ARRAY )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FQUALIFIER, "FQUALIFIER"), root_1);

                    	    if ( !(stream_IDENTIFIER.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_IDENTIFIER.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());

                    	    }
                    	    stream_IDENTIFIER.Reset();
                    	    adaptor.AddChild(root_1, (object)adaptor.Create(ARRAY, "ARRAY"));

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Vnvd.g:452:4: IDENTIFIER ( PERIOD IDENTIFIER )*
                    {
                    	IDENTIFIER283=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_qualifier3256); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER283);

                    	// Vnvd.g:452:15: ( PERIOD IDENTIFIER )*
                    	do 
                    	{
                    	    int alt62 = 2;
                    	    int LA62_0 = input.LA(1);

                    	    if ( (LA62_0 == PERIOD) )
                    	    {
                    	        alt62 = 1;
                    	    }


                    	    switch (alt62) 
                    		{
                    			case 1 :
                    			    // Vnvd.g:452:16: PERIOD IDENTIFIER
                    			    {
                    			    	PERIOD284=(IToken)Match(input,PERIOD,FOLLOW_PERIOD_in_qualifier3259); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_PERIOD.Add(PERIOD284);

                    			    	IDENTIFIER285=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_qualifier3261); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_IDENTIFIER.Add(IDENTIFIER285);


                    			    }
                    			    break;

                    			default:
                    			    goto loop62;
                    	    }
                    	} while (true);

                    	loop62:
                    		;	// Stops C# compiler whining that label 'loop62' has no statements



                    	// AST REWRITE
                    	// elements:          IDENTIFIER
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 453:2: -> ^( FQUALIFIER ( IDENTIFIER )+ )
                    	{
                    	    // Vnvd.g:453:5: ^( FQUALIFIER ( IDENTIFIER )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FQUALIFIER, "FQUALIFIER"), root_1);

                    	    if ( !(stream_IDENTIFIER.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_IDENTIFIER.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_IDENTIFIER.NextNode());

                    	    }
                    	    stream_IDENTIFIER.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "qualifier"

    public class access_modifier_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "access_modifier"
    // Vnvd.g:456:1: access_modifier : ( PRIVATE | PUBLIC | PROTECTED | INTERNAL );
    public VnvdParser.access_modifier_return access_modifier() // throws RecognitionException [1]
    {   
        VnvdParser.access_modifier_return retval = new VnvdParser.access_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set286 = null;

        object set286_tree=null;

        try 
    	{
            // Vnvd.g:457:2: ( PRIVATE | PUBLIC | PROTECTED | INTERNAL )
            // Vnvd.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set286 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PRIVATE && input.LA(1) <= INTERNAL) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set286));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "access_modifier"

    public class virtual_modifier_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "virtual_modifier"
    // Vnvd.g:460:1: virtual_modifier : ( VIRTUAL | OVERRIDE );
    public VnvdParser.virtual_modifier_return virtual_modifier() // throws RecognitionException [1]
    {   
        VnvdParser.virtual_modifier_return retval = new VnvdParser.virtual_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set287 = null;

        object set287_tree=null;

        try 
    	{
            // Vnvd.g:461:2: ( VIRTUAL | OVERRIDE )
            // Vnvd.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set287 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= VIRTUAL && input.LA(1) <= OVERRIDE) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set287));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "virtual_modifier"

    // $ANTLR start "synpred1_Vnvd"
    public void synpred1_Vnvd_fragment() {
        // Vnvd.g:233:4: ( method_mod_list type_qualifier IDENTIFIER LPAREN )
        // Vnvd.g:233:5: method_mod_list type_qualifier IDENTIFIER LPAREN
        {
        	PushFollow(FOLLOW_method_mod_list_in_synpred1_Vnvd1491);
        	method_mod_list();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_type_qualifier_in_synpred1_Vnvd1493);
        	type_qualifier();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_synpred1_Vnvd1495); if (state.failed) return ;
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred1_Vnvd1497); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Vnvd"

    // $ANTLR start "synpred2_Vnvd"
    public void synpred2_Vnvd_fragment() {
        // Vnvd.g:234:4: ( constructor_mod_list IDENTIFIER LPAREN )
        // Vnvd.g:234:5: constructor_mod_list IDENTIFIER LPAREN
        {
        	PushFollow(FOLLOW_constructor_mod_list_in_synpred2_Vnvd1508);
        	constructor_mod_list();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_synpred2_Vnvd1510); if (state.failed) return ;
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred2_Vnvd1512); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_Vnvd"

    // $ANTLR start "synpred3_Vnvd"
    public void synpred3_Vnvd_fragment() {
        // Vnvd.g:235:4: ( abstract_mod_list )
        // Vnvd.g:235:5: abstract_mod_list
        {
        	PushFollow(FOLLOW_abstract_mod_list_in_synpred3_Vnvd1523);
        	abstract_mod_list();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_Vnvd"

    // $ANTLR start "synpred4_Vnvd"
    public void synpred4_Vnvd_fragment() {
        // Vnvd.g:275:4: ( qualifier IDENTIFIER )
        // Vnvd.g:275:5: qualifier IDENTIFIER
        {
        	PushFollow(FOLLOW_qualifier_in_synpred4_Vnvd1816);
        	qualifier();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_synpred4_Vnvd1818); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_Vnvd"

    // $ANTLR start "synpred5_Vnvd"
    public void synpred5_Vnvd_fragment() {
        // Vnvd.g:297:4: ( qualifier IDENTIFIER BECOMES )
        // Vnvd.g:297:5: qualifier IDENTIFIER BECOMES
        {
        	PushFollow(FOLLOW_qualifier_in_synpred5_Vnvd1949);
        	qualifier();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_synpred5_Vnvd1951); if (state.failed) return ;
        	Match(input,BECOMES,FOLLOW_BECOMES_in_synpred5_Vnvd1953); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_Vnvd"

    // $ANTLR start "synpred6_Vnvd"
    public void synpred6_Vnvd_fragment() {
        // Vnvd.g:392:4: ( LPAREN qualifier RPAREN cast_expression )
        // Vnvd.g:392:5: LPAREN qualifier RPAREN cast_expression
        {
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred6_Vnvd2733); if (state.failed) return ;
        	PushFollow(FOLLOW_qualifier_in_synpred6_Vnvd2735);
        	qualifier();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred6_Vnvd2737); if (state.failed) return ;
        	PushFollow(FOLLOW_cast_expression_in_synpred6_Vnvd2739);
        	cast_expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_Vnvd"

    // $ANTLR start "synpred7_Vnvd"
    public void synpred7_Vnvd_fragment() {
        // Vnvd.g:413:4: ( NEW qualifier LPAREN )
        // Vnvd.g:413:5: NEW qualifier LPAREN
        {
        	Match(input,NEW,FOLLOW_NEW_in_synpred7_Vnvd2885); if (state.failed) return ;
        	PushFollow(FOLLOW_qualifier_in_synpred7_Vnvd2887);
        	qualifier();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred7_Vnvd2889); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_Vnvd"

    // $ANTLR start "synpred8_Vnvd"
    public void synpred8_Vnvd_fragment() {
        // Vnvd.g:414:4: ( NEW qualifier LBRACKET )
        // Vnvd.g:414:5: NEW qualifier LBRACKET
        {
        	Match(input,NEW,FOLLOW_NEW_in_synpred8_Vnvd2900); if (state.failed) return ;
        	PushFollow(FOLLOW_qualifier_in_synpred8_Vnvd2902);
        	qualifier();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,LBRACKET,FOLLOW_LBRACKET_in_synpred8_Vnvd2904); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_Vnvd"

    // $ANTLR start "synpred9_Vnvd"
    public void synpred9_Vnvd_fragment() {
        // Vnvd.g:415:4: ( NEW qualifier LCURLYBRACE )
        // Vnvd.g:415:5: NEW qualifier LCURLYBRACE
        {
        	Match(input,NEW,FOLLOW_NEW_in_synpred9_Vnvd2915); if (state.failed) return ;
        	PushFollow(FOLLOW_qualifier_in_synpred9_Vnvd2917);
        	qualifier();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,LCURLYBRACE,FOLLOW_LCURLYBRACE_in_synpred9_Vnvd2919); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_Vnvd"

    // $ANTLR start "synpred10_Vnvd"
    public void synpred10_Vnvd_fragment() {
        // Vnvd.g:416:4: ( READ LPAREN IDENTIFIER RPAREN )
        // Vnvd.g:416:5: READ LPAREN IDENTIFIER RPAREN
        {
        	Match(input,READ,FOLLOW_READ_in_synpred10_Vnvd2930); if (state.failed) return ;
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred10_Vnvd2932); if (state.failed) return ;
        	Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_synpred10_Vnvd2934); if (state.failed) return ;
        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred10_Vnvd2936); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred10_Vnvd"

    // $ANTLR start "synpred11_Vnvd"
    public void synpred11_Vnvd_fragment() {
        // Vnvd.g:420:4: ( WRITE LPAREN expression RPAREN )
        // Vnvd.g:420:5: WRITE LPAREN expression RPAREN
        {
        	Match(input,WRITE,FOLLOW_WRITE_in_synpred11_Vnvd2994); if (state.failed) return ;
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred11_Vnvd2996); if (state.failed) return ;
        	PushFollow(FOLLOW_expression_in_synpred11_Vnvd2998);
        	expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred11_Vnvd3000); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred11_Vnvd"

    // $ANTLR start "synpred12_Vnvd"
    public void synpred12_Vnvd_fragment() {
        // Vnvd.g:450:4: ( IDENTIFIER ( PERIOD IDENTIFIER )* ( LBRACKET RBRACKET ) )
        // Vnvd.g:450:5: IDENTIFIER ( PERIOD IDENTIFIER )* ( LBRACKET RBRACKET )
        {
        	Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_synpred12_Vnvd3206); if (state.failed) return ;
        	// Vnvd.g:450:16: ( PERIOD IDENTIFIER )*
        	do 
        	{
        	    int alt64 = 2;
        	    int LA64_0 = input.LA(1);

        	    if ( (LA64_0 == PERIOD) )
        	    {
        	        alt64 = 1;
        	    }


        	    switch (alt64) 
        		{
        			case 1 :
        			    // Vnvd.g:450:17: PERIOD IDENTIFIER
        			    {
        			    	Match(input,PERIOD,FOLLOW_PERIOD_in_synpred12_Vnvd3209); if (state.failed) return ;
        			    	Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_synpred12_Vnvd3211); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop64;
        	    }
        	} while (true);

        	loop64:
        		;	// Stops C# compiler whining that label 'loop64' has no statements

        	// Vnvd.g:450:37: ( LBRACKET RBRACKET )
        	// Vnvd.g:450:38: LBRACKET RBRACKET
        	{
        		Match(input,LBRACKET,FOLLOW_LBRACKET_in_synpred12_Vnvd3216); if (state.failed) return ;
        		Match(input,RBRACKET,FOLLOW_RBRACKET_in_synpred12_Vnvd3218); if (state.failed) return ;

        	}


        }
    }
    // $ANTLR end "synpred12_Vnvd"

    // Delegated rules

   	public bool synpred1_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_Vnvd_fragment(); // can never throw exception
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
   	public bool synpred6_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred6_Vnvd_fragment(); // can never throw exception
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
   	public bool synpred4_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_Vnvd_fragment(); // can never throw exception
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
   	public bool synpred5_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred5_Vnvd_fragment(); // can never throw exception
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
   	public bool synpred9_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_Vnvd_fragment(); // can never throw exception
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
   	public bool synpred7_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_Vnvd_fragment(); // can never throw exception
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
   	public bool synpred12_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred12_Vnvd_fragment(); // can never throw exception
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
   	public bool synpred11_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred11_Vnvd_fragment(); // can never throw exception
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
   	public bool synpred8_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_Vnvd_fragment(); // can never throw exception
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
   	public bool synpred2_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_Vnvd_fragment(); // can never throw exception
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
   	public bool synpred10_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred10_Vnvd_fragment(); // can never throw exception
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
   	public bool synpred3_Vnvd() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_Vnvd_fragment(); // can never throw exception
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


   	protected DFA19 dfa19;
   	protected DFA21 dfa21;
   	protected DFA29 dfa29;
   	protected DFA34 dfa34;
   	protected DFA30 dfa30;
   	protected DFA31 dfa31;
   	protected DFA33 dfa33;
   	protected DFA48 dfa48;
   	protected DFA49 dfa49;
   	protected DFA54 dfa54;
   	protected DFA55 dfa55;
   	protected DFA59 dfa59;
	private void InitializeCyclicDFAs()
	{
    	this.dfa19 = new DFA19(this);
    	this.dfa21 = new DFA21(this);
    	this.dfa29 = new DFA29(this);
    	this.dfa34 = new DFA34(this);
    	this.dfa30 = new DFA30(this);
    	this.dfa31 = new DFA31(this);
    	this.dfa33 = new DFA33(this);
    	this.dfa48 = new DFA48(this);
    	this.dfa49 = new DFA49(this);
    	this.dfa54 = new DFA54(this);
    	this.dfa55 = new DFA55(this);
    	this.dfa59 = new DFA59(this);
	    this.dfa19.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA19_SpecialStateTransition);
	    this.dfa49.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA49_SpecialStateTransition);
	    this.dfa54.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA54_SpecialStateTransition);
	}

    const string DFA19_eotS =
        "\x1b\uffff";
    const string DFA19_eofS =
        "\x1b\uffff";
    const string DFA19_minS =
        "\x01\x05\x01\x00\x19\uffff";
    const string DFA19_maxS =
        "\x01\x77\x01\x00\x19\uffff";
    const string DFA19_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x15\uffff\x01\x04\x01\x01";
    const string DFA19_specialS =
        "\x01\uffff\x01\x00\x19\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x01\x19\x01\x03\x03\uffff\x01\x03\x09\uffff\x02\x03\x0d\uffff"+
            "\x01\x03\x05\uffff\x01\x03\x02\uffff\x01\x03\x02\uffff\x02\x03"+
            "\x03\uffff\x01\x02\x04\x03\x09\uffff\x02\x03\x02\uffff\x01\x03"+
            "\x03\uffff\x02\x03\x27\uffff\x01\x01\x04\x03",
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
            ""
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "274:1: statement : ( ( qualifier IDENTIFIER )=> declaration_statement SEMICOLON | const_decl_statement SEMICOLON | expression SEMICOLON | SEMICOLON );"; }
        }

    }


    protected internal int DFA19_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA19_1 = input.LA(1);

                   	 
                   	int index19_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_Vnvd()) ) { s = 26; }

                   	else if ( (true) ) { s = 3; }

                   	 
                   	input.Seek(index19_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae19 =
            new NoViableAltException(dfa.Description, 19, _s, input);
        dfa.Error(nvae19);
        throw nvae19;
    }
    const string DFA21_eotS =
        "\x1b\uffff";
    const string DFA21_eofS =
        "\x1b\uffff";
    const string DFA21_minS =
        "\x01\x05\x1a\uffff";
    const string DFA21_maxS =
        "\x01\x77\x1a\uffff";
    const string DFA21_acceptS =
        "\x01\uffff\x01\x02\x01\x01\x18\uffff";
    const string DFA21_specialS =
        "\x1b\uffff}>";
    static readonly string[] DFA21_transitionS = {
            "\x02\x02\x01\x01\x02\uffff\x01\x02\x09\uffff\x02\x02\x0d\uffff"+
            "\x01\x02\x05\uffff\x01\x02\x02\uffff\x01\x02\x02\uffff\x02\x02"+
            "\x03\uffff\x05\x02\x09\uffff\x02\x02\x02\uffff\x01\x02\x03\uffff"+
            "\x02\x02\x27\uffff\x05\x02",
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

    static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
    static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
    static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
    static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
    static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
    static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
    static readonly short[][] DFA21_transition = DFA.UnpackEncodedStringArray(DFA21_transitionS);

    protected class DFA21 : DFA
    {
        public DFA21(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 292:4: ( statement )+"; }
        }

    }

    const string DFA29_eotS =
        "\x0d\uffff";
    const string DFA29_eofS =
        "\x0d\uffff";
    const string DFA29_minS =
        "\x01\x05\x0c\uffff";
    const string DFA29_maxS =
        "\x01\x49\x0c\uffff";
    const string DFA29_acceptS =
        "\x01\uffff\x03\x01\x01\x02\x08\uffff";
    const string DFA29_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA29_transitionS = {
            "\x01\x04\x01\uffff\x02\x04\x02\uffff\x01\x04\x01\uffff\x01"+
            "\x04\x03\uffff\x01\x02\x01\x03\x01\x01\x1a\uffff\x01\x04\x18"+
            "\uffff\x03\x04",
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

    static readonly short[] DFA29_eot = DFA.UnpackEncodedString(DFA29_eotS);
    static readonly short[] DFA29_eof = DFA.UnpackEncodedString(DFA29_eofS);
    static readonly char[] DFA29_min = DFA.UnpackEncodedStringToUnsignedChars(DFA29_minS);
    static readonly char[] DFA29_max = DFA.UnpackEncodedStringToUnsignedChars(DFA29_maxS);
    static readonly short[] DFA29_accept = DFA.UnpackEncodedString(DFA29_acceptS);
    static readonly short[] DFA29_special = DFA.UnpackEncodedString(DFA29_specialS);
    static readonly short[][] DFA29_transition = DFA.UnpackEncodedStringArray(DFA29_transitionS);

    protected class DFA29 : DFA
    {
        public DFA29(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 29;
            this.eot = DFA29_eot;
            this.eof = DFA29_eof;
            this.min = DFA29_min;
            this.max = DFA29_max;
            this.accept = DFA29_accept;
            this.special = DFA29_special;
            this.transition = DFA29_transition;

        }

        override public string Description
        {
            get { return "334:26: ( options {greedy=true; } : (b= BECOMES | ADDEVENT | REMEVENT ) t2= assignment_expression )?"; }
        }

    }

    const string DFA34_eotS =
        "\x18\uffff";
    const string DFA34_eofS =
        "\x18\uffff";
    const string DFA34_minS =
        "\x01\x06\x17\uffff";
    const string DFA34_maxS =
        "\x01\x77\x17\uffff";
    const string DFA34_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x11"+
        "\uffff";
    const string DFA34_specialS =
        "\x18\uffff}>";
    static readonly string[] DFA34_transitionS = {
            "\x01\x06\x03\uffff\x01\x06\x09\uffff\x02\x06\x0d\uffff\x01"+
            "\x06\x05\uffff\x01\x06\x02\uffff\x01\x04\x02\uffff\x01\x01\x01"+
            "\x02\x04\uffff\x04\x06\x09\uffff\x02\x06\x02\uffff\x01\x03\x03"+
            "\uffff\x01\x05\x01\x06\x27\uffff\x05\x06",
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

    static readonly short[] DFA34_eot = DFA.UnpackEncodedString(DFA34_eotS);
    static readonly short[] DFA34_eof = DFA.UnpackEncodedString(DFA34_eofS);
    static readonly char[] DFA34_min = DFA.UnpackEncodedStringToUnsignedChars(DFA34_minS);
    static readonly char[] DFA34_max = DFA.UnpackEncodedStringToUnsignedChars(DFA34_maxS);
    static readonly short[] DFA34_accept = DFA.UnpackEncodedString(DFA34_acceptS);
    static readonly short[] DFA34_special = DFA.UnpackEncodedString(DFA34_specialS);
    static readonly short[][] DFA34_transition = DFA.UnpackEncodedStringArray(DFA34_transitionS);

    protected class DFA34 : DFA
    {
        public DFA34(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 34;
            this.eot = DFA34_eot;
            this.eof = DFA34_eof;
            this.min = DFA34_min;
            this.max = DFA34_max;
            this.accept = DFA34_accept;
            this.special = DFA34_special;
            this.transition = DFA34_transition;

        }

        override public string Description
        {
            get { return "337:1: control_expression : ( WHILE LPAREN scope_expr RPAREN expression -> ^( WHILE scope_expr expression ) | FOR LPAREN type_= qualifier IDENTIFIER IN expression RPAREN do_= expression -> ^( FOR ^( LOCAL $type_ IDENTIFIER ) expression $do_) | TRY expression ( finally_block | ( options {greedy=true; } : ( catch_block )+ ( finally_block )? ) ) -> ^( TRY expression ( catch_block )* ( finally_block )? ) | IF LPAREN scope_expr RPAREN THEN expression ( options {greedy=true; } : ELSE expression )? -> ^( IF scope_expr expression ( expression )? ) | THROW expression -> ^( THROW expression ) | conditional_or_operator_expression );"; }
        }

    }

    const string DFA30_eotS =
        "\x0d\uffff";
    const string DFA30_eofS =
        "\x0d\uffff";
    const string DFA30_minS =
        "\x01\x05\x0c\uffff";
    const string DFA30_maxS =
        "\x01\x49\x0c\uffff";
    const string DFA30_acceptS =
        "\x01\uffff\x01\x02\x04\uffff\x02\x01\x05\uffff";
    const string DFA30_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA30_transitionS = {
            "\x01\x01\x01\uffff\x02\x01\x02\uffff\x01\x01\x01\uffff\x01"+
            "\x01\x03\uffff\x03\x01\x1a\uffff\x01\x01\x18\uffff\x01\x06\x01"+
            "\x07\x01\x01",
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

    static readonly short[] DFA30_eot = DFA.UnpackEncodedString(DFA30_eotS);
    static readonly short[] DFA30_eof = DFA.UnpackEncodedString(DFA30_eofS);
    static readonly char[] DFA30_min = DFA.UnpackEncodedStringToUnsignedChars(DFA30_minS);
    static readonly char[] DFA30_max = DFA.UnpackEncodedStringToUnsignedChars(DFA30_maxS);
    static readonly short[] DFA30_accept = DFA.UnpackEncodedString(DFA30_acceptS);
    static readonly short[] DFA30_special = DFA.UnpackEncodedString(DFA30_specialS);
    static readonly short[][] DFA30_transition = DFA.UnpackEncodedStringArray(DFA30_transitionS);

    protected class DFA30 : DFA
    {
        public DFA30(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 30;
            this.eot = DFA30_eot;
            this.eof = DFA30_eof;
            this.min = DFA30_min;
            this.max = DFA30_max;
            this.accept = DFA30_accept;
            this.special = DFA30_special;
            this.transition = DFA30_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 342:62: ( catch_block )+"; }
        }

    }

    const string DFA31_eotS =
        "\x0d\uffff";
    const string DFA31_eofS =
        "\x0d\uffff";
    const string DFA31_minS =
        "\x01\x05\x0c\uffff";
    const string DFA31_maxS =
        "\x01\x49\x0c\uffff";
    const string DFA31_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x0a\uffff";
    const string DFA31_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA31_transitionS = {
            "\x01\x02\x01\uffff\x02\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x03\uffff\x03\x02\x1a\uffff\x01\x02\x18\uffff\x02\x02\x01"+
            "\x01",
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

    static readonly short[] DFA31_eot = DFA.UnpackEncodedString(DFA31_eotS);
    static readonly short[] DFA31_eof = DFA.UnpackEncodedString(DFA31_eofS);
    static readonly char[] DFA31_min = DFA.UnpackEncodedStringToUnsignedChars(DFA31_minS);
    static readonly char[] DFA31_max = DFA.UnpackEncodedStringToUnsignedChars(DFA31_maxS);
    static readonly short[] DFA31_accept = DFA.UnpackEncodedString(DFA31_acceptS);
    static readonly short[] DFA31_special = DFA.UnpackEncodedString(DFA31_specialS);
    static readonly short[][] DFA31_transition = DFA.UnpackEncodedStringArray(DFA31_transitionS);

    protected class DFA31 : DFA
    {
        public DFA31(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 31;
            this.eot = DFA31_eot;
            this.eof = DFA31_eof;
            this.min = DFA31_min;
            this.max = DFA31_max;
            this.accept = DFA31_accept;
            this.special = DFA31_special;
            this.transition = DFA31_transition;

        }

        override public string Description
        {
            get { return "342:75: ( finally_block )?"; }
        }

    }

    const string DFA33_eotS =
        "\x0d\uffff";
    const string DFA33_eofS =
        "\x0d\uffff";
    const string DFA33_minS =
        "\x01\x05\x0c\uffff";
    const string DFA33_maxS =
        "\x01\x49\x0c\uffff";
    const string DFA33_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x0a\uffff";
    const string DFA33_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA33_transitionS = {
            "\x01\x02\x01\uffff\x02\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x03\uffff\x03\x02\x1a\uffff\x01\x01\x18\uffff\x03\x02",
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

    static readonly short[] DFA33_eot = DFA.UnpackEncodedString(DFA33_eotS);
    static readonly short[] DFA33_eof = DFA.UnpackEncodedString(DFA33_eofS);
    static readonly char[] DFA33_min = DFA.UnpackEncodedStringToUnsignedChars(DFA33_minS);
    static readonly char[] DFA33_max = DFA.UnpackEncodedStringToUnsignedChars(DFA33_maxS);
    static readonly short[] DFA33_accept = DFA.UnpackEncodedString(DFA33_acceptS);
    static readonly short[] DFA33_special = DFA.UnpackEncodedString(DFA33_specialS);
    static readonly short[][] DFA33_transition = DFA.UnpackEncodedStringArray(DFA33_transitionS);

    protected class DFA33 : DFA
    {
        public DFA33(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 33;
            this.eot = DFA33_eot;
            this.eof = DFA33_eof;
            this.min = DFA33_min;
            this.max = DFA33_max;
            this.accept = DFA33_accept;
            this.special = DFA33_special;
            this.transition = DFA33_transition;

        }

        override public string Description
        {
            get { return "344:48: ( options {greedy=true; } : ELSE expression )?"; }
        }

    }

    const string DFA48_eotS =
        "\x13\uffff";
    const string DFA48_eofS =
        "\x13\uffff";
    const string DFA48_minS =
        "\x01\x06\x12\uffff";
    const string DFA48_maxS =
        "\x01\x77\x12\uffff";
    const string DFA48_acceptS =
        "\x01\uffff\x01\x04\x0e\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA48_specialS =
        "\x13\uffff}>";
    static readonly string[] DFA48_transitionS = {
            "\x01\x01\x03\uffff\x01\x01\x09\uffff\x01\x11\x01\x12\x0d\uffff"+
            "\x01\x10\x05\uffff\x01\x01\x0b\uffff\x04\x01\x09\uffff\x02\x01"+
            "\x07\uffff\x01\x01\x27\uffff\x05\x01",
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

    static readonly short[] DFA48_eot = DFA.UnpackEncodedString(DFA48_eotS);
    static readonly short[] DFA48_eof = DFA.UnpackEncodedString(DFA48_eofS);
    static readonly char[] DFA48_min = DFA.UnpackEncodedStringToUnsignedChars(DFA48_minS);
    static readonly char[] DFA48_max = DFA.UnpackEncodedStringToUnsignedChars(DFA48_maxS);
    static readonly short[] DFA48_accept = DFA.UnpackEncodedString(DFA48_acceptS);
    static readonly short[] DFA48_special = DFA.UnpackEncodedString(DFA48_specialS);
    static readonly short[][] DFA48_transition = DFA.UnpackEncodedStringArray(DFA48_transitionS);

    protected class DFA48 : DFA
    {
        public DFA48(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 48;
            this.eot = DFA48_eot;
            this.eof = DFA48_eof;
            this.min = DFA48_min;
            this.max = DFA48_max;
            this.accept = DFA48_accept;
            this.special = DFA48_special;
            this.transition = DFA48_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 388:4: ( NOT | PLUS | MINUS )*"; }
        }

    }

    const string DFA49_eotS =
        "\x11\uffff";
    const string DFA49_eofS =
        "\x11\uffff";
    const string DFA49_minS =
        "\x01\x06\x01\x00\x0f\uffff";
    const string DFA49_maxS =
        "\x01\x77\x01\x00\x0f\uffff";
    const string DFA49_acceptS =
        "\x02\uffff\x01\x02\x0d\uffff\x01\x01";
    const string DFA49_specialS =
        "\x01\uffff\x01\x00\x0f\uffff}>";
    static readonly string[] DFA49_transitionS = {
            "\x01\x01\x03\uffff\x01\x02\x1e\uffff\x01\x02\x0b\uffff\x04"+
            "\x02\x09\uffff\x02\x02\x07\uffff\x01\x02\x27\uffff\x05\x02",
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
            ""
    };

    static readonly short[] DFA49_eot = DFA.UnpackEncodedString(DFA49_eotS);
    static readonly short[] DFA49_eof = DFA.UnpackEncodedString(DFA49_eofS);
    static readonly char[] DFA49_min = DFA.UnpackEncodedStringToUnsignedChars(DFA49_minS);
    static readonly char[] DFA49_max = DFA.UnpackEncodedStringToUnsignedChars(DFA49_maxS);
    static readonly short[] DFA49_accept = DFA.UnpackEncodedString(DFA49_acceptS);
    static readonly short[] DFA49_special = DFA.UnpackEncodedString(DFA49_specialS);
    static readonly short[][] DFA49_transition = DFA.UnpackEncodedStringArray(DFA49_transitionS);

    protected class DFA49 : DFA
    {
        public DFA49(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 49;
            this.eot = DFA49_eot;
            this.eof = DFA49_eof;
            this.min = DFA49_min;
            this.max = DFA49_max;
            this.accept = DFA49_accept;
            this.special = DFA49_special;
            this.transition = DFA49_transition;

        }

        override public string Description
        {
            get { return "391:1: cast_expression : ( ( LPAREN qualifier RPAREN cast_expression )=> ( LPAREN qualifier RPAREN cast_expression ) -> ^( CAST qualifier cast_expression ) | invocation_or_load_expression );"; }
        }

    }


    protected internal int DFA49_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA49_1 = input.LA(1);

                   	 
                   	int index49_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred6_Vnvd()) ) { s = 16; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index49_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae49 =
            new NoViableAltException(dfa.Description, 49, _s, input);
        dfa.Error(nvae49);
        throw nvae49;
    }
    const string DFA54_eotS =
        "\x17\uffff";
    const string DFA54_eofS =
        "\x17\uffff";
    const string DFA54_minS =
        "\x01\x06\x0a\uffff\x03\x00\x09\uffff";
    const string DFA54_maxS =
        "\x01\x77\x0a\uffff\x03\x00\x09\uffff";
    const string DFA54_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x03\uffff\x01\x12\x01\x13\x01\x0b\x01"+
        "\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11";
    const string DFA54_specialS =
        "\x0b\uffff\x01\x00\x01\x01\x01\x02\x09\uffff}>";
    static readonly string[] DFA54_transitionS = {
            "\x01\x0e\x03\uffff\x01\x0f\x1e\uffff\x01\x0b\x0b\uffff\x01"+
            "\x06\x01\x07\x01\x0a\x01\x09\x09\uffff\x01\x0c\x01\x08\x07\uffff"+
            "\x01\x0d\x27\uffff\x01\x01\x01\x02\x01\x04\x01\x05\x01\x03",
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
            "\x01\uffff",
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
            ""
    };

    static readonly short[] DFA54_eot = DFA.UnpackEncodedString(DFA54_eotS);
    static readonly short[] DFA54_eof = DFA.UnpackEncodedString(DFA54_eofS);
    static readonly char[] DFA54_min = DFA.UnpackEncodedStringToUnsignedChars(DFA54_minS);
    static readonly char[] DFA54_max = DFA.UnpackEncodedStringToUnsignedChars(DFA54_maxS);
    static readonly short[] DFA54_accept = DFA.UnpackEncodedString(DFA54_acceptS);
    static readonly short[] DFA54_special = DFA.UnpackEncodedString(DFA54_specialS);
    static readonly short[][] DFA54_transition = DFA.UnpackEncodedStringArray(DFA54_transitionS);

    protected class DFA54 : DFA
    {
        public DFA54(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 54;
            this.eot = DFA54_eot;
            this.eof = DFA54_eof;
            this.min = DFA54_min;
            this.max = DFA54_max;
            this.accept = DFA54_accept;
            this.special = DFA54_special;
            this.transition = DFA54_transition;

        }

        override public string Description
        {
            get { return "401:1: operand : ( qualifier -> ^( USAGE qualifier ) | NUMBER | FLOAT | STRING | CHAR | TRUE | FALSE | NULL | THIS | BASE | ( NEW qualifier LPAREN )=> object_creation_expression | ( NEW qualifier LBRACKET )=> array_creation_expression | ( NEW qualifier LCURLYBRACE )=> array_creation_expression_elemented | ( READ LPAREN IDENTIFIER RPAREN )=> READ LPAREN IDENTIFIER RPAREN -> ^( READ IDENTIFIER ) | READ LPAREN IDENTIFIER ( COMMA IDENTIFIER )+ RPAREN -> ^( SCOPEEXPR ( ^( READVOID IDENTIFIER ) )+ ) | ( WRITE LPAREN expression RPAREN )=> WRITE LPAREN expression RPAREN -> ^( WRITE expression ) | WRITE LPAREN expression ( COMMA expression )+ RPAREN -> ^( SCOPEEXPR ( ^( WRITEVOID expression ) )+ ) | LPAREN expression RPAREN -> ^( EXPRBLOCK expression ) | block_expression );"; }
        }

    }


    protected internal int DFA54_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA54_11 = input.LA(1);

                   	 
                   	int index54_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_Vnvd()) ) { s = 16; }

                   	else if ( (synpred8_Vnvd()) ) { s = 17; }

                   	else if ( (synpred9_Vnvd()) ) { s = 18; }

                   	 
                   	input.Seek(index54_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA54_12 = input.LA(1);

                   	 
                   	int index54_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred10_Vnvd()) ) { s = 19; }

                   	else if ( (true) ) { s = 20; }

                   	 
                   	input.Seek(index54_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA54_13 = input.LA(1);

                   	 
                   	int index54_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred11_Vnvd()) ) { s = 21; }

                   	else if ( (true) ) { s = 22; }

                   	 
                   	input.Seek(index54_13);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae54 =
            new NoViableAltException(dfa.Description, 54, _s, input);
        dfa.Error(nvae54);
        throw nvae54;
    }
    const string DFA55_eotS =
        "\x1b\uffff";
    const string DFA55_eofS =
        "\x1b\uffff";
    const string DFA55_minS =
        "\x01\x05\x1a\uffff";
    const string DFA55_maxS =
        "\x01\x77\x1a\uffff";
    const string DFA55_acceptS =
        "\x01\uffff\x01\x02\x01\x01\x18\uffff";
    const string DFA55_specialS =
        "\x1b\uffff}>";
    static readonly string[] DFA55_transitionS = {
            "\x02\x02\x03\uffff\x01\x02\x01\x01\x08\uffff\x02\x02\x0d\uffff"+
            "\x01\x02\x05\uffff\x01\x02\x02\uffff\x01\x02\x02\uffff\x02\x02"+
            "\x03\uffff\x05\x02\x09\uffff\x02\x02\x02\uffff\x01\x02\x03\uffff"+
            "\x02\x02\x27\uffff\x05\x02",
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

    static readonly short[] DFA55_eot = DFA.UnpackEncodedString(DFA55_eotS);
    static readonly short[] DFA55_eof = DFA.UnpackEncodedString(DFA55_eofS);
    static readonly char[] DFA55_min = DFA.UnpackEncodedStringToUnsignedChars(DFA55_minS);
    static readonly char[] DFA55_max = DFA.UnpackEncodedStringToUnsignedChars(DFA55_maxS);
    static readonly short[] DFA55_accept = DFA.UnpackEncodedString(DFA55_acceptS);
    static readonly short[] DFA55_special = DFA.UnpackEncodedString(DFA55_specialS);
    static readonly short[][] DFA55_transition = DFA.UnpackEncodedStringArray(DFA55_transitionS);

    protected class DFA55 : DFA
    {
        public DFA55(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 55;
            this.eot = DFA55_eot;
            this.eof = DFA55_eof;
            this.min = DFA55_min;
            this.max = DFA55_max;
            this.accept = DFA55_accept;
            this.special = DFA55_special;
            this.transition = DFA55_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 430:16: ( statement )*"; }
        }

    }

    const string DFA59_eotS =
        "\x19\uffff";
    const string DFA59_eofS =
        "\x19\uffff";
    const string DFA59_minS =
        "\x01\x06\x18\uffff";
    const string DFA59_maxS =
        "\x01\x77\x18\uffff";
    const string DFA59_acceptS =
        "\x01\uffff\x01\x01\x16\uffff\x01\x02";
    const string DFA59_specialS =
        "\x19\uffff}>";
    static readonly string[] DFA59_transitionS = {
            "\x01\x01\x01\x18\x02\uffff\x01\x01\x09\uffff\x02\x01\x0d\uffff"+
            "\x01\x01\x05\uffff\x01\x01\x02\uffff\x01\x01\x02\uffff\x02\x01"+
            "\x04\uffff\x04\x01\x09\uffff\x02\x01\x02\uffff\x01\x01\x03\uffff"+
            "\x02\x01\x27\uffff\x05\x01",
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

    static readonly short[] DFA59_eot = DFA.UnpackEncodedString(DFA59_eotS);
    static readonly short[] DFA59_eof = DFA.UnpackEncodedString(DFA59_eofS);
    static readonly char[] DFA59_min = DFA.UnpackEncodedStringToUnsignedChars(DFA59_minS);
    static readonly char[] DFA59_max = DFA.UnpackEncodedStringToUnsignedChars(DFA59_maxS);
    static readonly short[] DFA59_accept = DFA.UnpackEncodedString(DFA59_acceptS);
    static readonly short[] DFA59_special = DFA.UnpackEncodedString(DFA59_specialS);
    static readonly short[][] DFA59_transition = DFA.UnpackEncodedStringArray(DFA59_transitionS);

    protected class DFA59 : DFA
    {
        public DFA59(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 59;
            this.eot = DFA59_eot;
            this.eof = DFA59_eof;
            this.min = DFA59_min;
            this.max = DFA59_max;
            this.accept = DFA59_accept;
            this.special = DFA59_special;
            this.transition = DFA59_transition;

        }

        override public string Description
        {
            get { return "440:4: ( expression ( COMMA expression )* )?"; }
        }

    }

 

    public static readonly BitSet FOLLOW_import_stat_in_program997 = new BitSet(new ulong[]{0x0000006000000000UL});
    public static readonly BitSet FOLLOW_namespace_decl_in_program1000 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_program1003 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_USING_in_import_stat1027 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_import_stat1029 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_import_stat1031 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NAMESPACE_in_namespace_decl1051 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_namespace_decl1053 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LCURLYBRACE_in_namespace_decl1055 = new BitSet(new ulong[]{0x0002018000000800UL});
    public static readonly BitSet FOLLOW_namespace_body_in_namespace_decl1057 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RCURLYBRACE_in_namespace_decl1059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_class_decl_in_namespace_body1083 = new BitSet(new ulong[]{0x0002018000000002UL});
    public static readonly BitSet FOLLOW_interface_decl_in_namespace_body1087 = new BitSet(new ulong[]{0x0002018000000002UL});
    public static readonly BitSet FOLLOW_enum_decl_in_namespace_body1091 = new BitSet(new ulong[]{0x0002018000000002UL});
    public static readonly BitSet FOLLOW_CLASS_in_class_decl1105 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000000F000UL});
    public static readonly BitSet FOLLOW_class_mod_list_in_class_decl1109 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_class_decl1113 = new BitSet(new ulong[]{0xC000000000000400UL});
    public static readonly BitSet FOLLOW_EXTENDS_in_class_decl1116 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_class_decl1120 = new BitSet(new ulong[]{0xC000000000000400UL});
    public static readonly BitSet FOLLOW_IMPLEMENTS_in_class_decl1125 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_type_list_in_class_decl1129 = new BitSet(new ulong[]{0xC000000000000400UL});
    public static readonly BitSet FOLLOW_class_body_in_class_decl1133 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENUM_in_enum_decl1180 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000000F000UL});
    public static readonly BitSet FOLLOW_access_modifier_in_enum_decl1184 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_enum_decl1188 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_enum_body_in_enum_decl1190 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LCURLYBRACE_in_enum_body1221 = new BitSet(new ulong[]{0x0000000000000800UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_enum_body1224 = new BitSet(new ulong[]{0x0000000000000900UL});
    public static readonly BitSet FOLLOW_COMMA_in_enum_body1227 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_enum_body1229 = new BitSet(new ulong[]{0x0000000000000900UL});
    public static readonly BitSet FOLLOW_RCURLYBRACE_in_enum_body1235 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTERFACE_in_interface_decl1257 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000000F000UL});
    public static readonly BitSet FOLLOW_class_mod_list_in_interface_decl1261 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_interface_decl1265 = new BitSet(new ulong[]{0x4000000000000400UL});
    public static readonly BitSet FOLLOW_EXTENDS_in_interface_decl1268 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_interface_decl1272 = new BitSet(new ulong[]{0x4000000000000400UL});
    public static readonly BitSet FOLLOW_interface_body_in_interface_decl1276 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LCURLYBRACE_in_interface_body1315 = new BitSet(new ulong[]{0x0000080000000800UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_interface_method_in_interface_body1317 = new BitSet(new ulong[]{0x0000080000000800UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_RCURLYBRACE_in_interface_body1320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_qualifier_in_interface_method1337 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_interface_method1339 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_interface_method1341 = new BitSet(new ulong[]{0x0000000000000080UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_parameter_list_in_interface_method1343 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_interface_method1345 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_interface_method1347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_access_modifier_in_class_mod_list1372 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ABSTRACT_in_class_mod_list1375 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_access_modifier_in_method_mod_list1388 = new BitSet(new ulong[]{0x0000040000000002UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_STATIC_in_method_mod_list1391 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_virtual_modifier_in_method_mod_list1395 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_access_modifier_in_field_mod_list1409 = new BitSet(new ulong[]{0x0000040000000002UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_STATIC_in_field_mod_list1411 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_INITONLY_in_field_mod_list1414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_access_modifier_in_constructor_mod_list1426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_access_modifier_in_abstract_mod_list1438 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ABSTRACT_in_abstract_mod_list1440 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qualifier_in_type_list1452 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_COMMA_in_type_list1455 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_type_list1458 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_LCURLYBRACE_in_class_body1472 = new BitSet(new ulong[]{0x0000040000000800UL,0x000000000000F000UL});
    public static readonly BitSet FOLLOW_class_element_in_class_body1475 = new BitSet(new ulong[]{0x0000040000000800UL,0x000000000000F000UL});
    public static readonly BitSet FOLLOW_RCURLYBRACE_in_class_body1478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_method_decl_in_class_element1502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constructor_decl_in_class_element1517 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_abstract_method_decl_in_class_element1528 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_field_decl_in_class_element1533 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_static_constructor_in_class_element1538 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STATIC_in_static_constructor1549 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_block_expression_in_static_constructor1551 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal_value0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_field_mod_list_in_field_decl1611 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_field_decl1615 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_field_decl1617 = new BitSet(new ulong[]{0x0000000000000120UL});
    public static readonly BitSet FOLLOW_COMMA_in_field_decl1620 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_field_decl1622 = new BitSet(new ulong[]{0x0000000000000120UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_field_decl1626 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_method_mod_list_in_method_decl1660 = new BitSet(new ulong[]{0x0000080000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_type_qualifier_in_method_decl1662 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_method_decl1664 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_method_decl1666 = new BitSet(new ulong[]{0x0000000000000080UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_parameter_list_in_method_decl1668 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_method_decl1670 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_block_expression_in_method_decl1672 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_abstract_mod_list_in_abstract_method_decl1707 = new BitSet(new ulong[]{0x0000080000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_type_qualifier_in_abstract_method_decl1709 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_abstract_method_decl1711 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_abstract_method_decl1713 = new BitSet(new ulong[]{0x0000000000000080UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_parameter_list_in_abstract_method_decl1715 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_abstract_method_decl1717 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_abstract_method_decl1719 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constructor_mod_list_in_constructor_decl1753 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_constructor_decl1755 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_constructor_decl1757 = new BitSet(new ulong[]{0x0000000000000080UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_parameter_list_in_constructor_decl1759 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_constructor_decl1761 = new BitSet(new ulong[]{0x0000000000000410UL});
    public static readonly BitSet FOLLOW_COLON_in_constructor_decl1764 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_BASE_in_constructor_decl1766 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_constructor_decl1768 = new BitSet(new ulong[]{0x01E19208003004C0UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_argument_list_in_constructor_decl1770 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_constructor_decl1772 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_block_expression_in_constructor_decl1776 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_declaration_statement_in_statement1823 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_statement1825 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_const_decl_statement_in_statement1831 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_statement1833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_statement1839 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_statement1841 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_statement1847 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CATCH_in_catch_block1860 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_CAREBOX_in_catch_block1864 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_catch_block1867 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_catch_block1869 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_catch_block1871 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_catch_block1873 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_catch_block1875 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FINALLY_in_finally_block1903 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_finally_block1905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_scope_expr1925 = new BitSet(new ulong[]{0x01F1920800300462UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_qualifier_in_declaration_statement1960 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_declaration_statement1962 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_BECOMES_in_declaration_statement1964 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_declaration_statement1966 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qualifier_in_declaration_statement2001 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_declaration_statement2003 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_COMMA_in_declaration_statement2006 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_declaration_statement2008 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_CONST_in_const_decl_statement2034 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_const_decl_statement2036 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_const_decl_statement2038 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_BECOMES_in_const_decl_statement2040 = new BitSet(new ulong[]{0x0060000000000400UL,0x0070000000000008UL});
    public static readonly BitSet FOLLOW_const_value_in_const_decl_statement2042 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_COMMA_in_const_decl_statement2045 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_const_decl_statement2047 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_BECOMES_in_const_decl_statement2049 = new BitSet(new ulong[]{0x0060000000000400UL,0x0070000000000008UL});
    public static readonly BitSet FOLLOW_const_value_in_const_decl_statement2051 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_literal_value_in_const_value2079 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LCURLYBRACE_in_const_value2084 = new BitSet(new ulong[]{0x0060000000000000UL,0x0070000000000008UL});
    public static readonly BitSet FOLLOW_literal_value_in_const_value2086 = new BitSet(new ulong[]{0x0000000000000900UL});
    public static readonly BitSet FOLLOW_COMMA_in_const_value2089 = new BitSet(new ulong[]{0x0060000000000000UL,0x0070000000000008UL});
    public static readonly BitSet FOLLOW_literal_value_in_const_value2091 = new BitSet(new ulong[]{0x0000000000000900UL});
    public static readonly BitSet FOLLOW_RCURLYBRACE_in_const_value2095 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEW_in_object_creation_expression2123 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_object_creation_expression2125 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_object_creation_expression2127 = new BitSet(new ulong[]{0x01E19208003004C0UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_argument_list_in_object_creation_expression2129 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_object_creation_expression2131 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEW_in_array_creation_expression_elemented2155 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_array_creation_expression_elemented2157 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LCURLYBRACE_in_array_creation_expression_elemented2159 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_array_creation_expression_elemented2161 = new BitSet(new ulong[]{0x0000000000000900UL});
    public static readonly BitSet FOLLOW_COMMA_in_array_creation_expression_elemented2164 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_array_creation_expression_elemented2166 = new BitSet(new ulong[]{0x0000000000000900UL});
    public static readonly BitSet FOLLOW_RCURLYBRACE_in_array_creation_expression_elemented2170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEW_in_array_creation_expression2204 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_array_creation_expression2206 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBRACKET_in_array_creation_expression2208 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_array_creation_expression2210 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRACKET_in_array_creation_expression2212 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_expression_in_expression2234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_control_expression_in_assignment_expression2248 = new BitSet(new ulong[]{0x00000000000E0002UL});
    public static readonly BitSet FOLLOW_BECOMES_in_assignment_expression2263 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_ADDEVENT_in_assignment_expression2268 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_REMEVENT_in_assignment_expression2273 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_assignment_expression_in_assignment_expression2279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_control_expression2292 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_control_expression2294 = new BitSet(new ulong[]{0x01F1920800300460UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_scope_expr_in_control_expression2296 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_control_expression2298 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_control_expression2300 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_control_expression2316 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_control_expression2318 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_control_expression2322 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_control_expression2324 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_IN_in_control_expression2326 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_control_expression2328 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_control_expression2330 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_control_expression2334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRY_in_control_expression2360 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_control_expression2362 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000380UL});
    public static readonly BitSet FOLLOW_finally_block_in_control_expression2365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_catch_block_in_control_expression2379 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000380UL});
    public static readonly BitSet FOLLOW_finally_block_in_control_expression2382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_control_expression2405 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_control_expression2407 = new BitSet(new ulong[]{0x01F1920800300460UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_scope_expr_in_control_expression2409 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_control_expression2411 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_THEN_in_control_expression2413 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_control_expression2415 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_control_expression2427 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_control_expression2429 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_THROW_in_control_expression2450 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_control_expression2452 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditional_or_operator_expression_in_control_expression2466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditional_and_operator_expression_in_conditional_or_operator_expression2478 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_OR_in_conditional_or_operator_expression2481 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_conditional_and_operator_expression_in_conditional_or_operator_expression2484 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_logic_or_operator_expression_in_conditional_and_operator_expression2497 = new BitSet(new ulong[]{0x0000000040000002UL});
    public static readonly BitSet FOLLOW_AND_in_conditional_and_operator_expression2500 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_logic_or_operator_expression_in_conditional_and_operator_expression2503 = new BitSet(new ulong[]{0x0000000040000002UL});
    public static readonly BitSet FOLLOW_logic_xor_operator_expression_in_logic_or_operator_expression2516 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_LOR_in_logic_or_operator_expression2519 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_logic_xor_operator_expression_in_logic_or_operator_expression2522 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_logic_and_operator_expression_in_logic_xor_operator_expression2535 = new BitSet(new ulong[]{0x0000000100000002UL});
    public static readonly BitSet FOLLOW_LXOR_in_logic_xor_operator_expression2538 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_logic_and_operator_expression_in_logic_xor_operator_expression2541 = new BitSet(new ulong[]{0x0000000100000002UL});
    public static readonly BitSet FOLLOW_logic_expression_in_logic_and_operator_expression2554 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_LAND_in_logic_and_operator_expression2557 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_logic_expression_in_logic_and_operator_expression2560 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_cast_as_expression_in_logic_expression2573 = new BitSet(new ulong[]{0x000000003F000002UL});
    public static readonly BitSet FOLLOW_LE_in_logic_expression2577 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_LEQ_in_logic_expression2582 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_GE_in_logic_expression2587 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_GEQ_in_logic_expression2592 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_EQ_in_logic_expression2597 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_NEQ_in_logic_expression2602 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_cast_as_expression_in_logic_expression2606 = new BitSet(new ulong[]{0x000000003F000002UL});
    public static readonly BitSet FOLLOW_primary_expression_in_cast_as_expression2619 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_AS_in_cast_as_expression2623 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IS_in_cast_as_expression2628 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_cast_as_expression2632 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_secundary_expression_in_primary_expression2646 = new BitSet(new ulong[]{0x0000000000300002UL});
    public static readonly BitSet FOLLOW_PLUS_in_primary_expression2650 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_MINUS_in_primary_expression2655 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_secundary_expression_in_primary_expression2659 = new BitSet(new ulong[]{0x0000000000300002UL});
    public static readonly BitSet FOLLOW_logicnotoperator_expression_in_secundary_expression2673 = new BitSet(new ulong[]{0x0000001000C00002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_secundary_expression2677 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_DIVISION_in_secundary_expression2682 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_MOD_in_secundary_expression2687 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_logicnotoperator_expression_in_secundary_expression2691 = new BitSet(new ulong[]{0x0000001000C00002UL});
    public static readonly BitSet FOLLOW_NOT_in_logicnotoperator_expression2706 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_PLUS_in_logicnotoperator_expression2711 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_MINUS_in_logicnotoperator_expression2716 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_cast_expression_in_logicnotoperator_expression2721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_cast_expression2745 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_cast_expression2747 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_cast_expression2749 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_cast_expression_in_cast_expression2751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_invocation_or_load_expression_in_cast_expression2768 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operand_in_invocation_or_load_expression2779 = new BitSet(new ulong[]{0x0000000000011002UL});
    public static readonly BitSet FOLLOW_DCOLON_in_invocation_or_load_expression2783 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_invocation_or_load_expression2786 = new BitSet(new ulong[]{0x0000000000011042UL});
    public static readonly BitSet FOLLOW_LPAREN_in_invocation_or_load_expression2789 = new BitSet(new ulong[]{0x01E19208003004C0UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_argument_list_in_invocation_or_load_expression2792 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_invocation_or_load_expression2794 = new BitSet(new ulong[]{0x0000000000011002UL});
    public static readonly BitSet FOLLOW_LBRACKET_in_invocation_or_load_expression2803 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_invocation_or_load_expression2806 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRACKET_in_invocation_or_load_expression2808 = new BitSet(new ulong[]{0x0000000000011002UL});
    public static readonly BitSet FOLLOW_qualifier_in_operand2824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_operand2839 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FLOAT_in_operand2844 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_operand2849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_in_operand2854 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_in_operand2859 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_in_operand2864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_in_operand2869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_THIS_in_operand2874 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BASE_in_operand2879 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_object_creation_expression_in_operand2894 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_array_creation_expression_in_operand2909 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_array_creation_expression_elemented_in_operand2924 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_READ_in_operand2941 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_operand2943 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_operand2945 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_operand2947 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_READ_in_operand2961 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_operand2963 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_operand2965 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_COMMA_in_operand2968 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_operand2970 = new BitSet(new ulong[]{0x0000000000000180UL});
    public static readonly BitSet FOLLOW_RPAREN_in_operand2974 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WRITE_in_operand3005 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_operand3007 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_operand3009 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_operand3011 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WRITE_in_operand3025 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_operand3027 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_operand3029 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_COMMA_in_operand3032 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_operand3034 = new BitSet(new ulong[]{0x0000000000000180UL});
    public static readonly BitSet FOLLOW_RPAREN_in_operand3038 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_operand3057 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_operand3059 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_operand3061 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_expression_in_operand3075 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LCURLYBRACE_in_block_expression3087 = new BitSet(new ulong[]{0x01F1920800300C60UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_statement_in_block_expression3089 = new BitSet(new ulong[]{0x01F1920800300C60UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_RCURLYBRACE_in_block_expression3092 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qualifier_in_parameter_list3114 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_parameter_list3116 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_COMMA_in_parameter_list3119 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_parameter_list3121 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_parameter_list3123 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_expression_in_argument_list3153 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_COMMA_in_argument_list3156 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_argument_list3158 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_VOID_in_type_qualifier3188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qualifier_in_type_qualifier3193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_qualifier3225 = new BitSet(new ulong[]{0x0000000000001200UL});
    public static readonly BitSet FOLLOW_PERIOD_in_qualifier3228 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_qualifier3230 = new BitSet(new ulong[]{0x0000000000001200UL});
    public static readonly BitSet FOLLOW_LBRACKET_in_qualifier3235 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRACKET_in_qualifier3237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_qualifier3256 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_PERIOD_in_qualifier3259 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_qualifier3261 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_set_in_access_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_virtual_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_method_mod_list_in_synpred1_Vnvd1491 = new BitSet(new ulong[]{0x0000080000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_type_qualifier_in_synpred1_Vnvd1493 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_synpred1_Vnvd1495 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred1_Vnvd1497 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constructor_mod_list_in_synpred2_Vnvd1508 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_synpred2_Vnvd1510 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred2_Vnvd1512 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_abstract_mod_list_in_synpred3_Vnvd1523 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qualifier_in_synpred4_Vnvd1816 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_synpred4_Vnvd1818 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qualifier_in_synpred5_Vnvd1949 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_synpred5_Vnvd1951 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_BECOMES_in_synpred5_Vnvd1953 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred6_Vnvd2733 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_synpred6_Vnvd2735 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred6_Vnvd2737 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_cast_expression_in_synpred6_Vnvd2739 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEW_in_synpred7_Vnvd2885 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_synpred7_Vnvd2887 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred7_Vnvd2889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEW_in_synpred8_Vnvd2900 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_synpred8_Vnvd2902 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBRACKET_in_synpred8_Vnvd2904 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEW_in_synpred9_Vnvd2915 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_qualifier_in_synpred9_Vnvd2917 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LCURLYBRACE_in_synpred9_Vnvd2919 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_READ_in_synpred10_Vnvd2930 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred10_Vnvd2932 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_synpred10_Vnvd2934 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred10_Vnvd2936 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WRITE_in_synpred11_Vnvd2994 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred11_Vnvd2996 = new BitSet(new ulong[]{0x01E1920800300440UL,0x00F8000000000C4CUL});
    public static readonly BitSet FOLLOW_expression_in_synpred11_Vnvd2998 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred11_Vnvd3000 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_synpred12_Vnvd3206 = new BitSet(new ulong[]{0x0000000000001200UL});
    public static readonly BitSet FOLLOW_PERIOD_in_synpred12_Vnvd3209 = new BitSet(new ulong[]{0x0000000000000000UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_synpred12_Vnvd3211 = new BitSet(new ulong[]{0x0000000000001200UL});
    public static readonly BitSet FOLLOW_LBRACKET_in_synpred12_Vnvd3216 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRACKET_in_synpred12_Vnvd3218 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}