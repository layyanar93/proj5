using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    public partial class StaffAddViewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string newUsername = nameTextBox.Text;
            string newPassword = passwordTextBox.Text;
            string type = "admin";
            loginServiceReference.Service1Client myClient = new loginServiceReference.Service1Client();
            string createUserResult = myClient.createUser(newUsername, newPassword, type);
            addLabel.Text = createUserResult;
        }
    }
}