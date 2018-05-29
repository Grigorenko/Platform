using System;
using Microsoft.AspNetCore.Routing;

namespace Core.Infrastructure.Actions
{
  public interface IUseMvcAction
  {
    int Priority { get; }

    void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider);
  }
}
