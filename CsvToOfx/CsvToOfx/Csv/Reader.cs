using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace CsvToOfx.Csv
{
    public class Reader
    {
        public const char STANDARD_SEPARATOR = ';';
        private const char QUOTE = '"';
        private string commaSeparators;

        private string ParseQuotedEntry(string line, ref int index)
        {
            int startIndex = index;
            int length = 0;

            while(true)
            {
                Debug.Assert(index < line.Length);
                
                if(line[index++] == QUOTE)
                {
                    break;
                }
                
                ++length;
            }

            string result = line.Substring(startIndex, length);
            return(result);
        }

        private bool IsSeparator(char character)
        {
            foreach(char commaSeparator in commaSeparators)
            {
                if(character == commaSeparator)
                {
                    return true;
                }
            }

            return false;
        }

        private string ParseEntry(string line, ref int index)
        {
            if(line[index] == QUOTE)
            {
                ++index;
                string entry = ParseQuotedEntry(line, ref index);
                
                Debug.Assert(index == line.Length || IsSeparator(line[index++]));
                return entry;
            }
            else
            {
                int startIndex = index;
                int length = 0;

                while(index < line.Length)
                {
                    if (IsSeparator(line[index++]))
                    {
                        break;
                    }
                    
                    ++length;
                }

                string result = line.Substring(startIndex, length);
                return(result);
            }
        }

        private List<string> ParseLine(StreamReader reader)
        {
            List<string> result = new List<string>();
            string line = reader.ReadLine();

            int index = 0;
            while(index < line.Length)
            {
                string entry = ParseEntry(line, ref index);
                result.Add(entry);
            }

            return (result);
        }

        public List<List<string>> ReadFile(string filename, int skipLines = 0)
        {
            List<List<string>> result = new List<List<string>>();

            using (StreamReader reader = new StreamReader(filename))
            {
                for (int skipLine = 0; skipLine < skipLines; ++skipLine)
                {
                    if (reader.EndOfStream)
                    {
                        break;
                    }
                    else
                    {
                        reader.ReadLine();
                    }
                }

                while (!reader.EndOfStream)
                {
                    List<string> line = ParseLine(reader);
                    result.Add(line);
                }
            }
            
            return(result);
        }

        public Reader(string commaSeparators)
        {
            this.commaSeparators = commaSeparators;
        }

        public Reader(char commaSeparator = STANDARD_SEPARATOR) : this(commaSeparator.ToString())
        {
        }
    }
}
