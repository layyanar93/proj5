using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    public partial class imageProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            imageVerServiceReference.ServiceClient fromService = new imageVerServiceReference.ServiceClient();
            int anwser;
            if (Session["generatedAnwser"] == null)
            {
                anwser = fromService.RandomNumber();
                Session["generatedAnwser"] = anwser;
            }
            else
            {
                anwser = (int)Session["generatedAnwser"];
            }
            Stream myStream = fromService.GetImage(anwser);
            System.Drawing.Image myImage = System.Drawing.Image.FromStream(myStream);
            Response.ContentType = "image/jpeg";
            myImage.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
    }
}