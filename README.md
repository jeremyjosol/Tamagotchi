# Tamagotchi

This is a basic web application that emulates the gameplay of a popular toy from the 90's called Tamagotchi. This application implements methods such as 'feed, play, and sleep' with the click of a button.

Under the hood, the methods do the following:
```csharp
exampleTamagotchi = new Tamagotchi();
// each Tamagotchi instance starts with 25 Hunger points and 25 Happiness points.
exampleTamagotchi.Hunger = 25;
exampleTamagotchi.Happiness = 25;
// when the Feed method is fired, the Hunger points go up by 5 and the Happiness points go up by 2.
exampleTamagotchi.Feed();
// so the value of the mentioned properties are now:
exampleTamagotchi.Hunger = 30;
exampleTamagotchi.Happiness = 27;
// on the contrary, Hunger points are decremented when;
exampleTamagotchi.Play();
// is called upon, because playing makes our Tamagotchi friends tired and therefore hungrier, now;
exampleTamagotchi.Hunger = 28;
// but its Happiness points go up;
exampleTamagotchi.Happiness = 32;
// your Tamagotchi can pass away if either points hit 0 because the IsAlive method checks for the condition of your Tamagotchi's current points after each method is fired so;
if (exampleTamagotchi.IsAlive = false)
{
  // your Tamagotchi dies.
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