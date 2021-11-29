using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    public partial class StaffLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            string type = "admin";
            string resultText = myClient.userLogin(username, password, type);
            loginLabel.Text = resultText;
            if (loginLabel.Text == "Authenticated")
            {
                Session["username"] = username;
                Response.Redirect("StaffAddViewPage.aspx");
                
            }

        }
    }
}