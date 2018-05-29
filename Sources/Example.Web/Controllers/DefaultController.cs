using Microsoft.AspNetCore.Mvc;
using Core.Data;
using Example.Data.Abstractions;

namespace Example.Web.Controllers
{
  public class DefaultController : Controller
  {
    private readonly IStorage storage;

    public DefaultController(IStorage storage)
    {
      this.storage = storage;
    }

    [HttpGet]
    public IActionResult Index()
    {
      return this.Json(this.storage.GetRepository<IEntityRepository>().All());
    }
  }
}
