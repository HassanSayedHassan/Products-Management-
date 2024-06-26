namespace Products_Management.PRESENTATION_LAYER
{
    partial class Form_ADD_PRODUCT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ADD_PRODUCT));
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnOK = new Button();
            button1 = new Button();
            pbox = new PictureBox();
            txtDes = new TextBox();
            txtPrice = new TextBox();
            txtQte = new TextBox();
            txtRef = new TextBox();
            cmbCategories = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnOK);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pbox);
            groupBox1.Controls.Add(txtDes);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtQte);
            groupBox1.Controls.Add(txtRef);
            groupBox1.Controls.Add(cmbCategories);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 467);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(474, 427);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "الغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(318, 427);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "اضافة";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // button1
            // 
            button1.Location = new Point(318, 373);
            button1.Name = "button1";
            button1.Size = new Size(231, 23);
            button1.TabIndex = 4;
            button1.Text = "اختر الصورة";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pbox
            // 
            pbox.Image = (Image)resources.GetObject("pbox.Image");
            pbox.Location = new Point(318, 277);
            pbox.Name = "pbox";
            pbox.Size = new Size(231, 73);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.TabIndex = 4;
            pbox.TabStop = false;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(318, 97);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.ScrollBars = ScrollBars.Vertical;
            txtDes.Size = new Size(231, 55);
            txtDes.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(318, 225);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(231, 23);
            txtPrice.TabIndex = 3;
            txtPrice.TextChanged += textBox1_TextChanged;
            // 
            // txtQte
            // 
            txtQte.Location = new Point(318, 179);
            txtQte.Name = "txtQte";
            txtQte.Size = new Size(231, 23);
            txtQte.TabIndex = 2;
            txtQte.TextChanged += textBox1_TextChanged;
            // 
            // txtRef
            // 
            txtRef.Location = new Point(318, 59);
            txtRef.Name = "txtRef";
            txtRef.Size = new Size(231, 23);
            txtRef.TabIndex = 0;
            txtRef.TextChanged += textBox1_TextChanged;
            txtRef.Validated += txtRef_Validated;
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(318, 22);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(231, 23);
            cmbCategories.TabIndex = 2;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(573, 277);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 1;
            label6.Text = "صورة المنتج";
            label6.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 228);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 1;
            label5.Text = "ثمن المنتج";
            label5.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(573, 182);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 1;
            label4.Text = "الكمية المخزنة :";
            label4.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 91);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 1;
            label3.Text = "وصف المنتج :";
            label3.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(576, 62);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "معرف المنتج : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 25);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "صنف المنتج: ";
            // 
            // Form_ADD_PRODUCT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 487);
            Controls.Add(groupBox1);
            Name = "Form_ADD_PRODUCT";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة منتج";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox groupBox1;
        public Label label1;
        public Label label2;
        public Label label4;
        public Label label3;
        public Label label5;
        public Label label6;
        public ComboBox cmbCategories;
        public TextBox txtRef;
        public TextBox txtDes;
        public Button button1;
        public PictureBox pbox;
        public TextBox txtPrice;
        public TextBox txtQte;
        public Button btnCancel;
        public Button btnOK;
    }
}