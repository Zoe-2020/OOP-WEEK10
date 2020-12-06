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

namespace Q3
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

        private void RollBtn_Click(object sender, RoutedEventArgs e)
        {
           // update();
            update2();
        }

        public void update()
        {
            Random rng = new Random();
            int diceRoll = rng.Next(1, 7);
            rollResult.Text = diceRoll.ToString();
        }

        public async void update2()
        {
            Random rng = new Random();
            int diceRoll;

            for(int i = 0; i < 20; i ++)
            {
                diceRoll = rng.Next(1, 7);
                rollResult.Text = diceRoll.ToString();
                await Task.Delay(50);
            
            }
          
        }
    }
}
