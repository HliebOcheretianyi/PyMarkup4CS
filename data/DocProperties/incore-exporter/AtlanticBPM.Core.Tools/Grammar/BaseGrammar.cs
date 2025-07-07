using Irony.Parsing;
using System.Globalization;

namespace AtlanticBPM.Core.Tools.Grammar
{
    abstract class BaseGrammar : Irony.Parsing.Grammar
    {
        protected TerminalSet _skipTokensInPreview = new TerminalSet(); //used in token preview for conflict resolution

        #region Lexical structure

        public StringLiteral StringLiteral = TerminalFactory.CreateCSharpString("StringLiteral");
        public StringLiteral CharLiteral = TerminalFactory.CreateCSharpChar("CharLiteral");
        public NumberLiteral Number = TerminalFactory.CreateCSharpNumber("Number");
        public IdentifierTerminal identifier = TerminalFactory.CreateCSharpIdentifier("Identifier");

        public CommentTerminal SingleLineComment = new CommentTerminal("SingleLineComment", "//", "\r", "\n", "\u2085", "\u2028", "\u2029");
        public CommentTerminal DelimitedComment = new CommentTerminal("DelimitedComment", "/*", "*/");
        //Temporarily, treat preprocessor instructions like comments
        public CommentTerminal ppInstruction = new CommentTerminal("ppInstruction", "#", "\n");

        //Symbols
        public KeyTerm colon;
        public KeyTerm semi;
        public NonTerminal semi_opt = new NonTerminal("semi?");
        public KeyTerm dot;
        public KeyTerm comma;
        public NonTerminal comma_opt;
        public NonTerminal commas_opt = new NonTerminal("commas_opt");
        public KeyTerm qmark;
        public NonTerminal qmark_opt;
        public KeyTerm Lbr;
        public KeyTerm Rbr;
        public KeyTerm Lpar;
        public KeyTerm Rpar;

        public KeyTerm nullTerm;
        public KeyTerm trueTerm;
        public KeyTerm falseTerm;

        #endregion

        #region NonTerminals
        //B.2.1. Basic concepts
        public NonTerminal qual_name_with_targs = new NonTerminal("qual_name_with_targs");
        public NonTerminal qual_name_segment = new NonTerminal("qual_name_segment");
        public NonTerminal qual_name_segments_opt = new NonTerminal("qual_name_segments_opt");
        public NonTerminal type_or_void = new NonTerminal("type_or_void", "type or void");
        public NonTerminal type_ref_list = new NonTerminal("type_ref_list");
        public NonTerminal identifier_ext = new NonTerminal("identifier_ext");
        public NonTerminal identifier_or_builtin = new NonTerminal("identifier_or_builtin");

        //B.2.2. Types
        public NonTerminal type_ref = new NonTerminal("type_ref");
        public NonTerminal type_argument_list = new NonTerminal("type_argument_list");
        public NonTerminal typearg_or_gendimspec_list = new NonTerminal("typearg_or_gendimspec_list");

        //B.2.4. Expressions
        public NonTerminal argument = new NonTerminal("argument");
        public NonTerminal argument_list = new NonTerminal("argument_list");
        public NonTerminal argument_list_opt = new NonTerminal("argument_list_opt");
        public NonTerminal expression = new NonTerminal("expression", "expression");
        public NonTerminal conditional_expression = new NonTerminal("conditional_expression");
        public NonTerminal lambda_expression = new NonTerminal("lambda_expression");
        public NonTerminal unary_operator = new NonTerminal("unary_operator");
        public NonTerminal assignment_operator = new NonTerminal("assignment_operator");
        public NonTerminal primary_expression = new NonTerminal("primary_expression");
        public NonTerminal unary_expression = new NonTerminal("unary_expression");
        public NonTerminal literal = new NonTerminal("literal");
        public NonTerminal parenthesized_expression = new NonTerminal("parenthesized_expression");
        public NonTerminal member_access = new NonTerminal("member_access");
        public NonTerminal member_access_segment = new NonTerminal("member_access_segment");
        public NonTerminal member_access_segments_opt = new NonTerminal("member_access_segments_opt");
        public NonTerminal array_indexer = new NonTerminal("array_indexer");
        public NonTerminal argument_list_par = new NonTerminal("argument_list_par");
        public NonTerminal creation_args = new NonTerminal("creation_args");
        public NonTerminal object_creation_expression = new NonTerminal("object_creation_expression");
        public NonTerminal object_creation_expression_opt = new NonTerminal("object_creation_expression_opt");

        public NonTerminal initializer_value = new NonTerminal("initializer_value");

        public NonTerminal anonymous_function_body = new NonTerminal("anonymous_function_body");
        public NonTerminal bin_op_expression = new NonTerminal("bin_op_expression");
        public NonTerminal typecast_expression = new NonTerminal("typecast_expression");
        public NonTerminal bin_op = new NonTerminal("bin_op", "operator symbol");

        //B.2.5. Statements
        public NonTerminal statement = new NonTerminal("statement", "statement");
        public NonTerminal statement_list = new NonTerminal("statement_list");
        public NonTerminal statement_list_opt = new NonTerminal("statement_list_opt");
        public NonTerminal declaration_statement = new NonTerminal("declaration_statement");
        public NonTerminal embedded_statement = new NonTerminal("embedded_statement");
        public NonTerminal selection_statement = new NonTerminal("selection_statement");
        public NonTerminal iteration_statement = new NonTerminal("iteration_statement");
        public NonTerminal block = new NonTerminal("block");
        public NonTerminal statement_expression = new NonTerminal("statement_expression");
        public NonTerminal local_variable_declaration = new NonTerminal("local_variable_declaration");
        public NonTerminal local_variable_type = new NonTerminal("local_variable_type");
        public NonTerminal local_variable_declarator = new NonTerminal("local_variable_declarator");
        public NonTerminal if_statement = new NonTerminal("if_statement");
        public NonTerminal else_clause_opt = new NonTerminal("else_clause_opt");
        public NonTerminal while_statement = new NonTerminal("while_statement");

        public NonTerminal gen_lt = new NonTerminal("gen_lt");

        #endregion

        public BaseGrammar()
        {
            InitLexicalStructure();

            ConflictResolution();

            RegisterOperators();

            this.MarkPunctuation(";", ",", "(", ")", "{", "}", "[", "]", ":");

            this.MarkTransient(statement, embedded_statement, expression,
              literal, bin_op, unary_operator, primary_expression, expression,
              identifier_ext, type_or_void, qual_name_segment,
              type_ref_list, identifier_ext, identifier_or_builtin, statement_list_opt,
              gen_lt, typearg_or_gendimspec_list, qmark_opt, assignment_operator,
              local_variable_type, initializer_value, member_access_segment, parenthesized_expression,
              argument, argument_list_par, creation_args, block, declaration_statement,
              anonymous_function_body, selection_statement, iteration_statement, else_clause_opt);

            AddTermsReportGroup();

            Rules();

            this.Root = GetRootNonTerminal();

            _skipTokensInPreview.UnionWith(new Terminal[] { dot, identifier, comma, ToTerm("::"), comma, ToTerm("["), ToTerm("]") });
        }

        protected abstract NonTerminal GetRootNonTerminal();

        #region conflict resolution for "<"
        /* The shift-reduce conflict for "<" symbol is the problem of deciding what is "<" symbol in the input - is it 
 * opening brace for generic reference, or logical operator. The following is a printout of parser state that has a conflict
 * The handling code needs to run ahead and decide a proper action: if we see ">", then it is a generic bracket and we do shift; 
 * otherwise, it is an operator and we make Reduce
 * 
State S188 (Inadequate)
  Shift items:
    member_access_segments_opt -> member_access_segments_opt ·member_access_segment 
    member_access_segment -> ·. Identifier 
    member_access_segment -> ·array_indexer 
    array_indexer -> ·[ expression_list ] 
    member_access_segment -> ·argument_list_par 
    argument_list_par -> ·( argument_list_opt ) 
    member_access_segment -> ·type_argument_list 
    type_argument_list -> ·_<_ type_ref_list > 
    _<_ -> ·< 
  Reduce items:
    member_access -> identifier_ext member_access_segments_opt · [? , ) : ; } ] Identifier ++ -- || && | ^ & == != > <= >= << >> + - * / % = += -= *= /= %= &= |= ^= <<= >>= is as ?? <]
  Shifts: member_access_segment->S220, .->S221, array_indexer->S222, [->S223, argument_list_par->S224, (->S225, type_argument_list->S226, _<_->S59, 
   
*/
        //Here is an elaborate generic declaration which can be used as a good test. Perfectly legal, uncomment it to check that c#
        // accepts it:
        // List<Dictionary<string, object[,]>> genericVar; 
        private void ResolveLessThanConflict(ParsingContext context, CustomParserAction customAction)
        {
            var scanner = context.Parser.Scanner;
            string previewSym = null;
            if (context.CurrentParserInput.Term.Name == "<")
            {
                scanner.BeginPreview();
                int ltCount = 0;
                while (true)
                {
                    //Find first token ahead (using preview mode) that is either end of generic parameter (">") or something else
                    Token preview;
                    do
                    {
                        preview = scanner.GetToken();
                    } while (_skipTokensInPreview.Contains(preview.Terminal) && preview.Terminal != base.Eof);
                    //See what did we find
                    previewSym = preview.Terminal.Name;
                    if (previewSym == "<")
                        ltCount++;
                    else if (previewSym == ">" && ltCount > 0)
                    {
                        ltCount--;
                        continue;
                    }
                    else
                        break;
                }
                scanner.EndPreview(true); //keep previewed tokens; important to keep ">>" matched to two ">" symbols, not one combined symbol (see method below)
            }//if
            //if we see ">", then it is type argument, not operator
            ParserAction action;
            if (previewSym == ">")
                action = customAction.ShiftActions.First(a => a.Term.Name == "<");
            else
                action = customAction.ReduceActions.First();
            // Actually execute action
            action.Execute(context);
        }

        //In preview, we may run into combination '>>' which is a comletion of nested generic parameters.
        // It should be recognized as two ">" symbols, not a single ">>" operator
        // By default, the ">>" has higher priority over single ">" symbol because it is longer. 
        // When this method is called we force the selection to a single ">"
        public override void OnScannerSelectTerminal(ParsingContext context)
        {
            if (context.Source.PreviewChar == '>' && context.Status == ParserStatus.Previewing)
            {
                context.CurrentTerminals.Clear();
                context.CurrentTerminals.Add(ToTerm(">")); //select the ">" terminal
            }
            base.OnScannerSelectTerminal(context);
        }
        #endregion

        private void InitLexicalStructure()
        {
            NonGrammarTerminals.Add(SingleLineComment);
            NonGrammarTerminals.Add(DelimitedComment);
            NonGrammarTerminals.Add(ppInstruction);

            colon = ToTerm(":", "colon");
            semi = ToTerm(";", "semi");
            semi_opt.Rule = Empty | semi;
            dot = ToTerm(".", "dot");
            comma = ToTerm(",", "comma");
            comma_opt = new NonTerminal("comma_opt", Empty | comma);
            commas_opt.Rule = MakeStarRule(commas_opt, null, comma);
            qmark = ToTerm("?", "qmark");
            qmark_opt = new NonTerminal("qmark_opt", Empty | qmark);
            Lbr = ToTerm("{");
            Rbr = ToTerm("}");
            Lpar = ToTerm("(");
            Rpar = ToTerm(")");

            nullTerm = ToTerm("null", "null");
            trueTerm = ToTerm("true", "true");
            falseTerm = ToTerm("false", "false");
        }

        private void ConflictResolution()
        {
            gen_lt.Rule = CustomActionHere(this.ResolveLessThanConflict) + "<";
        }

        private void RegisterOperators()
        {
            RegisterOperators(1, "||");
            RegisterOperators(2, "&&");
            RegisterOperators(3, "|");
            RegisterOperators(4, "^");
            RegisterOperators(5, "&");
            RegisterOperators(6, "==", "!=");
            RegisterOperators(7, "<", ">", "<=", ">=", "is", "as");
            RegisterOperators(8, "<<", ">>");
            RegisterOperators(9, "+", "-");
            RegisterOperators(10, "*", "/", "%");
            RegisterOperators(-3, "=", "+=", "-=", "*=", "/=", "%=", "&=", "|=", "^=", "<<=", ">>=");
            RegisterOperators(-2, "?");
            RegisterOperators(-1, "??");
        }

        private void AddTermsReportGroup()
        {
            this.AddTermsReportGroup("assignment", "=", "+=", "-=", "*=", "/=", "%=", "&=", "|=", "^=", "<<=", ">>=");
            this.AddTermsReportGroup("typename", "bool", "decimal", "float", "double", "string", "object",
              "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "char");
            this.AddTermsReportGroup("statement", "if", "switch", "do", "while", "for", "foreach", "continue", "goto", "return", "try", "yield",
                                                  "break", "throw", "unchecked", "using");
            this.AddTermsReportGroup("type declaration", "public", "private", "protected", "static", "internal", "sealed", "abstract", "partial",
                                                         "class", "struct", "delegate", "interface", "enum");
            this.AddTermsReportGroup("member declaration", "virtual", "override", "readonly", "volatile", "extern");
            this.AddTermsReportGroup("constant", Number, StringLiteral, CharLiteral);
            this.AddTermsReportGroup("constant", "true", "false", "null");

            this.AddTermsReportGroup("unary operator", "+", "-", "!", "~");

            this.AddToNoReportGroup(comma, semi);
            this.AddToNoReportGroup("var", "const", "new", "++", "--", "this", "base", "checked", "lock", "typeof", "default",
                                     "{", "}", "[");
        }

        private void Rules()
        {
            //B.2.1. Basic concepts
            qual_name_segments_opt.Rule = MakeStarRule(qual_name_segments_opt, null, qual_name_segment);
            identifier_or_builtin.Rule = identifier;
            identifier_ext.Rule = identifier_or_builtin;
            qual_name_segment.Rule = dot + identifier
                                    | type_argument_list;
            qual_name_with_targs.Rule = identifier_or_builtin + qual_name_segments_opt;

            type_argument_list.Rule = gen_lt + type_ref_list + ">";
            typearg_or_gendimspec_list.Rule = type_argument_list | Empty;

            //B.2.2. Types
            type_or_void.Rule = qual_name_with_targs;

            type_ref.Rule = type_or_void + qmark_opt + typearg_or_gendimspec_list;
            type_ref_list.Rule = MakePlusRule(type_ref_list, comma, type_ref);

            var comma_list_opt = new NonTerminal("comma_list_opt");
            comma_list_opt.Rule = MakeStarRule(comma_list_opt, comma);

            //B.2.4. Expressions
            argument.Rule = expression;
            argument_list.Rule = MakePlusRule(argument_list, comma, argument);
            argument_list_opt.Rule = Empty | argument_list | lambda_expression;
            expression.Rule = conditional_expression
                          | bin_op_expression
                          | unary_expression
                          | typecast_expression
                          | primary_expression;
            unary_operator.Rule = ToTerm("+") | "-" | "!";
            assignment_operator.Rule = ToTerm("=");
            conditional_expression.Rule = expression + PreferShiftHere() + qmark + expression + colon + expression;// + ReduceThis();
            bin_op_expression.Rule = expression + bin_op + expression;

            typecast_expression.Rule = parenthesized_expression + primary_expression;
            primary_expression.Rule =
              literal
              | parenthesized_expression
              | member_access
              | object_creation_expression_opt;
            unary_expression.Rule = unary_operator + primary_expression;
            literal.Rule = Number | StringLiteral | CharLiteral | trueTerm | falseTerm | nullTerm;
            parenthesized_expression.Rule = Lpar + expression + Rpar;

            //joined invocation_expr and member_access; for member access left the most general variant
            member_access.Rule = identifier_ext + member_access_segments_opt | parenthesized_expression + member_access_segments_opt;
            member_access_segments_opt.Rule = MakeStarRule(member_access_segments_opt, null, member_access_segment);
            member_access_segment.Rule = dot + identifier
                                       | array_indexer
                                       | argument_list_par
                                       | type_argument_list;
            array_indexer.Rule = "[" + argument_list + "]";

            argument_list_par.Rule = Lpar + argument_list_opt + Rpar;

            initializer_value.Rule = expression;

            //delegate, anon-object, object
            object_creation_expression.Rule = "new" + qual_name_with_targs + qmark_opt + creation_args;
            object_creation_expression_opt.Rule = object_creation_expression + member_access_segments_opt;
            creation_args.Rule = argument_list_par;

            //anonymous method and lambda - we join explicit and implicit param definitions, making 'type' element optional
            // TODO: add after-parse check for this
            lambda_expression.Rule = identifier + "=>" + anonymous_function_body;
            anonymous_function_body.Rule = expression | block;

            //we don't use grammar expressions to specify operator precedence, so we combine all these grammar elements together
            // and define just bin_op_expression. Where to put it? 
            // In spec:     non_assignment_expression.Rule = conditional_expression | lambda_expression | query_expression;
            //I think it's a mistake; there must be additional entry here for arithm expressions, so we put them here. 
            // We also have to add "is" and "as" expressions here, as we don't build entire hierarchy of elements for expressing
            // precedence (where they appear in original spec); so we put them here 
            bin_op.Rule = ToTerm("<") | "||" | "&&" | "==" | "!=" | ">" | "<=" | ">=" | "+" | "-" | "*" | "/"
                        | "=";

            //type_check_expression.Rule = expression + "is" + type_ref | expression + "as" + type_ref;

            //B.2.5. Statements
            statement.Rule = declaration_statement | embedded_statement;
            statement.ErrorRule = SyntaxError + semi; //skip all until semicolon
            statement_list.Rule = MakePlusRule(statement_list, null, statement);
            statement_list_opt.Rule = Empty | statement_list;
            //declaration_statement
            declaration_statement.Rule = local_variable_declaration + semi;
            local_variable_declaration.Rule = local_variable_type + local_variable_declarator; //!!!
            local_variable_type.Rule = member_access; // | builtin_type; //to fix the conflict, changing to member-access here
            local_variable_declarator.Rule = identifier | identifier + "=" + initializer_value;
            //embedded_statement
            embedded_statement.Rule = block | semi /*empty_statement*/ | statement_expression + semi | selection_statement
                                     | iteration_statement;
            block.Rule = Lbr + statement_list_opt + Rbr;
            //selection (if and switch)
            selection_statement.Rule = if_statement;
            if_statement.Rule = ToTerm("if") + parenthesized_expression + embedded_statement + else_clause_opt;
            else_clause_opt.Rule = Empty | PreferShiftHere() + "else" + embedded_statement;
            //iteration statements
            iteration_statement.Rule = while_statement;
            while_statement.Rule = "while" + parenthesized_expression + embedded_statement;

            //expression statement
            statement_expression.Rule = object_creation_expression_opt
                                      | member_access | member_access + assignment_operator + expression;
        }

        public override void SkipWhitespace(ISourceStream source)
        {
            while (!source.EOF())
            {
                var ch = source.PreviewChar;
                switch (ch)
                {
                    case ' ':
                    case '\t':
                    case '\r':
                    case '\n':
                    case '\v':
                    case '\u2085':
                    case '\u2028':
                    case '\u2029':
                        source.PreviewPosition++;
                        break;
                    default:
                        //Check unicode class Zs
                        UnicodeCategory chCat = char.GetUnicodeCategory(ch);
                        if (chCat == UnicodeCategory.SpaceSeparator) //it is whitespace, continue moving
                            continue;//while loop 
                        //Otherwize return
                        return;
                }//switch
            }//while
        }
    }
}
