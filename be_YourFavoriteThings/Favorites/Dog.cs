using System;

namespace be_YourFavoriteThings.Favorites
{ 
  class Dog
  { 
    public string Size { get; set; } 
    public short Weight { get; private set; }
    public string Name { get; set; }

    public Dog(string name, string size, short weight)
    {
      Name = name;
      Weight = weight;
      Size = size;
    }

    public void Bark()
    {
      Console.WriteLine($"{Name} barks noisily.");
    }
 
    public void Eat(string typeOfFood)
    {
      if (String.Equals(typeOfFood, "healthy food", StringComparison.OrdinalIgnoreCase))
      {
        Console.WriteLine("this is healthy food");
      }

      switch (typeOfFood)
      {
        case "healthy food":
          Weight -= 1;
          break;

        case "bad food":
          Weight += 1;
          break;

        default:
          Console.WriteLine("didn't find the food");
          return;
          break;
      }

      Console.WriteLine($"{Name} I just ate: {typeOfFood} \n{Name}'s weight is: {Weight}\n");
    }

  }
}
