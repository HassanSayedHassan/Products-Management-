namespace Products_Management.PRESENTATION_LAYER
{
    partial class Form_LOGIN
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
            label2 = new Label();
            txtPWD = new TextBox();
            txtID = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "اسم المستخدم";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 80);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "كلمة المرور";
            label2.Click += label1_Click;
            // 
            // txtPWD
            // 
            txtPWD.Location = new Point(190, 77);
            txtPWD.Name = "txtPWD";
            txtPWD.PasswordChar = '*';
            txtPWD.Size = new Size(316, 23);
            txtPWD.TabIndex = 1;
            txtPWD.TextChanged += textBox1_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(190, 19);
            txtID.Name = "txtID";
            txtID.Size = new Size(316, 23);
            txtID.TabIndex = 1;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(227, 126);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "دخول";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(409, 126);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "الغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form_LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 205);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtID);
            Controls.Add(txtPWD);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_LOGIN";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "تسجيل الدخول";
            Load += Form_LOGIN_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPWD;
        private TextBox txtID;
        private Button btnLogin;
        private Button btnCancel;
    }
}