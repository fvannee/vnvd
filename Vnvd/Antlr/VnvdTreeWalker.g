/*
	vNVD Checker

*/

tree grammar VnvdTreeWalker;

options
{
	tokenVocab = Vnvd;
	language = CSharp2;
	ASTLabelType = TreeNode;
	output = AST;
	rewrite = true;
}

@header
{
	using System.Collections.Generic;
	using Vnvd;
	using Vnvd.UserDefined;
}

@namespace
{
	Vnvd.Antlr
}

@members
{
	private AbstractHelper h;
	public int SemanticErrorCount { get; private set; }
	public String Filename { get; set; }

	public VnvdTreeWalker(AbstractHelper helper, ITreeNodeStream input)
    		: this(input, new RecognizerSharedState())
	{
		this.h = helper;
    }
}

@rulecatch
{
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
}

program
	:	^(node=PROGRAM import_stat* { h.BeginProgram(node); } namespace_decl*)
		{
			h.Program(node);
		}
	;

import_stat
	:	^(node=USING qual=qualifier)
		{
			h.Import(node, $qual.ids);
		}
	;

namespace_decl
	:	^(node=NAMESPACE qual=qualifier { h.BeginNamespace(node, $qual.ids); } (class_decl | interface_decl | enum_decl)*)
		{
			h.Namespace(node, $qual.ids);
		}
	;

	
class_decl
	:	^(node=CLASS ^(mod=MODIFIERS modifier*) qual=qualifier (^(ext=EXTENDS qualifier))? (^(imp=IMPLEMENTS qualifier*))?
		{ h.BeginClass(node, h.Modifiers(mod), $qual.ids, h.Extendation(ext), h.Implements(imp)); } class_element*)
		{
			h.Class(node, h.Modifiers(mod), $qual.ids, h.Extendation(ext), h.Implements(imp));
		}
	;

enum_decl
	:	^(node=ENUM ^(mod=MODIFIERS modifier*) qual=qualifier (^(ENUMOPTION IDENTIFIER))*)
	;
	
interface_decl
	:	^(node=INTERFACE ^(mod=MODIFIERS modifier*) qual=qualifier (^(ext=EXTENDS qualifier))?
		{ h.BeginInterface(node, h.Modifiers(mod), $qual.ids, h.Extendation(ext)); } interface_method*)
		{
			h.Interface(node, h.Modifiers(mod), $qual.ids, h.Extendation(ext));
		}
	;

interface_method
	:	^(node=IMETHOD qual=type_qualifier id=IDENTIFIER ^(par=PARAMETER (qualifier IDENTIFIER)*))
		{
			h.InterfaceMethod(node, $qual.ids, id.Text, h.Parameters(par));
		}
	;

class_element
	:	method_decl
	|	constructor_decl
	|	field_decl
	|	static_constructor
	;
	
literal_value
	:	node=NUMBER
		{
			h.LiteralNumber(node);
		}
	|	node=STRING
		{
			h.LiteralString(node);
		}
	|	node=FLOAT
		{
			h.LiteralFloat(node);
		}
	|	node=CHAR
		{
			h.LiteralCharacter(node);
		}
	|	node=TRUE
		{
			h.LiteralBoolean(node);
		}
	|	node=FALSE
		{
			h.LiteralBoolean(node);
		}
	;

constant_literal_value
	:	node=NUMBER
		{
			h.ConstLiteralNumber(node);
		}
	|	node=STRING
		{
			h.ConstLiteralString(node);
		}
	|	node=FLOAT
		{
			h.ConstLiteralFloat(node);
		}
	|	node=CHAR
		{
			h.ConstLiteralCharacter(node);
		}
	|	node=TRUE
		{
			h.ConstLiteralBoolean(node);
		}
	|	node=FALSE
		{
			h.ConstLiteralBoolean(node);
		}
	;
		
abstract_mod_list
	:	^(MODIFIERS access_modifier ABSTRACT)
	;

access_modifier
	:	PRIVATE | PUBLIC | PROTECTED | INTERNAL
	;
	
field_decl
	:	^(node=FIELD ^(mod=MODIFIERS modifier*) qual=qualifier id=IDENTIFIER)
		{
			h.Field(node, h.Modifiers(mod), $qual.ids, id.Text);
		}
	;
	
method_decl
	:	^(node=METHOD ^(mod=MODIFIERS modifier*) return_=type_qualifier id=IDENTIFIER ^(par=PARAMETER (qualifier IDENTIFIER)*) { h.BeginMethod(node, h.Modifiers(mod), $return_.ids, id.Text, h.Parameters(par));} block_expression?)
		{
			h.Method(node, h.Modifiers(mod), $return_.ids, id.Text, h.Parameters(par));
		}
	;
	
constructor_decl
	:	^(node=CONSTRUCTOR ^(mod=MODIFIERS modifier*) id=IDENTIFIER ^(par=PARAMETER (qualifier IDENTIFIER)*) { h.BeginConstructorBeforeBaseCall(node); } (^(bas=BASE (^(ALIST argument*))))? { h.BeginConstructor(node, h.Modifiers(mod), h.Parameters(par), bas); } block_expression)
		{
			h.Constructor(node, h.Modifiers(mod), h.Parameters(par));
		}
	;
	
static_constructor
	:	^(node=SCONSTRUCTOR { h.BeginStaticConstructor(node); } block_expression)
	{
		h.EndStaticConstructor(node); 
	}
	;
	
statement
	:	expression
	|	declaration_statement
	|	const_decl_statement
	;

throw_expression
	:	^(node=THROW expression)
		{
			h.ThrowStatement(node);
		}
	;
	
try_expression
	:	^(node=TRY { h.BeginTry(node); } expression catch_block* finally_block?)
		{
			h.EndTry(node);
		}
	;
	
catch_block
	@init { h.OpenScope(); }
	:	^(node=ICATCH ^(node2=LOCAL qual=qualifier id=IDENTIFIER) { h.DeclarationStatement(node2, $qual.ids, id.Text); h.BeginCatch(node, node2, $qual.ids, id.Text); } expression)
		{
			h.EndCatch(node, $qual.ids, id.Text);
			h.CloseScope();		
		}
	;

finally_block
	:	^(node=FINALLY { h.BeginFinally(node); } expression)
		{
			h.EndFinally(node);
		}
	;
	
while_expression
	@init { h.OpenScope(); }
	:	^(node=WHILE { h.WhileStart(node); } scope_expr { h.WhileAfterExpr(node); } expression)
		{
			h.WhileLoop(node);
			h.CloseScope();
		}
	;
	
for_expression
	@init { h.OpenScope(); }
	:	^(node=FOR ^(node2=LOCAL qual=qualifier id=IDENTIFIER) expression { h.DeclarationStatement(node2, $qual.ids, id.Text); h.BeginFor(node, node2, $qual.ids, id.Text); } expression)
		{
			h.ForLoop(node);
			
			h.CloseScope();
		}
	;

scope_expr
	:	^(node=SCOPEEXPR statement+)
	{
		h.ScopeExpr(node);
	}
	;
	
declaration_statement
	:	^(node=LOCAL qual=qualifier id=IDENTIFIER)
		{
			h.DeclarationStatement(node, $qual.ids, id.Text);
		}
	;

const_decl_statement
	:	^(node=CONST qual=qualifier id=IDENTIFIER const_value)
		{
			h.ConstantDeclaration(node, $qual.ids, id.Text);
		}
	;
	
const_value
	:	constant_literal_value
	|	^(node=ARRELEMS (const_array_element)+)
		{
			h.ConstantArray(node);
		}
	;
	
const_array_element
	:	^(node=ARRELEM literal_value)
		{
			h.ConstantArrayElement(node);
		}
	;

expression
	:	assignment_expression
	;

assignment_expression
	:	control_expression
	|	^(node=BECOMES assignment_expression assignment_expression)
		{
			h.AssignmentExpr(node);
		}
	|	^(node=ADDEVENT assignment_expression assignment_expression)
		{
			h.AddEventExpr(node);
		}
	|	^(node=REMEVENT assignment_expression assignment_expression)
		{
			h.RemoveEventExpr(node);
		}
	;

control_expression
	:	while_expression
	|	for_expression
	|	try_expression
	|	throw_expression
	|	{ h.OpenScope(); }
		^(node=IF scope_expr { h.TernaryThen(node); } expression { h.TernaryElse(node); } expression?)
		{
			h.TernaryExpr(node);
			h.CloseScope();
		}
	|	conditional_or_operator_expression
	;

conditional_or_operator_expression
	:	conditional_and_operator_expression
	|	^(node=OR { h.BeginCondOr(node); } conditional_or_operator_expression { h.MiddleCondOr(node); } conditional_or_operator_expression)
		{
			h.EndConditionalOrExpr(node);
		}
	;

conditional_and_operator_expression
	:	logic_or_operator_expression
	|	^(node=AND { h.BeginCondAnd(node); } conditional_and_operator_expression { h.MiddleCondAnd(node); } conditional_and_operator_expression)
		{
			h.EndConditionalAndExpr(node);
		}
	;

logic_or_operator_expression
	:	logic_xor_operator_expression
	|	^(node=LOR logic_or_operator_expression logic_or_operator_expression)
		{
			h.LogicOrExpr(node);
		}
	;
	
logic_xor_operator_expression
	:	logic_and_operator_expression
	|	^(node=LXOR logic_xor_operator_expression logic_xor_operator_expression)
		{
			h.LogicXorExpr(node);
		}
	;
	
logic_and_operator_expression
	:	logic_expression
	|	^(node=LAND logic_and_operator_expression logic_and_operator_expression)
		{
			h.LogicAndExpr(node);
		}
	;

logic_expression
	:	cast_as_expression
	|	^(node=LE primary_expression primary_expression)
		{
			h.LessExpr(node);
		}
	|	^(node=LEQ primary_expression primary_expression)
		{
			h.LessEqualExpr(node);
		}
	|	^(node=GE primary_expression primary_expression)
		{
			h.GreaterExpr(node);
		}
	|	^(node=GEQ primary_expression primary_expression)
		{
			h.GreaterEqualExpr(node);
		}
	|	^(node=EQ primary_expression primary_expression)
		{
			h.EqualExpr(node);
		}
	|	^(node=NEQ primary_expression primary_expression)
		{
			h.NotEqualExpr(node);
		}
	;

cast_as_expression
	:	^(node=AS cast_as_expression qual=qualifier)
		{
			h.CastAsExpression(node, $qual.ids);
		}
	|	^(node=IS cast_as_expression qual=qualifier)
		{
			h.IsTypeExpression(node, $qual.ids);
		}
	|	primary_expression
	;
	
primary_expression
	:	(^(PLUS primary_expression primary_expression)) => ^(node=PLUS primary_expression primary_expression)
		{
			h.PlusExpr(node);
		}
	|	(^(MINUS primary_expression primary_expression)) => ^(node=MINUS primary_expression primary_expression)
		{
			h.MinusExpr(node);
		}
	|	secundary_expression
	;
	
secundary_expression
	:	^(node=MULTIPLY secundary_expression secundary_expression)
		{
			h.MultiplyExpr(node);
		}
	|	^(node=DIVISION secundary_expression secundary_expression)
		{
			h.DivisionExpr(node);
		}
	|	^(node=MOD secundary_expression secundary_expression)
		{
			h.ModExpr(node);
		}
	|	logicnotoperator_expression
	;

logicnotoperator_expression
	:	^(node=NOT logicnotoperator_expression)
		{
			h.LogicNotExpr(node);
		}
	|	^(node=PLUS logicnotoperator_expression)
		{
			h.UnaryPlusExpr(node);
		}
	|	^(node=MINUS logicnotoperator_expression)
		{
			h.UnaryMinusExpr(node);
		}
	|	cast_expression
	;

cast_expression
	:	^(node=CAST qual=qualifier cast_expression)
	{
		h.CastExpression(node, $qual.ids);
	}
	|	invocation_or_load_expression
	;
	
invocation_or_load_expression
	:	^(node=DCOLON invocation_or_load_expression id=IDENTIFIER (^(ALIST argument*))?)
		{
			h.InvocationExpr(node, id.Text);
		}
	|	^(node=LBRACKET invocation_or_load_expression expression)
		{
			h.AccessArray(node);
		}
	|	^(node=CALLVIRT invocation_or_load_expression id=IDENTIFIER (^(ALIST argument*)))
		{
			h.CallVirtual(node, id.Text);
		}
	|	^(node=CALL invocation_or_load_expression id=IDENTIFIER (^(ALIST argument*)))
		{
			h.Call(node, id.Text);
		}
	|	^(node=LDFLD invocation_or_load_expression id=IDENTIFIER)
		{
			h.LoadField(node, id.Text);
		}
	|	^(node=LDSFLD invocation_or_load_expression id=IDENTIFIER)
		{
			h.LoadStaticField(node, id.Text);
		}
	|	^(node=LDLITERAL invocation_or_load_expression id=IDENTIFIER)
		{
			h.LoadLiteral(node, id.Text);
		}
	|	^(node=LDVIRTFTN invocation_or_load_expression id=IDENTIFIER)
		{
			h.LoadVirtualFunction(node, id.Text);
		}
	|	^(node=LDFTN invocation_or_load_expression id=IDENTIFIER)
		{
			h.LoadFunction(node, id.Text);
		}
	|	^(node=DONTLD invocation_or_load_expression id=IDENTIFIER)
		{
			h.FieldAssignment(node, id.Text);
		}
	|	operand
	;

operand
	:	^(node=USAGE qual=qualifier)
		{
			h.VariableUsed(node, $qual.ids);
		}
	|	literal_value
	|	node=THIS
		{
			h.LiteralThis(node);
		}
	|	node=BASE
		{
			h.LiteralBase(node);
		}
	|	node=NULL
		{
			h.LiteralNull(node);
		}
	|	read_write_expression
	|	object_creation_expression
	|	array_creation_expression
	|	^(node=EXPRBLOCK expression)
		{
			h.ExpressionBlock(node);
		}
	|	block_expression
	|	scope_expr
	;

read_write_expression
	:	^(node=READ qual=IDENTIFIER)
		{
			h.ReadExpression(node, qual.Text);
		}
	|	^(node=READVOID qual=IDENTIFIER)
		{
			h.ReadVoidExpression(node, qual.Text);
		}
	|	^(node=WRITE expression)
		{
			h.WriteExpression(node);
		}
	|	^(node=WRITEVOID expression)
		{
			h.WriteVoidExpression(node);
		}
	;

array_creation_expression
	:	^(node=NEWARR qualifier expression)
		{
			h.ArrayCreationExpr(node);
		}
	|	^(node=NEWARRELEMS qualifier { h.BeforeArrayElementedCreationExpr(node); } ^(ARRELEMS array_initial_elements*))
		{
			h.ArrayElementedCreationExpr(node);
		}
	;
	
array_initial_elements
	:	^(node=ARRELEM { h.BeforeArrayElementedElement(node); } expression)
		{
			h.ArrayElementedElement(node);
		}
	;

object_creation_expression
	:	^(node=NEW qual=qualifier (^(ALIST argument*))?)
		{
			h.ObjectCreation(node, $qual.ids);
		}
	;
	
block_expression
	:	{ h.OpenScope(); } ^(node=SLIST statement*)
		{
			h.StatementBlock(node);
			h.CloseScope();
		}
	;

argument
	:	^(ARGUMENT expression)
	;

qualifier returns [Qualifier ids]
	:	^(fqual=FQUALIFIER IDENTIFIER+ ARRAY?)
		{
			$ids = h.FullQualifier(fqual);
		}
	;
	
type_qualifier returns [Qualifier ids]
	:	v=VOID
		{
			$ids = new Qualifier() { "System", "Void" };
		}
	|	qual=qualifier
		{
			$ids = h.TypeQualifier($qual.ids);
		}
	;

modifier
	:	PRIVATE | PUBLIC | PROTECTED | INTERNAL | ABSTRACT | STATIC | VIRTUAL | OVERRIDE | INITONLY
	;
