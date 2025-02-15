namespace NEXUS.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            separator1 = new ReaLTaiizor.Controls.Separator();
            label2 = new Label();
            pnlUsername = new Panel();
            tbxNewFirstName = new TextBox();
            tbxNewLastName = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            tbxNewUserName = new TextBox();
            panel4 = new Panel();
            pbPrivacy1 = new PictureBox();
            tbxNewPassword = new TextBox();
            label3 = new Label();
            cmbxMonth = new ComboBox();
            cmbxDay = new ComboBox();
            cmbxYear = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            rbtnFemale = new ReaLTaiizor.Controls.HopeRadioButton();
            panel6 = new Panel();
            rbtnMale = new ReaLTaiizor.Controls.HopeRadioButton();
            panel7 = new Panel();
            rbtnNotSay = new ReaLTaiizor.Controls.HopeRadioButton();
            label7 = new Label();
            btnSignUp = new ReaLTaiizor.Controls.Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlUsername.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrivacy1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(153, 229, 255);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(554, 34);
            panel2.TabIndex = 16;
            panel2.MouseDown += Register_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(499, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += Minimize;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(468, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Minimize;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(526, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Close;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(24, 60, 114);
            label1.Location = new Point(9, 46);
            label1.Name = "label1";
            label1.Size = new Size(116, 39);
            label1.TabIndex = 17;
            label1.Text = "Sign up";
            // 
            // separator1
            // 
            separator1.LineColor = Color.Gray;
            separator1.Location = new Point(13, 104);
            separator1.Name = "separator1";
            separator1.Size = new Size(514, 20);
            separator1.TabIndex = 19;
            separator1.Text = "separator1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 10F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(14, 84);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 18;
            label2.Text = "It's quick and easy.";
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.FromArgb(176, 233, 255);
            pnlUsername.BackgroundImageLayout = ImageLayout.None;
            pnlUsername.Controls.Add(tbxNewFirstName);
            pnlUsername.Location = new Point(21, 127);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(302, 48);
            pnlUsername.TabIndex = 20;
            // 
            // tbxNewFirstName
            // 
            tbxNewFirstName.BackColor = Color.FromArgb(176, 233, 255);
            tbxNewFirstName.BorderStyle = BorderStyle.None;
            tbxNewFirstName.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNewFirstName.ForeColor = Color.FromArgb(24, 60, 114);
            tbxNewFirstName.Location = new Point(13, 13);
            tbxNewFirstName.Name = "tbxNewFirstName";
            tbxNewFirstName.Size = new Size(273, 20);
            tbxNewFirstName.TabIndex = 9;
            tbxNewFirstName.TabStop = false;
            tbxNewFirstName.Text = "First Name";
            // 
            // tbxNewLastName
            // 
            tbxNewLastName.BackColor = Color.FromArgb(176, 233, 255);
            tbxNewLastName.BorderStyle = BorderStyle.None;
            tbxNewLastName.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNewLastName.ForeColor = Color.FromArgb(24, 60, 114);
            tbxNewLastName.Location = new Point(11, 13);
            tbxNewLastName.Name = "tbxNewLastName";
            tbxNewLastName.Size = new Size(165, 20);
            tbxNewLastName.TabIndex = 9;
            tbxNewLastName.TabStop = false;
            tbxNewLastName.Text = "Last Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(176, 233, 255);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(tbxNewLastName);
            panel1.Location = new Point(338, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 48);
            panel1.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(176, 233, 255);
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(tbxNewUserName);
            panel3.Location = new Point(20, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(511, 48);
            panel3.TabIndex = 21;
            // 
            // tbxNewUserName
            // 
            tbxNewUserName.BackColor = Color.FromArgb(176, 233, 255);
            tbxNewUserName.BorderStyle = BorderStyle.None;
            tbxNewUserName.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNewUserName.ForeColor = Color.FromArgb(24, 60, 114);
            tbxNewUserName.Location = new Point(13, 13);
            tbxNewUserName.Name = "tbxNewUserName";
            tbxNewUserName.Size = new Size(481, 20);
            tbxNewUserName.TabIndex = 9;
            tbxNewUserName.TabStop = false;
            tbxNewUserName.Text = "Username";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(176, 233, 255);
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(pbPrivacy1);
            panel4.Controls.Add(tbxNewPassword);
            panel4.Location = new Point(20, 253);
            panel4.Name = "panel4";
            panel4.Size = new Size(511, 48);
            panel4.TabIndex = 22;
            // 
            // pbPrivacy1
            // 
            pbPrivacy1.Cursor = Cursors.Hand;
            pbPrivacy1.Image = Properties.Resources._3844443_disable_eye_inactive_see_show_icon;
            pbPrivacy1.Location = new Point(470, 13);
            pbPrivacy1.Name = "pbPrivacy1";
            pbPrivacy1.Size = new Size(33, 21);
            pbPrivacy1.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPrivacy1.TabIndex = 69;
            pbPrivacy1.TabStop = false;
            pbPrivacy1.Click += pbPrivacy1_Click;
            // 
            // tbxNewPassword
            // 
            tbxNewPassword.BackColor = Color.FromArgb(176, 233, 255);
            tbxNewPassword.BorderStyle = BorderStyle.None;
            tbxNewPassword.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNewPassword.ForeColor = Color.FromArgb(24, 60, 114);
            tbxNewPassword.Location = new Point(13, 13);
            tbxNewPassword.Name = "tbxNewPassword";
            tbxNewPassword.Size = new Size(459, 20);
            tbxNewPassword.TabIndex = 9;
            tbxNewPassword.TabStop = false;
            tbxNewPassword.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 10.55F);
            label3.ForeColor = Color.FromArgb(24, 60, 114);
            label3.Location = new Point(16, 315);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 23;
            label3.Text = "Birthday";
            // 
            // cmbxMonth
            // 
            cmbxMonth.BackColor = Color.FromArgb(176, 233, 255);
            cmbxMonth.Font = new Font("Inter", 11.25F);
            cmbxMonth.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxMonth.FormattingEnabled = true;
            cmbxMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cmbxMonth.Location = new Point(29, 341);
            cmbxMonth.Name = "cmbxMonth";
            cmbxMonth.Size = new Size(168, 30);
            cmbxMonth.TabIndex = 24;
            cmbxMonth.Text = "Month";
            // 
            // cmbxDay
            // 
            cmbxDay.BackColor = Color.FromArgb(176, 233, 255);
            cmbxDay.Font = new Font("Inter", 11.25F);
            cmbxDay.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxDay.FormattingEnabled = true;
            cmbxDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cmbxDay.Location = new Point(220, 341);
            cmbxDay.Name = "cmbxDay";
            cmbxDay.Size = new Size(123, 30);
            cmbxDay.TabIndex = 25;
            cmbxDay.Text = "Day";
            // 
            // cmbxYear
            // 
            cmbxYear.BackColor = Color.FromArgb(176, 233, 255);
            cmbxYear.Font = new Font("Inter", 11.25F);
            cmbxYear.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxYear.FormattingEnabled = true;
            cmbxYear.Items.AddRange(new object[] { "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            cmbxYear.Location = new Point(366, 341);
            cmbxYear.Name = "cmbxYear";
            cmbxYear.Size = new Size(145, 30);
            cmbxYear.TabIndex = 26;
            cmbxYear.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 10.55F);
            label4.ForeColor = Color.FromArgb(24, 60, 114);
            label4.Location = new Point(16, 384);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 27;
            label4.Text = "Gender";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(176, 233, 255);
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Controls.Add(rbtnFemale);
            panel5.Location = new Point(21, 413);
            panel5.Name = "panel5";
            panel5.Size = new Size(137, 41);
            panel5.TabIndex = 22;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.CheckedColor = Color.FromArgb(64, 158, 255);
            rbtnFemale.DisabledColor = Color.FromArgb(196, 198, 202);
            rbtnFemale.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rbtnFemale.Enable = true;
            rbtnFemale.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rbtnFemale.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rbtnFemale.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rbtnFemale.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnFemale.ForeColor = Color.FromArgb(24, 60, 114);
            rbtnFemale.Location = new Point(22, 11);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(88, 20);
            rbtnFemale.TabIndex = 28;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(176, 233, 255);
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.Controls.Add(rbtnMale);
            panel6.Location = new Point(188, 413);
            panel6.Name = "panel6";
            panel6.Size = new Size(112, 41);
            panel6.TabIndex = 29;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.CheckedColor = Color.FromArgb(64, 158, 255);
            rbtnMale.DisabledColor = Color.FromArgb(196, 198, 202);
            rbtnMale.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rbtnMale.Enable = true;
            rbtnMale.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rbtnMale.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rbtnMale.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rbtnMale.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnMale.ForeColor = Color.FromArgb(24, 60, 114);
            rbtnMale.Location = new Point(22, 11);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(71, 20);
            rbtnMale.TabIndex = 28;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(176, 233, 255);
            panel7.BackgroundImageLayout = ImageLayout.None;
            panel7.Controls.Add(rbtnNotSay);
            panel7.Location = new Point(328, 413);
            panel7.Name = "panel7";
            panel7.Size = new Size(201, 41);
            panel7.TabIndex = 30;
            // 
            // rbtnNotSay
            // 
            rbtnNotSay.AutoSize = true;
            rbtnNotSay.CheckedColor = Color.FromArgb(64, 158, 255);
            rbtnNotSay.DisabledColor = Color.FromArgb(196, 198, 202);
            rbtnNotSay.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rbtnNotSay.Enable = true;
            rbtnNotSay.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rbtnNotSay.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rbtnNotSay.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rbtnNotSay.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnNotSay.ForeColor = Color.FromArgb(24, 60, 114);
            rbtnNotSay.Location = new Point(22, 11);
            rbtnNotSay.Name = "rbtnNotSay";
            rbtnNotSay.Size = new Size(161, 20);
            rbtnNotSay.TabIndex = 28;
            rbtnNotSay.TabStop = true;
            rbtnNotSay.Text = "Prefer not to say";
            rbtnNotSay.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(25, 481);
            label7.Name = "label7";
            label7.Size = new Size(488, 18);
            label7.TabIndex = 66;
            label7.Text = "By clicking Sing Up, you agreee to our Terms, Data Policy and Cookies Policy.";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(24, 60, 114);
            btnSignUp.BorderColor = Color.FromArgb(24, 60, 114);
            btnSignUp.EnteredBorderColor = Color.FromArgb(255, 192, 192);
            btnSignUp.EnteredColor = Color.FromArgb(24, 60, 114);
            btnSignUp.Font = new Font("Inter Medium", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSignUp.Image = null;
            btnSignUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignUp.InactiveColor = Color.FromArgb(24, 60, 114);
            btnSignUp.Location = new Point(171, 509);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.PressedBorderColor = Color.FromArgb(176, 233, 255);
            btnSignUp.PressedColor = Color.FromArgb(176, 233, 255);
            btnSignUp.Size = new Size(215, 40);
            btnSignUp.TabIndex = 68;
            btnSignUp.Text = "Sign Up";
            btnSignUp.TextAlignment = StringAlignment.Center;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(554, 566);
            Controls.Add(btnSignUp);
            Controls.Add(label7);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(label4);
            Controls.Add(cmbxYear);
            Controls.Add(cmbxDay);
            Controls.Add(cmbxMonth);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pnlUsername);
            Controls.Add(separator1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            MouseDown += Register_MouseDown;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrivacy1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private ReaLTaiizor.Controls.Separator separator1;
        private Label label2;
        private Panel pnlUsername;
        private TextBox tbxNewFirstName;
        private TextBox tbxNewLastName;
        private Panel panel1;
        private Panel panel3;
        private TextBox tbxNewUserName;
        private Panel panel4;
        private TextBox tbxNewPassword;
        private Label label3;
        private ComboBox cmbxMonth;
        private ComboBox cmbxDay;
        private ComboBox cmbxYear;
        private Label label4;
        private Panel panel5;
        private ReaLTaiizor.Controls.HopeRadioButton rbtnFemale;
        private Panel panel6;
        private ReaLTaiizor.Controls.HopeRadioButton rbtnMale;
        private Panel panel7;
        private ReaLTaiizor.Controls.HopeRadioButton rbtnNotSay;
        private Label label7;
        private ReaLTaiizor.Controls.Button btnSignUp;
        private PictureBox pbPrivacy1;
    }
}