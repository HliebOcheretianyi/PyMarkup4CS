namespace AtlanticBPM.Core.Tools.Grammar
{
    internal sealed class ExpressionGrammar : BaseGrammar
    {
        protected override Irony.Parsing.NonTerminal GetRootNonTerminal()
        {
            return expression;
        }
    }
}
