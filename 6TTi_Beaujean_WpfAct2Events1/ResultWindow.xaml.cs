using System.Windows;

namespace _6TTi_Beaujean_WpfAct2Events1
{
    public partial class ResultWindow : Window
    {
        
        public ResultWindow(string text)
        {
            InitializeComponent();
            txtResult.Text = text;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
