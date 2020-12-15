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

namespace Uppgift2
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            /*
            bool[] isBroken = new bool[] { true, true, true, false, true, false,
            false, true, true, false, true, true, false, false, true, true, false,
            true, false, false, true, false, true, true, true, true, false, false,
            false, false, false, false, false, true, false, false, true, false,
            false, true, false, true, true, true, false, true, false, true, false,
            true, true, true, false, true, false, false, false, false, false, false,
            false, false, true, false, true, false, false, true, false, false, false,
            true, true, false, false, true, true, false, true, true, false, false,
            true, true, true, false, false, false, false, true };*/
            bool[]  isBroken = new bool[] { true, true, false, true, false };


            int brokenEgg = 0, numberOfEggs = 0, notBrokenEggs = 0; 

            foreach (bool egg in isBroken)
            {
                numberOfEggs += 1;

                if (egg == true)
                {
                    brokenEgg += 1;
                }
            }

            notBrokenEggs = numberOfEggs - brokenEgg;

            MessageBox.Show($"Av {numberOfEggs} är det {brokenEgg} som är trasiga och {notBrokenEggs} som är hela");

        }
    }
}
