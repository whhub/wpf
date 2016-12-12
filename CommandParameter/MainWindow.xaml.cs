using System.Windows.Input;

namespace CommandParameter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !string.IsNullOrEmpty(NameTextBox.Text);

            e.Handled = true;
        }

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var name = NameTextBox.Text;
            if (e.Parameter.ToString() == "Teacher")
            {
                NewItemsListBox.Items.Add(string.Format("New Teacher: {0}, 学而不厌，诲人不倦。", name));
            }
            else if (e.Parameter.ToString() == "Student")
            {
                NewItemsListBox.Items.Add(string.Format("New Student: {0}, 好好学习，天天向上。", name));
            }
        }
    }
}
