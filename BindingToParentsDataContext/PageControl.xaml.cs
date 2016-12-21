namespace BindingToParentsDataContext
{
    public partial class PageControl
    {
        public PageControl()
        {
            InitializeComponent();
            var pageControlViewModel = new PageControlViewModel();
            DataContext = pageControlViewModel;
            pageControlViewModel.NumInPageControlDataContext = 3;

            var gridViewModel = new GridViewModel();
            SubGrid.DataContext = gridViewModel;
            gridViewModel.NumInGridDataContext = 10;
        }
    }
}