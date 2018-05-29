using System;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Infrastructure.Actions
{
  public interface IAddMvcAction
  {
    int Priority { get; }

    void Execute(IMvcBuilder mvcBuilder, IServiceProvider serviceProvider);
  }
}
