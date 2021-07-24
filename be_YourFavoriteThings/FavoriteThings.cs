using be_YourFavoriteThings.Favorites;
using System;

namespace be_YourFavoriteThings
{
  class FavoriteThings
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var bookJuan = new Book("Juan Book", "Sci-Fi", true);
      bookJuan.PrintTheBook();
      bookJuan.OpenCloseBook();
      bookJuan.PrintTheBook();

      var bookTwo = new Book("Second-Juan", "Sci-Fi2", true);
      bookTwo.PrintTheBook();
      bookTwo.OpenCloseBook();
      bookTwo.PrintTheBook();

      var gunner = new Dog("Gunner", "Large", 90);
      gunner.Bark();
      Console.WriteLine($"{gunner.Name}'s weight is: {gunner.Weight}");
      gunner.Eat("healthy food");

      var freedom = new Dog("Freedom", "Medium", 45);
      freedom.Bark();
      Console.WriteLine($"{freedom.Name}'s weight is: {freedom.Weight}");
      freedom.Eat("healthy food");

      var guanabana = new Fruit("Guanabana", "Healthy", false);
      guanabana.PrintTheFruit();
      guanabana.RipenTheFruit();
      guanabana.PrintTheFruit();

      var anona = new Fruit("Anona", "Healthy", true);
      anona.PrintTheFruit();

      var salsa = new Food("Juan's Salsa", "https://vm.tiktok.com/ZMdXaHLCE/");
      salsa.AddIngredients("Salsa Lizano");
      salsa.AddIngredients("Onion");
      salsa.AddIngredients("2 x Cilantro bushels");
      salsa.AddIngredients("3 X Garlic");
      salsa.AddIngredients("2-3 Jalapenos");
      salsa.AddIngredients("4-8 Tomatoes");
      salsa.AddIngredients("1 Can of Dice tomatos");
      salsa.AddIngredients("1 Can of Rotel");
      salsa.AddIngredients("2 Limes");
      salsa.AddIngredients("1 Lemon");
      salsa.AddIngredients("tbs whole Chipotle peper");
      salsa.AddIngredients("Olive oil");
      salsa.AddIngredients("Salt");
      salsa.AddIngredients("Pepper");
      salsa.AddIngredients("Oregano");
      salsa.AddIngredients("Parsley");

      salsa.PrintFood();

      var seviche = new Food("Seviche", 
                             "Cut fish in small cubes. \n" +
                             "Cut onions in small pieces \n" +
                             "Mix and leave in refrigerator\n" +
                             "cut the cilantro and add at the 7 hour mark\n" +
                             "Let the mix sit in the refrigerator for at least 9 hour before serving.");
      seviche.AddIngredients("2-3 Fish Tilapia, Flounder, Grouper");
      seviche.AddIngredients("20-30 Limes");
      seviche.AddIngredients("Salsa lizano");
      seviche.AddIngredients("1 Large Onion");
      seviche.AddIngredients("1-2 Cilantro Bushels");
      seviche.AddIngredients("Salt");

      seviche.PrintFood();

    }
  }
}


//-Create at least four classes, each representing one of your favorite things.
// Something generic like a book, a car, or a beach.
//- Give each of these things two or more properties (attributes) like Location, Name, Age, etc.
//- Give each of these things two or more methods (behavior) like Open, Fly, etc.
//    - At this point, your methods only need to Console.WriteLine sentences to represent the behavior.
//- Inside your `Main` method, create at least two instances of each of your favorite things.
//    - For instance, one of my favorite things are pets. My `Main` method might look like this.

//        ```csharp
//        var pickle = new Pet
//                     {
//                       Name = "Bitsy",
//                       Type = Pet.Cat, // <-- an enum called Pet
//                       Age = 2
//                     };
//var data = new Pet
//{
//  Name = "Data",
//  Type = Pet.Dog, // <-- an enum called Pet
//  Age = 1
//};
//        ```

//-Access each of your instantiated favorite things and print the
//attributes and behaviors to the console in any way you want. For
//example:

//    ```csharp
//    Console.WriteLine(data.Speak("feed me")); // Data says "bark bark"
//    ```
