using System;

namespace be_YourFavoriteThings.Favorites
{
  class Fruit
  {
    public string Name { get; set; } = "Generic";
    public string Type { get; set; } = "none";
    public bool IsTheFruitRipen { get; set; } = false;

    public Fruit(string name,
                 string type,
                 bool isTheFruitRipen)
    {
      Name = name;
      Type = type;
      IsTheFruitRipen = isTheFruitRipen;
    }

    public void RipenTheFruit()
    {
      if (!IsTheFruitRipen)
      {
        IsTheFruitRipen = true;
      }
    }

    public void PrintTheFruit()
    {
      Console.WriteLine($"The fruit is: {Name}." +
        $"\nAnd the fruit is: {Type}." +
        $"\nAnd the fruit is: {(IsTheFruitRipen ? "ready to be eaten" : "still to not ready to eat")}.\n");

    }



  }
}
