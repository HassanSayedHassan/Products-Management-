namespace Products_Management.PRESENTATION_LAYER
{
    partial class Form_PRODUCTS
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
            label1 = new Label();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button8 = new Button();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            delete_btn = new Button();
            add_btn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 20);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "ابحث عن اي منتج";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(245, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(562, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(21, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(950, 325);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "المنتجات";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(920, 294);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(delete_btn);
            groupBox2.Controls.Add(add_btn);
            groupBox2.Location = new Point(41, 408);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(845, 106);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "العمليات المتاحة";
            // 
            // button6
            // 
            button6.Location = new Point(24, 38);
            button6.Name = "button6";
            button6.Size = new Size(115, 23);
            button6.TabIndex = 0;
            button6.Text = "طباعة الكل";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(145, 38);
            button5.Name = "button5";
            button5.Size = new Size(115, 23);
            button5.TabIndex = 0;
            button5.Text = "طباعة المنتج المحدد";
            button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(266, 72);
            button8.Name = "button8";
            button8.Size = new Size(115, 23);
            button8.TabIndex = 0;
            button8.Text = "خروج";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(403, 72);
            button7.Name = "button7";
            button7.Size = new Size(115, 23);
            button7.TabIndex = 0;
            button7.Text = "الحفظ الي اكسل";
            button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(266, 38);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 0;
            button4.Text = "اظهار صورة المنتج";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(403, 38);
            button3.Name = "button3";
            button3.Size = new Size(115, 23);
            button3.TabIndex = 0;
            button3.Text = "تعديل بيانات المنتج";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(544, 38);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(115, 23);
            delete_btn.TabIndex = 0;
            delete_btn.Text = "حذف المنتج المحدد";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(687, 38);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(75, 23);
            add_btn.TabIndex = 0;
            add_btn.Text = "اضافة منتج";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // Form_PRODUCTS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 554);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "Form_PRODUCTS";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ادارة المنتجات";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button add_btn;
        private Button delete_btn;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button8;
        private Button button7;
        public DataGridView dataGridView1;
    }
}