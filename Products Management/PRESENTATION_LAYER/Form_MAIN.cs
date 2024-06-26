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
    public partial class Form_MAIN : Form
    {
        private static Form_MAIN frm;

        static void frm_Closed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Form_MAIN getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_Closed);
                }
                return frm;
            }

        }
        public Form_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.استعادةنسخهمحفوظهToolStripMenuItem.Enabled = false;
            this.انشاءنسخهاحتياطيةToolStripMenuItem.Enabled = false;
        }

        private void تسجيلدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_LOGIN form_LOGIN = new Form_LOGIN();
            form_LOGIN.ShowDialog();
        }

        private void اضافةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ADD_PRODUCT frm = new Form_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void ادارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PRODUCTS frm = new Form_PRODUCTS();
            frm.ShowDialog();
        }

        private void ادارهالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CATEGORIES frm = new Form_CATEGORIES();
            frm.ShowDialog();
        }
    }
}
