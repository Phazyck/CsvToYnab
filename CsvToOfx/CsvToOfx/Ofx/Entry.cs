using CsvToOfx.Exportable;
using CsvToOfx.Output;
using CsvToOfx.Lookup;

namespace CsvToOfx.Ofx
{
    public class Entry : IExportable
    {
        private static string EntryPrefix(LookupEntry entry)
        {
            switch(entry)
            {
                case LookupEntry.Amount: return "<TRNAMT>";
                case LookupEntry.Checknum: return "<CHECKNUM>";
                case LookupEntry.Date: return "<DTPOSTED>";
                case LookupEntry.Memo: return "<MEMO>";
                case LookupEntry.Payee: return "<NAME>";
                default: return $"<{entry}>";
            }
        }

        private string tag;
        private string value;

        public Entry(string tag, string value)
        {
            this.tag = tag;
            this.value = value;
        }

        public Entry(LookupEntry entry, string value) : this(EntryPrefix(entry), value)
        {

        }

        public void ExportTabbedTo(TabbedOutput output)
        {
            ExportTo(output);
        }

        public void ExportTo(IOutput output)
        {
            output.Write(tag);
            output.Write(value);
            output.EndLine();
        }
    }
}
