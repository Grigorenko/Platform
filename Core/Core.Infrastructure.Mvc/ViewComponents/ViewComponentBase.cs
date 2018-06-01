using Microsoft.AspNetCore.Mvc;
using Core.Data;

namespace Core.Infrastructure.Mvc.ViewComponents
{
  public abstract class ViewComponentBase : ViewComponent
  {
    public IStorage Storage { get; private set; }

    public ViewComponentBase(IStorage storage)
    {
      this.Storage = storage;
    }
  }
}
