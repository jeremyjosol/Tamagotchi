using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TamagotchiToy.Models;
using System;

namespace TamagotchiTests.Tests
{
  [TestClass]
  public class TamagotchiTests
  {
    [TestMethod]
    public void Tamagotchi_CreateInstanceOfTamagotchi_Tamagotchi()
    {
      Tamagotchi tamagotchi = new Tamagotchi("Pochita");
      Assert.AreEqual("Pochita", tamagotchi.Name);
      Assert.AreEqual(25, tamagotchi.Hunger);
      Assert.AreEqual(25, tamagotchi.Happiness);
      Assert.IsTrue(tamagotchi.IsAlive);
    }
    [TestMethod]
    public void Feed_ChangesValueOfHungerProperty_Int()
    {
      Tamagotchi tamagotchi = new Tamagotchi("Pochita");
      tamagotchi.Feed();
      Assert.AreEqual(30, tamagotchi.Hunger);
      Assert.AreEqual(27, tamagotchi.Happiness);
    }
    [TestMethod]
    public void Play_ChangesValueOfHappinessProperty_Int()
    {
      Tamagotchi tamagotchi = new Tamagotchi("Pochita");
      tamagotchi.Play();
      Assert.AreEqual(30, tamagotchi.Happiness);
      Assert.AreEqual(23, tamagotchi.Hunger);
    }
  }
}
  