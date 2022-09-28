using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;           // ConnectionState için
using System.Data.SqlClient; // sql işlemler için




namespace WindowsFormsApp1
{
   public class SqlOperations
    {
        public static SqlConnection connection = new SqlConnection("Data Source=LAPTOP-26MR7RO5;Initial Catalog=SchoolDB;Integrated Security=True");
        
        public static void CheckConnection(SqlConnection tempConnetion)
        {
            if(tempConnetion.State == ConnectionState.Closed)
            {
                tempConnetion.Open();
            }
            else
            {

            }
        }
    }
}
