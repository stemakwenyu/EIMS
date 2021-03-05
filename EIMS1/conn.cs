using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EIMS1
{
   
   public class conn
   {
       public MySqlConnection connection;
       private string server;
       private string database;
       private string uid;
       private string password;

       public conn() //initialize data variables
       {
           server = "localhost";
           database = "eism_db";
           uid = "root";
           password = "";
           string connectionString;
           connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

           connection = new MySqlConnection(connectionString);
       
       }
       //Open connection
       public bool OpenConnection()
       {
           try
           {
               connection.Open();
               return true;
           }
           catch (MySqlException ex)
           {
               switch (ex.Number)
               { 
                 case 0:
                       MessageBox.Show("cannot connect to Server. Contact administrator");
                       break;

                 case 1045:
                       MessageBox.Show("Invalid username/password, please try again");
                       break;
               

               }
               return false;
           }
           
       }
       //Close connection
       public bool CloseConnection()
       {
           try
           {
               connection.Close();
               return true;
           }
           catch (MySqlException ex)
           {
               MessageBox.Show(ex.Message);
               return false;
           }
    }
   
}
}
