﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using MyCost.Common;
using MyCost.ServerHandling;

namespace MyCost.View
{
    public partial class SettingsForm : Form
    {
        private bool _quitAppOnFormClosing;

        public SettingsForm()
        {
            InitializeComponent();

            _quitAppOnFormClosing = true;
        }

        private void ThisFormLoading(object sender, EventArgs e)
        {
            userNameLaabel.Text = "username: " + StaticStorage.Username;
        }

        private void UsernameTextBoxesClicked(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.ForeColor != Color.Black)
            {
                //remove the placeholder
                tb.ForeColor = Color.Black;
                tb.Text = "";
            }
        }

        private void UserNameTextBoxesTextChanged(object sender, EventArgs e)
        {
            if (currentUserNameTextBox.ForeColor == Color.Black
                && currentUserNameTextBox.Text != ""
                && newUserNameTextBox.ForeColor == Color.Black
                && newUserNameTextBox.Text != ""
                && confirmUserNameTextBox.ForeColor == Color.Black
                && confirmUserNameTextBox.Text != "")
            {
                submitUserNameButton.Enabled = true;
            }
            else
            {
                submitUserNameButton.Enabled = false;
            }
        }

        private void PasswordTextBoxesClicked(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if(tb.ForeColor != Color.Black)
            {
                tb.ForeColor = Color.Black;
                tb.Text = "";
            }
        }

        private void PasswordTextBoxesTextChanged(object sender, EventArgs e)
        {
            if (currentPasswordTextBox.ForeColor == Color.Black
               && currentPasswordTextBox.Text != ""
               && newPasswordTextBox.ForeColor == Color.Black
               && newPasswordTextBox.Text != ""
               && confirmPasswordTextBox.ForeColor == Color.Black
               && confirmPasswordTextBox.Text != "")
            {
                submitPasswordButton.Enabled = true;
            }
            else
            {
                submitPasswordButton.Enabled = false;
            }
        }

        private void SubmitNewUsernameButtonClicked(object sender, EventArgs e)
        {
            if (currentUserNameTextBox.Text != StaticStorage.Username)
            {
                MessageBox.Show("Current username is incorrect");
            }
            else if (newUserNameTextBox.Text != confirmUserNameTextBox.Text)
            {
                MessageBox.Show("Username doesn't match");
            }
            else //all fields are correct
            {
                string result = ServerHandler.UpdateUsername(newUserNameTextBox.Text);

                if (result == "SUCCESS")
                {
                    //log out user from the current session
                    LogOut();
                }
                else
                {
                    //if the update doesn't succeed, the error message is returned
                    MessageBox.Show(result);
                }
            }
        }

        private void SubmitNewPasswordButtonClicked(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Password doesn't match!");
            }
            else //all fields are correct
            {
                string result = ServerHandler.UpdatePassword(currentPasswordTextBox.Text, newPasswordTextBox.Text);

                if (result == "SUCCESS")
                {
                    //log out user from the current session
                    LogOut();
                }
                else
                {
                    //if the update doesn't succeed, error message is returned
                    MessageBox.Show(result);
                }
            }
        }

        private void MenuButtonsMouseHovering(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.ForestGreen;
            button.ForeColor = Color.White;
        }

        private void MenuButtonsMouseLeaving(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.White;
            button.ForeColor = Color.ForestGreen;
        }

        private void MenuButtonsClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "homeButton")
            {
                OpenNewForm(new MainForm());
            }
            else if (button.Name == "monthlyReportButton")
            {
                OpenNewForm(new MonthlyReportForm());
            }
            else if (button.Name == "statisticsButton")
            {
                OpenNewForm(new StatisticsForm());
            }
            else if (button.Name == "addNewDataButton")
            {
                OpenNewForm(new AddNewDataForm());
            }
            else if (button.Name == "logOutButton")
            {
                LogOut();
            }
        }

        new private void HelpButtonClicked(object sender, EventArgs e)
        {
            try
            {
                Process.Start(StaticStorage.HelpSourcePath);
            }
            catch
            {
                MessageBox.Show("Could not open default browser!");
            }
        }

        private void ReportIssueButtonClicked(object sender, EventArgs e)
        {
            try
            {
                Process.Start(StaticStorage.ReportAppSourcePath);
            }
            catch
            {
                MessageBox.Show("Could not open the default browser!");
            }
        }

        private void ViewSourceButtonClicked(object sender, EventArgs e)
        {
            try
            {
                Process.Start(StaticStorage.SourcePath);
            }
            catch
            {
                MessageBox.Show("Could not open the default browser!");
            }
        }

        private void ThisFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_quitAppOnFormClosing)
            {
                Application.Exit();
            }
        }

        private void OpenNewForm(Form form)
        {
            form.Location = this.Location;
            form.Show();

            _quitAppOnFormClosing = false;
            this.Close();
        }

        private void LogOut()
        {
            //reset auto login properties
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Save();

            UserAuthenticationForm form = new UserAuthenticationForm();
            form.Show();

            _quitAppOnFormClosing = false;
            this.Close();
        }
    }
}