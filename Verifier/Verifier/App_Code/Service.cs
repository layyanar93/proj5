using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public int RandomNumber()
	{
        Random random = new Random();
		return random.Next(2,100);
    }
    public Stream GetImage(int anwser)
    {
        //WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";
        int mapwidth = (8 * 25);
        Bitmap bMap = new Bitmap(mapwidth, 40);
        Graphics graph = Graphics.FromImage(bMap);
        graph.Clear(Color.Azure);
        graph.DrawRectangle(new Pen(Color.LightBlue, 0), 0, 0, bMap.Width - 1, bMap.Height - 1);
        Random random = new Random();
        Pen badPen = new Pen(Color.LightGreen, 0);
        for (int i = 0; i < 100; i++)
        {
            int x = random.Next(1, bMap.Width - 1);
            int y = random.Next(1, bMap.Width - 1);
            graph.DrawRectangle(badPen, x, y, 4, 3);
            graph.DrawEllipse(badPen, x, y, 2, 3);
        }
        int num1 = random.Next(1, anwser - 1);
        int num2 = anwser - num1;
        string myString = " "+ num1.ToString() + " + " + num2.ToString();
        char[] charString = myString.ToCharArray();
        Font font = new Font("Boopee", 18, FontStyle.Bold);
        Color[] clr = { Color.Black, Color.Red, Color.DarkViolet, Color.Green, Color.DarkOrange, Color.Brown, Color.DarkGoldenrod, Color.Plum };
        for (int i = 0; i < myString.Length; i++)
        {
            int d = random.Next(20, 25);
            int p = random.Next(1, 15);
            int c = random.Next(0, clr.Length-1);
            string str1 = Convert.ToString(charString[i]);
            Brush b = new System.Drawing.SolidBrush(clr[c]);
            graph.DrawString(str1, font, b, 1 + i * d, p);
        }
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        bMap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        ms.Position = 0;
        graph.Dispose();
        bMap.Dispose();
        return ms;
    }
}
