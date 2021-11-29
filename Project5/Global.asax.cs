﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Project5
{
    public class Global : HttpApplication
    { 
        void Application_Start(object sender, EventArgs e)
        {
            Application["VisitorCount"] = 0;
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_End(object sender, EventArgs e)
        {
                Application["lastVisited"] = "<hr />This application was last visited on " + DateTime.Now.ToString();

        }
        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started  
            Application["VisitorCount"] = (int)Application["VisitorCount"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends.   
            // Note: The Session_End event is raised only when the sessionstate mode  
            // is set to InProc in the Web.config file. If session mode is set to StateServer   
            // or SQLServer, the event is not raised.  
        }
    }
}