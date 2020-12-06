using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Q4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtInput_GotFocus(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            int num;
            bool isNum = int.TryParse(input, out num);

            if (isNum)
            {
                MessageBox.Show("value entered is a valid number");
                txtInput.Background = Brushes.Green;
            }
            else
            {
                MessageBox.Show("value entered is NOT a valid number");
                txtInput.Background = Brushes.Red;
            }
        }
    }
}
