using System;
using System.Collections.Generic;

namespace be_YourFavoriteThings.Favorites
{
  class Food
  {
    public string Name { get; set; } = "Generic";
    public string Recipe { get; set; } = "All Types";
    public List<string> Ingridients { get; set; } = new List<string>();

    public Food(string name,
                string recipe)
    {
      Name = name;
      Recipe = recipe;
    }

    public void AddIngredients(string ingredient)
    {
      Ingridients.Add(ingredient);
    }

    public void PrintFood()
    {
      Console.WriteLine($"Food: {Name}" +
                        $"\nRecipe: \n{Recipe}" +
                        $"\nIngredients: \n");
      Ingridients.ForEach(Console.WriteLine);
      Console.WriteLine("\n");
    }





  }
}
