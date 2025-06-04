using FoodGame.Grocerie;

namespace FoodGame.Kitchen
{
    public class Kitchen(Inventory inventory)
    {
        public void Open()
        {
            
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
                        ShowInventory();
                        break;
                    case "3":
                        CookDish();
                        break;
                    case "4":
                    case "back":
                        return;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }

        private void ShowAllRecipes()
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

        private void ShowInventory()
        {
            Console.Clear();
            Console.WriteLine($"\nGold: {inventory.Gold} ");

            if (inventory.Groceries.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                Console.WriteLine("(Press Enter to go back)");
                Console.ReadLine();
                return;
            }

            foreach (var g in inventory.Groceries)
            {
                Console.WriteLine($"- {g.Name} )");
            }

            Console.WriteLine("\n(Press Enter to go back)");
            Console.ReadLine();
        }

        private void CookDish()
        {
            while (true)
            {
                var craftable = RecipeCache.AllRecipes
                    .Where(recipe => recipe.RequiredGrocerieIds
                        .All(id => inventory.Groceries.Any(g => g.Id == id)))
                    .ToList();

                if (!craftable.Any())
                {
                    Console.WriteLine("\nYou don’t have ingredients for any recipes.");
                    return;
                }

                Console.Clear();
                Console.WriteLine("\n--- Cookable Recipes ---");

                for (int i = 0; i < craftable.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {craftable[i].Name} ");
                }

                Console.WriteLine("\nEnter the number of the recipe to cook (or 'back'):");
                Console.Write("> ");
                var input = Console.ReadLine()?.Trim().ToLower();
                if (input == "back") return;

                if (int.TryParse(input, out int index) && index >= 1 && index <= craftable.Count)
                {
                    var selected = craftable[index - 1];

                    foreach (var id in selected.RequiredGrocerieIds)
                    {
                        var itemToRemove = inventory.Groceries.FirstOrDefault(g => g.Id == id);
                        if (itemToRemove != null)
                        {
                            inventory.RemoveGrocery(itemToRemove);
                        }
                    }

                    Console.Write("\nCooking");
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(300);
                        Console.Write(".");
                    }
                    Console.WriteLine(" Done!");

                    inventory.AddBoughtGrocery(selected.ResultGrocerie);
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


