using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}