// Decompiled with JetBrains decompiler
// Type: SimpleLog.RouteConfig
// Assembly: SimpleLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 97BB082D-C5E4-4372-B15D-F8177A038084
// Assembly location: C:\Users\100752\Downloads\SimpleLog.dll

using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleLog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            RouteCollectionExtensions.IgnoreRoute(routes, "{resource}.axd/{*pathInfo}");
            RouteCollectionExtensions.MapRoute(routes, "Default", "{controller}/{action}/{id}", (object)new
            {
                controller = "Calculo",
                action = "Index",
                id = (UrlParameter)UrlParameter.Optional
            });
        }
    }
}
