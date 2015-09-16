using CsvToOfx.Config;
using System;
using System.Windows.Forms;

namespace ConfigurationEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigurationForm configurationForm = new ConfigurationForm();
            configurationForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            Application.Run(configurationForm);
        }
    }
}
