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

namespace Uppgift3
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

        private int CountEggs(int code){
            List<string> pinkCodes = new List<string>() {"1SE123-2", "0SE675-6",
            "2SE122-4", "0SE234-1", "0SE234-5", "2SE564-4", "0SE234-2", "1SE564-6",
            "2SE144-5", "0SE675-1", "1SE144-1", "2SE144-3", "1SE123-4", "2SE122-2",
            "1SE122-6", "0SE234-2", "2SE123-3", "1SE234-3", "1SE123-6", "1SE123-4",
            "0SE122-2", "1SE144-3", "0SE234-4", "0SE564-1", "0SE234-4", "2SE144-3",
            "2SE122-3", "1SE234-3", "1SE123-4", "1SE564-5", "1SE123-1", "2SE122-6",
            "0SE123-6", "1SE564-6", "1SE234-5", "1SE564-6", "2SE234-2", "1SE234-3",
            "0SE234-3", "2SE122-5", "2SE234-2", "2SE144-2", "2SE564-5", "1SE144-5",
            "1SE675-4", "1SE123-6", "2SE564-6", "1SE122-6", "1SE122-5", "2SE122-2",
            "1SE234-2", "0SE675-5", "2SE122-4", "1SE234-6", "0SE564-4", "1SE564-6",
            "2SE675-3", "1SE144-4", "2SE564-5", "0SE564-1", "1SE564-4", "1SE123-4",
            "1SE564-6", "2SE122-2", "1SE564-5", "2SE234-4", "1SE564-4", "2SE122-1",
            "2SE123-3", "2SE564-2", "2SE234-4", "1SE144-1", "1SE675-1", "0SE144-1",
            "2SE123-6", "0SE123-5", "2SE144-6", "0SE144-6", "1SE122-4", "1SE675-6",
            "0SE122-6", "2SE144-2", "2SE122-3", "1SE234-5", "1SE564-2", "1SE144-5",
            "0SE144-1", "1SE144-3", "1SE122-4", "1SE123-1"};

            int count = 0;

            foreach (string producer in pinkCodes)
            {
                string producerCode = producer[3].ToString() + producer[4].ToString() + producer[5];

                if (producerCode == code.ToString())
                {
                    count++;
                }
            }

            return count;
        }




        private void btn_Click(object sender, RoutedEventArgs e)
        {
            int count = CountEggs(123);



        }
    }
}
