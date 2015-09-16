using CsvToOfx.Config;
using CsvToOfx.Exportable;
using CsvToOfx.Lookup;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CsvToOfx.Ofx
{
    public class Statement : AComplexExportable
    {
        private static readonly string[] prefixes = new string[]
        {
            "<STMTTRN>"
        };

        private static readonly string[] suffixes = new string[]
        {
            "</STMTTRN>"
        };

        private List<Entry> entries = new List<Entry>();

        public Statement(List<string> row, Configuration configuration)
        {
            LookupTable table = configuration.LookupTable;
            string s = "";

            if (table.Lookup(LookupEntry.Amount, row, ref s))
            {
                float amount = float.Parse(s, configuration.NumberFormatInfo);
                string value = amount.ToString();
                AddEntry(LookupEntry.Amount, value);
            }

            if (table.Lookup(LookupEntry.Checknum, row, ref s))
            {
                int checknum = int.Parse(s);
                string value = checknum.ToString();
                AddEntry(LookupEntry.Checknum, value);
            }

            if (table.Lookup(LookupEntry.Date, row, ref s))
            {
                DateTime dateTime = DateTime.ParseExact(s, configuration.DateFormat, DateTimeFormatInfo.InvariantInfo);
                int day = dateTime.Day;
                int month = dateTime.Month;
                int year = dateTime.Year;
                string value = dateTime.ToString("yyyyMMdd");
                AddEntry(LookupEntry.Date, value);
            }

            if (table.Lookup(LookupEntry.Memo, row, ref s))
            {
                string memo = s;
                string value = memo;
                AddEntry(LookupEntry.Memo, value);

            }

            if (table.Lookup(LookupEntry.Payee, row, ref s))
            {
                string payee = s;
                string value = payee;
                AddEntry(LookupEntry.Payee, value);
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
            return entries;
        }

        public void AddEntry(LookupEntry entry, string value)
        {
            entries.Add(new Entry(entry, value));
        }
    }
}
