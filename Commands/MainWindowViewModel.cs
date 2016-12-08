using System;
using System.Windows;
using System.Windows.Input;

namespace Commands
{
    public class MainWindowViewModel
    {
        #region [--KeyBindingCommand--]

        private ICommand _keyBindingCommand;

        public ICommand KeyBindingCommand
        {
            get { return _keyBindingCommand = _keyBindingCommand ?? new RelayCommand(KeyBinding); }
        }

        private void KeyBinding()
        {
            MessageBox.Show("F5 pressed");
        }

        #endregion [--KeyBindingCommand--]    

    }

    public class RelayCommand : ICommand
    {
        private Action _action;

        public RelayCommand(Action action)
        {
            _action = action;
        }

        #region Implementation of ICommand

        public void Execute(object parameter)
        {
            _action();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        #endregion
    }
}