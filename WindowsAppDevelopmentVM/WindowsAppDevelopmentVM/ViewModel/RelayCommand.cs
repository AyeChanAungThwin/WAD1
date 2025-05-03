using System;
using System.Windows.Input;

namespace WindowsAppDevelopmentVM
{
    public class RelayCommand: ICommand
    {
        public event EventHandler CanExecutedChanged;
        private Action<object> _executeMethod { get; set; }
        private Predicate<object> _canExecute { get; set; }

        public RelayCommand(Action<object> executeMethodMethod, Predicate<object> canExecute)
        {
            _executeMethod = executeMethodMethod;
            _canExecute = canExecute;
        }
        
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _executeMethod(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}