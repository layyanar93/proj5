using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace Project5
{
    public partial class _Default : Page
    {

        void GenerateImage()
        {
            imageVerServiceReference.ServiceClient fromService = new imageVerServiceReference.ServiceClient();
            string length = "6";
            Session["userLength"] = length;
            string myStr = fromService.GetVerifierString(length);
            Session["generatedString"] = myStr;
            showImageButton.Text = "Show another image";
            Image1.Visible = true;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "~/imageProcess.aspx";
            HttpCookie myCookies = Request.Cookies["recipieApp"];
            if (((myCookies == null) || (myCookies["Name"] == "")) != true && usernameTextBox.Text == "")
            {
                usernameTextBox.Text = myCookies["Name"];
                rememberChk.Checked = true;
            }
            if (showImageButton.Text != "Show another image")
            {
                GenerateImage();
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            if (username == "" || password == "")
            {
                loginLabel.Text = "Please enter a username and password";
                return;
            }
            loginServiceReference.Service1Client myClient = new loginServiceReference.Service1Client();
            string resultText = myClient.userLogin(username, password);
            loginLabel.Text = resultText;
            HttpCookie myCookies = Request.Cookies["recipieApp"];
            if (rememberChk.Checked == true && loginLabel.Text == "Authenticated")
            {
                myCookies = new HttpCookie("recipieApp");
                myCookies["Name"] = usernameTextBox.Text;
                myCookies.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(myCookies);
            }
            else if (rememberChk.Checked == false && myCookies["Name"] != "" && loginLabel.Text == "Authenticated")
            {
                myCookies = new HttpCookie("recipieApp");
                myCookies["Name"] = "";
                Response.Cookies.Add(myCookies);
            }
        }

        protected void createUserButton_Click(object sender, EventArgs e)
        {
            string newUsername = newUserTextBox.Text;
            string newPassword = newPassTextBox.Text;
            loginServiceReference.Service1Client myClient = new loginServiceReference.Service1Client();
            string createUserResult = myClient.createUser(newUsername, newPassword);
            createUserLabel.Text = createUserResult;
        }

        protected void showImageButton_Click(object sender, EventArgs e)
        {
            GenerateImage();
        }

        protected void buttonSubmitImage_Click(object sender, EventArgs e)
        {
            if (Session["generatedString"].Equals(TextBox1.Text))
            {
                imageVerLabel.Text = "The code you entered is correct.";
            }
            else
            {
                imageVerLabel.Text = "Incorrect string entered";
                GenerateImage();
            }
        }
        protected void chkRemember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}