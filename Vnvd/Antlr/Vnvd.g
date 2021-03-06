/* Grammar voor vertalerbouw

*/

grammar Vnvd;

options
{
	k = 1;
	language = CSharp2;
	output = AST;
}

tokens
{
	COLON = ':';
	SEMICOLON = ';';
	LPAREN = '(';
	RPAREN = ')';
	COMMA = ',';
	PERIOD = '.';
	LCURLYBRACE = '{';
	RCURLYBRACE = '}';
	LBRACKET = '[';
	RBRACKET = ']';
	QUESTION = '?';
	TILDE = '~';
	DCOLON = '::';
	
	ADDEVENT = '+=';
	REMEVENT = '-=';
	
	BECOMES = '=';
	PLUS = '+';
	MINUS = '-';
	MULTIPLY = '*';
	DIVISION = '/';
	
	LE = '<';
	LEQ = '<=';
	GE = '>';
	GEQ = '>=';
	EQ = '==';
	NEQ = '!=';
	
	AND = '&&';
	OR = '||';
	
	LXOR = '^';
	LAND = '&';
	LOR = '|';
	
	NOT = '!';
	MOD = '%';
	
	USING = 'import';
	NAMESPACE = 'namespace';
	CLASS = 'class';
	INTERFACE = 'interface';
	NEW = 'new';
	STATIC = 'static';
	VOID = 'void';
	IF = 'if';
	THEN = 'then';
	ELSE = 'else';
	WHILE = 'while';
	FOR = 'for';
	ENUM = 'enum';
	IN = 'in';
	RETURN = 'return';
	CONST = 'const';
	TRUE = 'true';
	FALSE = 'false';
	BASE = 'base';
	THIS = 'this';
	METHOD = '~method~';
	IMETHOD = '~imethod~';
	FIELD = '~field~';
	CONSTRUCTOR = '~constructor~';
	LOCAL = '~local~';
	EXTENDS = 'extends';
	IMPLEMENTS = 'implements';
	FI	= 'fi';
	PRINT = 'print';
	READ = 'read';
	NULL =  'null';
	AS = 'as';
	IS = 'is';
	TRY = 'try';
	CATCH = 'catch';
	CAREBOX = 'carebox';
	FINALLY = 'finally';
	THROW = 'throw';
	
	// functions
	READ = 'read';
	WRITE = 'write';
	
	//modifiers
	PRIVATE = 'private';
	PUBLIC = 'public';
	PROTECTED = 'protected';
	INTERNAL = 'internal';
	ABSTRACT = 'abstract';
	STATIC = 'static';
	VIRTUAL = 'virtual';
	OVERRIDE = 'override';
	INITONLY = 'initonly';
	
	//imaginary tokens
	PROGRAM = '~program~';
	VARDECL = '~vardecl~';
	PARAMETER = '~par~';
	ARGUMENT = '~arg~';
	SLIST = '~slist~';
	ENUMOPTION = '~enumoption~';
	FQUALIFIER = '~fqualifier~';
	EQUALIFIER = '~equalifier~';
	MODIFIERS = '~modifiers~';
	EXPRBLOCK = '~expression~';
	USAGE = '~usage~';
	SCOPEEXPR = '~scopeepxr~';
	CAST = '~cast~';
	ARRAY = '~array~';
	READVOID = '~readvoid~';
	WRITEVOID = '~writevoid~';
	ALIST = '~alist~';
	NEWARR	= '~newarr~';
	NEWARRELEMS	= '~newarrelems~';
	ARRELEMS = '~arrelems~';
	ARRELEM = '~arrelem~';
	SCONSTRUCTOR = '~sconstructor~';
	ICATCH = '~icatch~';
	
	CALLVIRT = '~callvirt~';
	CALL = '~call~';
	LDFLD = '~ldfld~';
	LDSFLD = '~ldsfld~';
	LDLITERAL = '~ldliteral~';
	LDVIRTFTN = '~ldvirtftn~';
	LDFTN = '~ldftn~';
	DONTLD = '~dontld~';
}
	
@namespace
{
	Vnvd.Antlr
}

@lexer::namespace
{
	Vnvd.Antlr
}

program
	:	import_stat* namespace_decl* EOF
	->	^(PROGRAM import_stat* namespace_decl*)
	;

import_stat
	:	USING qualifier SEMICOLON
	->	^(USING qualifier)
	;

namespace_decl
	:	NAMESPACE qualifier LCURLYBRACE namespace_body RCURLYBRACE
	->	^(NAMESPACE qualifier namespace_body?)
	;

namespace_body
	:	(class_decl | interface_decl | enum_decl)*
	;
	
class_decl
	:	CLASS mod=class_mod_list name=qualifier (EXTENDS base_=qualifier)? (IMPLEMENTS interface_=type_list)? class_body
	->	^(CLASS ^(MODIFIERS $mod) $name ^(EXTENDS $base_)? ^(IMPLEMENTS $interface_)? class_body?)
	;

enum_decl
	:	ENUM mod=access_modifier name=qualifier enum_body
	->	^(ENUM ^(MODIFIERS $mod) $name enum_body?)
	;

enum_body
	:	LCURLYBRACE (IDENTIFIER (COMMA IDENTIFIER)*)? RCURLYBRACE
	->	^(ENUMOPTION IDENTIFIER)*
	;
	
interface_decl
	:	INTERFACE mod=class_mod_list name=qualifier (EXTENDS base_=qualifier)? interface_body
	->	^(INTERFACE ^(MODIFIERS $mod) $name ^(EXTENDS $base_)? interface_body?)
	;

interface_body
	:	LCURLYBRACE interface_method* RCURLYBRACE
	->	interface_method*
	;

interface_method
	:	type_qualifier IDENTIFIER LPAREN parameter_list RPAREN SEMICOLON
	->	^(IMETHOD type_qualifier IDENTIFIER parameter_list)
	;
	
class_mod_list
	:	access_modifier (ABSTRACT)?
	;

method_mod_list
	: access_modifier (STATIC | virtual_modifier)?
	;
	
field_mod_list
	:	access_modifier STATIC? INITONLY?
	;

constructor_mod_list
	:	access_modifier
	;	

abstract_mod_list
	:	access_modifier ABSTRACT
	;
	
type_list
	:	qualifier (COMMA! qualifier)*
	;
	
class_body
	:	LCURLYBRACE! class_element* RCURLYBRACE!
	;

class_element
	:	(method_mod_list type_qualifier IDENTIFIER LPAREN) => method_decl
	|	(constructor_mod_list IDENTIFIER LPAREN) => constructor_decl
	|	(abstract_mod_list) => abstract_method_decl
	|	field_decl
	|	static_constructor
	;

static_constructor
	:	STATIC block_expression
	->	^(SCONSTRUCTOR block_expression)
	;
	
literal_value
	:	NUMBER
	|	STRING
	|	CHAR
	|	TRUE
	|	FALSE
	|	NULL
	;
	
field_decl
	:	mod=field_mod_list qual=qualifier IDENTIFIER (COMMA IDENTIFIER)* SEMICOLON
	->	^(FIELD ^(MODIFIERS $mod) $qual IDENTIFIER)+
	;
	
method_decl
	:	mod=method_mod_list type_qualifier IDENTIFIER LPAREN parameter_list RPAREN block_expression
	->	^(METHOD ^(MODIFIERS $mod) type_qualifier IDENTIFIER parameter_list block_expression)
	;

abstract_method_decl
	:	mod=abstract_mod_list type_qualifier IDENTIFIER LPAREN parameter_list RPAREN SEMICOLON
	->	^(METHOD ^(MODIFIERS $mod) type_qualifier IDENTIFIER parameter_list)
	;
	
constructor_decl
	:	mod=constructor_mod_list IDENTIFIER LPAREN parameter_list RPAREN (COLON BASE LPAREN argument_list RPAREN)? block_expression
	->	^(CONSTRUCTOR ^(MODIFIERS $mod) IDENTIFIER parameter_list ^(BASE argument_list?)? block_expression)
	;

statement
	:	(qualifier IDENTIFIER) => declaration_statement SEMICOLON!
	|	const_decl_statement SEMICOLON!
	|	expression SEMICOLON!
	|	SEMICOLON!
	;

catch_block
	:	(CATCH | CAREBOX) LPAREN qualifier IDENTIFIER RPAREN expression
	->	^(ICATCH ^(LOCAL qualifier IDENTIFIER) expression)
	;

finally_block
	:	FINALLY expression
	->	^(FINALLY expression)
	;

scope_expr
	:	statement+
	-> ^(SCOPEEXPR statement+)
	;
	
declaration_statement
	:	(qualifier IDENTIFIER BECOMES) => type_=qualifier IDENTIFIER BECOMES expression
	->	^(LOCAL $type_ IDENTIFIER) ^(BECOMES ^(USAGE ^(FQUALIFIER IDENTIFIER)) expression)
	|	type_=qualifier IDENTIFIER (COMMA IDENTIFIER)*
	->	^(LOCAL $type_ IDENTIFIER)+
	;

const_decl_statement
	:	CONST qualifier IDENTIFIER BECOMES const_value (COMMA IDENTIFIER BECOMES const_value)*
	->	^(CONST qualifier IDENTIFIER const_value)+
	;
	
const_value
	:	literal_value
	|	LCURLYBRACE literal_value (COMMA literal_value)* RCURLYBRACE
	->	^(ARRELEMS (^(ARRELEM literal_value))+)
	;
	
object_creation_expression
	:	NEW qualifier LPAREN argument_list RPAREN
	->	^(NEW qualifier argument_list?)
	;
	
array_creation_expression_elemented
	:	NEW qualifier LCURLYBRACE expression (COMMA expression)* RCURLYBRACE
	->	^(NEWARRELEMS qualifier ^(ARRELEMS (^(ARRELEM expression))*))
	;
	
array_creation_expression
	:	NEW qualifier LBRACKET expression RBRACKET
	->	^(NEWARR qualifier expression)
	;

expression
	:	assignment_expression
	;
	
assignment_expression
	:	t1=control_expression (options {greedy=true;} : (b=BECOMES^ | ADDEVENT^ | REMEVENT^) t2=assignment_expression)?
	;

control_expression
	:	WHILE LPAREN scope_expr RPAREN expression
	->	^(WHILE scope_expr expression)
	|	FOR LPAREN type_=qualifier IDENTIFIER IN expression RPAREN do_=expression
	->	^(FOR ^(LOCAL $type_ IDENTIFIER) expression $do_)
	|	TRY expression (finally_block | (options {greedy=true;} : catch_block+ finally_block?))
	->	^(TRY expression catch_block* finally_block?)
	|	IF LPAREN scope_expr RPAREN THEN expression (options {greedy=true;} : ELSE expression)?
	->	^(IF scope_expr expression expression?)
	|	THROW expression
	->	^(THROW expression)
	|	conditional_or_operator_expression
	;
	
conditional_or_operator_expression
	:	conditional_and_operator_expression (OR^ conditional_and_operator_expression)*
	;

conditional_and_operator_expression
	:	logic_or_operator_expression (AND^ logic_or_operator_expression)*
	;

logic_or_operator_expression
	:	logic_xor_operator_expression (LOR^ logic_xor_operator_expression)*
	;

logic_xor_operator_expression
	:	logic_and_operator_expression (LXOR^ logic_and_operator_expression)*
	;

logic_and_operator_expression
	:	logic_expression (LAND^ logic_expression)*
	;

logic_expression
	:	cast_as_expression ((LE^ | LEQ^ | GE^ | GEQ^ | EQ^ | NEQ^) cast_as_expression)*
	;

cast_as_expression
	:	primary_expression ((AS^ | IS^) qualifier)*
	;
	
primary_expression
	:	secundary_expression ((PLUS^ | MINUS^) secundary_expression)*
	;
	
secundary_expression
	:	logicnotoperator_expression ((MULTIPLY^ | DIVISION^ | MOD^) logicnotoperator_expression )*
	;

logicnotoperator_expression
	:	(NOT^ | PLUS^ | MINUS^)* cast_expression
	;

cast_expression
	:	(LPAREN qualifier RPAREN cast_expression) => (LPAREN qualifier RPAREN cast_expression)
	->	^(CAST qualifier cast_expression)
	|	invocation_or_load_expression
	;

invocation_or_load_expression
	:	operand ((DCOLON^ IDENTIFIER (LPAREN! argument_list RPAREN!)?) | (LBRACKET^ expression RBRACKET!))*
	;
	
operand
	:	qualifier
	->  ^(USAGE qualifier)
	|	NUMBER
	|	FLOAT
	|	STRING
	|	CHAR
	|	TRUE
	|	FALSE
	|	NULL
	|	THIS
	|	BASE
	|	(NEW qualifier LPAREN) => object_creation_expression
	|	(NEW qualifier LBRACKET) => array_creation_expression
	|	(NEW qualifier LCURLYBRACE) => array_creation_expression_elemented
	|	(READ LPAREN IDENTIFIER RPAREN) => READ LPAREN IDENTIFIER RPAREN
	->	^(READ IDENTIFIER)
	|	READ LPAREN IDENTIFIER (COMMA IDENTIFIER)+ RPAREN
	->	^(SCOPEEXPR ^(READVOID IDENTIFIER)+)
	|	(WRITE LPAREN expression RPAREN) => WRITE LPAREN expression RPAREN
	->	^(WRITE expression)
	|	WRITE LPAREN expression (COMMA expression)+ RPAREN
	->	^(SCOPEEXPR ^(WRITEVOID expression)+)
	|	LPAREN expression RPAREN
	->	^(EXPRBLOCK expression)
	|	block_expression
	;
	
block_expression
	:	LCURLYBRACE statement* RCURLYBRACE
	->	^(SLIST statement*)
	;

parameter_list
	:	(qualifier IDENTIFIER (COMMA qualifier IDENTIFIER)*)?
	->	^(PARAMETER (qualifier IDENTIFIER)*)
	;

argument_list
	:	(expression (COMMA expression)*)?
	->	^(ALIST ^(ARGUMENT expression)*)
	;
	
type_qualifier
	:	VOID
	|	qualifier
	;
	
qualifier
	:	(IDENTIFIER (PERIOD IDENTIFIER)* (LBRACKET RBRACKET)) => (IDENTIFIER (PERIOD IDENTIFIER)* (LBRACKET RBRACKET))
	->	^(FQUALIFIER IDENTIFIER+ ARRAY)
	|	IDENTIFIER (PERIOD IDENTIFIER)*
	->	^(FQUALIFIER IDENTIFIER+)
	;

access_modifier
	:	PRIVATE | PUBLIC | PROTECTED | INTERNAL
	;
	
virtual_modifier
	:	VIRTUAL | OVERRIDE
	;
	
	
// LEXER
IDENTIFIER
	:   (LETTER | '_') (LETTER | DIGIT | '_')*
	;

STRING
	:	('"' (QUOTED_CHARACTER | ~('"' | '\\'))* '"')
	;

CHAR
	:	'\'' (QUOTED_CHARACTER | ~('\'' | '\\')) '\''
	;
	
QUOTED_CHARACTER
	:	'\\' .
	;
	
NUMBER
	:   (MINUS | PLUS)? DIGIT+
	;

FLOAT
	:	(MINUS | PLUS)? DIGIT+ '.' DIGIT+
	;
	
COMMENT
	:   '//' .* '\n' 
		{ $channel=HIDDEN; }
		| '/*' .* '*/'
		{ $channel=HIDDEN; }
	;

WS
	:   (' ' | '\t' | '\f' | '\r' | '\n')+
		{ $channel=HIDDEN; }
	;

fragment DIGIT  :   ('0'..'9') ;
fragment LOWER  :   ('a'..'z') ;
fragment UPPER  :   ('A'..'Z') ;
fragment LETTER :   LOWER | UPPER ;
