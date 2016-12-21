using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BindingToParentsDataContext
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region [--NumInMainWindowDataContext--]

        private int _numInMainWindowDataContext = 10;

        public int NumInMainWindowDataContext
        {
            get { return _numInMainWindowDataContext; }
            set
            {
                if (_numInMainWindowDataContext == value) return;
                _numInMainWindowDataContext = value;
                RaisePropertyChanged(() => NumInMainWindowDataContext);
            }
        }

        #endregion [--NumInMainWindowDataContext--]

        #region [--StartTestCommand--]

        private ICommand _startTestCommand;

        public ICommand StartTestCommand
        {
            get { return _startTestCommand = _startTestCommand ?? new RelayCommand(StartTest); }
        }

        private void StartTest()
        {
            NumInMainWindowDataContext++;
        }

        #endregion [--StartTestCommand--]    

    }
}