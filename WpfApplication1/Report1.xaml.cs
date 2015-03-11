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
using System.Data;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Report1.xaml
    /// </summary>
    public partial class Report1 : Window
    {

        DataTable table; 

        public Report1()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CreateDocx_Click(object sender, RoutedEventArgs e)
        {

            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("#A1","Мы все умерем");
            dic.Add("#A2", "Но чуть позже");

            ExportToDocx r = new ExportToDocx();
            r.InputDataMek(dic,"ME1.docx");

            ShowDocument show = new ShowDocument();
            show.filename = System.IO.Directory.GetCurrentDirectory() + "/temp/ME1.docx";
            show.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           table = new DataTable();
           table.Columns.Add("C0", typeof(String));
           table.Columns.Add("C1", typeof(String));
           table.Columns.Add("C2", typeof(String));
           table.Columns.Add("C3", typeof(String));
           table.Columns.Add("C4", typeof(String));
           table.Columns.Add("C5", typeof(String));



           ForTFOMS.ItemsSource = table.DefaultView;


           table.Rows.Add("ddddddddddddddddddddddddddddddd", "1", "2", "3", "4", "5");



        }
    }
}
