using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products_Management.DATA_ACCESS_LAYER;

namespace Products_Management.BUSSNISS_LAYER
{
     class CLS_LOGIN
    {
        public DataTable Login(string ID , string PWD)
        {
           DateAccessLayer dal=new DateAccessLayer();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            sp[0].Value = ID;
            sp[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            sp[1].Value = PWD;

            dal.Open();
            DataTable td=new DataTable();
            td = dal.SelectData("SP_LOGIN", sp);
            dal.Close();
            return td;
        }



    }
}
