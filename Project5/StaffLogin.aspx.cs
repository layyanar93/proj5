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
            HttpCookie myCookies = Request.Cookies["recipieApp"];
            if (loginLabel.Text == "Authenticated")
            {
                if (myCookies["Name"] != "")
                {
                    myCookies = new HttpCookie("recipieApp");
                    myCookies["Name"] = "";
                    Response.Cookies.Add(myCookies);
                }
                else
                {
                    myCookies = new HttpCookie("recipieApp");
                    myCookies["Name"] = usernameTextBox.Text;
                    myCookies.Expires = DateTime.Now.AddMonths(6);
                    Response.Cookies.Add(myCookies);
                    Response.Redirect("StaffAddViewPage.aspx");
                }
            }

        }
    }
}