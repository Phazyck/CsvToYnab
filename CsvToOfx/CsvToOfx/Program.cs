using System;
using CsvToOfx.Output;
using System.IO;
using CsvToOfx.Config;
using CsvToOfx.Ofx;

namespace CsvToOfx
{
    public class Program
    {
        private static void Convert(Importer importer, string inputFile, string outputFile)
        {
            Transactions transactions = importer.ImportTransations(inputFile);

            //IOutput output = new ConsoleOutput();
            using (FileOutput output = new FileOutput(outputFile))
            {
                TabbedOutput tabbedOutput = new TabbedOutput(output);
                transactions.ExportTabbedTo(tabbedOutput);
            }
        }

        private static bool SplitName(string filename, ref string prefix, ref string suffix)
        {
            for(int index = filename.Length-1; index >= 0; --index)
            {
                if(filename[index] == '.')
                {
                    prefix = filename.Substring(0, index);
                    ++index;
                    suffix = filename.Substring(index, filename.Length - index);
                    return true;
                }
            }

            return false;
        }

        private static bool Convert(Importer importer, string filename)
        {
            string prefix = "";
            string suffix = "";

            if(SplitName(filename,ref prefix, ref suffix) && suffix.Equals("csv"))
            {
                string inputFile = filename;
                string outputFile = $"{prefix}.ofx";
                Console.WriteLine($"Converting \n  {inputFile}\nto\n  {outputFile}.");
                Convert(importer, inputFile, outputFile);
                return true;
            }
            else
            {
                return false;
            }

        }

        private static void ConvertAny(Importer importer, string[] args)
        {
            foreach(string arg in args)
            {
                bool success = Convert(importer, arg);
                if(!success)
                {
                    Console.WriteLine($"Unhandled argument: {arg}");
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                Configuration configuration = Configuration.LoadDefaultConfiguration();
                Console.WriteLine("Exporting...\n");

                Importer importer = new Importer(configuration);
                ConvertAny(importer, args);
                Console.WriteLine("...done!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not load config.csv.");
                Console.WriteLine(ex.StackTrace);


                CreateConfig();
            }
            
            Console.ReadLine();
            
        }

        private static void CreateConfig()
        {
            // TODO(oliver): Interactive creation of config file.
        }
    }
}