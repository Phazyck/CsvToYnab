using System.Diagnostics;

namespace CsvToOfx.Output
{
    public class TabbedOutput : IOutput
    {
        private bool tabsInserted = false;
        private int tabs = 0;
        private string tabString;
        private IOutput output;

        public TabbedOutput(IOutput output, string tabString = "  ")
        {
            this.tabString = tabString;
            this.output = output;
        }

        private void EnsureTabs()
        {
            if (tabsInserted)
            {
                return;
            }

            for (int tab = 0; tab < tabs; ++tab)
            {
                output.Write(tabString);
            }

            tabsInserted = true;
        }


        public void Tab()
        {
            Debug.Assert((tabs + 1) > 0);
            ++tabs;
        }

        public void UnTab()
        {
            Debug.Assert(tabs > 0);
            --tabs;
        }

        public void Write(string s)
        {
            EnsureTabs();
            output.Write(s);
        }

        public void EndLine()
        {
            output.EndLine();
            tabsInserted = false;
        }

        public override string ToString()
        {
            return output.ToString();
        }
    }

}
