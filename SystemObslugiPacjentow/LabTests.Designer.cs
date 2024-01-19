namespace SystemObslugiPacjentow
{
    partial class LabTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabTests));
            LabDGV = new DataGridView();
            LabEditBtn = new Button();
            LabAddBtn = new Button();
            LabDelBtn = new Button();
            TestNameDb = new TextBox();
            label15 = new Label();
            label9 = new Label();
            TestPriceDb = new TextBox();
            label1 = new Label();
            LabExit = new PictureBox();
            pictureBox1 = new PictureBox();
            label14 = new Label();
            LogoutLink = new PictureBox();
            panel1 = new Panel();
            pictureBox11 = new PictureBox();
            RecepLink = new Label();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            LabLink = new Label();
            DoctorLink = new Label();
            PatientLink = new Label();
            ((System.ComponentModel.ISupportInitialize)LabDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LabExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutLink).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // LabDGV
            // 
            LabDGV.BackgroundColor = SystemColors.ButtonHighlight;
            LabDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LabDGV.Location = new Point(199, 231);
            LabDGV.Name = "LabDGV";
            LabDGV.Size = new Size(678, 186);
            LabDGV.TabIndex = 75;
            LabDGV.CellContentClick += LabDGV_CellContentClick;
            // 
            // LabEditBtn
            // 
            LabEditBtn.BackColor = Color.Yellow;
            LabEditBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LabEditBtn.ForeColor = Color.Black;
            LabEditBtn.Location = new Point(581, 170);
            LabEditBtn.Name = "LabEditBtn";
            LabEditBtn.Size = new Size(98, 36);
            LabEditBtn.TabIndex = 74;
            LabEditBtn.Text = "Edit";
            LabEditBtn.UseVisualStyleBackColor = false;
            LabEditBtn.Click += LabEditBtn_Click;
            // 
            // LabAddBtn
            // 
            LabAddBtn.BackColor = SystemColors.ActiveCaptionText;
            LabAddBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LabAddBtn.ForeColor = Color.White;
            LabAddBtn.Location = new Point(474, 170);
            LabAddBtn.Name = "LabAddBtn";
            LabAddBtn.Size = new Size(98, 36);
            LabAddBtn.TabIndex = 73;
            LabAddBtn.Text = "Submit";
            LabAddBtn.UseVisualStyleBackColor = false;
            LabAddBtn.Click += LabAddBtn_Click;
            // 
            // LabDelBtn
            // 
            LabDelBtn.BackColor = Color.FromArgb(192, 0, 0);
            LabDelBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LabDelBtn.ForeColor = Color.White;
            LabDelBtn.Location = new Point(370, 170);
            LabDelBtn.Name = "LabDelBtn";
            LabDelBtn.Size = new Size(98, 36);
            LabDelBtn.TabIndex = 72;
            LabDelBtn.Text = "Delete";
            LabDelBtn.UseVisualStyleBackColor = false;
            LabDelBtn.Click += LabDelBtn_Click;
            // 
            // TestNameDb
            // 
            TestNameDb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            TestNameDb.Location = new Point(338, 112);
            TestNameDb.Name = "TestNameDb";
            TestNameDb.Size = new Size(170, 29);
            TestNameDb.TabIndex = 68;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label15.ForeColor = SystemColors.MenuText;
            label15.Location = new Point(338, 86);
            label15.Name = "label15";
            label15.Size = new Size(86, 21);
            label15.TabIndex = 67;
            label15.Text = "Test Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.ForeColor = SystemColors.MenuText;
            label9.Location = new Point(518, 89);
            label9.Name = "label9";
            label9.Size = new Size(46, 21);
            label9.TabIndex = 66;
            label9.Text = "Price";
            // 
            // TestPriceDb
            // 
            TestPriceDb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            TestPriceDb.Location = new Point(518, 112);
            TestPriceDb.Name = "TestPriceDb";
            TestPriceDb.Size = new Size(177, 29);
            TestPriceDb.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(429, 24);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 59;
            label1.Text = "Labolatory";
            // 
            // LabExit
            // 
            LabExit.Image = (Image)resources.GetObject("LabExit.Image");
            LabExit.Location = new Point(818, 12);
            LabExit.Name = "LabExit";
            LabExit.Size = new Size(29, 29);
            LabExit.SizeMode = PictureBoxSizeMode.StretchImage;
            LabExit.TabIndex = 60;
            LabExit.TabStop = false;
            LabExit.Click += LabExit_Click;
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(92, 322);
            label14.Name = "label14";
            label14.Size = new Size(59, 20);
            label14.TabIndex = 19;
            label14.Text = "Logout";
            label14.Click += label14_Click;
            // 
            // LogoutLink
            // 
            LogoutLink.Image = (Image)resources.GetObject("LogoutLink.Image");
            LogoutLink.Location = new Point(38, 322);
            LogoutLink.Name = "LogoutLink";
            LogoutLink.Size = new Size(43, 42);
            LogoutLink.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutLink.TabIndex = 20;
            LogoutLink.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox11);
            panel1.Controls.Add(RecepLink);
            panel1.Controls.Add(pictureBox10);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(LabLink);
            panel1.Controls.Add(DoctorLink);
            panel1.Controls.Add(PatientLink);
            panel1.Controls.Add(LogoutLink);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 417);
            panel1.TabIndex = 58;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(12, 258);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(43, 42);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 28;
            pictureBox11.TabStop = false;
            // 
            // RecepLink
            // 
            RecepLink.AutoSize = true;
            RecepLink.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            RecepLink.ForeColor = SystemColors.HighlightText;
            RecepLink.Location = new Point(66, 258);
            RecepLink.Name = "RecepLink";
            RecepLink.Size = new Size(96, 20);
            RecepLink.TabIndex = 27;
            RecepLink.Text = "Receptionist";
            RecepLink.Click += RecepLink_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(12, 205);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(43, 42);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 25;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(12, 144);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 42);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 23;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 89);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(43, 42);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 21;
            pictureBox8.TabStop = false;
            // 
            // LabLink
            // 
            LabLink.AutoSize = true;
            LabLink.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LabLink.ForeColor = SystemColors.HighlightText;
            LabLink.Location = new Point(66, 205);
            LabLink.Name = "LabLink";
            LabLink.Size = new Size(85, 20);
            LabLink.TabIndex = 26;
            LabLink.Text = "Labolatory";
            LabLink.Click += LabLink_Click;
            // 
            // DoctorLink
            // 
            DoctorLink.AutoSize = true;
            DoctorLink.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            DoctorLink.ForeColor = SystemColors.HighlightText;
            DoctorLink.Location = new Point(66, 144);
            DoctorLink.Name = "DoctorLink";
            DoctorLink.Size = new Size(64, 20);
            DoctorLink.TabIndex = 24;
            DoctorLink.Text = "Doctors";
            DoctorLink.Click += DoctorLink_Click;
            // 
            // PatientLink
            // 
            PatientLink.AutoSize = true;
            PatientLink.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            PatientLink.ForeColor = SystemColors.HighlightText;
            PatientLink.Location = new Point(66, 89);
            PatientLink.Name = "PatientLink";
            PatientLink.Size = new Size(66, 20);
            PatientLink.TabIndex = 22;
            PatientLink.Text = "Patients";
            PatientLink.Click += PatientLink_Click;
            // 
            // LabTests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(877, 417);
            Controls.Add(LabDGV);
            Controls.Add(LabEditBtn);
            Controls.Add(LabAddBtn);
            Controls.Add(LabDelBtn);
            Controls.Add(TestNameDb);
            Controls.Add(label15);
            Controls.Add(label9);
            Controls.Add(TestPriceDb);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(LabExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LabTests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LabTests";
            ((System.ComponentModel.ISupportInitialize)LabDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)LabExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutLink).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView LabDGV;
        private Button LabEditBtn;
        private Button LabAddBtn;
        private Button LabDelBtn;
        private TextBox TestNameDb;
        private Label label15;
        private Label label9;
        private TextBox TestPriceDb;
        private Label label1;
        private PictureBox LabExit;
        private PictureBox pictureBox1;
        private Label label14;
        private PictureBox LogoutLink;
        private Panel panel1;
        private PictureBox pictureBox11;
        private Label RecepLink;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Label LabLink;
        private Label DoctorLink;
        private Label PatientLink;
    }
}