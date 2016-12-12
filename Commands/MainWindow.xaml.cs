using System;
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
        private readonly RoutedCommand _clearCmd = new RoutedCommand("Clear", typeof(MainWindow));

        private void InitializeCommand()
        {
            // 把命令赋值给命令源（发送者）并指定快捷键
            Button1.Command = _clearCmd;
            _clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

            // 指定命令目标
            Button1.CommandTarget = TextBoxA;

            // 创建命令关联u
            var cb = new CommandBinding();
            cb.Command = _clearCmd;  // 只关注与_clearCmd相关的事件
            cb.CanExecute += CbOnCanExecute;
            cb.Executed += CbOnExecuted;

            // 把命令关联安置在外围控件上
            StackPanel.CommandBindings.Add(cb);
        }

        // 当命令送达目标后，此方法被调用
        private void CbOnExecuted(object sender, ExecutedRoutedEventArgs executedRoutedEventArgs)
        {
            TextBoxA.Clear();

            // 避免继续向上传而降低性能
            executedRoutedEventArgs.Handled = true;
        }

        // 当探测命令是否可以执行时，此方法被调用
        private void CbOnCanExecute(object sender, CanExecuteRoutedEventArgs canExecuteRoutedEventArgs)
        {
            canExecuteRoutedEventArgs.CanExecute = !string.IsNullOrEmpty(TextBoxA.Text);

            // 避免继续向上传而降低程序性能
            canExecuteRoutedEventArgs.Handled = true;
        }
    }
}