using System;

namespace CsvToOfx.Output
{
    public class ConsoleOutput : IOutput
    {
        public void EndLine()
        {
            Console.WriteLine();
        }

        public void Write(string s)
        {
            Console.Write(s);
        }
    }
}
