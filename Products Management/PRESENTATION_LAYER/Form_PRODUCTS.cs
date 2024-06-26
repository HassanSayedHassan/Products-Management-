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

namespace Products_Management.PRESENTATION_LAYER
{
    public partial class Form_PRODUCTS : Form
    {
        CLS_PRODUCTS CLS_PRODUCTS = new CLS_PRODUCTS();
        private static Form_PRODUCTS frm;

        static void frm_Closed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Form_PRODUCTS getMainProduct
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form_PRODUCTS();
                    frm.FormClosed += new FormClosedEventHandler(frm_Closed);
                }
                return frm;
            }

        }
        public Form_PRODUCTS()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = CLS_PRODUCTS.GET_ALL_PRODUCTS();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = CLS_PRODUCTS.Search_PRODUCTS(txtSearch.Text);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Form_ADD_PRODUCT frm = new Form_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المنتج", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CLS_PRODUCTS.DELETE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString() ?? "");
                MessageBox.Show("تمت عملية الحذف ");
                this.dataGridView1.DataSource = CLS_PRODUCTS.GET_ALL_PRODUCTS();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_ADD_PRODUCT frm = new Form_ADD_PRODUCT();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "  :  تحديث بيانات المنتج" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnOK.Text = "تعديل";
            frm.state = "edit";
            frm.txtRef.ReadOnly = true;
            // ==============   getting Image ==================================
            byte[] image = (byte[])CLS_PRODUCTS.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString() ?? "").Rows[0][0];
            MemoryStream memoryStream = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(memoryStream);
            // ================================================================
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Preview frm = new Form_Preview();
            byte[] image = (byte[])CLS_PRODUCTS.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString() ?? "").Rows[0][0];
            MemoryStream memoryStream = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(memoryStream);
            frm.ShowDialog();
        }
    }
}
