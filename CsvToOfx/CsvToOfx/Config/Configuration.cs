using CsvToOfx.Lookup;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace CsvToOfx.Config
{
    public class Configuration
    {
        private const string KEY_STRING_COMMASEPARATORS = "CommaSeparators";
        private const string KEY_STRING_DATEFORMAT = "DateFormat";
        private const string KEY_STRING_SKIP_LINES = "SkipLines";
        private const string KEY_STRING_NUMBER_DECIMAL_SEPARATOR = "NumberDecimalSeparator";
        private const string KEY_STRING_NUMBER_GROUP_SEPARATOR = "NumberGroupSeparator";
        
        private const string DEFAULT_NAME = "config.csv";

        private static string DEFAULT_PATH 
        {
            get {
                string uriString = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
                Uri uri = new Uri(uriString);
                string dir = Path.GetDirectoryName(uri.LocalPath);
                string path = Path.Combine(dir, DEFAULT_NAME);
                return path;
            }
        }

        private static char DEFAULT_SEPARATOR = ';';

        public LookupTable LookupTable { get; set; } = new LookupTable();

        public string CommaSeparators { get; set; } = Csv.Reader.STANDARD_SEPARATOR.ToString();

        public int SkipLines { get; set; } = 0;

        public string DateFormat { get; set; } = "yyyyMMdd";

        public NumberFormatInfo NumberFormatInfo
        {
            get; private set;
        } = new NumberFormatInfo { NumberDecimalSeparator = ".", NumberGroupSeparator = ","};

        public Configuration()
        {

        }

        private bool LoadFormat(List<string> row)
        {
            string key = row[0];
            if (key.Equals(KEY_STRING_DATEFORMAT, StringComparison.InvariantCultureIgnoreCase))
            {
                DateFormat = row[1];
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LoadNumberGroupSeparator(List<string> row)
        {
            string key = row[0];
            if (key.Equals(KEY_STRING_NUMBER_GROUP_SEPARATOR, StringComparison.InvariantCultureIgnoreCase))
            {
                NumberFormatInfo.NumberGroupSeparator = row[1];
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LoadNumberDecimalSeparator(List<string> row)
        {
            string key = row[0];
            if (key.Equals(KEY_STRING_NUMBER_DECIMAL_SEPARATOR, StringComparison.InvariantCultureIgnoreCase))
            {
                NumberFormatInfo.NumberDecimalSeparator = row[1];
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LoadSkipLines(List<string> row)
        {
            string key = row[0];
            if (key.Equals(KEY_STRING_SKIP_LINES, StringComparison.InvariantCultureIgnoreCase))
            {
                SkipLines = int.Parse(row[1]);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LoadCommaSeparators(List<string> row)
        {
            string key = row[0];
            if(key.Equals(KEY_STRING_COMMASEPARATORS, StringComparison.InvariantCultureIgnoreCase))
            {
                CommaSeparators = row[1];
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LoadLookupEntry(List<string> row)
        {
            LookupEntry key = LookupTable.ParseEntry(row[0]);
            bool ignore = bool.Parse(row[1]);
            int value = int.Parse(row[2]);
            LookupTable.IsEnabled[key] = ignore;
            LookupTable[key] = value;
            
            return true;
        }



        private Configuration(string filename)
        {
            Csv.Reader reader = new Csv.Reader(DEFAULT_SEPARATOR);
            List<List<string>> data = reader.ReadFile(filename);

            foreach (List<string> row in data)
            {
                if (LoadFormat(row) ||
                    LoadNumberGroupSeparator(row) ||
                    LoadNumberDecimalSeparator(row) ||
                    LoadSkipLines(row) ||
                    LoadCommaSeparators(row) ||
                    LoadLookupEntry(row))
                {
                    continue;
                }
                else
                {
                    Debug.Assert(false);
                }
            }
        }

        public static Configuration LoadDefaultConfiguration()
        {
            return LoadConfiguration(DEFAULT_PATH);
        }

        public static Configuration LoadConfiguration(string filename)
        {
            return new Configuration(filename);
        }

        private static void WriteCsvLine(StreamWriter writer, object key, object value)
        {
            writer.WriteLine($"\"{key}\"{DEFAULT_SEPARATOR}\"{value}\"");
        }

        private static void WriteCsvLine(StreamWriter writer, object key, object value1, object value2)
        {
            writer.WriteLine($"\"{key}\"{DEFAULT_SEPARATOR}\"{value1}\"{DEFAULT_SEPARATOR}\"{value2}\"");
        }

        public static void SaveConfiguration(Configuration configuration, string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                LookupTable table = configuration.LookupTable;

                foreach (var pair in table)
                {
                    LookupEntry key = pair.Key;
                    bool ignore = table.IsEnabled[key];
                    int index = pair.Value;
                    WriteCsvLine(writer, key, ignore, index);
                }
                        
                WriteCsvLine(writer, KEY_STRING_COMMASEPARATORS, configuration.CommaSeparators);
                WriteCsvLine(writer, KEY_STRING_DATEFORMAT, configuration.DateFormat);
                WriteCsvLine(writer, KEY_STRING_SKIP_LINES, configuration.SkipLines);
                WriteCsvLine(writer, KEY_STRING_NUMBER_DECIMAL_SEPARATOR, configuration.NumberFormatInfo.NumberDecimalSeparator);
                WriteCsvLine(writer, KEY_STRING_NUMBER_GROUP_SEPARATOR, configuration.NumberFormatInfo.NumberGroupSeparator);
                writer.Flush();
                writer.Close();
            }
        }

        public static void SaveDefaultConfiguration(Configuration configuration)
        {
            SaveConfiguration(configuration, DEFAULT_PATH);
        }
    }
}