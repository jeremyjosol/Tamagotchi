using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TamagotchiToy.Models;

namespace TamagotchiToy.Controllers
{
  public class TamagotchisController : Controller
  {
    private static List<Tamagotchi> _tamagotchis = new List<Tamagotchi>();
    public static Tamagotchi myTamagotchi;

    [HttpGet("/tamagotchis")] // needs to match form action
    public ActionResult Index()
    {
      return View(_tamagotchis);
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
      _tamagotchis.Add(myTamagotchi);
      return RedirectToAction("Index");
    }
    [HttpPost("/tamagotchis/feed")]
    public ActionResult Feed()
    {
      if (_tamagotchis.Count > 0)
      {
        Tamagotchi myTamagotchi = _tamagotchis[0];
        myTamagotchi.Feed();
        myTamagotchi.LifeUpdate();

        if (!myTamagotchi.IsAlive)
        {
          _tamagotchis.Remove(myTamagotchi);
          return RedirectToAction("GameOver");
        }
      }
      return RedirectToAction("Index");
    }
    [HttpPost("/tamagotchis/play")]
    public ActionResult Play()
    {
      if (_tamagotchis.Count > 0)
      {
        Tamagotchi myTamagotchi = _tamagotchis[0];
        myTamagotchi.Play();
        myTamagotchi.LifeUpdate();
      }
      return RedirectToAction("Index");
    }
    [HttpPost("/tamagotchis/sleep")]
    public ActionResult Sleep()
    {
      if (_tamagotchis.Count > 0)
      {
        Tamagotchi myTamagotchi = _tamagotchis[0];
        myTamagotchi.Sleep();
        myTamagotchi.LifeUpdate();
      }
      return RedirectToAction("Index");
    }
    [HttpGet("/tamagotchis/gameover")]
    public ActionResult GameOver()
    {
      return View();
    }
  }
}
