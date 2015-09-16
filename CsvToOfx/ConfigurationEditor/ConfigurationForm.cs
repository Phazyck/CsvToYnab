using CsvToOfx.Config;
using CsvToOfx.Lookup;
using System;
using System.Windows.Forms;

namespace ConfigurationEditor
{
    public partial class ConfigurationForm : Form
    {
        private Configuration configuration;
        
        public ConfigurationForm()
        {
            try
            {
                configuration = Configuration.LoadDefaultConfiguration();
            }
            catch(Exception)
            {
                configuration = new Configuration();
            }

            InitializeComponent();

            ResetFields();
        }

        private void checkBoxPayee_CheckedChanged(object sender, System.EventArgs e)
        {
            numericUpDownPayee.Enabled = checkBoxPayee.Checked;
        }

        private void checkBoxDate_CheckedChanged(object sender, System.EventArgs e)
        {
            numericUpDownDate.Enabled = checkBoxDate.Checked;
        }

        private void checkBoxAmount_CheckedChanged(object sender, System.EventArgs e)
        {
            numericUpDownAmount.Enabled = checkBoxAmount.Checked;
        }

        private void checkBoxMemo_CheckedChanged(object sender, System.EventArgs e)
        {
            numericUpDownMemo.Enabled = checkBoxMemo.Checked;
        }

        private void checkBoxCheckNum_CheckedChanged(object sender, System.EventArgs e)
        {
            numericUpDownCheckNum.Enabled = checkBoxCheckNum.Checked;
        }

        private void buttonApply_Click(object sender, System.EventArgs e)
        {

            configuration.LookupTable.IsEnabled[LookupEntry.Payee] = checkBoxPayee.Checked;
            configuration.LookupTable.IsEnabled[LookupEntry.Date] = checkBoxDate.Checked;
            configuration.LookupTable.IsEnabled[LookupEntry.Amount] = checkBoxAmount.Checked;
            configuration.LookupTable.IsEnabled[LookupEntry.Memo] = checkBoxMemo.Checked;
            configuration.LookupTable.IsEnabled[LookupEntry.Checknum] = checkBoxCheckNum.Checked;
            configuration.LookupTable[LookupEntry.Payee] = (int)numericUpDownPayee.Value;
            configuration.LookupTable[LookupEntry.Date] = (int)numericUpDownDate.Value;
            configuration.LookupTable[LookupEntry.Amount] = (int)numericUpDownAmount.Value;
            configuration.LookupTable[LookupEntry.Memo] = (int)numericUpDownMemo.Value;
            configuration.LookupTable[LookupEntry.Checknum] = (int)numericUpDownCheckNum.Value;
            configuration.DateFormat = textBoxDateFormat.Text;
            configuration.CommaSeparators = textBoxCommaSeparators.Text;
            configuration.SkipLines = (int)numericUpDownSkipLines.Value;
            configuration.NumberFormatInfo.NumberDecimalSeparator = textBoxNumberDecimalSeparator.Text;
            configuration.NumberFormatInfo.NumberGroupSeparator = textBoxNumberGroupSeparator.Text;
            
            Configuration.SaveDefaultConfiguration(configuration);
        }

        private void ResetFields()
        {
            checkBoxPayee.Checked = configuration.LookupTable.IsEnabled[LookupEntry.Payee];
            checkBoxDate.Checked = configuration.LookupTable.IsEnabled[LookupEntry.Date];
            checkBoxAmount.Checked = configuration.LookupTable.IsEnabled[LookupEntry.Amount];
            checkBoxMemo.Checked = configuration.LookupTable.IsEnabled[LookupEntry.Memo];
            checkBoxCheckNum.Checked = configuration.LookupTable.IsEnabled[LookupEntry.Checknum];
            numericUpDownPayee.Value = configuration.LookupTable[LookupEntry.Payee];
            numericUpDownDate.Value = configuration.LookupTable[LookupEntry.Date];
            numericUpDownAmount.Value = configuration.LookupTable[LookupEntry.Amount];
            numericUpDownMemo.Value = configuration.LookupTable[LookupEntry.Memo];
            numericUpDownCheckNum.Value = configuration.LookupTable[LookupEntry.Checknum];
            textBoxDateFormat.Text = configuration.DateFormat;
            textBoxCommaSeparators.Text = configuration.CommaSeparators;
            numericUpDownSkipLines.Value = configuration.SkipLines;
            textBoxNumberDecimalSeparator.Text = configuration.NumberFormatInfo.NumberDecimalSeparator;
            textBoxNumberGroupSeparator.Text = configuration.NumberFormatInfo.NumberGroupSeparator;

        }

        private void buttonReset_Click(object sender, System.EventArgs e)
        {
            ResetFields();
        }
    }
}
