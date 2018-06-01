using Core.Data;

namespace Core.Infrastructure.Mvc.ViewModels
{
  public abstract class ViewModelFactoryBase
  {
    public IStorage Storage { get; private set; }

    public ViewModelFactoryBase(IStorage storage)
    {
      this.Storage = storage;
    }
  }
}
