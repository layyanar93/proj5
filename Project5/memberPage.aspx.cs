using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            string fileToSave = Path.Combine(downloadTextBox.Text, "toSave.xml");
            using (var fs = File.Open(fileToSave, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(toSave);
                }
            }
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
            printLabel.Text = myAddClient.getStringFromFile(uname);
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            searchServiceReference.Service1Client mySearchClient = new searchServiceReference.Service1Client();
            string[] urls = mySearchClient.NewsFocus(keywordsTextBox.Text);
            BulletedList1.Items.Clear();
            if (urls.Length != 0)
                foreach (string url in urls)
                {
                    BulletedList1.Items.Add(url);
                }
            else
            {
                BulletedList1.Items.Add("Error with topics");
            }
        }
    }
}