using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace WpfApplication1
{
    class RepMekClass  
    {
         SqlConnection connect;

         public int A1A4(DateTime begin, DateTime end,int usl_ok) 
          {

              int value = 0;
            string sqltext = "select count (distinct id_schet_lpu)  from sk_sluch where id_schet_lpu in (select id from sk_schet_lpu where (dateload>=@beg and dateload<=@end))  and usl_ok=@usl_ok";
            SqlCommand com = new SqlCommand();
            com.CommandText = sqltext;
            com.Parameters.Add("@beg",SqlDbType.Date).Value=begin;
            com.Parameters.Add("@end", SqlDbType.Date).Value = begin;
            com.Parameters.Add("@usl_ok", SqlDbType.Date).Value = begin;

            try 
            { 
            string constring = "Data Source="+Properties.Settings.Default.Sqlserver
            +",1433;Network Library=DBMSSOCN;Initial Catalog="
            +Properties.Settings.Default.database+";User ID="
            +Properties.Settings.Default.user+";Password="
            +Properties.Settings.Default.password+";";


            connect = new SqlConnection();
            connect.ConnectionString = constring;

            connect.Open();
            com.Connection = connect;


            using (SqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection))
            {
                //цикл по всем столбцам полученной в результате запроса таблицы
                for (int i = 0; i < dr.FieldCount; i++)
                    /*метод GetName() класса SqlDataReader позволяет получить имя столбца
                     по номеру, который передается в качестве параметра, данному методу
                     и озночает номер столбца в таблице(начинается с 0)
                     */
                 
                /*читаем данные из таблицы
                 чтение происходит только в прямом направлении
                 все прочитаные строки отбрасываюся */
                while (dr.Read())
                {
                    /*метод GetValue() класса SqlDataReader позволяет получить значение столбца
                                            по номеру, который передается в качестве параметра, данному методу
                                            и озночает номер столбца в таблице(начинается с 0)
                     * */
                    value = Convert.ToInt32(dr.GetValue(0).ToString().Trim());
                  
                }
            }


            connect.Close();

            }
            catch (Exception e) { connect.Close(); return 0; }


            return value;

         }

         public int B1B4(DateTime begin, DateTime end, int usl_ok) 
         {
             int  value=0;
             
string sql = "select  count(distinct id_schet_lpu) "+  
"from sk_sluch  where id_schet_lpu in " +
"(select id from sk_schet_lpu where (dateload>=@beg and dateload<=@end ) ) " +  
"and usl_ok=3  and id in (select id_sluch from sk_refreason)  ";

connect = new SqlConnection();
             string constring = "Data Source="+Properties.Settings.Default.Sqlserver
            +",1433;Network Library=DBMSSOCN;Initial Catalog="
            +Properties.Settings.Default.database+";User ID="
            +Properties.Settings.Default.user+";Password="
            +Properties.Settings.Default.password+";";
             connect.ConnectionString = constring;


             try 
             {
                 SqlCommand com = new SqlCommand();
                 com.CommandText = sql;
                 com.Parameters.Add("@beg", SqlDbType.Date).Value = begin;
                 com.Parameters.Add("@end", SqlDbType.Date).Value = begin;
                 com.Parameters.Add("@usl_ok", SqlDbType.Date).Value = begin;

                 com.Connection = connect;
                 connect.Open();

                 com.ExecuteNonQuery();
                 using (SqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection))
                 {
                     //цикл по всем столбцам полученной в результате запроса таблицы
                     for (int i = 0; i < dr.FieldCount; i++)
                         /*метод GetName() класса SqlDataReader позволяет получить имя столбца
                          по номеру, который передается в качестве параметра, данному методу
                          и озночает номер столбца в таблице(начинается с 0)
                          */

                         /*читаем данные из таблицы
                          чтение происходит только в прямом направлении
                          все прочитаные строки отбрасываюся */
                         while (dr.Read())
                         {
                             /*метод GetValue() класса SqlDataReader позволяет получить значение столбца
                                                     по номеру, который передается в качестве параметра, данному методу
                                                     и озночает номер столбца в таблице(начинается с 0)
                              * */
                             value = Convert.ToInt32(dr.GetValue(0).ToString().Trim());

                         }
                 }
                 connect.Close();

             }
             catch (Exception e) 
             { }


            return value;

         }

         public int C1C4(DateTime begin, DateTime end, int usl_ok) 
         {
             int value = 0;

             string sql = "select  count(distinct id_schet_lpu) " +
             "from sk_sluch  where id_schet_lpu in " +
             "(select id from sk_schet_lpu where (dateload>=@beg and dateload<=@end ) ) " +
             "and usl_ok=3  and id in (select id_sluch from sk_refreason)  ";

             connect = new SqlConnection();
             string constring = "Data Source=" + Properties.Settings.Default.Sqlserver
            + ",1433;Network Library=DBMSSOCN;Initial Catalog="
            + Properties.Settings.Default.database + ";User ID="
            + Properties.Settings.Default.user + ";Password="
            + Properties.Settings.Default.password + ";";
             connect.ConnectionString = constring;


             try
             {
                 SqlCommand com = new SqlCommand();
                 com.CommandText = sql;
                 com.Parameters.Add("@beg", SqlDbType.Date).Value = begin;
                 com.Parameters.Add("@end", SqlDbType.Date).Value = begin;
                 com.Parameters.Add("@usl_ok", SqlDbType.Date).Value = begin;

                 com.Connection = connect;
                 connect.Open();

                 com.ExecuteNonQuery();
                 using (SqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection))
                 {
                     //цикл по всем столбцам полученной в результате запроса таблицы
                     for (int i = 0; i < dr.FieldCount; i++)
                         /*метод GetName() класса SqlDataReader позволяет получить имя столбца
                          по номеру, который передается в качестве параметра, данному методу
                          и озночает номер столбца в таблице(начинается с 0)
                          */

                         /*читаем данные из таблицы
                          чтение происходит только в прямом направлении
                          все прочитаные строки отбрасываюся */
                         while (dr.Read())
                         {
                             /*метод GetValue() класса SqlDataReader позволяет получить значение столбца
                                                     по номеру, который передается в качестве параметра, данному методу
                                                     и озночает номер столбца в таблице(начинается с 0)
                              * */
                             value = Convert.ToInt32(dr.GetValue(0).ToString().Trim());

                         }
                 }
                 connect.Close();

             }
             catch (Exception e)
             { }


             return value;

         
         }
       
    }
}
