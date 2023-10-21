using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    internal class Lends
    {
        public IEnumerable<Lend> lends { get; set; } = new List<Lend>
        {
            new Lend{ PersonName = "Mathilde", BookIdsBorrowed=new List<int>{8,1} },
            new Lend{ PersonName = "Nathan", BookIdsBorrowed = new List<int>{9} }
            
        };

        public IEnumerable<Lend> borrows { get; set; } = new List<Lend>
        {
            new Lend{PersonName="Guillaume", BookIdsBorrowed= new List<int>{ 5,6 } }
        };
    }
}
