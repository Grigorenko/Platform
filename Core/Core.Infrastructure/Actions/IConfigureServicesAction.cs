using System;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Infrastructure.Actions
{
  public interface IConfigureServicesAction
  {
    int Priority { get; }

    void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider);
  }
}
