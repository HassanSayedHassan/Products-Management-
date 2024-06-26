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
    public partial class Form_LOGIN : Form
    {
        CLS_LOGIN Login = new CLS_LOGIN();

        public Form_LOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_LOGIN_Load(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = Login.Login(txtID.Text, txtPWD.Text);
            if (dt.Rows.Count > 0)
            {
                Form_MAIN.getMainForm.المنتجاتToolStripMenuItem.Enabled = true;
                Form_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                Form_MAIN.getMainForm.المستخدمينToolStripMenuItem.Enabled = true;
                Form_MAIN.getMainForm.استعادةنسخهمحفوظهToolStripMenuItem.Enabled = true;
                Form_MAIN.getMainForm.انشاءنسخهاحتياطيةToolStripMenuItem.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Fails");
            }

        }
    }
}
