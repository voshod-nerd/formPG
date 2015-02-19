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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {

             var a = VariantsReport.SelectedItem;
            ComboBoxItem v = (ComboBoxItem)a;


            if (v != null) 
            {

                if (v.Name == "V1")
                {
                    this.Visibility = Visibility.Collapsed;
                    Report1 window = new Report1();
                    window.Show();
                } 
            }


         

        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {

            ConnectionSetting form = new ConnectionSetting();
            form.Show();

        }
    }
}
