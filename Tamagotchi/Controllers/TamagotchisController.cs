using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TamagotchiToy.Models;

namespace TamagotchiToy.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/tamagotchis")] // needs to match form action
    public ActionResult Index()
    {
      List<Tamagotchi> myTamagotchi = Tamagotchi.GetAll();
      return View(myTamagotchi);
    }
    [HttpGet("tamagotchis/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/tamagotchis")]
    public ActionResult Create(string name)
    {
      Tamagotchi myTamagotchi = new Tamagotchi(name);
      return RedirectToAction("Index", myTamagotchi);
    }
    [HttpPost("tamagotchis/feed")]
    public ActionResult Feed(string name)
    {
      Tamagotchi myTamagotchi = new Tamagotchi(name);
      myTamagotchi.Feed();
      return RedirectToAction("Index", myTamagotchi);
    }
  }
}