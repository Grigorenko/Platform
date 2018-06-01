using Core.Data;
using Microsoft.AspNetCore.Mvc;

namespace Example.Web.Backend.Controllers
{
  [Area("Backend")]
  public class HomeController : Core.Infrastructure.Mvc.Backend.Controllers.ControllerBase
  {
    public HomeController(IStorage storage) : base(storage)
    {
    }

    [HttpGet]
    public IActionResult Index()
    {
      return this.Content("Areas -> Backend -> Home -> Index");
    }
  }
}
