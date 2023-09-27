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
      Assert.AreEqual(true, tamagotchi.IsAlive);
    }
  }
}
  