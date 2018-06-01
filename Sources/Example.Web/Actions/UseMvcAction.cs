using System;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder;
using Core.Infrastructure.Actions;

namespace Example.Web.Actions
{
  public class UseMvcAction : IUseMvcAction
  {
    public int Priority => 1000;

    public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
    {
      routeBuilder.MapRoute(name: "areas", template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

      routeBuilder.MapRoute(name: "Default", template: "{controller=Default}/{action=Index}/{id?}");
    }
  }
}
