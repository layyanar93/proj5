using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "~/imageProcess.aspx";
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            loginServiceReference.Service1Client myClient = new loginServiceReference.Service1Client();
            string resultText = myClient.userLogin(username, password);
            loginLabel.Text = resultText;
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
            imageVerServiceReference.ServiceClient fromService = new imageVerServiceReference.ServiceClient();
            string length = "6";
            Session["userLength"] = length;
            string myStr = fromService.GetVerifierString(length);
            Session["generatedString"] = myStr;
            showImageButton.Text = "Show another image";
            Image1.Visible = true;
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
            }
        }
    }
}