using Irony.Parsing;

namespace AtlanticBPM.Core.Tools.Grammar
{
    internal sealed class StatementGrammar : BaseGrammar
    {
        protected override NonTerminal GetRootNonTerminal()
        {
            return statement_list;
        }
    }
}
