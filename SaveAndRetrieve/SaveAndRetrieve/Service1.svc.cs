using System;
using System.IO;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.Net;
using EncryptDecryptLib;

namespace SaveAndRetrieve
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string returnString;
        public string toDownload;
        public string putStringToFile (string username, string value)
        {
            try
            {
                string encryptedRecipie = EncryptDecrypt.Encrypt(value);
                string fileToWrite = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data/recipes.xml");
                XElement file = XElement.Load(fileToWrite);
                file.Add(new XElement("User",
                    new XAttribute("Username", username),
                    new XElement("Recipe", encryptedRecipie)));
                //doc.LoadXml(fileToWrite.Substring(fileToWrite.IndexOf(Environment.NewLine)));
                //var node = doc.SelectSingleNode("//Recipes/[Username='Lohitha']
                file.Save(fileToWrite);
                returnString = "success";
            }
                catch (Exception ecx) { returnString = ecx.Message; }
            return returnString; 
        }

        public string getStringFromFile(string username)
        {
            string fileToWrite = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data/recipes.xml");
            XElement xml = XElement.Load(fileToWrite);
            var nodes = xml.Elements("User").Where(x => x.Attribute("Username").Value == username);
            string toPrint = "Recipes: ";
            foreach (XElement u in nodes.Nodes())
            {
                toPrint = toPrint +"\n----------------------------------------------\n"+ EncryptDecrypt.Decrypt(u.Value);
            }
            toDownload = toPrint;
            returnString = toPrint;
            return returnString;
        }

    }
 }
