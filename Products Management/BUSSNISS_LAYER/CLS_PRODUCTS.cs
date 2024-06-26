using Products_Management.DATA_ACCESS_LAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Products_Management.BUSSNISS_LAYER
{
    class CLS_PRODUCTS
    {
        public DataTable GET_ALL_GATEGORIES()
        {
            DateAccessLayer dal = new DateAccessLayer();
            dal.Open();
            DataTable td = new DataTable();
            td = dal.SelectData("GET_ALL_GATEGORIES", null);
            dal.Close();
            return td;
        }

        public void ADD_PRODUCT(int ID_CAT,string LABLE_PRODUCT,string ID_PRODUCT,
                                int QUANTITY,string PRICE , Byte[] image)
        {
            DateAccessLayer dal = new DateAccessLayer();
            dal.Open();
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 50);
            sp[0].Value = ID_PRODUCT;

            sp[1] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.NVarChar, 50);
            sp[1].Value = LABLE_PRODUCT;

            sp[2] = new SqlParameter("@QTE_IN_STOCK", SqlDbType.Int);
            sp[2].Value = QUANTITY;

            sp[3] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 50);
            sp[3].Value = PRICE;            

            sp[4] = new SqlParameter("@IMAGE_PRODUCT", SqlDbType.Image);
            sp[4].Value = image;

            sp[5] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            sp[5].Value = ID_CAT;

            dal.ExecuteCommand("ADD_PRODUCT", sp);
            dal.Close();


        }
        public DataTable VerfyProduct(string ID)
        {
            DateAccessLayer dal = new DateAccessLayer();
            dal.Open();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            sp[0].Value = ID;


            DataTable td = new DataTable();
            td = dal.SelectData("VerfyProductID", sp);
            dal.Close();
            return td;
        }
        public DataTable GET_ALL_PRODUCTS()
        {
            DateAccessLayer dal = new DateAccessLayer();
            dal.Open();
            DataTable td = new DataTable();
            td = dal.SelectData("GET_ALL_PRODUCTS", null);
            dal.Close();
            return td;
        }
        public DataTable Search_PRODUCTS(string ID)
        {
            DateAccessLayer dal = new DateAccessLayer();
            dal.Open();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            sp[0].Value = ID;

            DataTable td = new DataTable();
            td = dal.SelectData("Search_PRODUCTS", sp);
            dal.Close();
            return td;
        }
        public void DELETE_PRODUCT(string ID)
        {
            DateAccessLayer dal = new DateAccessLayer();
            dal.Open();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            sp[0].Value = ID;

            DataTable td = new DataTable();
            dal.ExecuteCommand("DELETE_PRODUCT", sp);
            dal.Close();
        }
        public DataTable GET_IMAGE_PRODUCT(string ID)
        {
            DateAccessLayer dal = new DateAccessLayer();
            dal.Open();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            sp[0].Value = ID;

            DataTable td = new DataTable();
            td = dal.SelectData("GET_IMAGE_PRODUCT", sp);
            dal.Close();
            return td;
        }
        public void Update_Product(int ID_CAT, string LABLE_PRODUCT, string ID_PRODUCT,
                               int QUANTITY, string PRICE, Byte[] image)
        {
            DateAccessLayer dal = new DateAccessLayer();
            dal.Open();
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 50);
            sp[0].Value = ID_PRODUCT;

            sp[1] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.NVarChar, 50);
            sp[1].Value = LABLE_PRODUCT;

            sp[2] = new SqlParameter("@QTE_IN_STOCK", SqlDbType.Int);
            sp[2].Value = QUANTITY;

            sp[3] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 50);
            sp[3].Value = PRICE;

            sp[4] = new SqlParameter("@IMAGE_PRODUCT", SqlDbType.Image);
            sp[4].Value = image;

            sp[5] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            sp[5].Value = ID_CAT;

            dal.ExecuteCommand("Update_Product", sp);
            dal.Close();


        }
    }
}
