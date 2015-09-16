using System.IO;

namespace CsvToOfx.Output
{
    public class FileOutput : StreamWriter, IOutput
    {
        public FileOutput(string filename) : base(filename)
        {
        }
        
        public void EndLine()
        {
            Write(NewLine);
        }
    }
}
