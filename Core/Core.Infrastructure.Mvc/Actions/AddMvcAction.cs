using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.DependencyInjection;
using Core.Infrastructure.Actions;

namespace Core.Infrastructure.Mvc.Actions
{
  public class AddMvcAction : IConfigureServicesAction
  {
    public int Priority => 10000;

    public void Execute(IServiceCollection services, IServiceProvider serviceProvider)
    {
      IMvcBuilder mvcBuilder = services.AddMvc();

      mvcBuilder.AddRazorOptions(
        o =>
        {
          foreach (Assembly assembly in ExtensionManager.Assemblies)
            o.FileProviders.Add(new EmbeddedFileProvider(assembly, assembly.GetName().Name));
        }
      );

      foreach (IAddMvcAction action in ExtensionManager.GetInstances<IAddMvcAction>().OrderBy(a => a.Priority))
      {
        ILogger logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger("Core.Infrastructure.Mvc");

        logger.LogInformation("Executing AddMvc action '{0}'", action.GetType().FullName);
        action.Execute(mvcBuilder, serviceProvider);
      }
    }
  }
}
