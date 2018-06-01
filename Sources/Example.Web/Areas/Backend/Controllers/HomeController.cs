using Microsoft.AspNetCore.Mvc;

namespace Example.Web.Backend.Controllers
{
  [Area("Backend")]
  public class HomeController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      return this.Content("Areas -> Backend -> Home -> Index");
    }
  }
}
