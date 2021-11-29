using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    public partial class LoginOrSignUpPage : System.Web.UI.Page
    {
        void GenerateImage()
        {
            imageVerServiceReference.ServiceClient fromService = new imageVerServiceReference.ServiceClient();
            int anwser = fromService.RandomNumber();
            Session["generatedAnwser"] = anwser;
            showImageButton.Text = "Show another image";
            Image1.Visible = true;
            //showImageButton.Text = ((int)Session["generatedAnwser"]).ToString();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string numUsers = Application["VisitorCount"].ToString();
            globalLabel.Text = "Number of visitors: "+ numUsers;
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
                Session["passed"] = null;
            }
            if(Session["passed"] != null && (bool)Session["passed"] == true)
            {
                newPassTextBox.Enabled = true;
            }
            else
            {
                newPassTextBox.Enabled = false;
            }
        }

        void Login(string username, string password)
        {
            string type = "user";
            loginServiceReference.Service1Client myClient = new loginServiceReference.Service1Client();
            string resultText = myClient.userLogin(username, password, type);
            loginLabel.Text = resultText;
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
            Login(username, password);
            HttpCookie myCookies = Request.Cookies["recipieApp"];
            if (loginLabel.Text == "Authenticated")
            {
                if (rememberChk.Checked == true)
                {
                    myCookies = new HttpCookie("recipieApp");
                    myCookies["Name"] = usernameTextBox.Text;
                    myCookies.Expires = DateTime.Now.AddMonths(6);
                    Response.Cookies.Add(myCookies);
                }
                else if (rememberChk.Checked == false && myCookies["Name"] != "")
                {
                    myCookies = new HttpCookie("recipieApp");
                    myCookies["Name"] = "";
                    Response.Cookies.Add(myCookies);
                }
                Session["username"] = username;
                //loginLabel.Text = (String)Session["username"];
                Response.Redirect("SaveAndRetrieve.aspx");
            }
        }

        protected void createUserButton_Click(object sender, EventArgs e)
        {
            string newUsername = newUserTextBox.Text;
            string newPassword = newPassTextBox.Text;
            if (newUsername == "" || newPassword == "")
            {
                loginLabel.Text = "Please enter a username and password";
                return;
            }
            string type = "user";
            loginServiceReference.Service1Client myClient = new loginServiceReference.Service1Client();
            string createUserResult = myClient.createUser(newUsername, newPassword, type);
            createUserLabel.Text = createUserResult;
            Login(newUsername, newPassword);
            if (loginLabel.Text == "Authenticated")
            {
                Session["username"] = newUsername;
                Response.Redirect("SaveAndRetrieve.aspx");
            }

        }

        protected void showImageButton_Click(object sender, EventArgs e)
        {
            GenerateImage();
        }

        protected void buttonSubmitImage_Click(object sender, EventArgs e)
        {

            if (((int)Session["generatedAnwser"]).ToString() == TextBox1.Text)
            {
                imageVerLabel.Text = "The code you entered is correct.";
                Session["passed"] = true;
                newPassTextBox.Enabled = true;
            }
            else
            {
                imageVerLabel.Text = "The number you entered is incorrect. Try again.";
                GenerateImage();
            }
        }
        protected void chkRemember_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void backToDefButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}