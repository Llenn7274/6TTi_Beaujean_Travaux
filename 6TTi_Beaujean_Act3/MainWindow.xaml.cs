using _6TTi_Beaujean_Act3.Views;
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

namespace _6TTi_Beaujean_Act3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Page1Button.Click += Page1Button_Click;
            Page2Button.Click += Page2Button_Click;
            mainFrame.Content = new Views.acceuil();
        }

        private void Page2Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Views.Page2();
        }

        private void Page1Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Views.Page1();
        }
    }
}