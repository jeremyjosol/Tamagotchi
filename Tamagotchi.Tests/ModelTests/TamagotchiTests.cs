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
    [TestMethod]
    public void Sleep_ChangesValueOfHappinessProperty_Int()
    {
      Tamagotchi tamagotchi = new Tamagotchi("Pochita");
      tamagotchi.Sleep();
      Assert.AreEqual(23, tamagotchi.Hunger);
      Assert.AreEqual(35, tamagotchi.Happiness);
    }
    [TestMethod]
    public void LifeUpdate_ChecksValueOfHungerAndHappiness_BoolFalse()
    {
      Tamagotchi tamagotchi = new Tamagotchi("Pochita");
      tamagotchi.Happiness = 0;
      tamagotchi.Hunger = 30;
      tamagotchi.LifeUpdate();
      Assert.IsFalse(tamagotchi.IsAlive);
    }
    [TestMethod]
    public void LifeUpdate_ChecksValueOfHungerAndHappiness_BoolTrue()
    {
      Tamagotchi tamagotchi = new Tamagotchi("Pochita");
      tamagotchi.Happiness = 25;
      tamagotchi.Hunger = 25;
      tamagotchi.LifeUpdate();
      Assert.IsTrue(tamagotchi.IsAlive);
    }
  }
}
  