using Core.Data;

namespace Core.Infrastructure.Mvc.Backend.ViewModels
{
  public abstract class ViewModelFactoryBase : Core.Infrastructure.Mvc.ViewModels.ViewModelFactoryBase
  {
    public ViewModelFactoryBase(IStorage storage) : base(storage)
    {
    }
  }
}
