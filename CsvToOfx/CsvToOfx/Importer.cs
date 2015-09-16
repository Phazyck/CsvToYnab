using CsvToOfx.Config;
using CsvToOfx.Ofx;
using System.Collections.Generic;


namespace CsvToOfx
{
    public class Importer
    {
        private Configuration configuration;

        public Importer(Configuration configuration)
        {
            this.configuration = configuration;
        }

        public Transactions ImportTransations(string filename)
        {
            Csv.Reader inputReader = new Csv.Reader(configuration.CommaSeparators);

            List<List<string>> data = inputReader.ReadFile(filename, configuration.SkipLines);

            Transactions transactions = new Transactions(data, configuration);

            return (transactions);
        }
    }
}
