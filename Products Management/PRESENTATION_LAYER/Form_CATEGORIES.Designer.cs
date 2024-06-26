namespace Products_Management.PRESENTATION_LAYER
{
    partial class Form_CATEGORIES
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
            groupBox1 = new GroupBox();
            dgList = new DataGridView();
            lblPosition = new Label();
            btnNext = new Button();
            btnLast = new Button();
            btnPrev = new Button();
            btnFirst = new Button();
            txtDES = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnPrint = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnNew = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgList);
            groupBox1.Controls.Add(lblPosition);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnLast);
            groupBox1.Controls.Add(btnPrev);
            groupBox1.Controls.Add(btnFirst);
            groupBox1.Controls.Add(txtDES);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "بينات الصنف";
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.AllowUserToDeleteRows = false;
            dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Location = new Point(16, 15);
            dgList.Name = "dgList";
            dgList.RowTemplate.Height = 25;
            dgList.Size = new Size(326, 179);
            dgList.TabIndex = 0;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(570, 154);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(38, 15);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "label3";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(497, 154);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(54, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += button4_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(437, 154);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(54, 23);
            btnLast.TabIndex = 2;
            btnLast.Text = ">>||";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += button2_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(626, 153);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(58, 23);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "<<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += button3_Click;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(699, 153);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(64, 23);
            btnFirst.TabIndex = 2;
            btnFirst.Text = "||<<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += button1_Click;
            // 
            // txtDES
            // 
            txtDES.Location = new Point(437, 78);
            txtDES.Multiline = true;
            txtDES.Name = "txtDES";
            txtDES.ScrollBars = ScrollBars.Vertical;
            txtDES.Size = new Size(209, 58);
            txtDES.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(437, 37);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(209, 23);
            txtID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(679, 83);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 0;
            label2.Text = "وصف الصنف : ";
            label2.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(679, 37);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "معرف الصنف : ";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPrint);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnNew);
            groupBox2.Location = new Point(12, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 73);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "العمليات المتاحة";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(175, 32);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "طباعة";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(273, 32);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "تعديل";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(387, 32);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(486, 32);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "اضافة";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(598, 32);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 0;
            btnNew.Text = "جديد";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // Form_CATEGORIES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 301);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form_CATEGORIES";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ادارة الاصناف";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtDES;
        private Button btnFirst;
        private Button btnNext;
        private Button btnLast;
        private Button btnPrev;
        private Label lblPosition;
        private GroupBox groupBox2;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnNew;
        private DataGridView dgList;
        private Button btnPrint;
    }
}