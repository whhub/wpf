using GalaSoft.MvvmLight;

namespace BindingToParentsDataContext
{
    public class PageControlViewModel : ViewModelBase
    {
        #region [--NumInPageControlDataContext--]

        private int _numInPageControlDataContext;

        public int NumInPageControlDataContext
        {
            get { return _numInPageControlDataContext; }
            set
            {
                if (_numInPageControlDataContext == value) return;
                _numInPageControlDataContext = value;
                RaisePropertyChanged(() => NumInPageControlDataContext);
            }
        }

        #endregion [--NumInPageControlDataContext--]

    }
}