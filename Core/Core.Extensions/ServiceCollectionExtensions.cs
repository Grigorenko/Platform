using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Core.Infrastructure;
using Core.Infrastructure.Actions;

namespace Core.Extensions
{
  public static class ServiceCollectionExtensions
  {
    public static void AddCore(this IServiceCollection services)
    {
      ExtensionManager.SetAssemblies(new DefaultAssemblyProvider(services.BuildServiceProvider()).GetAssemblies("/", false));

      IServiceProvider serviceProvider = services.BuildServiceProvider();
      ILogger logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger("Core.Extensions");

      foreach (IConfigureServicesAction action in ExtensionManager.GetInstances<IConfigureServicesAction>().OrderBy(a => a.Priority))
      {
        logger.LogInformation("Executing ConfigureServices action '{0}'", action.GetType().FullName);
        action.Execute(services, serviceProvider);
        serviceProvider = services.BuildServiceProvider();
      }
    }
  }
}
