using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Core.Infrastructure;
using Core.Infrastructure.Actions;

namespace Core.Data.Dapper.Actions
{
  public class AddStorageContextAction : IConfigureServicesAction
  {
    public int Priority => 1000;

    public void Execute(IServiceCollection services, IServiceProvider serviceProvider)
    {
      Type type = ExtensionManager.GetImplementations<IStorageContext>()?.FirstOrDefault(t => !t.GetTypeInfo().IsAbstract);

      if (type == null)
      {
        ILogger logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger("Core.Data.Dapper");

        logger.LogError("Implementation of Core.Data.Dapper.IStorageContext not found");
        return;
      }

      services.AddScoped(typeof(IStorageContext), type);
    }
  }
}
