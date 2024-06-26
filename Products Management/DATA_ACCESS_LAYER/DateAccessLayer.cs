using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management.DATA_ACCESS_LAYER
{
    class DateAccessLayer
    {
        SqlConnection sqlConnection;

        public DateAccessLayer()
        {
            // SQLEXPRESS
            sqlConnection = new SqlConnection(@"Server=DESKTOP-Q7JA4SD\HASSAN;Database=Product_DB;Trusted_Connection=True;");

        }

        // method to open connection
        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        // method to close connection
        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }


        // method to read data
        public DataTable SelectData(string stored_precedure, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = stored_precedure;
            sqlCommand.Connection = sqlConnection;

            if(param != null)
            {
                for (int i = 0; i < param.Length;i++)
                {
                    sqlCommand.Parameters.Add (param[i]);
                }

            }

            SqlDataAdapter da=new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // method to Insert,Update, Delete 
        public void ExecuteCommand(string stored_precedure, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType= CommandType.StoredProcedure;
            sqlCommand.CommandText= stored_precedure;
            sqlCommand.Connection = sqlConnection;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            sqlCommand.ExecuteNonQuery();
        }
    }
}
