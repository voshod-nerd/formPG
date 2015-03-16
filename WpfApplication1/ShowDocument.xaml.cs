using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Text.RegularExpressions;




namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для ShowDocument.xaml
    /// </summary>
    public partial class ShowDocument : Window
    {

       public string filenameDocx { get; set; }
       public string filenameXps { get; set; }
 

        public ShowDocument()
        {
            InitializeComponent();
        }


        private void ReadDocx()
        {
            string path = filenameDocx;
         
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            ReadDocx();
            //
            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() == true)
            {
              
            }

        }
    }
}
