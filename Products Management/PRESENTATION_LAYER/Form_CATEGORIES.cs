using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management.PRESENTATION_LAYER
{
    public partial class Form_CATEGORIES : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-Q7JA4SD\HASSAN;Database=Product_DB;Trusted_Connection=True;");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;

        SqlCommandBuilder sqlCommandBuilder;
        public Form_CATEGORIES()
        {
            InitializeComponent();
            da = new SqlDataAdapter("SELECT ID_CAT  as 'المعرف',DESCRIPTION_CAT as 'الوصف' FROM CATEGORIES", sqlConnection);
            da.Fill(dt);
            dgList.DataSource = dt;
            txtID.DataBindings.Add("text", dt, "المعرف");
            txtDES.DataBindings.Add("text", dt, "الوصف");

            bmb = this.BindingContext[dt];
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            sqlCommandBuilder = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم التحديث بنجاح");
            btnNew.Enabled = true;
            btnAdd.Enabled = false;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);

            bmb.EndCurrentEdit();
            sqlCommandBuilder = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم الحذف بنجاح");
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            sqlCommandBuilder=new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم الاضافة بنجاح");
            btnNew.Enabled = true ;
            btnAdd.Enabled = false;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
            int id = 1;
            if (dt.Rows.Count>0)
            {
                id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            }
            
            txtID.Text = (id).ToString();
            txtDES.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmb.Position = (bmb.Position - 1 > 0 ? bmb.Position - 1 : 0);
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmb.Position = (bmb.Position + 1 < bmb.Count ? bmb.Position + 1 : bmb.Count);
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }
    }
}
