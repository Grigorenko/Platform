using Microsoft.AspNetCore.Mvc;
using Core.Data;
using Example.Data.Abstractions;

namespace Example.Web.Controllers
{
  public class DefaultController : Core.Infrastructure.Mvc.Controllers.ControllerBase
  {
    public DefaultController(IStorage storage) : base(storage)
    {
    }

    [HttpGet]
    public IActionResult Index()
    {
      return this.Json(this.Storage.GetRepository<IEntityRepository>().All());
    }
  }
}
