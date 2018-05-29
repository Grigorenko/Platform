using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Core.Infrastructure.Actions;

namespace Core.Infrastructure.Mvc.Actions
{
  public class UseMvcAction : IConfigureAction
  {
    public int Priority => 10000;

    public void Execute(IApplicationBuilder applicationBuilder, IServiceProvider serviceProvider)
    {
      applicationBuilder.UseMvc(
        routeBuilder =>
        {
          foreach (IUseMvcAction action in ExtensionManager.GetInstances<IUseMvcAction>().OrderBy(a => a.Priority))
          {
            ILogger logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger("Core.Infrastructure.Mvc");

            logger.LogInformation("Executing UseMvc action '{0}'", action.GetType().FullName);
            action.Execute(routeBuilder, serviceProvider);
          }
        }
      );
    }
  }
}
