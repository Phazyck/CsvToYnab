using System.Collections.Generic;
using System;

namespace CsvToOfx.Lookup
{
    public enum LookupEntry { Payee, Date, Amount, Memo, Checknum };

    public class LookupTable : Dictionary<LookupEntry, int>
    {
        public Dictionary<LookupEntry, bool> IsEnabled
        {
            get; private set;
        }

        public static LookupEntry ParseEntry(string entryString)
        {
            return (LookupEntry)Enum.Parse(typeof(LookupEntry), entryString, true);
        }

        public LookupTable()
        {
            Array keys = Enum.GetValues(typeof(LookupEntry));
            int value = 0;
            IsEnabled = new Dictionary<LookupEntry, bool>();
            foreach(LookupEntry key in keys)
            {
                this[key] = value++;
                IsEnabled[key] = true;
            }
        }
        
        public bool Lookup(LookupEntry entry, List<string> entries, ref string value)
        {
            if(!IsEnabled[entry])
            {
                return false;
            }

            int index = this[entry];
            if(index < 0)
            {
                return false;
            }
            if(index >= entries.Count)
            {
                return false;
            }

            value = entries[index];
            return true;
        }
    }
}
