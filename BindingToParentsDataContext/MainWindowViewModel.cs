using GalaSoft.MvvmLight;

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


    }
}