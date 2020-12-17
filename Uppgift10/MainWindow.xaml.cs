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

namespace Uppgift10
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

        private void btnClass_Click(object sender, RoutedEventArgs e)
        {
            int weight = int.Parse(txtBox.Text);
            
            txtBlock.Text = $"Ägget klassificeras som {GetClassification(weight)}";
        }

        private string GetClassification(int weight)
        {
            if (weight >= 73)
            {
                return "XL";
            }
            else if (weight >= 63 && weight < 73)
            {
                return "L";
            }
            else if (weight > 53 && weight < 63)
            {
                return "M";
            }
            else if (weight <= 53)
            {
                return "S";
            }
            return null;

        }
    }
}
