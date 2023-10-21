using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelWrapper
{
    public class FilterItemViewModel
    {
        public string Name { get; set; }

        public string NumberOfElements { get; set; }

        public FilterItemViewModel(string name, string nbOfElements)
        {
            Name = name;
            NumberOfElements = nbOfElements;
        }
    }
}
