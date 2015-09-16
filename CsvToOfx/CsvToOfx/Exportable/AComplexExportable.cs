using CsvToOfx.Output;
using System.Collections.Generic;

namespace CsvToOfx.Exportable
{
    public abstract class AComplexExportable : IExportable
    {
        public abstract IEnumerable<string> GetPrefixes();
        public abstract IEnumerable<string> GetSuffixes();
        public abstract IEnumerable<IExportable> GetChildren();

        public void ExportTabbedTo(TabbedOutput output)
        {
            foreach (string prefix in GetPrefixes())
            {
                output.WriteLine(prefix);
                output.Tab();
            }

            foreach (IExportable child in GetChildren())
            {
                child.ExportTabbedTo(output);
            }

            foreach (string suffix in GetSuffixes())
            {
                output.UnTab();
                output.WriteLine(suffix);
            }
        }

        public void ExportTo(IOutput output)
        {
            foreach (string prefix in GetPrefixes())
            {
                output.WriteLine(prefix);
            }

            foreach (IExportable child in GetChildren())
            {
                child.ExportTo(output);
            }

            foreach (string suffix in GetSuffixes())
            {
                output.WriteLine(suffix);
            }
        }
    }
}
