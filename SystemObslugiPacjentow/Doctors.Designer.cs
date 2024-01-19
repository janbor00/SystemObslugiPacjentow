namespace SystemObslugiPacjentow
{
    partial class Doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors));
            DocEditBtn = new Button();
            DocAddBtn = new Button();
            DocDelBtn = new Button();
            label16 = new Label();
            DocAddTb = new TextBox();
            DocGenTb = new ComboBox();
            DocPhoneTb = new TextBox();
            label15 = new Label();
            label9 = new Label();
            DocExpTb = new TextBox();
            DocDOB = new DateTimePicker();
            DocSpecTb = new ComboBox();
            DocNameTb = new TextBox();
            label8 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox12 = new PictureBox();
            LogoutLink = new Label();
            pictureBox11 = new PictureBox();
            RecepLink = new Label();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            LabLink = new Label();
            DoctorsLink = new Label();
            PatientLink = new Label();
            pictureBox1 = new PictureBox();
            ExitDoc = new PictureBox();
            DoctorsDGV = new DataGridView();
            label2 = new Label();
            DocPassTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitDoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoctorsDGV).BeginInit();
            SuspendLayout();
            // 
            // DocEditBtn
            // 
            DocEditBtn.BackColor = Color.Yellow;
            DocEditBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DocEditBtn.ForeColor = Color.Black;
            DocEditBtn.Location = new Point(589, 360);
            DocEditBtn.Name = "DocEditBtn";
            DocEditBtn.Size = new Size(98, 36);
            DocEditBtn.TabIndex = 52;
            DocEditBtn.Text = "Edit";
            DocEditBtn.UseVisualStyleBackColor = false;
            DocEditBtn.Click += DocEditBtn_Click;
            // 
            // DocAddBtn
            // 
            DocAddBtn.BackColor = SystemColors.ActiveCaptionText;
            DocAddBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DocAddBtn.ForeColor = Color.White;
            DocAddBtn.Location = new Point(482, 360);
            DocAddBtn.Name = "DocAddBtn";
            DocAddBtn.Size = new Size(98, 36);
            DocAddBtn.TabIndex = 51;
            DocAddBtn.Text = "Submit";
            DocAddBtn.UseVisualStyleBackColor = false;
            DocAddBtn.Click += DocAddBtn_Click;
            // 
            // DocDelBtn
            // 
            DocDelBtn.BackColor = Color.FromArgb(192, 0, 0);
            DocDelBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DocDelBtn.ForeColor = Color.White;
            DocDelBtn.Location = new Point(378, 360);
            DocDelBtn.Name = "DocDelBtn";
            DocDelBtn.Size = new Size(98, 36);
            DocDelBtn.TabIndex = 50;
            DocDelBtn.Text = "Delete";
            DocDelBtn.UseVisualStyleBackColor = false;
            DocDelBtn.Click += DocDelBtn_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label16.ForeColor = SystemColors.MenuText;
            label16.Location = new Point(651, 105);
            label16.Name = "label16";
            label16.Size = new Size(70, 21);
            label16.TabIndex = 49;
            label16.Text = "Address";
            // 
            // DocAddTb
            // 
            DocAddTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DocAddTb.Location = new Point(651, 128);
            DocAddTb.Multiline = true;
            DocAddTb.Name = "DocAddTb";
            DocAddTb.Size = new Size(177, 80);
            DocAddTb.TabIndex = 48;
            // 
            // DocGenTb
            // 
            DocGenTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DocGenTb.FormattingEnabled = true;
            DocGenTb.Items.AddRange(new object[] { "Male", "Female" });
            DocGenTb.Location = new Point(523, 179);
            DocGenTb.Name = "DocGenTb";
            DocGenTb.Size = new Size(113, 29);
            DocGenTb.TabIndex = 47;
            DocGenTb.Text = "Gender";
            // 
            // DocPhoneTb
            // 
            DocPhoneTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DocPhoneTb.Location = new Point(223, 244);
            DocPhoneTb.Name = "DocPhoneTb";
            DocPhoneTb.Size = new Size(170, 29);
            DocPhoneTb.TabIndex = 46;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label15.ForeColor = SystemColors.MenuText;
            label15.Location = new Point(223, 218);
            label15.Name = "label15";
            label15.Size = new Size(56, 21);
            label15.TabIndex = 45;
            label15.Text = "Phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.ForeColor = SystemColors.MenuText;
            label9.Location = new Point(403, 221);
            label9.Name = "label9";
            label9.Size = new Size(90, 21);
            label9.TabIndex = 44;
            label9.Text = "Experience";
            // 
            // DocExpTb
            // 
            DocExpTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DocExpTb.Location = new Point(403, 244);
            DocExpTb.Name = "DocExpTb";
            DocExpTb.Size = new Size(177, 29);
            DocExpTb.TabIndex = 43;
            // 
            // DocDOB
            // 
            DocDOB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DocDOB.Location = new Point(219, 176);
            DocDOB.Name = "DocDOB";
            DocDOB.Size = new Size(289, 29);
            DocDOB.TabIndex = 42;
            // 
            // DocSpecTb
            // 
            DocSpecTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DocSpecTb.FormattingEnabled = true;
            DocSpecTb.Items.AddRange(new object[] { "Gynecologist", "Surgeon", "Dermatologist", "Urology", "General" });
            DocSpecTb.Location = new Point(469, 128);
            DocSpecTb.Name = "DocSpecTb";
            DocSpecTb.Size = new Size(167, 29);
            DocSpecTb.TabIndex = 41;
            DocSpecTb.Text = "Specialization";
            // 
            // DocNameTb
            // 
            DocNameTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DocNameTb.Location = new Point(219, 128);
            DocNameTb.Name = "DocNameTb";
            DocNameTb.Size = new Size(244, 29);
            DocNameTb.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.ForeColor = SystemColors.MenuText;
            label8.Location = new Point(219, 105);
            label8.Name = "label8";
            label8.Size = new Size(108, 21);
            label8.TabIndex = 39;
            label8.Text = "Doctor Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(421, 24);
            label1.Name = "label1";
            label1.Size = new Size(266, 25);
            label1.TabIndex = 36;
            label1.Text = "Patient Management System";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox12);
            panel1.Controls.Add(LogoutLink);
            panel1.Controls.Add(pictureBox11);
            panel1.Controls.Add(RecepLink);
            panel1.Controls.Add(pictureBox10);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(LabLink);
            panel1.Controls.Add(DoctorsLink);
            panel1.Controls.Add(PatientLink);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 608);
            panel1.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(66, 317);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 21;
            label3.Text = "Labolatory";
            label3.Click += label3_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(12, 528);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(43, 42);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 20;
            pictureBox12.TabStop = false;
            // 
            // LogoutLink
            // 
            LogoutLink.AutoSize = true;
            LogoutLink.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LogoutLink.ForeColor = SystemColors.ButtonHighlight;
            LogoutLink.Location = new Point(66, 528);
            LogoutLink.Name = "LogoutLink";
            LogoutLink.Size = new Size(59, 20);
            LogoutLink.TabIndex = 19;
            LogoutLink.Text = "Logout";
            LogoutLink.Click += LogoutLink_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(12, 317);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(43, 42);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 18;
            pictureBox11.TabStop = false;
            // 
            // RecepLink
            // 
            RecepLink.AutoSize = true;
            RecepLink.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            RecepLink.ForeColor = SystemColors.HighlightText;
            RecepLink.Location = new Point(66, 317);
            RecepLink.Name = "RecepLink";
            RecepLink.Size = new Size(0, 20);
            RecepLink.TabIndex = 17;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(12, 264);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(43, 42);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 16;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(12, 203);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 42);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 15;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 148);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(43, 42);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            // 
            // LabLink
            // 
            LabLink.AutoSize = true;
            LabLink.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LabLink.ForeColor = SystemColors.HighlightText;
            LabLink.Location = new Point(66, 264);
            LabLink.Name = "LabLink";
            LabLink.Size = new Size(85, 20);
            LabLink.TabIndex = 16;
            LabLink.Text = "Labolatory";
            LabLink.Click += LabLink_Click;
            // 
            // DoctorsLink
            // 
            DoctorsLink.AutoSize = true;
            DoctorsLink.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            DoctorsLink.ForeColor = SystemColors.HighlightText;
            DoctorsLink.Location = new Point(66, 203);
            DoctorsLink.Name = "DoctorsLink";
            DoctorsLink.Size = new Size(51, 20);
            DoctorsLink.TabIndex = 15;
            DoctorsLink.Text = "Home";
            DoctorsLink.Click += DoctorsLink_Click;
            // 
            // PatientLink
            // 
            PatientLink.AutoSize = true;
            PatientLink.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            PatientLink.ForeColor = SystemColors.HighlightText;
            PatientLink.Location = new Point(66, 148);
            PatientLink.Name = "PatientLink";
            PatientLink.Size = new Size(66, 20);
            PatientLink.TabIndex = 14;
            PatientLink.Text = "Patients";
            PatientLink.Click += PatientLink_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ExitDoc
            // 
            ExitDoc.Image = (Image)resources.GetObject("ExitDoc.Image");
            ExitDoc.Location = new Point(818, 12);
            ExitDoc.Name = "ExitDoc";
            ExitDoc.Size = new Size(29, 29);
            ExitDoc.SizeMode = PictureBoxSizeMode.StretchImage;
            ExitDoc.TabIndex = 37;
            ExitDoc.TabStop = false;
            ExitDoc.Click += ExitDoc_Click;
            // 
            // DoctorsDGV
            // 
            DoctorsDGV.BackgroundColor = SystemColors.ButtonHighlight;
            DoctorsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DoctorsDGV.Location = new Point(199, 422);
            DoctorsDGV.Name = "DoctorsDGV";
            DoctorsDGV.Size = new Size(678, 186);
            DoctorsDGV.TabIndex = 55;
            DoctorsDGV.CellContentClick += DoctorsDGV_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(589, 221);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 57;
            label2.Text = "Password";
            // 
            // DocPassTb
            // 
            DocPassTb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DocPassTb.Location = new Point(589, 244);
            DocPassTb.Name = "DocPassTb";
            DocPassTb.Size = new Size(177, 29);
            DocPassTb.TabIndex = 56;
            // 
            // Doctors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(877, 608);
            Controls.Add(label2);
            Controls.Add(DocPassTb);
            Controls.Add(DoctorsDGV);
            Controls.Add(DocEditBtn);
            Controls.Add(DocAddBtn);
            Controls.Add(DocDelBtn);
            Controls.Add(label16);
            Controls.Add(DocAddTb);
            Controls.Add(DocGenTb);
            Controls.Add(DocPhoneTb);
            Controls.Add(label15);
            Controls.Add(label9);
            Controls.Add(DocExpTb);
            Controls.Add(DocDOB);
            Controls.Add(DocSpecTb);
            Controls.Add(DocNameTb);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(ExitDoc);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctors";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctors";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitDoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoctorsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DocEditBtn;
        private Button DocAddBtn;
        private Button DocDelBtn;
        private Label label16;
        private TextBox DocAddTb;
        private ComboBox DocGenTb;
        private TextBox DocPhoneTb;
        private Label label15;
        private Label label9;
        private TextBox DocExpTb;
        private DateTimePicker DocDOB;
        private ComboBox DocSpecTb;
        private TextBox DocNameTb;
        private Label label8;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox12;
        private Label LogoutLink;
        private PictureBox pictureBox11;
        private Label RecepLink;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Label LabLink;
        private Label DoctorsLink;
        private Label PatientLink;
        private PictureBox pictureBox1;
        private PictureBox ExitDoc;
        private DataGridView DoctorsDGV;
        private Label label2;
        private TextBox DocPassTb;
        private Label label3;
    }
}