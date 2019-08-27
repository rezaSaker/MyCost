﻿using System;
using System.Text;
using System.Collections;
using System.Net;
using System.Threading;

namespace MyCost.Common.WebHandler
{
    class WebHandler
    {
        private string _webResponse;

        public event EventHandler WebRequestSuccessEventHandler;
        public event EventHandler WebRequestFailedEventHandler;
        public event EventHandler GetActivationCodeSuccessEventHandler;
        public event EventHandler GetActivationCodeFailedEventHandler;

        public string Response
        {
            get => _webResponse;
            set => _webResponse = value;
        }

        public void AuthenticateUser(string username, string password)
        {
            Thread thread = new Thread(() => WebRequestToAuthenticateUser(username, password));
            thread.Start();
        }

        public void WebRequestToAuthenticateUser(string username, string password)
        {
            WebClient www = new WebClient();

            System.Collections.Specialized.NameValueCollection queryData;
            queryData = new System.Collections.Specialized.NameValueCollection();

            queryData.Add("username", username);
            queryData.Add("password", password);

            try
            {
                byte[] resultBytes = www.UploadValues(GlobalSpace.ServerAddress + "userAuthentication.php", "POST", queryData);
                string resultData  = Encoding.UTF8.GetString(resultBytes);
                _webResponse = resultData;

                OnAuthenticationSuccess();
            }
            catch
            {
                _webResponse = "Server connection error";

                OnAuthenticationFailed();
            }
        }

        private void OnAuthenticationSuccess()
        {
            WebRequestSuccessEventHandler?.Invoke(this, null);
        }

        private void OnAuthenticationFailed()
        {
            WebRequestFailedEventHandler?.Invoke(this, null);
        }

        public void RegisterNewUser(string username, string password, string activationCode)
        {
            Thread thread = new Thread(() => WebRequestToRegisterUser(username, password, activationCode));
            thread.Start();
        }

        private void WebRequestToRegisterUser(string username, string password, string activationCode)
        {
            WebClient www = new WebClient();

            System.Collections.Specialized.NameValueCollection queryData;
            queryData = new System.Collections.Specialized.NameValueCollection();

            queryData.Add("username", username);
            queryData.Add("password", password);
            queryData.Add("activationCode", activationCode);
            try
            {
                byte[] resultBytes = www.UploadValues(GlobalSpace.ServerAddress + "registerNewUser.php", "POST", queryData);
                string resultData = Encoding.UTF8.GetString(resultBytes);
                _webResponse = resultData;

                OnRegisterSuccess();
            }
            catch
            {
                _webResponse = "Server connection error";

                OnRegisterFailed();
            }
        }

        private void OnRegisterSuccess()
        {
            WebRequestSuccessEventHandler?.Invoke(this, null);
        }

        private void OnRegisterFailed()
        {
            WebRequestFailedEventHandler?.Invoke(this, null);
        }

        public void RetrieveDailyInfo()
        {
            Thread thread = new Thread(() => WebRequestToRetrieveDailyInfo());
            thread.Start();
        }    

        private void WebRequestToRetrieveDailyInfo()
        {
            WebClient www = new WebClient();

            System.Collections.Specialized.NameValueCollection queryData;
            queryData = new System.Collections.Specialized.NameValueCollection();

            queryData.Add("token", GlobalSpace.AccessToken);
            queryData.Add("userid", GlobalSpace.UserID.ToString());

            try
            {
                byte[] resultBytes = www.UploadValues(GlobalSpace.ServerAddress + "getDailyInfo.php", "POST", queryData);
                string resultData = Encoding.UTF8.GetString(resultBytes);
                _webResponse = resultData;

                OnRetrieveDailyInfoSuccess();
            }
            catch
            {
                _webResponse = "Server connection error";

                OnRetrieveDailyInfoFailed();
            }
        }

        private void OnRetrieveDailyInfoSuccess()
        {
            WebRequestSuccessEventHandler?.Invoke(this, null);
        }

        private void OnRetrieveDailyInfoFailed()
        {
            WebRequestFailedEventHandler?.Invoke(this, null);
        }

        public void RetrieveCategories()
        {
            Thread thread = new Thread(() => WebRequestToRetrieveCategories());
            thread.Start();
        }

        private void WebRequestToRetrieveCategories()
        {
            WebClient www = new WebClient();

            System.Collections.Specialized.NameValueCollection queryData;
            queryData = new System.Collections.Specialized.NameValueCollection();

            queryData.Add("token", GlobalSpace.AccessToken);
            queryData.Add("userid", GlobalSpace.UserID.ToString());

            try
            {
                byte[] resultBytes = www.UploadValues(GlobalSpace.ServerAddress + "getCategories.php", "POST", queryData);
                string resultData = Encoding.UTF8.GetString(resultBytes);
                _webResponse = resultData;

                OnRetrieveCategoriesSuccess();
            }
            catch
            {
                _webResponse = "Server connection error";

                OnRetrieveCategoriesFailed();
            }
        }

        private void OnRetrieveCategoriesSuccess()
        {
            WebRequestSuccessEventHandler?.Invoke(this, null);
        }

        private void OnRetrieveCategoriesFailed()
        {
            WebRequestFailedEventHandler?.Invoke(this, null);
        }

        public static string SaveDailyInfo(DailyInfo daily)
        {
            WebClient www = new WebClient();

            System.Collections.Specialized.NameValueCollection queryData;
            queryData = new System.Collections.Specialized.NameValueCollection();

            string expenseReasons = "";
            string expenseAmounts = "";
            string expenseCategories = "";
            string expenseComments = "";
            string earningSources = "";
            string earningAmounts = "";
            string earningCategories = "";
            string earningComments = "";

            bool addSplitChar = false;

            //adds splitting characters between expense properties so
            //that we can split the rows when retrieving from db
            foreach (ExpenseInfo expense in daily.ExpenseList)
            {
                if (addSplitChar)
                {
                    expenseReasons += "~";
                    expenseAmounts += "~";
                    expenseCategories += "~";
                    expenseComments += "~";
                }
                else
                {
                    addSplitChar = true;
                }

                expenseReasons += expense.Reason;
                expenseAmounts += expense.Amount.ToString();
                expenseCategories += expense.Category;
                expenseComments += expense.Comment;
            }

            addSplitChar = false;

            //adds splitting characters between expense properties so
            //that we can split the rows when retrieving from db
            foreach (EarningInfo earning in daily.EarningList)
            {
                if (addSplitChar)
                {
                    earningSources += "~";
                    earningAmounts += "~";
                    earningCategories += "~";
                    earningComments += "~";
                }
                else
                {
                    addSplitChar = true;
                }

                earningSources += earning.Source;
                earningAmounts += earning.Amount.ToString();
                earningCategories += earning.Category;
                earningComments += earning.Comment;
            }

            queryData.Add("token", GlobalSpace.AccessToken);
            queryData.Add("userid", GlobalSpace.UserID.ToString());
            queryData.Add("note", StringCypher.Encrypt(daily.Note, GlobalSpace.CypherKey));
            queryData.Add("day", StringCypher.Encrypt(daily.Day.ToString(), GlobalSpace.CypherKey));
            queryData.Add("month", StringCypher.Encrypt(daily.Month.ToString(), GlobalSpace.CypherKey));
            queryData.Add("year", StringCypher.Encrypt(daily.Year.ToString(), GlobalSpace.CypherKey));
            queryData.Add("expenseReasons", StringCypher.Encrypt(expenseReasons, GlobalSpace.CypherKey));
            queryData.Add("expenseAmounts", StringCypher.Encrypt(expenseAmounts, GlobalSpace.CypherKey));
            queryData.Add("expenseCategories", StringCypher.Encrypt(expenseCategories, GlobalSpace.CypherKey));
            queryData.Add("expenseComments", StringCypher.Encrypt(expenseComments, GlobalSpace.CypherKey));
            queryData.Add("earningSources", StringCypher.Encrypt(earningSources, GlobalSpace.CypherKey));
            queryData.Add("earningAmounts", StringCypher.Encrypt(earningAmounts, GlobalSpace.CypherKey));
            queryData.Add("earningCategories", StringCypher.Encrypt(earningCategories, GlobalSpace.CypherKey));
            queryData.Add("earningComments", StringCypher.Encrypt(earningComments, GlobalSpace.CypherKey));
            queryData.Add("totalExpense", StringCypher.Encrypt(daily.TotalExpense.ToString(), GlobalSpace.CypherKey));
            queryData.Add("totalEarning", StringCypher.Encrypt(daily.TotalEarning.ToString(), GlobalSpace.CypherKey));

            //try
            //{
                byte[] resultBytes = www.UploadValues(GlobalSpace.ServerAddress + "saveDailyInfo.php", "POST", queryData);
                string resultData = Encoding.UTF8.GetString(resultBytes);

                return resultData;      
            //}
            //catch
            //{
            //    return "Server connection error";
            //}
        }

        public static string SaveCategory(string categoryNames, string categoryType)
        {
            WebClient www = new WebClient();

            System.Collections.Specialized.NameValueCollection queryData;
            queryData = new System.Collections.Specialized.NameValueCollection();

            queryData.Add("token", GlobalSpace.AccessToken);
            queryData.Add("userid", GlobalSpace.UserID.ToString());
            queryData.Add("categoryNames", categoryNames);
            queryData.Add("categoryType", categoryType);

            try
            {
                byte[] resultBytes = www.UploadValues(GlobalSpace.ServerAddress + "saveCategories.php", "POST", queryData);
                string resultData = Encoding.UTF8.GetString(resultBytes);

                return resultData;
            }
            catch
            {
                return "Server connection error";
            }
        }

        public static string DeleteDailyInfo(int day, int month, int year)
        {
            WebClient www = new WebClient();

            System.Collections.Specialized.NameValueCollection queryData;
            queryData = new System.Collections.Specialized.NameValueCollection();

            queryData.Add("token", GlobalSpace.AccessToken);
            queryData.Add("userid", GlobalSpace.UserID.ToString());
            queryData.Add("day", day.ToString());
            queryData.Add("month", month.ToString());
            queryData.Add("year", year.ToString());

            try
            {
                byte[] resultBytes = www.UploadValues(GlobalSpace.ServerAddress + "deleteDailyInfo.php", "POST", queryData);
                string resultData = Encoding.UTF8.GetString(resultBytes);

                return resultData;
            }
            catch
            {
                return "Server connection error";
            }
        }

        public static string UpdateUsername(string newUsername, string password)
        {
            WebClient www = new WebClient();

            System.Collections.Specialized.NameValueCollection queryData;
            queryData = new System.Collections.Specialized.NameValueCollection();

            queryData.Add("token", GlobalSpace.AccessToken);
            queryData.Add("userid", GlobalSpace.UserID.ToString());
            queryData.Add("newUsername", newUsername);
            queryData.Add("currentUsername", GlobalSpace.Username);
            queryData.Add("password", password);

            try
            {
                byte[] resultBytes = www.UploadValues(GlobalSpace.ServerAddress + "updateUsername.php", "POST", queryData);
                string resultData = Encoding.UTF8.GetString(resultBytes);

                return resultData;
            }
            catch
            {
                return "Server connection error";
            }
        }

        public static string UpdatePassword(string currentPass, string newPass)
        {
            WebClient www = new WebClient();

            System.Collections.Specialized.NameValueCollection queryData;
            queryData = new System.Collections.Specialized.NameValueCollection();

            queryData.Add("token", GlobalSpace.AccessToken);
            queryData.Add("userid", GlobalSpace.UserID.ToString());
            queryData.Add("username", GlobalSpace.Username);
            queryData.Add("currentPassword", currentPass);
            queryData.Add("newPassword", newPass);

            try
            {
                byte[] resultBytes = www.UploadValues(GlobalSpace.ServerAddress + "updatePassword.php", "POST", queryData);
                string resultData = Encoding.UTF8.GetString(resultBytes);

                return resultData;
            }
            catch
            {
                return "Server connection error";
            }
        }

        public void GetActivationCode()
        {
            WebClient www = new WebClient();

            System.Collections.Specialized.NameValueCollection queryData;
            queryData = new System.Collections.Specialized.NameValueCollection();

            try
            {
                byte[] resultBytes = www.UploadValues(GlobalSpace.ServerAddress + "generateActivationCode.php", "POST", queryData);
                string resultData = Encoding.UTF8.GetString(resultBytes);
                _webResponse = resultData;

                if(resultData != "Server connection error")
                {
                    OnGetActivationCodeSuccessful();                   
                }
                else
                {
                    OnGetActivationCodeFailed();
                }               
            }
            catch
            {
                _webResponse = "Server connection error";

                OnGetActivationCodeFailed();
            }
        }

        private void OnGetActivationCodeSuccessful()
        {
            GetActivationCodeSuccessEventHandler?.Invoke(this, null);
        }

        private void OnGetActivationCodeFailed()
        {
            GetActivationCodeFailedEventHandler?.Invoke(this, null);
        }
    }
}
