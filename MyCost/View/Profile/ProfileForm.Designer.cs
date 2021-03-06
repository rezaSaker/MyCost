﻿namespace MyCost.View
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ChangeUsernameLabel = new System.Windows.Forms.Label();
            this.NewUserNameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmUserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordForUsernameChangeTextBox = new System.Windows.Forms.TextBox();
            this.UpdateUsernameButton = new System.Windows.Forms.Button();
            this.UpdatePasswordButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.CurrentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReportIssueButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.AboutAppButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.MonthlyReportButton = new System.Windows.Forms.Button();
            this.AddNewDataButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ContactButton = new System.Windows.Forms.Button();
            this.VerifyEmailButton = new System.Windows.Forms.Button();
            this.EmailVerificationStatusLabel = new System.Windows.Forms.Label();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.PasswordForEmailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateEmailButton = new System.Windows.Forms.Button();
            this.NewEmailTextBox = new System.Windows.Forms.TextBox();
            this.VideoTutorialButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.Black;
            this.UserNameLabel.Location = new System.Drawing.Point(3, 12);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(96, 21);
            this.UserNameLabel.TabIndex = 46;
            this.UserNameLabel.Text = "Username: ";
            // 
            // ChangeUsernameLabel
            // 
            this.ChangeUsernameLabel.AutoSize = true;
            this.ChangeUsernameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeUsernameLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.ChangeUsernameLabel.Location = new System.Drawing.Point(4, 49);
            this.ChangeUsernameLabel.Name = "ChangeUsernameLabel";
            this.ChangeUsernameLabel.Size = new System.Drawing.Size(157, 21);
            this.ChangeUsernameLabel.TabIndex = 47;
            this.ChangeUsernameLabel.Text = "Change Username";
            // 
            // NewUserNameTextBox
            // 
            this.NewUserNameTextBox.BackColor = System.Drawing.Color.White;
            this.NewUserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewUserNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.NewUserNameTextBox.Location = new System.Drawing.Point(8, 80);
            this.NewUserNameTextBox.Name = "NewUserNameTextBox";
            this.NewUserNameTextBox.Size = new System.Drawing.Size(356, 27);
            this.NewUserNameTextBox.TabIndex = 48;
            this.NewUserNameTextBox.Text = "New Username";
            this.NewUserNameTextBox.Click += new System.EventHandler(this.UsernameTextBoxesClicked);
            // 
            // ConfirmUserNameTextBox
            // 
            this.ConfirmUserNameTextBox.BackColor = System.Drawing.Color.White;
            this.ConfirmUserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmUserNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmUserNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.ConfirmUserNameTextBox.Location = new System.Drawing.Point(8, 113);
            this.ConfirmUserNameTextBox.Name = "ConfirmUserNameTextBox";
            this.ConfirmUserNameTextBox.Size = new System.Drawing.Size(356, 27);
            this.ConfirmUserNameTextBox.TabIndex = 49;
            this.ConfirmUserNameTextBox.Text = "Confirm New Username";
            this.ConfirmUserNameTextBox.Click += new System.EventHandler(this.UsernameTextBoxesClicked);
            // 
            // PasswordForUsernameChangeTextBox
            // 
            this.PasswordForUsernameChangeTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordForUsernameChangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordForUsernameChangeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordForUsernameChangeTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordForUsernameChangeTextBox.Location = new System.Drawing.Point(8, 144);
            this.PasswordForUsernameChangeTextBox.Name = "PasswordForUsernameChangeTextBox";
            this.PasswordForUsernameChangeTextBox.Size = new System.Drawing.Size(356, 27);
            this.PasswordForUsernameChangeTextBox.TabIndex = 50;
            this.PasswordForUsernameChangeTextBox.Text = "Password";
            this.PasswordForUsernameChangeTextBox.Click += new System.EventHandler(this.PasswordTextBoxesClicked);
            // 
            // UpdateUsernameButton
            // 
            this.UpdateUsernameButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateUsernameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.UpdateUsernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUsernameButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUsernameButton.ForeColor = System.Drawing.Color.White;
            this.UpdateUsernameButton.Location = new System.Drawing.Point(7, 185);
            this.UpdateUsernameButton.Name = "UpdateUsernameButton";
            this.UpdateUsernameButton.Size = new System.Drawing.Size(357, 35);
            this.UpdateUsernameButton.TabIndex = 51;
            this.UpdateUsernameButton.Text = "Update Username";
            this.UpdateUsernameButton.UseVisualStyleBackColor = false;
            this.UpdateUsernameButton.Click += new System.EventHandler(this.SubmitNewUsernameButtonClicked);
            // 
            // UpdatePasswordButton
            // 
            this.UpdatePasswordButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdatePasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.UpdatePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePasswordButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePasswordButton.ForeColor = System.Drawing.Color.White;
            this.UpdatePasswordButton.Location = new System.Drawing.Point(447, 185);
            this.UpdatePasswordButton.Name = "UpdatePasswordButton";
            this.UpdatePasswordButton.Size = new System.Drawing.Size(356, 35);
            this.UpdatePasswordButton.TabIndex = 56;
            this.UpdatePasswordButton.Text = "Update Password";
            this.UpdatePasswordButton.UseVisualStyleBackColor = false;
            this.UpdatePasswordButton.Click += new System.EventHandler(this.SubmitNewPasswordButtonClicked);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(447, 111);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(356, 27);
            this.ConfirmPasswordTextBox.TabIndex = 55;
            this.ConfirmPasswordTextBox.Text = "Confirm New Password";
            this.ConfirmPasswordTextBox.Click += new System.EventHandler(this.PasswordTextBoxesClicked);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.NewPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.NewPasswordTextBox.Location = new System.Drawing.Point(447, 80);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(356, 27);
            this.NewPasswordTextBox.TabIndex = 54;
            this.NewPasswordTextBox.Text = "New Password";
            this.NewPasswordTextBox.Click += new System.EventHandler(this.PasswordTextBoxesClicked);
            // 
            // CurrentPasswordTextBox
            // 
            this.CurrentPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.CurrentPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.CurrentPasswordTextBox.Location = new System.Drawing.Point(447, 144);
            this.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox";
            this.CurrentPasswordTextBox.Size = new System.Drawing.Size(356, 27);
            this.CurrentPasswordTextBox.TabIndex = 53;
            this.CurrentPasswordTextBox.Text = "Current Password";
            this.CurrentPasswordTextBox.Click += new System.EventHandler(this.PasswordTextBoxesClicked);
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(443, 49);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(151, 21);
            this.ChangePasswordLabel.TabIndex = 52;
            this.ChangePasswordLabel.Text = "Change Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(403, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 198);
            this.label3.TabIndex = 57;
            this.label3.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(800, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "_________________________________________________________________________________" +
    "_______";
            // 
            // ReportIssueButton
            // 
            this.ReportIssueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportIssueButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReportIssueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportIssueButton.FlatAppearance.BorderSize = 0;
            this.ReportIssueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.ReportIssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportIssueButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportIssueButton.ForeColor = System.Drawing.Color.White;
            this.ReportIssueButton.Location = new System.Drawing.Point(625, 248);
            this.ReportIssueButton.Name = "ReportIssueButton";
            this.ReportIssueButton.Size = new System.Drawing.Size(178, 35);
            this.ReportIssueButton.TabIndex = 64;
            this.ReportIssueButton.Text = "Report Issues";
            this.ReportIssueButton.UseVisualStyleBackColor = false;
            this.ReportIssueButton.Click += new System.EventHandler(this.ReportIssueButtonClicked);
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.ForeColor = System.Drawing.Color.White;
            this.HelpButton.Location = new System.Drawing.Point(447, 249);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(172, 34);
            this.HelpButton.TabIndex = 65;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButtonClicked);
            // 
            // AboutAppButton
            // 
            this.AboutAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutAppButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AboutAppButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutAppButton.FlatAppearance.BorderSize = 0;
            this.AboutAppButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.AboutAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutAppButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutAppButton.ForeColor = System.Drawing.Color.White;
            this.AboutAppButton.Location = new System.Drawing.Point(447, 289);
            this.AboutAppButton.Name = "AboutAppButton";
            this.AboutAppButton.Size = new System.Drawing.Size(172, 36);
            this.AboutAppButton.TabIndex = 66;
            this.AboutAppButton.Text = "About ";
            this.AboutAppButton.UseVisualStyleBackColor = false;
            this.AboutAppButton.Click += new System.EventHandler(this.AboutAppButtonClicked);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(710, 9);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(117, 33);
            this.LogOutButton.TabIndex = 73;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.White;
            this.ProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ProfileButton.Location = new System.Drawing.Point(588, 8);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(118, 33);
            this.ProfileButton.TabIndex = 72;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = false;
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.StatisticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StatisticsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.StatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticsButton.ForeColor = System.Drawing.Color.White;
            this.StatisticsButton.Location = new System.Drawing.Point(463, 8);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(121, 33);
            this.StatisticsButton.TabIndex = 71;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.UseVisualStyleBackColor = false;
            this.StatisticsButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            // 
            // MonthlyReportButton
            // 
            this.MonthlyReportButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MonthlyReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonthlyReportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.MonthlyReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthlyReportButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyReportButton.ForeColor = System.Drawing.Color.White;
            this.MonthlyReportButton.Location = new System.Drawing.Point(307, 8);
            this.MonthlyReportButton.Name = "MonthlyReportButton";
            this.MonthlyReportButton.Size = new System.Drawing.Size(152, 33);
            this.MonthlyReportButton.TabIndex = 70;
            this.MonthlyReportButton.Text = "Monthly Report";
            this.MonthlyReportButton.UseVisualStyleBackColor = false;
            this.MonthlyReportButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            // 
            // AddNewDataButton
            // 
            this.AddNewDataButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddNewDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNewDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.AddNewDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewDataButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewDataButton.ForeColor = System.Drawing.Color.White;
            this.AddNewDataButton.Location = new System.Drawing.Point(188, 8);
            this.AddNewDataButton.Name = "AddNewDataButton";
            this.AddNewDataButton.Size = new System.Drawing.Size(115, 33);
            this.AddNewDataButton.TabIndex = 69;
            this.AddNewDataButton.Text = "Add New";
            this.AddNewDataButton.UseVisualStyleBackColor = false;
            this.AddNewDataButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(67, 8);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(117, 33);
            this.HomeButton.TabIndex = 68;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.MenuButtonsClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ContactButton);
            this.panel1.Controls.Add(this.VerifyEmailButton);
            this.panel1.Controls.Add(this.EmailVerificationStatusLabel);
            this.panel1.Controls.Add(this.DeleteAccountButton);
            this.panel1.Controls.Add(this.PasswordForEmailTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UpdateEmailButton);
            this.panel1.Controls.Add(this.NewEmailTextBox);
            this.panel1.Controls.Add(this.VideoTutorialButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.UpdatePasswordButton);
            this.panel1.Controls.Add(this.ConfirmPasswordTextBox);
            this.panel1.Controls.Add(this.NewPasswordTextBox);
            this.panel1.Controls.Add(this.CurrentPasswordTextBox);
            this.panel1.Controls.Add(this.ChangePasswordLabel);
            this.panel1.Controls.Add(this.AboutAppButton);
            this.panel1.Controls.Add(this.UpdateUsernameButton);
            this.panel1.Controls.Add(this.ReportIssueButton);
            this.panel1.Controls.Add(this.HelpButton);
            this.panel1.Controls.Add(this.PasswordForUsernameChangeTextBox);
            this.panel1.Controls.Add(this.ConfirmUserNameTextBox);
            this.panel1.Controls.Add(this.NewUserNameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ChangeUsernameLabel);
            this.panel1.Controls.Add(this.UserNameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 418);
            this.panel1.TabIndex = 74;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(625, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 31);
            this.button2.TabIndex = 85;
            this.button2.Text = "View License";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContactButton
            // 
            this.ContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactButton.FlatAppearance.BorderSize = 0;
            this.ContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.ContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactButton.ForeColor = System.Drawing.Color.White;
            this.ContactButton.Location = new System.Drawing.Point(447, 331);
            this.ContactButton.Name = "ContactButton";
            this.ContactButton.Size = new System.Drawing.Size(172, 31);
            this.ContactButton.TabIndex = 84;
            this.ContactButton.Text = "Contact";
            this.ContactButton.UseVisualStyleBackColor = false;
            this.ContactButton.Click += new System.EventHandler(this.ContactButton_Click);
            // 
            // VerifyEmailButton
            // 
            this.VerifyEmailButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.VerifyEmailButton.FlatAppearance.BorderSize = 0;
            this.VerifyEmailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.VerifyEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyEmailButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyEmailButton.ForeColor = System.Drawing.Color.White;
            this.VerifyEmailButton.Location = new System.Drawing.Point(551, 8);
            this.VerifyEmailButton.Name = "VerifyEmailButton";
            this.VerifyEmailButton.Size = new System.Drawing.Size(125, 28);
            this.VerifyEmailButton.TabIndex = 83;
            this.VerifyEmailButton.Text = "Verify Email";
            this.VerifyEmailButton.UseVisualStyleBackColor = false;
            this.VerifyEmailButton.Click += new System.EventHandler(this.VerifyEmailButtonClicked);
            // 
            // EmailVerificationStatusLabel
            // 
            this.EmailVerificationStatusLabel.AutoSize = true;
            this.EmailVerificationStatusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailVerificationStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailVerificationStatusLabel.Location = new System.Drawing.Point(301, 12);
            this.EmailVerificationStatusLabel.Name = "EmailVerificationStatusLabel";
            this.EmailVerificationStatusLabel.Size = new System.Drawing.Size(241, 21);
            this.EmailVerificationStatusLabel.TabIndex = 82;
            this.EmailVerificationStatusLabel.Text = "Email verification Status Label";
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.BackColor = System.Drawing.Color.Tomato;
            this.DeleteAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.DeleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAccountButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccountButton.ForeColor = System.Drawing.Color.White;
            this.DeleteAccountButton.Location = new System.Drawing.Point(447, 368);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(356, 35);
            this.DeleteAccountButton.TabIndex = 81;
            this.DeleteAccountButton.Text = "Permanently Delete My Account";
            this.DeleteAccountButton.UseVisualStyleBackColor = false;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteProfileButtonClicked);
            // 
            // PasswordForEmailTextBox
            // 
            this.PasswordForEmailTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordForEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordForEmailTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordForEmailTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordForEmailTextBox.Location = new System.Drawing.Point(8, 326);
            this.PasswordForEmailTextBox.Name = "PasswordForEmailTextBox";
            this.PasswordForEmailTextBox.Size = new System.Drawing.Size(356, 27);
            this.PasswordForEmailTextBox.TabIndex = 80;
            this.PasswordForEmailTextBox.Text = "Passowrd";
            this.PasswordForEmailTextBox.Click += new System.EventHandler(this.PasswordTextBoxesClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(403, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 198);
            this.label5.TabIndex = 79;
            this.label5.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // UpdateEmailButton
            // 
            this.UpdateEmailButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateEmailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.UpdateEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEmailButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEmailButton.ForeColor = System.Drawing.Color.White;
            this.UpdateEmailButton.Location = new System.Drawing.Point(7, 368);
            this.UpdateEmailButton.Name = "UpdateEmailButton";
            this.UpdateEmailButton.Size = new System.Drawing.Size(357, 35);
            this.UpdateEmailButton.TabIndex = 77;
            this.UpdateEmailButton.Text = "Update Email";
            this.UpdateEmailButton.UseVisualStyleBackColor = false;
            this.UpdateEmailButton.Click += new System.EventHandler(this.UpdateEmailButtonClicked);
            // 
            // NewEmailTextBox
            // 
            this.NewEmailTextBox.BackColor = System.Drawing.Color.White;
            this.NewEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewEmailTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEmailTextBox.ForeColor = System.Drawing.Color.Gray;
            this.NewEmailTextBox.Location = new System.Drawing.Point(8, 293);
            this.NewEmailTextBox.Name = "NewEmailTextBox";
            this.NewEmailTextBox.Size = new System.Drawing.Size(356, 27);
            this.NewEmailTextBox.TabIndex = 76;
            this.NewEmailTextBox.Text = "New Email";
            this.NewEmailTextBox.Click += new System.EventHandler(this.UsernameTextBoxesClicked);
            // 
            // VideoTutorialButton
            // 
            this.VideoTutorialButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoTutorialButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.VideoTutorialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VideoTutorialButton.FlatAppearance.BorderSize = 0;
            this.VideoTutorialButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.VideoTutorialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VideoTutorialButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoTutorialButton.ForeColor = System.Drawing.Color.White;
            this.VideoTutorialButton.Location = new System.Drawing.Point(625, 290);
            this.VideoTutorialButton.Name = "VideoTutorialButton";
            this.VideoTutorialButton.Size = new System.Drawing.Size(178, 35);
            this.VideoTutorialButton.TabIndex = 75;
            this.VideoTutorialButton.Text = "Video Tutorial";
            this.VideoTutorialButton.UseVisualStyleBackColor = false;
            this.VideoTutorialButton.Click += new System.EventHandler(this.VideoTutorialButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(3, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "Change Email";
            // 
            // LogoButton
            // 
            this.LogoButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoButton.BackgroundImage = global::MyCost.Properties.Resources.AppIcon;
            this.LogoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.LogoButton.FlatAppearance.BorderSize = 0;
            this.LogoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoButton.ForeColor = System.Drawing.Color.White;
            this.LogoButton.Location = new System.Drawing.Point(12, 8);
            this.LogoButton.Name = "LogoButton";
            this.LogoButton.Size = new System.Drawing.Size(49, 33);
            this.LogoButton.TabIndex = 83;
            this.LogoButton.UseVisualStyleBackColor = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 491);
            this.Controls.Add(this.LogoButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.StatisticsButton);
            this.Controls.Add(this.MonthlyReportButton);
            this.Controls.Add(this.AddNewDataButton);
            this.Controls.Add(this.HomeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyCost - Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThisFormClosing);
            this.Load += new System.EventHandler(this.ThisFormLoading);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label ChangeUsernameLabel;
        private System.Windows.Forms.TextBox NewUserNameTextBox;
        private System.Windows.Forms.TextBox ConfirmUserNameTextBox;
        private System.Windows.Forms.TextBox PasswordForUsernameChangeTextBox;
        private System.Windows.Forms.Button UpdateUsernameButton;
        private System.Windows.Forms.Button UpdatePasswordButton;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.TextBox CurrentPasswordTextBox;
        private System.Windows.Forms.Label ChangePasswordLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReportIssueButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button AboutAppButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button StatisticsButton;
        private System.Windows.Forms.Button MonthlyReportButton;
        private System.Windows.Forms.Button AddNewDataButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button VideoTutorialButton;
        private System.Windows.Forms.Button UpdateEmailButton;
        private System.Windows.Forms.TextBox NewEmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordForEmailTextBox;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.Label EmailVerificationStatusLabel;
        private System.Windows.Forms.Button LogoButton;
        private System.Windows.Forms.Button VerifyEmailButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ContactButton;
    }
}