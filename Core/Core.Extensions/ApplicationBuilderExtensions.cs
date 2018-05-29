using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Core.Infrastructure;
using Core.Infrastructure.Actions;

namespace Core.Extensions
{
  public static class ApplicationBuilderExtensions
  {
    public static void UseCore(this IApplicationBuilder applicationBuilder)
    {
      ILogger logger = applicationBuilder.ApplicationServices.GetService<ILoggerFactory>().CreateLogger("Core.Extensions");

      foreach (IConfigureAction action in ExtensionManager.GetInstances<IConfigureAction>().OrderBy(a => a.Priority))
      {
        logger.LogInformation("Executing Configure action '{0}'", action.GetType().FullName);
        action.Execute(applicationBuilder, applicationBuilder.ApplicationServices);
      }
    }
  }
}
