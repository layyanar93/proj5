using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    public partial class memberPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)Session["username"];
            Label2.Text = "Welcome " + username+ "!" ;
            //string username = (String)Session[username];
        }

        protected void downloadButton_Click(object sender, EventArgs e)
        {
            saveServiceReference.Service1Client myAddClient = new saveServiceReference.Service1Client();
            string username = (string)Session["username"];
            string toSave = myAddClient.getStringFromFile(username);
            Stream stm1 = new MemoryStream(Encoding.UTF8.GetBytes(toSave ?? ""));
            Int16 bufferSize = 1024;
            byte[] buffer = new byte[bufferSize + 1];

            Response.ContentType = "text/plain";
            Response.AddHeader("Content-Disposition","attachment; filename=\"recipes\";");
            Response.BufferOutput = false;
            int count = stm1.Read(buffer, 0, bufferSize);

            while (count > 0)
            {
                Response.OutputStream.Write(buffer, 0, count);
                count = stm1.Read(buffer, 0, bufferSize);
                
            }
            Response.End();
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            saveServiceReference.Service1Client myAddClient = new saveServiceReference.Service1Client();
            string textToSave = saveTextBox.Text;
            string usernameToSave = (string)Session["username"];
            string result = myAddClient.putStringToFile(usernameToSave, textToSave);
            saveLabel.Text = result;
        }

        //to retrieve only the user's recipes from recipes.xml
        protected void RButton_Click(object sender, EventArgs e)
        {
            saveServiceReference.Service1Client myAddClient = new saveServiceReference.Service1Client();
            string uname = (string)Session["username"];
            printBox.Text = myAddClient.getStringFromFile(uname);
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click1(object sender, EventArgs e)
        {

        }
    }
}