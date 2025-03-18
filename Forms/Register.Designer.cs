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
            rbtnMale = new ReaLTaiizor.Controls.HopeRadioButton();
            rbtnNotSay = new ReaLTaiizor.Controls.HopeRadioButton();
            label7 = new Label();
            btnSignUp = new ReaLTaiizor.Controls.Button();
            panel8 = new Panel();
            rbtnFemale = new ReaLTaiizor.Controls.HopeRadioButton();
            panel7 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            pnlRole = new Panel();
            rbtnDriver = new ReaLTaiizor.Controls.HopeRadioButton();
            rbtnPassenger = new ReaLTaiizor.Controls.HopeRadioButton();
            panel12 = new Panel();
            panel10 = new Panel();
            label5 = new Label();
            panel11 = new Panel();
            tbxEmail = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlUsername.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrivacy1).BeginInit();
            panel8.SuspendLayout();
            pnlRole.SuspendLayout();
            panel11.SuspendLayout();
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
            panel2.Size = new Size(554, 28);
            panel2.TabIndex = 16;
            panel2.MouseDown += Register_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(499, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += Maximize;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(468, 4);
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
            pictureBox1.Location = new Point(526, 4);
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
            pnlUsername.Click += EnterFirstname;
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
            tbxNewFirstName.Click += EnterFirstname;
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
            tbxNewLastName.Click += EnterLastname;
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
            panel1.Click += EnterLastname;
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
            panel3.Click += EnterUsername;
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
            tbxNewUserName.Click += EnterUsername;
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
            panel4.Click += EnterPassword;
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
            tbxNewPassword.Click += EnterPassword;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 10.55F);
            label3.ForeColor = Color.FromArgb(24, 60, 114);
            label3.Location = new Point(16, 466);
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
            cmbxMonth.Location = new Point(29, 492);
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
            cmbxDay.Location = new Point(220, 492);
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
            cmbxYear.Location = new Point(366, 492);
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
            label4.Location = new Point(16, 535);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 27;
            label4.Text = "Gender";
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.BackColor = Color.FromArgb(176, 233, 255);
            rbtnMale.CheckedColor = Color.FromArgb(64, 158, 255);
            rbtnMale.DisabledColor = Color.FromArgb(196, 198, 202);
            rbtnMale.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rbtnMale.Enable = true;
            rbtnMale.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rbtnMale.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rbtnMale.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rbtnMale.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnMale.ForeColor = Color.FromArgb(24, 60, 114);
            rbtnMale.Location = new Point(188, 16);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(71, 20);
            rbtnMale.TabIndex = 28;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = false;
            // 
            // rbtnNotSay
            // 
            rbtnNotSay.AutoSize = true;
            rbtnNotSay.BackColor = Color.FromArgb(176, 233, 255);
            rbtnNotSay.CheckedColor = Color.FromArgb(64, 158, 255);
            rbtnNotSay.DisabledColor = Color.FromArgb(196, 198, 202);
            rbtnNotSay.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rbtnNotSay.Enable = true;
            rbtnNotSay.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rbtnNotSay.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rbtnNotSay.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rbtnNotSay.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnNotSay.ForeColor = Color.FromArgb(24, 60, 114);
            rbtnNotSay.Location = new Point(329, 16);
            rbtnNotSay.Name = "rbtnNotSay";
            rbtnNotSay.Size = new Size(161, 20);
            rbtnNotSay.TabIndex = 28;
            rbtnNotSay.TabStop = true;
            rbtnNotSay.Text = "Prefer not to say";
            rbtnNotSay.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter", 10F);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(19, 619);
            label7.Name = "label7";
            label7.Size = new Size(425, 21);
            label7.TabIndex = 66;
            label7.Text = "By signing up, you agree to our Privacy Policy and Data Usage.";
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
            btnSignUp.Location = new Point(171, 660);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.PressedBorderColor = Color.FromArgb(176, 233, 255);
            btnSignUp.PressedColor = Color.FromArgb(176, 233, 255);
            btnSignUp.Size = new Size(215, 40);
            btnSignUp.TabIndex = 68;
            btnSignUp.Text = "Sign Up";
            btnSignUp.TextAlignment = StringAlignment.Center;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(230, 249, 255);
            panel8.BackgroundImageLayout = ImageLayout.None;
            panel8.Controls.Add(rbtnFemale);
            panel8.Controls.Add(rbtnMale);
            panel8.Controls.Add(rbtnNotSay);
            panel8.Controls.Add(panel7);
            panel8.Controls.Add(panel5);
            panel8.Controls.Add(panel6);
            panel8.Location = new Point(20, 560);
            panel8.Name = "panel8";
            panel8.Size = new Size(511, 55);
            panel8.TabIndex = 29;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.BackColor = Color.FromArgb(176, 233, 255);
            rbtnFemale.CheckedColor = Color.FromArgb(64, 158, 255);
            rbtnFemale.DisabledColor = Color.FromArgb(196, 198, 202);
            rbtnFemale.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rbtnFemale.Enable = true;
            rbtnFemale.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rbtnFemale.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rbtnFemale.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rbtnFemale.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnFemale.ForeColor = Color.FromArgb(24, 60, 114);
            rbtnFemale.Location = new Point(21, 16);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(88, 20);
            rbtnFemale.TabIndex = 28;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(176, 233, 255);
            panel7.BackgroundImageLayout = ImageLayout.None;
            panel7.Location = new Point(318, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(191, 41);
            panel7.TabIndex = 69;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(176, 233, 255);
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Location = new Point(180, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(107, 41);
            panel5.TabIndex = 70;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(176, 233, 255);
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.Location = new Point(14, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(139, 41);
            panel6.TabIndex = 71;
            // 
            // pnlRole
            // 
            pnlRole.BackColor = Color.FromArgb(230, 249, 255);
            pnlRole.BackgroundImageLayout = ImageLayout.None;
            pnlRole.Controls.Add(rbtnDriver);
            pnlRole.Controls.Add(rbtnPassenger);
            pnlRole.Controls.Add(panel12);
            pnlRole.Controls.Add(panel10);
            pnlRole.Location = new Point(21, 399);
            pnlRole.Name = "pnlRole";
            pnlRole.Size = new Size(390, 55);
            pnlRole.TabIndex = 72;
            // 
            // rbtnDriver
            // 
            rbtnDriver.AutoSize = true;
            rbtnDriver.BackColor = Color.FromArgb(176, 233, 255);
            rbtnDriver.CheckedColor = Color.FromArgb(64, 158, 255);
            rbtnDriver.DisabledColor = Color.FromArgb(196, 198, 202);
            rbtnDriver.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rbtnDriver.Enable = true;
            rbtnDriver.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rbtnDriver.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rbtnDriver.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rbtnDriver.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnDriver.ForeColor = Color.FromArgb(24, 60, 114);
            rbtnDriver.Location = new Point(240, 16);
            rbtnDriver.Name = "rbtnDriver";
            rbtnDriver.Size = new Size(81, 20);
            rbtnDriver.TabIndex = 28;
            rbtnDriver.TabStop = true;
            rbtnDriver.Text = "Driver";
            rbtnDriver.UseVisualStyleBackColor = false;
            // 
            // rbtnPassenger
            // 
            rbtnPassenger.AutoSize = true;
            rbtnPassenger.BackColor = Color.FromArgb(176, 233, 255);
            rbtnPassenger.CheckedColor = Color.FromArgb(64, 158, 255);
            rbtnPassenger.DisabledColor = Color.FromArgb(196, 198, 202);
            rbtnPassenger.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rbtnPassenger.Enable = true;
            rbtnPassenger.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rbtnPassenger.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rbtnPassenger.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rbtnPassenger.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnPassenger.ForeColor = Color.FromArgb(24, 60, 114);
            rbtnPassenger.Location = new Point(27, 16);
            rbtnPassenger.Name = "rbtnPassenger";
            rbtnPassenger.Size = new Size(113, 20);
            rbtnPassenger.TabIndex = 28;
            rbtnPassenger.TabStop = true;
            rbtnPassenger.Text = "Passenger";
            rbtnPassenger.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(176, 233, 255);
            panel12.BackgroundImageLayout = ImageLayout.None;
            panel12.Location = new Point(14, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(159, 46);
            panel12.TabIndex = 71;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(176, 233, 255);
            panel10.BackgroundImageLayout = ImageLayout.None;
            panel10.Location = new Point(223, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(153, 46);
            panel10.TabIndex = 69;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 10.55F);
            label5.ForeColor = Color.FromArgb(24, 60, 114);
            label5.Location = new Point(14, 374);
            label5.Name = "label5";
            label5.Size = new Size(83, 22);
            label5.TabIndex = 73;
            label5.Text = "User Type";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(176, 233, 255);
            panel11.BackgroundImageLayout = ImageLayout.None;
            panel11.Controls.Add(tbxEmail);
            panel11.Location = new Point(21, 316);
            panel11.Name = "panel11";
            panel11.Size = new Size(511, 48);
            panel11.TabIndex = 22;
            panel11.ClientSizeChanged += tbxEmail_Click;
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.FromArgb(176, 233, 255);
            tbxEmail.BorderStyle = BorderStyle.None;
            tbxEmail.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxEmail.ForeColor = Color.FromArgb(24, 60, 114);
            tbxEmail.Location = new Point(13, 13);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(481, 20);
            tbxEmail.TabIndex = 9;
            tbxEmail.TabStop = false;
            tbxEmail.Text = "Email address";
            tbxEmail.Click += tbxEmail_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(554, 718);
            Controls.Add(panel11);
            Controls.Add(label5);
            Controls.Add(pnlRole);
            Controls.Add(btnSignUp);
            Controls.Add(label7);
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
            Controls.Add(panel8);
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
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            pnlRole.ResumeLayout(false);
            pnlRole.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
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
        private ReaLTaiizor.Controls.HopeRadioButton rbtnMale;
        private ReaLTaiizor.Controls.HopeRadioButton rbtnNotSay;
        private Label label7;
        private ReaLTaiizor.Controls.Button btnSignUp;
        private PictureBox pbPrivacy1;
        private Panel panel8;
        private Panel panel7;
        private Panel panel5;
        private ReaLTaiizor.Controls.HopeRadioButton rbtnFemale;
        private Panel panel6;
        private Panel pnlRole;
        private ReaLTaiizor.Controls.HopeRadioButton rbtnPassenger;
        private Panel panel10;
        private ReaLTaiizor.Controls.HopeRadioButton rbtnDriver;
        private Panel panel12;
        private Label label5;
        private Panel panel11;
        private TextBox tbxEmail;
    }
}