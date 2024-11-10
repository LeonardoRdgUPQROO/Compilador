using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Compilador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly string ceditor_default = "Comience a crear su código...";
        LexicCompilator lexic = new LexicCompilator();
        Messages messages = new Messages();
        public MainWindow()
        {
            InitializeComponent();
            CompileEditor_Default(ceditor_default);
        }

        private void Compile_Click(object sender, RoutedEventArgs e)
        {
            string t = CodeEditor.Text, r;
            bool success = true;
            foreach(char c in t)
            {
                if (c == '\n' || c == '\r')
                    continue;
                else
                {
                    r = messages.compile_message(lexic.evaluate(c));
                    if (r != "good")
                        success = false;
                }
            }

            if (success)
                Success_Message(Messages.success);
            else
                Error_Message();
            messages.clear();
        }
        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            CodeEditor.Clear();
            CompileEditor_Default(ceditor_default);
        }

        public  void CompileEditor_Default(string text)
        {
            CodeEditor.Text = text;
        }

        public void Success_Message(string message)
        {
            MBlock.Foreground = Brushes.Green;
            MBlock.Text = message;
        }

        public void Error_Message()
        {
            string text = messages.error_tostring();
            MBlock.Foreground = Brushes.Red;
            MBlock.Text = text;
        }

    }
}