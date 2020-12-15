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

namespace Uppgift1
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
            int eggsPerPackage = 12;
            double profit = 3.56;
            int numberOfEggs = int.Parse(txtBox.Text);
            int numberOfPackages = numberOfEggs / eggsPerPackage;
            double price = numberOfEggs * profit - ((numberOfEggs % eggsPerPackage )* profit);
            txtBlock.Text = $"Du ska leverera {numberOfPackages} st paket till ett pris av {Math.Round( price, 2)} kr";

        }
    }
}
