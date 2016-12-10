using System.Windows.Input;

namespace Commands
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeCommand();
        }

        // 声明并定义命令
        private RoutedCommand clearCmd = new RoutedCommand("Clear", typeof(MainWindow));

        private void InitializeCommand()
        {
            // 把命令赋值给命令源（发送者）并指定快捷键
            Button1.Command = clearCmd;
            clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

            // 指定命令目标
            Button1.CommandTarget = TextBoxA;
        }
    }
}