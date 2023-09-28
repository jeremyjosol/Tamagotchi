using Microsoft.AspNetCore.Mvc;

namespace TamagotchiToy.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}