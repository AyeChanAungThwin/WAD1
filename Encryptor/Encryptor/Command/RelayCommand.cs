﻿using System;
using System.Windows.Input;

namespace Encryptor.Command
{
    public class RelayCommand: ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<object> _execute { get; set; }
        private Predicate<object> _canExecute { get; set; }

        public RelayCommand(Action<object> executeMethod, Predicate<object> canExecuteMethod = null)
        {
            _execute = executeMethod;
            _canExecute = canExecuteMethod;
        }
        
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}