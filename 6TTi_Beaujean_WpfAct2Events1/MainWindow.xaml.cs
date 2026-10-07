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

namespace _6TTi_Beaujean_WpfAct2Events1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnV.Visibility = Visibility.Hidden;

            txtA.PreviewTextInput += TxtA_PreviewTextInput;
            txtB.PreviewTextInput += TxtB_PreviewTextInput;
            txtC.PreviewTextInput += TxtC_PreviewTextInput;
            btnCalculer.MouseEnter += BtnCalculer_MouseEnter;
            btnCalculer.MouseLeave += BtnCalculer_MouseLeave;
        }

        private void BtnCalculer_MouseLeave(object sender, MouseEventArgs e)
        {
            btnV.Visibility = Visibility.Hidden;
            btnV.Background = Brushes.White;
            txtBlockA.Background = Brushes.DarkGray;
            txtBlockB.Background = Brushes.DarkGray;
            txtBlockC.Background = Brushes.DarkGray;
            txtA.Background = Brushes.WhiteSmoke;
            txtB.Background = Brushes.WhiteSmoke;
            txtC.Background = Brushes.WhiteSmoke;
            

        }

        private void BtnCalculer_MouseEnter(object sender, MouseEventArgs e)
        {
            btnV.Visibility = Visibility.Visible;
            txtBlockA.Background = Brushes.Pink;
            txtBlockB.Background = Brushes.Blue;
            txtBlockC.Background = Brushes.Red;
            txtA.Background = Brushes.Bisque;
            txtB.Background = Brushes.HotPink;
            txtC.Background = Brushes.LightSkyBlue;
            btnV.Background = Brushes.Purple;
        }

        private void TxtC_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int n))
            {
                e.Handled = true;
            }
        }

        private void TxtB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int n))
            {
                e.Handled = true;
            }
        }

        private void TxtA_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int n))
            {
                e.Handled = true;
            }
        }

        private void btnCalculer_Click(object sender, RoutedEventArgs e)
        {
            string message;
            int a = 0, b = 0, c = 0;
            int.TryParse(txtA.Text, out a);
            int.TryParse(txtB.Text, out b);
            int.TryParse(txtC.Text, out c);

            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                message = "Il n'y a pas de solution réelle";

            }
            else if (delta == 0)
            {
                double x1 = -b / (2 * a);
                message = "Il y a une solution " + x1;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                message = "Il y a deux solutions " + x1 + " et " + x2;
            }

            // Affiche uniquement la somme
            MessageBox.Show(message.ToString(), "", MessageBoxButton.OK, MessageBoxImage.None);
        }
    }
}