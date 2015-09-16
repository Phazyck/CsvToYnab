namespace CsvToOfx.Output
{
    public interface IOutput
    {
        void Write(string s);
        void EndLine();
    }

    public static class OutputExtensions
    {
        public static void WriteLine(this IOutput output, string s)
        {
            output.Write(s);
            output.EndLine();
        }
    }
}
