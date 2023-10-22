using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyToolkit
{
    public class RelayCommand<TParam> : ICommand
    {
        private Action<TParam> execute;

        private Func<TParam, bool> canExecute;

        public event EventHandler? CanExecuteChanged;

        public RelayCommand(Action<TParam> execute, Func<TParam, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            try
            {
                return canExecute((TParam)parameter);
            }
            catch { throw new InvalidCastException(); }
        }

        public void Execute(object? parameter)
        {
            try
            {
                execute((TParam)parameter);
            }
            catch
            {
                throw new InvalidCastException();
            }
        }

        public void Refresh() => CanExecuteChanged?.Invoke(this, new EventArgs());
    }
}
