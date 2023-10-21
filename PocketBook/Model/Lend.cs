using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Lend
    {
        public string PersonName { get; set; }
        public IEnumerable<int> BookIdsBorrowed { get; set; }

        public Lend() { }
    }
}
