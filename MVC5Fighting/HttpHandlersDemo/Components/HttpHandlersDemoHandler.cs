using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace HttpHandlersDemo.Components
{
    public class HttpHandlersDemoHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var segments = context.Request.Url.Segments;
            var controller = segments[1].TrimEnd('/');
            var action = segments[2].TrimEnd('/');
            var param1 = segments[3].TrimEnd('/');

            var fullName = String.Format("{0}.{1}Controller", GetType().Namespace, controller);
            var controllerType = Type.GetType(fullName, true, true);
            var instance = Activator.CreateInstance(controllerType);
            var methodInfo = controllerType.GetMethod(action,
                BindingFlags.Instance | BindingFlags.IgnoreCase | BindingFlags.Public);
            var result = String.Empty;
            if (methodInfo.GetParameters().Length == 0)
            {
                result = methodInfo.Invoke(instance, null) as String;
            }
            else
            {
                result = methodInfo.Invoke(instance, new Object[] {param1}) as String;
            }
            context.Response.Write(result);
        }

        public bool IsReusable => false;
    }
}