using CsvToOfx.Output;

namespace CsvToOfx.Exportable
{
    public interface IExportable
    {
        void ExportTo(IOutput output);
        void ExportTabbedTo(TabbedOutput output);
    }
}
