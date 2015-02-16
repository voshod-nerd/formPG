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

       public string filename { get; set; }
 

        public ShowDocument()
        {
            InitializeComponent();
        }


        private void ReadDocx()
        {
            string path = this.filename;
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var flowDocumentConverter = new DocxToFlowDocumentConverter(stream);
                flowDocumentConverter.Read();
                this.flowDocumentReader.Document = flowDocumentConverter.Document;
                this.Title = System.IO.Path.GetFileName(path);
            }
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            ReadDocx();
        }
    }
}
