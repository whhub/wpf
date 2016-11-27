using System.Windows;

namespace XNamespace
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var text = FindResource("MyString") as string;
            TextBox.Text = text;
        }
    }
}
