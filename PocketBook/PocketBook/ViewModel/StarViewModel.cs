using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketBook.ViewModel
{
    
    public class StarViewModel
    {
        public int Grade { get; set; }
        public string Color { get; set; }

        public StarViewModel(int Grade, string Color)
        {
            this.Grade = Grade;
            this.Color = Color;
        }
    }
}
