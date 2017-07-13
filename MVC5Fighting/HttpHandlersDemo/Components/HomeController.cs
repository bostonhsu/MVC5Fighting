using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpHandlersDemo.Components
{
    public class HomeController
    {
        public String Test(Object param1)
        {
            var message = "<html><h1>Got it! You passed '{0}' </h1></html>";
            return string.Format(message, param1);
        }
    }
}