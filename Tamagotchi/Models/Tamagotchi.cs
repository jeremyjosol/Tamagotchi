using System.Collections.Generic;

namespace TamagotchiToy.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Happiness { get; set; }
    public bool IsAlive { get; set; }
    
    public Tamagotchi(string name)
    {
      Name = name;
      Hunger = 25;
      Happiness = 25;
      IsAlive = true;
    }
    public void Feed()
    {
      Hunger += 5;
      Happiness += 2;
    }
    public void Play()
    {
      Hunger -= 2;
      Happiness += 5;
    }
    public void Sleep()
    {
      Hunger -= 2;
      Happiness += 10;
    }
    public void LifeUpdate()
    {
      if (Hunger <= 0 || Happiness <= 0)
      {
        IsAlive = false;
      }
    }
  }
}