﻿namespace MyCost.View
{
    partial class UserAuthenticationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAuthenticationForm));
            this.ShowRegisterPanelButton = new System.Windows.Forms.Button();
            this.ShowLoginPanelButton = new System.Windows.Forms.Button();
            this.AppLogoLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ForgotPasswordTextBox = new System.Windows.Forms.Label();
            this.AgreeCheckBox = new System.Windows.Forms.CheckBox();
            this.AgreeLicenseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowRegisterPanelButton
            // 
            this.ShowRegisterPanelButton.AutoSize = true;
            this.ShowRegisterPanelButton.BackColor = System.Drawing.Color.White;
            this.ShowRegisterPanelButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ShowRegisterPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowRegisterPanelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRegisterPanelButton.ForeColor = System.Drawing.Color.Black;
            this.ShowRegisterPanelButton.Location = new System.Drawing.Point(400, 106);
            this.ShowRegisterPanelButton.Name = "ShowRegisterPanelButton";
            this.ShowRegisterPanelButton.Size = new System.Drawing.Size(246, 36);
            this.ShowRegisterPanelButton.TabIndex = 0;
            this.ShowRegisterPanelButton.Text = "Register";
            this.ShowRegisterPanelButton.UseVisualStyleBackColor = false;
            this.ShowRegisterPanelButton.Click += new System.EventHandler(this.ShowRegisterPanelButtonClicked);
            // 
            // ShowLoginPanelButton
            // 
            this.ShowLoginPanelButton.AutoSize = true;
            this.ShowLoginPanelButton.BackColor = System.Drawing.Color.White;
            this.ShowLoginPanelButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ShowLoginPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLoginPanelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLoginPanelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowLoginPanelButton.Location = new System.Drawing.Point(146, 106);
            this.ShowLoginPanelButton.Name = "ShowLoginPanelButton";
            this.ShowLoginPanelButton.Size = new System.Drawing.Size(246, 36);
            this.ShowLoginPanelButton.TabIndex = 1;
            this.ShowLoginPanelButton.Text = "Log in";
            this.ShowLoginPanelButton.UseVisualStyleBackColor = false;
            this.ShowLoginPanelButton.Click += new System.EventHandler(this.ShowLoginPanelButoonClicked);
            // 
            // AppLogoLabel
            // 
            this.AppLogoLabel.AutoSize = true;
            this.AppLogoLabel.BackColor = System.Drawing.Color.White;
            this.AppLogoLabel.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLogoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AppLogoLabel.Location = new System.Drawing.Point(286, 9);
            this.AppLogoLabel.Name = "AppLogoLabel";
            this.AppLogoLabel.Size = new System.Drawing.Size(209, 54);
            this.AppLogoLabel.TabIndex = 3;
            this.AppLogoLabel.Text = "MYCOST";
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(324, 379);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(142, 36);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "Log in";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButtonClicked);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(146, 250);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(500, 27);
            this.ConfirmPasswordTextBox.TabIndex = 12;
            this.ConfirmPasswordTextBox.Text = "Confirm password";
            this.ConfirmPasswordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConfirmPasswordTextBoxClicked);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PasswordTextBox.Location = new System.Drawing.Point(146, 204);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(500, 27);
            this.PasswordTextBox.TabIndex = 11;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordTextboxClicked);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.White;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UsernameTextBox.Location = new System.Drawing.Point(146, 158);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(500, 27);
            this.UsernameTextBox.TabIndex = 10;
            this.UsernameTextBox.TabStop = false;
            this.UsernameTextBox.Text = "Username";
            this.UsernameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsernameTextBoxClicked);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(142, 74);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(105, 21);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.Text = "Label Status";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.AutoSize = true;
            this.RememberMeCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberMeCheckBox.Location = new System.Drawing.Point(146, 334);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(144, 25);
            this.RememberMeCheckBox.TabIndex = 15;
            this.RememberMeCheckBox.Text = "Remember me";
            this.RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmailTextBox.Location = new System.Drawing.Point(146, 298);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(500, 27);
            this.EmailTextBox.TabIndex = 16;
            this.EmailTextBox.TabStop = false;
            this.EmailTextBox.Text = "Email";
            this.EmailTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EmailTextBoxClicked);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.VersionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.Black;
            this.VersionLabel.Location = new System.Drawing.Point(341, 445);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(102, 17);
            this.VersionLabel.TabIndex = 17;
            this.VersionLabel.Text = "Version: 1.1.1.5";
            // 
            // ForgotPasswordTextBox
            // 
            this.ForgotPasswordTextBox.AutoSize = true;
            this.ForgotPasswordTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordTextBox.ForeColor = System.Drawing.Color.Red;
            this.ForgotPasswordTextBox.Location = new System.Drawing.Point(407, 245);
            this.ForgotPasswordTextBox.Name = "ForgotPasswordTextBox";
            this.ForgotPasswordTextBox.Size = new System.Drawing.Size(239, 21);
            this.ForgotPasswordTextBox.TabIndex = 18;
            this.ForgotPasswordTextBox.Text = "Forgot Password / Username?";
            this.ForgotPasswordTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ForgotPasswordTextBox.Click += new System.EventHandler(this.ForgotPasswordTextBoxClicked);
            // 
            // AgreeCheckBox
            // 
            this.AgreeCheckBox.AutoSize = true;
            this.AgreeCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgreeCheckBox.Location = new System.Drawing.Point(453, 334);
            this.AgreeCheckBox.Name = "AgreeCheckBox";
            this.AgreeCheckBox.Size = new System.Drawing.Size(137, 25);
            this.AgreeCheckBox.TabIndex = 19;
            this.AgreeCheckBox.Text = "I agree to the";
            this.AgreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AgreeLicenseLabel
            // 
            this.AgreeLicenseLabel.AutoSize = true;
            this.AgreeLicenseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgreeLicenseLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgreeLicenseLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AgreeLicenseLabel.Location = new System.Drawing.Point(585, 335);
            this.AgreeLicenseLabel.Name = "AgreeLicenseLabel";
            this.AgreeLicenseLabel.Size = new System.Drawing.Size(66, 21);
            this.AgreeLicenseLabel.TabIndex = 20;
            this.AgreeLicenseLabel.Text = "License";
            this.AgreeLicenseLabel.Click += new System.EventHandler(this.LicenseLabelClicked);
            // 
            // UserAuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 471);
            this.Controls.Add(this.AgreeLicenseLabel);
            this.Controls.Add(this.AgreeCheckBox);
            this.Controls.Add(this.ForgotPasswordTextBox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.RememberMeCheckBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.AppLogoLabel);
            this.Controls.Add(this.ShowLoginPanelButton);
            this.Controls.Add(this.ShowRegisterPanelButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserAuthenticationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCost - Login or Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThisFormClosing);
            this.Load += new System.EventHandler(this.ThisFormLoading);
            this.Shown += new System.EventHandler(this.ThisFormShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowRegisterPanelButton;
        private System.Windows.Forms.Button ShowLoginPanelButton;
        private System.Windows.Forms.Label AppLogoLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.CheckBox RememberMeCheckBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label ForgotPasswordTextBox;
        private System.Windows.Forms.CheckBox AgreeCheckBox;
        private System.Windows.Forms.Label AgreeLicenseLabel;
    }
}

