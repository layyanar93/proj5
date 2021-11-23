using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace LoginAndCreate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        string returnString = "";
        bool foundUser = false;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        EncDecServiceReference.Service1Client EncDecRef = new EncDecServiceReference.Service1Client(); // proxy to encrypt/decrypt service
        private string returnVal1;
        private string returnVal2;
        private Boolean fail = false;

        public string createUser(string username, string password)
        {
            if (username.Length >= 5 && password.Length >= 5 && !username.Equals(password))
            {

                //verify username isn't already taken
                string fileToRead = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data/members.xml");

                XDocument doc = XDocument.Load(fileToRead);
                XElement element = doc.Element("Members").Descendants("Member").Where(a => a.Element("Username").Value.Equals(username)).First();

                if (element == null)
                {
                    writeToFile(username, password);
                    returnVal1 = "Successfully created account";
                }
                else
                {
                    returnVal1 = "Account already exists";
                    fail = true;
                }
            }
            else
            {
                fail = true;
                returnVal1 = "Error creating account (username/password does not meet requirements)";
            }
            return returnVal1;
        }

        public string userLogin(string username, string password)
        {
            if (username != null && password != null)
            {
                string forAuth = username + "." + password;
                AuthUser(forAuth);
            }
            else
            {
                returnVal2 = "Error: Fill in all fields.";
            }
            return returnVal2;
        }

        // TODO: add redirect code in here
        public void writeToFile(string username, string password)
        {
            if (!fail)
            {
                string encPassword = EncDecRef.Encrypt(password);
                string fileToWrite = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data/members.xml");
                string[] userInfo = new String[2];
                try
                {
                    XElement file = XElement.Load(fileToWrite);
                    file.Add(new XElement("Member",
                        new XElement("Username", username),
                        new XElement("Password", encPassword)));

                    file.Save(fileToWrite);
                    returnString = "User has been added successfully";
                }
                catch (Exception ecx) { returnString = ecx.Message; }
            }
            else
            {
                Console.WriteLine("Error writing to xml file .");
            }
        }


        public string AuthUser(string authString) //authString format is user.password
        {
            string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath,
                @"App_Data"); // From server root to current
            string[] userWPass = authString.Split('.');
            string user = userWPass[0];
            string pass = userWPass[1].Trim();
            returnVal2 = "Not Authenticated";
            // string returnStr = "";
            fLocation = Path.Combine(fLocation, "members.xml"); // From current to App_Data
            XDocument file = XDocument.Load(fLocation);
            if (!File.Exists(fLocation))
            {
                returnVal2 = "cannot find file to authenticate";
            }
            var query = from o in file.Root.Elements("Member")
                        where (string)o.Element("Username") == user
                        select (string)o.Element("Password").Value;
            string passToDecrypt = query.ToString();
            //XElement element = file.Element("Members").Descendants("Member").Where(a => a.Element("Username").Value.Equals(user)).First();
            string decPassword = EncDecRef.Decrypt(passToDecrypt);
            if (pass == decPassword)
            {
                returnVal2 = "Authenticated";//Can return a string or bool
            }
            else
            {
                returnVal2 = "Wrong Password";
            }
            return returnVal2;
            }
        }
    }


