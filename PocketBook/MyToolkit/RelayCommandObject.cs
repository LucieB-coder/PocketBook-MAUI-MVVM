using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToolkit
{
    public class RelayCommandObject : RelayCommand<object>
    {
        public RelayCommandObject(Action<object> execute, Func<object, bool> canExecute = null) : base(execute, canExecute) { }
    }
}
