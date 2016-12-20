using System.Windows;
using GalaSoft.MvvmLight;

namespace DynamicGrid
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region [--DisplayMode--]

        private int _displayMode;

        public int DisplayMode
        {
            get { return _displayMode; }
            set
            {
                if (_displayMode == value) return;
                _displayMode = value;
                RaisePropertyChanged(() => DisplayMode);
            }
        }

        #endregion [--DisplayMode--]

    }
}