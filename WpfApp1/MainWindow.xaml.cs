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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void RunningButton_MouseEnter(object sender, MouseEventArgs e)
        {

            Canvas.SetLeft(runningButton, Canvas.GetLeft(runningButton) + random.Next(-200, 200));
            Canvas.SetTop(runningButton, Canvas.GetTop(runningButton) + random.Next(-200, 200));

        }

        private void runningButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}