using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Core.Infrastructure;
using Core.Infrastructure.Actions;

namespace Core.Data.Dapper.Actions
{
  public class AddStorageAction : IConfigureServicesAction
  {
    public int Priority => 2000;

    public void Execute(IServiceCollection services, IServiceProvider serviceProvider)
    {
      Type type = ExtensionManager.GetImplementations<IStorage>()?.FirstOrDefault(t => !t.GetTypeInfo().IsAbstract);

      if (type == null)
      {
        ILogger logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger("Core.Data.Dapper");

        logger.LogError("Implementation of Core.Data.Dapper. IStorage not found");
        return;
      }

      services.AddScoped(typeof(IStorage), type);
    }
  }
}
