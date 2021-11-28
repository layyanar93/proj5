using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace SaveAndRetrieveTryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveToXmlButton_Click(object sender, EventArgs e)
        {
            saveServiceReference.Service1Client myAddClient = new saveServiceReference.Service1Client();
            string textToSave = toSaveTextBox.Text;
            string usernameToSave = unameToAddTextbox.Text;
            string result = myAddClient.putStringToFile(usernameToSave, textToSave);
            resultLabel.Text = result;
        }

        protected void printButton_Click(object sender, EventArgs e)
        {
            saveServiceReference.Service1Client myAddClient = new saveServiceReference.Service1Client();
            string uname = printTextBox.Text;
            printedLabel.Text = myAddClient.getStringFromFile(uname);
        }

        protected void downloadButton_Click(object sender, EventArgs e)
        {
            saveServiceReference.Service1Client myAddClient = new saveServiceReference.Service1Client();
            string username = "Lohitha";
            string toSave = myAddClient.getStringFromFile(username);
            string fileToSave = Path.Combine(SaveTextBox.Text, "toSave.xml");
            using (var fs = File.Open(fileToSave, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(toSave);
                }
            }
        }

        protected void memberButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("memberPage.aspx");
        }
    }
}