using Core.Data;

namespace Core.Infrastructure.Mvc.ViewModels
{
  public abstract class ViewModelMapperBase
  {
    public IStorage Storage { get; private set; }

    public ViewModelMapperBase(IStorage storage)
    {
      this.Storage = storage;
    }
  }
}
