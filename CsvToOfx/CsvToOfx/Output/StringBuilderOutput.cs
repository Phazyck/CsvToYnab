using System.Text;

namespace CsvToOfx.Output
{
    public class StringBuilderOutput : IOutput
    {
        private StringBuilder builder = new StringBuilder();

        public void Write(string s)
        {
            builder.Append(s);
        }

        public void EndLine()
        {
            builder.Append('\n');
        }

        public override string ToString()
        {
            return builder.ToString();
        }
    }
}
