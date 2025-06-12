using FoodGame;
using FoodGame.Grocerie;
using FoodGame.Station;
using FoodGame.Store;


namespace FoodGameConsole
{
    public class GameConsole(Game game)
    {
        public void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n--- Grocery Game ---");
                Console.WriteLine("1. Visit a Store");
                Console.WriteLine("2. Go to Station");
                Console.WriteLine("3. Exit");
                Console.Write("> ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        VisitStore();
                        break;
                    case "2":
                        VisitStation();
                        break;
                    case "3":
                        Console.WriteLine("Thanks for playing!");
                        return;
                    case "motherload":
                        game.AddAllIngredientsCheat();
                        Console.WriteLine("Cheat activated! All ingredients added. Press Enter to continue.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void VisitStore()
        {
            Console.Clear();
            Console.WriteLine("Choose a store (or 'back' to return):");

            var stores = StoreCache.AllStores;
            for (var i = 0; i < stores.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {stores[i].Name}");
            }

            Console.Write("> ");
            var input = Console.ReadLine()?.Trim().ToLower();

            if (input == "back") return;

            if (int.TryParse(input, out int index) && index >= 1 && index <= stores.Length)
            {
                var store = stores[index - 1];
                game.VisitShop(store);

                if (store.Type == StoreType.DishMerchant)
                {
                    store.Inventory ??= game.Inventory;
                    ShowDishMerchant(store,game.Inventory);
                }
                else
                {
                    ShowStoreInteraction(store,game.Inventory);
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
            }
        }

        private void ShowStoreInteraction(Store store, Inventory inventory)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"\nYou entered: {store.Name}");
                Console.WriteLine("Available groceries:");

                var groceries = store.Groceries;
                if (!groceries.Any())
                {
                    Console.WriteLine("This store currently has no items.");
                    Console.WriteLine("\nPress Enter to return...");
                    Console.ReadLine();
                    return;
                }

                for (int i = 0; i < groceries.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {groceries[i].Name}  cost: {groceries[i].Price} ");
                }

                Console.WriteLine("\nEnter the number to buy (or type 'back' to leave):");
                Console.Write("> ");
                var input = Console.ReadLine()?.Trim().ToLower();

                if (input == "back") return;

                if (int.TryParse(input, out int selectedIndex) &&
                    selectedIndex >= 1 && selectedIndex <= groceries.Count)
                {
                    var selected = groceries[selectedIndex - 1];
                    var item = store.Purchase(selected.Id); // Use the method here

                    if (item == null)
                    {
                        Console.WriteLine("Item not found in store.");
                        return;
                    }

                    if (inventory.Gold >= item.Price)
                    {
                        inventory.Gold -= item.Price;
                        inventory.AddGrocery(item);
                        Console.WriteLine($"You bought {item.Name}!");
                    }
                    else
                    {
                        Console.WriteLine("Not enough gold.");
                    }
                }
             

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

            }
        }

        public void ShowDishMerchant(Store store, Inventory gameInventory)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n--- Andrew, The Dish Merchant ---");

                
                var dishes = store.GetDishesToSell();

                if (!dishes.Any())
                {
                    Console.WriteLine("You have no dishes to sell.");
                    Console.WriteLine("\nPress Enter to return...");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Here are your dishes:");
                for (int i = 0; i < dishes.Count; i++)
                {
                    var dish = dishes[i];
                    decimal sellPrice = Store.GetSellPrice(dish);
                    Console.WriteLine($"{i + 1}. {dish.Name}  Sell Price: {sellPrice} ");
                }

                Console.WriteLine("\nEnter number to sell dish (or type 'back'):");
                Console.Write("> ");
                var input = Console.ReadLine()?.Trim().ToLower();

                if (input == "back") return;

                if (int.TryParse(input, out int index) && index >= 1 && index <= dishes.Count)
                {
                    var selected = dishes[index - 1];
                    store.SellDish(selected);
                    Console.WriteLine($"\nYou sold {selected.Name}!");

                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }




        private void VisitStation()
        {
            Console.Clear();
            Console.WriteLine("Choose a station (or 'back' to return):");

            for (int i = 0; i < StationCache.AllStations.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {StationCache.AllStations[i].Name} ({StationCache.AllStations[i].Type})");
            }

            Console.Write("> ");
            var input = Console.ReadLine()?.Trim().ToLower();

            if (input == "back") return; //repetisjon

            if (int.TryParse(input, out int index) && index >= 1 && index <= StationCache.AllStations.Length)
            {
                var station = StationCache.AllStations[index - 1];
                switch (station.Type)
                {
                    case StationType.Kitchen:
                        OpenKitchen();
                        break;
                    default:
                        Console.WriteLine("This station is not implemented yet.");
                        Console.ReadLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
            }
        }

        private void OpenKitchen()
        {
            var kitchen = game.GetKitchenStation();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n--- Kitchen ---");
                Console.WriteLine("1. View Recipes");
                Console.WriteLine("2. View Inventory");
                Console.WriteLine("3. Cook Dish");
                Console.WriteLine("4. Back");
                Console.Write("> ");
                var choice = Console.ReadLine()?.Trim().ToLower();

                switch (choice)
                {
                    case "1":
                        ShowAllRecipes();
                        break;
                    case "2":
                        ShowInventory(kitchen);
                        break;
                    case "3":
                        CookDish(kitchen);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }

        private static void ShowAllRecipes()
        {
            Console.Clear();
            Console.WriteLine("\n--- All Recipes ---");

            foreach (var recipe in RecipeCache.AllRecipes)
            {
                Console.WriteLine($"\n {recipe.Name} ");
                Console.WriteLine("   Requires:");
                foreach (var id in recipe.RequiredGrocerieIds)
                {
                    var g = GrocerieCache.AllGrocery.FirstOrDefault(g => g.Id == id);
                    if (g != null)
                        Console.WriteLine($"   - {g.Name}");
                }
            }

            Console.WriteLine("\n(Press Enter to go back)");
            Console.ReadLine();
        }

        private void ShowInventory(CraftingStation crafting) //usikker
        {
            var inventory = crafting.Inventory;
            Console.Clear();
            Console.WriteLine($"\nGold: {inventory.Gold} ");

            if (inventory.Groceries.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
            }
            else
            {
                foreach (var g in inventory.Groceries)
                {
                    Console.WriteLine($"- {g.Name} ({g.Type})");
                }
            }

            Console.WriteLine("\n(Press Enter to go back)");
            Console.ReadLine();
        }

        private void CookDish(CraftingStation crafting) //Har refactored 
        {
            var recipes = crafting.GetCraftableRecipes();
            if (!recipes.Any())
            {
                Console.WriteLine("\nYou don’t have ingredients for any recipes.");
                Console.ReadLine();
                return;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n--- Cookable Recipes ---");

                for (int i = 0; i < recipes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {recipes[i].Name}");
                }

                Console.WriteLine("\nEnter the number of the recipe to cook (or 'back'):");
                Console.Write("> ");
                var input = Console.ReadLine()?.Trim().ToLower();
                if (input == "back") return;

                if (int.TryParse(input, out int index) && index >= 1 && index <= recipes.Count)
                {
                    var selected = recipes[index - 1];

                    Console.Write("\nCooking");
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(300);
                        Console.Write(".");
                    }

                    Console.WriteLine(" Done!");

                    crafting.CookRecipe(selected);

                    Console.WriteLine($"You made: {selected.Result}! It has been added to your inventory.");
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    Thread.Sleep(1000);
                }
            }
           




        }
    }
}
            
        
    

    

    
    


        
    

        
    



