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
using System.Web;

using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;



namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Report1.xaml
    /// </summary>
    public partial class Report1 : System.Windows.Window
    {

       
        

        DataTable table; 

        public Report1()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {  System.Windows.Application.Current.Shutdown();
        }

        private void CreateDocx_Click(object sender, RoutedEventArgs e)
        {
            /////////
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("#A1","Мы все умерем");
            dic.Add("#A2", "Но чуть позже");

            ExportToDocx r = new ExportToDocx();
            r.InputDataMek(dic,"ME1.docx");
            //
            ShowDocument show = new ShowDocument();
            show.filenameDocx = System.IO.Directory.GetCurrentDirectory() + "/temp/ME1.docx";

            /* Convert to Xps */
            Convert(System.IO.Directory.GetCurrentDirectory() + "/temp/ME1.docx", System.IO.Directory.GetCurrentDirectory() + "/temp/ME1.xps", WdSaveFormat.wdFormatXPS);

            // the show files
            show.Show();
        }



         public static void Convert(string input, string output, WdSaveFormat format)
        {
            // Create an instance of Word.exe
            Word._Application oWord = new Word.Application();
 
            // Make this instance of word invisible (Can still see it in the taskmgr).
            oWord.Visible = false;
 
            // Interop requires objects.
            object oMissing = System.Reflection.Missing.Value;
            object isVisible = true;
            object readOnly = false;
            object oInput = input;
            object oOutput = output;
            object oFormat = format;
 
            // Load a document into our instance of word.exe
            Word._Document oDoc = oWord.Documents.Open(ref oInput, ref oMissing, ref readOnly, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref isVisible, ref oMissing, ref oMissing );
           
            // Make this document the active document.
            oDoc.Activate();
 
            // Save this document in Word 2003 format.
            oDoc.SaveAs(ref oOutput, ref oFormat, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            
            // Always close Word.exe.
            oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
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
