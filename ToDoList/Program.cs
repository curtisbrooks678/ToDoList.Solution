using System;
using ToDoList.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to the To Do List");
    Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");

    string response = Console.ReadLine().ToLower();

    if (response == "add") 
    {
      AddItem();
    }
    else if (response == "view")
    {
      ViewList();
    }
    else 
    {
      Console.WriteLine("Sorry, I didn't quite understand you.");
      Main();
    }
  }

  static void AddItem()
  {
    Console.WriteLine("Please enter an item");
    string description = Console.ReadLine();
    Item newItem = new Item(description);
    Main();
  }

  static void ViewList()
  {
    if (Item.GetAll().Count == 0) {
      Console.WriteLine("No items in list. Please add items.");
    }
    else 
    {
      int counter = 1;
      foreach (Item item in Item.GetAll())
      {
        Console.WriteLine(counter.ToString() + ". " + item.Description);
        counter++;
      }
    }
    Main();
  }
}