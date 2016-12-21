using GalaSoft.MvvmLight;

namespace BindingToParentsDataContext
{
    class GridViewModel : ViewModelBase
    {
        #region [--NumInGridDataContext--]

        private int _numInGridDataContext;

        public int NumInGridDataContext
        {
            get { return _numInGridDataContext; }
            set
            {
                if (_numInGridDataContext == value) return;
                _numInGridDataContext = value;
                RaisePropertyChanged(() => NumInGridDataContext);
            }
        }

        #endregion [--NumInGridDataContext--]

    }
}
