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
using EncryptDecryptLib;

namespace LoginAndCreate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        string returnString = "";
        bool foundUser = false;
        string fileToRead = "";
        string fileToWrite = "";
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        private string returnVal1;
        private string returnVal2;
        private Boolean fail = false;
        string pathVar1;
        string pathVar2;

        //Creator: Lohitha Ayyanar
        public string createUser(string username, string password, string type)
        {
            if (username.Length >= 5 && password.Length >= 5 && !username.Equals(password))
            {

                //verify username isn't already taken
                if (type == "admin")
                {
                    fileToRead = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data/staff.xml");
                    pathVar1 = "Admins";
                    pathVar2 = "Staff";
                }
                else if (type == "user")
                {
                    fileToRead = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data/members.xml");
                    pathVar1 = "Members";
                    pathVar2 = "Member";
                }

                XDocument doc = XDocument.Load(fileToRead);
                var element = doc.Element(pathVar1).Descendants(pathVar2).Where(a => a.Element("Username").Value.Equals(username));

                if (element.Count() == 0 )
                {
                    writeToFile(username, password, type);
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

        public string userLogin(string username, string password, string type)
        {
            if (username != null && password != null)
            {
                string forAuth = username + "." + password;
                AuthUser(forAuth, type);
            }
            else
            {
                returnVal2 = "Error: Fill in all fields.";
            }
            return returnVal2;
        }

        //writes the new username and password to file. if it's being called by staff, it will write to staff.xml
        //if called by a user , will write to members.xml
        //Creator: Lohitha Ayyanar
        public void writeToFile(string username, string password, string type)
        {
            if (!fail)
            {
                string encPassword = EncryptDecrypt.Encrypt(password);//Call the dll library function
                string[] userInfo = new String[2];
                if (type == "admin")
                {
                    fileToWrite = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data/staff.xml");
                    try
                    {
                        XElement file = XElement.Load(fileToWrite);
                        file.Add(new XElement("Staff",
                            new XElement("Username", username),
                            new XElement("Password", encPassword)));

                        file.Save(fileToWrite);
                        returnString = "Staff has been added successfully";
                    }
                    catch (Exception ecx) { returnString = ecx.Message; }
                }
                else if (type == "user")
                {
                    fileToWrite = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data/members.xml");
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
            }
            else
            {
                Console.WriteLine("Error writing to xml file .");
            }
        }

        //Creator: Lohitha Ayyanar
        //Staff can see the members.xml file to see user credentials.
        public string viewMembers()
        {
            string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data/members.xml");
            XElement xml = XElement.Load(file);
            var nodes = xml.Elements("Member");
            string toPrint = "members.xml: ";
            foreach (XElement u in nodes.Nodes())
            {
                toPrint = toPrint + "\n----------------------------------------------\n" + u.Value;
            }
            returnString = toPrint;
            return returnString;
        }

        //Creator: Chance Engstrom
        public string AuthUser(string authString, string type) //authString format is user.password
        {
            string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath,
                @"App_Data"); // From server root to current
            string[] userWPass = authString.Split('.');
            string user = userWPass[0];
            string pass = userWPass[1].Trim();
            returnVal2 = "Not Authenticated";
            string decPassword = "";
            // string returnStr = "";
            if (type == "admin")
            {
                fLocation = Path.Combine(fLocation, "staff.xml"); // From current to App_Data
                XDocument file = XDocument.Load(fLocation);
                if (!File.Exists(fLocation))
                {
                    returnVal2 = "cannot find file to authenticate";
                }
                var query = from o in file.Root.Elements("Staff")
                            where (string)o.Element("Username") == user
                            select (string)o.Element("Password").Value;
                string passToDecrypt = query.First(); //This is where an error happened, Changed from ToString() to First()
                                                      //XElement element = file.Element("Members").Descendants("Member").Where(a => a.Element("Username").Value.Equals(user)).First();
                decPassword = EncryptDecrypt.Decrypt(passToDecrypt);//Call the dll library function
            }
            else if (type == "user")
            {
                fLocation = Path.Combine(fLocation, "members.xml"); // From current to App_Data
                XDocument file = XDocument.Load(fLocation);
                if (!File.Exists(fLocation))
                {
                    returnVal2 = "cannot find file to authenticate";
                }
                var query = from o in file.Root.Elements("Member")
                            where (string)o.Element("Username") == user
                            select (string)o.Element("Password").Value;
                string passToDecrypt = query.First(); //This is where an error happened, Changed from ToString() to First()
                                                      
                decPassword = EncryptDecrypt.Decrypt(passToDecrypt);//Call the dll library function
            }
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


