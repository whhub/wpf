using System.Windows;

namespace XamlAttribute
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Human h = (Human) this.FindResource("Human");
            MessageBox.Show(h.Child.Name);
        }

        public static string WindowTitle = "山高月小";
        public static string ShowText {get { return "水落石出"; }}
    }
}