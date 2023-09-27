using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TamagotchiToy.Models;

namespace TamagotchiToy.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/tamagotchis")]
    public ActionResult Index()
    {
    return View();
    }
    [HttpGet("tamagotchis/new")]
    public ActionResult New()
    {
      return View();
    }

  }
}