using FoodGame.Grocerie;
using FoodGame.Kitchen;
using FoodGame.KitchenLogic;
using FoodGame.Store;

namespace FoodGame
{
    internal class Recipes
    {
    }
}

public class Game
{
    private Inventory _inventory = new Inventory();

    public void Start()
    {
        _inventory.AddStarterItems();

        while (true)
        {
            Console.WriteLine("\n--- Grocery Game ---");
            Console.WriteLine("1. Visit a Store");
            Console.WriteLine("2. Show Inventory");
            Console.WriteLine("3. Kitchen");
            Console.WriteLine("4. Exit");
            Console.Write("> ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    VisitStore();
                    break;
                case "2":
                    ShowInventory();
                    break;
                case "3":
                    var kitchen = new Kitchen(_inventory);
                    kitchen.Open();
                    break;

                case "4":
                    Console.WriteLine("Thanks for playing!");
                    return;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }

    private void ShowInventory()
    {
        Console.WriteLine("\nYour Inventory:");
        Console.WriteLine($"Gold: {_inventory.Gold} 🪙");

        if (_inventory.Groceries.Length == 0)
        {
            Console.WriteLine("You have no groceries.");
            return;
        }

        foreach (var item in _inventory.Groceries)
        {
            Console.WriteLine($"- {item.Name} ({item.Type})");
        }

        Console.WriteLine();
    }

    private Store? SelectStore()
    {
        while (true)
        {
            Console.WriteLine("Choose a store (or type 'back' to return):");

            for (int i = 0; i < StoreCache.AllStores.Length; i++)
            {
                var store = StoreCache.AllStores[i];
                Console.WriteLine($"{i + 1}. {store.Name} ");
            }

            Console.Write("> ");
            var input = Console.ReadLine()?.Trim().ToLower();

            if (input == "back") return null;

            if (int.TryParse(input, out int index) &&
                index >= 1 && index <= StoreCache.AllStores.Length)
            {
                return StoreCache.AllStores[index - 1];
            }

            Console.WriteLine("Invalid input. Try again.\n");
        }
    }


    private void VisitStore()
    {
        var store = SelectStore();
        if (store == null) return;

        Store.GetGroceries.ShowGroceriesForStore(store, _inventory);
    }
    private void ShowKitchen()
    {
        Console.WriteLine("\n--- Kitchen Recipes ---");

        foreach (var recipe in RecipeCache.AllRecipes)
        {
            Console.WriteLine($"\n {recipe.Name}  {recipe.Result}");
            Console.WriteLine("   Requires:");

            foreach (var id in recipe.RequiredGrocerieIds)
            {
                var grocerie = FoodGame.Grocerie.GrocerieCache.AllGrocery.FirstOrDefault(g => g.Id == id);
                if (grocerie != null)
                {
                    Console.WriteLine($"   - {grocerie.Name}");
                }
            }
        }

        Console.WriteLine("\n(Press enter to go back)");
        Console.ReadLine();
    }

}
