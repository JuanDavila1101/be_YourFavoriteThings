using System;

namespace be_YourFavoriteThings.Favorites
{
  class Book
  {
    public string Name { get; set; } = "Generic";
    public string Type { get; set; } = "All Types";
    public bool IsOpen { get; set; } = false;

    public Book(string name,
                string type,
                bool isOpen)
    {
      Name = name;
      Type = type;
      IsOpen = isOpen;
    }

    public void OpenCloseBook()
    {
      if (IsOpen)
      {
        IsOpen = false;
      }
      else
      {
        IsOpen = true;
      }

    }

    public void PrintTheBook()
    {
      Console.WriteLine($"The name of the book is: {Name}." +
        $"\nThe Book type is: {Type}." +
        $"\nThe Book is {(IsOpen ? "open" : "closed" )}.\n");
    }


  }
}
