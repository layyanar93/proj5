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
        public partial class startPage : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {

            }
        }

        protected void memberButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginOrSignUpPage.aspx");
        }

        protected void staffButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffLogin.aspx");
        }
    }
}