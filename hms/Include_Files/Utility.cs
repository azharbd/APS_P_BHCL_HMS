using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hms.Include_Files
{
    class Utility
    {
        public class ComboboxItem
        {

            public string Name;
            public int Value;
            public ComboboxItem(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
            

            
        }
    }
}
