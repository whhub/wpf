using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Binding
{
    /// <summary>
    ///     MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Student _stu;

        public MainWindow()
        {
            InitializeComponent();
            _stu = new Student();
            var binding = new System.Windows.Data.Binding();
            binding.Source = _stu;
            binding.Path = new PropertyPath("Name");

            BindingOperations.SetBinding(TextBox, TextBox.TextProperty, binding);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _stu.Name += "Name";
        }
    }
}