using System;
using Microsoft.AspNetCore.Builder;

namespace Core.Infrastructure.Actions
{
  public interface IConfigureAction
  {
    int Priority { get; }

    void Execute(IApplicationBuilder applicationBuilder, IServiceProvider serviceProvider);
  }
}
