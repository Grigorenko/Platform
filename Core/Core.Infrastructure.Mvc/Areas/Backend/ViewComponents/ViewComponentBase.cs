using Core.Data;

namespace Core.Infrastructure.Mvc.Backend.ViewComponents
{
  public abstract class ViewComponentBase : Core.Infrastructure.Mvc.ViewComponents.ViewComponentBase
  {
    public ViewComponentBase(IStorage storage) : base(storage)
    {
    }
  }
}
