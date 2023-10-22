using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyToolkit
{
    public class RelayCommand2<T> : ICommand
    {

        private readonly Action<T> execute;
        private readonly Func<T, bool> canExecute;

        public RelayCommand2(Action<T> execute, Func<T, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return parameter == null ? true : canExecute((T)parameter);
        }

        public void Execute(object? parameter)
        {
            T param = (T)parameter;
            execute(param);
        }
    }

    public class RelayCommand2 : RelayCommand2<object>
    {
        public RelayCommand2(Action execute, Func<bool> canExecute)
            : base(new Action<object>(e => execute()), new Func<object, bool>(o => canExecute != null ? canExecute() : true))
        {
        }
    }
}
