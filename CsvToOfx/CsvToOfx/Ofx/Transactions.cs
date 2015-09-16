using CsvToOfx.Config;
using CsvToOfx.Exportable;
using System.Collections.Generic;

namespace CsvToOfx.Ofx
{
    public class Transactions : AComplexExportable
    {
        private static readonly string[] prefixes = new string[]
        {
            "<OFX>",
            "<BANKMSGSRSV1>",
            "<STMTTRNRS>",
            "<STMTRS>",
            "<BANKTRANLIST>"
        };

        private static readonly string[] suffixes = new string[]
        {
            "</BANKTRANLIST>",
            "</STMTRS>",
            "</STMTTRNRS>",
            "</BANKMSGSRSV1>",
            "</OFX>"
        };

        private List<Statement> statements = new List<Statement>();

        public Transactions(List<List<string>> data, Configuration configuration)
        {
            foreach (List<string> row in data)
            {
                AddStatement(new Statement(row, configuration));
            }
        }
        
        public override IEnumerable<string> GetPrefixes()
        {
            return prefixes;
        }

        public override IEnumerable<string> GetSuffixes()
        {
            return suffixes;
        }

        public override IEnumerable<IExportable> GetChildren()
        {
            return statements;
        }

        public void AddStatement(Statement statement)
        {
            statements.Add(statement);
        }
    }
}
