using System.Collections.Generic;
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


            var stuList = new List<Student>
            {
                new Student {Id = 0, Name = "Time", Age = 29},
                new Student {Id = 2, Name = "Tom", Age = 28},
                new Student {Id = 4, Name = "Vina", Age = 27}
            };

            ListBoxStudents.ItemsSource = stuList;
            //ListBoxStudents.DisplayMemberPath = "Name";

            var binding2 = new System.Windows.Data.Binding("SelectedItem.Id") {Source = ListBoxStudents};
            TextBoxID.SetBinding(TextBox.TextProperty, binding2);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _stu.Name += "Name";
        }
    }
}