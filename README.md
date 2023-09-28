# Tamagotchi

This is a basic web application that emulates the gameplay of a popular toy from the 90's called Tamagotchi. To get started, simply create a new Tamagotchi and give it a name and the application implements methods such as 'feed, play, and sleep' with the simple click of a corresponding button. 

To take a glimpse under the hood:
```csharp
exampleTamagotchi = new Tamagotchi();
// each Tamagotchi instance starts with 
// 25 Hunger points and 25 Happiness points.
exampleTamagotchi.Hunger = 25;
exampleTamagotchi.Happiness = 25;
// when the Feed method is fired, 
// Hunger points go up by 5 and 
// Happiness points go up by 2.
exampleTamagotchi.Feed();
// now the values of the mentioned properties incremented;
exampleTamagotchi.Hunger = 30;
exampleTamagotchi.Happiness = 27;
// on the contrary, Hunger points are decremented when;
exampleTamagotchi.Play();
// is called upon, because Play() time will make  your 
// Tamagotchi friend tired and therefore more Hungry, now;
exampleTamagotchi.Hunger = 28;
// but its Happiness points go up;
exampleTamagotchi.Happiness = 32;
// your Tamagotchi can pass away if either points hit 0 
// because an IsAlive method checks for the condition of
// your Tamagotchi's relevant points after each method fires so...
if (exampleTamagotchi.IsAlive = false)
{
  // ...your Tamagotchi dies.
}
```
## Application Setup

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory called `Tamagotchi`. 
3. Run `dotnet run`.
4. Open the browser to `http://localhost:5000` or `https://localhost:5001`.

## Available Routes

* localhost:5000/
* localhost:5000/tamagotchis
* localhost:5000/tamagotchis/new
* localhost:5000/gameover