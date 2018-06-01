using Core.Data;

namespace Core.Infrastructure.Mvc.Backend.ViewModels
{
  public abstract class ViewModelMapperBase : Core.Infrastructure.Mvc.ViewModels.ViewModelMapperBase
  {
    public ViewModelMapperBase(IStorage storage) : base(storage)
    {
    }
  }
}
