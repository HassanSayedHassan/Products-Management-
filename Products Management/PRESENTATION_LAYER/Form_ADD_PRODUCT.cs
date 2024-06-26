using Products_Management.BUSSNISS_LAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Products_Management.PRESENTATION_LAYER
{
    public partial class Form_ADD_PRODUCT : Form
    {

        public string state = "add";
        CLS_PRODUCTS CLS_PRODUCTS = new CLS_PRODUCTS();
        public Form_ADD_PRODUCT()
        {
            InitializeComponent();
            cmbCategories.DataSource = CLS_PRODUCTS.GET_ALL_GATEGORIES();
            cmbCategories.DisplayMember = "DESCRIPTION_CAT";
            cmbCategories.ValueMember = "ID_CAT";



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "ملفات الصور | *.jpg ; *.png; *.gif; ";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(file.FileName);
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(state=="add")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteImage = ms.ToArray();

                CLS_PRODUCTS.ADD_PRODUCT(
                    Convert.ToInt32(cmbCategories.SelectedValue),
                    txtDes.Text, txtRef.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);

                MessageBox.Show("تمت الاضافة بنجاح");
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteImage = ms.ToArray();

                CLS_PRODUCTS.Update_Product(
                    Convert.ToInt32(cmbCategories.SelectedValue),
                    txtDes.Text, txtRef.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);

                MessageBox.Show("تمت التعديل بنجاح");

            }
            Console.WriteLine(CLS_PRODUCTS.GET_ALL_PRODUCTS());
            Form_PRODUCTS.getMainProduct.dataGridView1.DataSource = CLS_PRODUCTS.GET_ALL_PRODUCTS();


        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            if(state=="add")
            {
                DataTable dt = new DataTable();
                dt = CLS_PRODUCTS.VerfyProduct(txtRef.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المنتج موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.TextLength;


                }

            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
