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
using System.Data;
using System.Data.SqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для ConnectionSetting.xaml
    /// </summary>
    public partial class ConnectionSetting : Window
    {
        public ConnectionSetting()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Password.Text = Properties.Settings.Default.password;
            UserDB.Text = Properties.Settings.Default.user;
            DataBase.Text = Properties.Settings.Default.database;
            IP.Text = Properties.Settings.Default.Sqlserver;
 
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.password=Password.Text;
            UserDB.Text = Properties.Settings.Default.user=UserDB.Text;
            DataBase.Text = Properties.Settings.Default.database=DataBase.Text;
            Properties.Settings.Default.Sqlserver= IP.Text;
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
              string constring = "Data Source="+IP.Text
            +",1433;Network Library=DBMSSOCN;Initial Catalog="
            +DataBase.Text+";User ID="
            +UserDB.Text+";Password="
            +Password.Text+";";
          
            SqlConnection sql = new SqlConnection();

            sql.ConnectionString = constring;

            try
            {
                sql.Open();
                MessageBox.Show("Подключение успешно!  ");

            }
            catch (Exception err) { MessageBox.Show(err.Message); sql.Close(); }


        }
    }
}
