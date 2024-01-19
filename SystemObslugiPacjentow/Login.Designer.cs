namespace SystemObslugiPacjentow
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            LoginExitBtn = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            RoleDb = new ComboBox();
            LoginUsrnmDb = new TextBox();
            LoginPassDb = new TextBox();
            LoginBtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            RstBtn = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginExitBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(LoginExitBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 100);
            panel1.TabIndex = 0;
            // 
            // LoginExitBtn
            // 
            LoginExitBtn.Image = (Image)resources.GetObject("LoginExitBtn.Image");
            LoginExitBtn.Location = new Point(347, 10);
            LoginExitBtn.Name = "LoginExitBtn";
            LoginExitBtn.Size = new Size(29, 29);
            LoginExitBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LoginExitBtn.TabIndex = 9;
            LoginExitBtn.TabStop = false;
            LoginExitBtn.Click += LoginExitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(51, 36);
            label1.Name = "label1";
            label1.Size = new Size(266, 25);
            label1.TabIndex = 1;
            label1.Text = "Patient Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(156, 280);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.MenuText;
            label3.Location = new Point(156, 355);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // RoleDb
            // 
            RoleDb.FormattingEnabled = true;
            RoleDb.Items.AddRange(new object[] { "Administrator", "Doctor", "Receptionist" });
            RoleDb.Location = new Point(76, 226);
            RoleDb.Name = "RoleDb";
            RoleDb.Size = new Size(222, 23);
            RoleDb.TabIndex = 4;
            // 
            // LoginUsrnmDb
            // 
            LoginUsrnmDb.Location = new Point(99, 310);
            LoginUsrnmDb.Name = "LoginUsrnmDb";
            LoginUsrnmDb.Size = new Size(174, 23);
            LoginUsrnmDb.TabIndex = 5;
            // 
            // LoginPassDb
            // 
            LoginPassDb.Location = new Point(99, 384);
            LoginPassDb.Name = "LoginPassDb";
            LoginPassDb.PasswordChar = '*';
            LoginPassDb.Size = new Size(174, 23);
            LoginPassDb.TabIndex = 6;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Black;
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(138, 413);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(98, 36);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RstBtn
            // 
            RstBtn.AutoSize = true;
            RstBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            RstBtn.ForeColor = Color.Crimson;
            RstBtn.Location = new Point(162, 462);
            RstBtn.Name = "RstBtn";
            RstBtn.Size = new Size(51, 21);
            RstBtn.TabIndex = 8;
            RstBtn.Text = "Reset";
            RstBtn.Click += RstBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(388, 492);
            Controls.Add(RstBtn);
            Controls.Add(LoginBtn);
            Controls.Add(LoginPassDb);
            Controls.Add(LoginUsrnmDb);
            Controls.Add(RoleDb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoginExitBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private ComboBox RoleDb;
        private TextBox LoginUsrnmDb;
        private TextBox LoginPassDb;
        private Button LoginBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label RstBtn;
        private PictureBox LoginExitBtn;
    }
}
