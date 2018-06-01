using Core.Data;

namespace Core.Infrastructure.Mvc.Backend.Controllers
{
  public abstract class ControllerBase : Core.Infrastructure.Mvc.Controllers.ControllerBase
  {
    public ControllerBase(IStorage storage) : base(storage)
    {
    }
  }
}
