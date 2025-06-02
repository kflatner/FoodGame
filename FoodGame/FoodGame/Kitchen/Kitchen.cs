using FoodGame.Grocerie;
using FoodGame.Kitchen;

namespace FoodGame.KitchenLogic
{
    public class Kitchen
    {
        private Inventory _inventory;

        public Kitchen(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void Open()
        {
            while (true)
            {
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
            Console.WriteLine("\n--- All Recipes ---");

            foreach (var recipe in RecipeCache.AllRecipes)
            {
                Console.WriteLine($"\n {recipe.Name} → {recipe.Result}");
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
            Console.WriteLine($"\nGold: {_inventory.Gold} 🪙");

            if (_inventory.Groceries.Length == 0)
            {
                Console.WriteLine("Inventory is empty.");
                Console.WriteLine("(Press Enter to go back)");
                Console.ReadLine();
                return;
            }

            foreach (var g in _inventory.Groceries)
            {
                Console.WriteLine($"- {g.Name} ({g.Type})");
            }

            Console.WriteLine("\n(Press Enter to go back)");
            Console.ReadLine();
        }

        private void CookDish()
        {
            var craftable = RecipeCache.AllRecipes
                .Where(recipe => recipe.RequiredGrocerieIds
                    .All(id => _inventory.Groceries.Any(g => g.Id == id)))
                .ToList();

            if (!craftable.Any())
            {
                Console.WriteLine("\nYou don’t have ingredients for any recipes.");
                return;
            }

            Console.WriteLine("\n--- Cookable Recipes ---");

            for (int i = 0; i < craftable.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {craftable[i].Name} → {craftable[i].Result}");
            }

            Console.WriteLine("\nEnter the number of the recipe to cook (or 'back'):");
            Console.Write("> ");
            var input = Console.ReadLine()?.Trim().ToLower();
            if (input == "back") return;

            if (int.TryParse(input, out int index) &&
                index >= 1 && index <= craftable.Count)
            {
                var selected = craftable[index - 1];

                
                var list = _inventory.Groceries.ToList();
                foreach (var id in selected.RequiredGrocerieIds)
                {
                    var itemToRemove = list.FirstOrDefault(g => g.Id == id);
                    if (itemToRemove != null) list.Remove(itemToRemove);
                }

                _inventory.Groceries = list.ToArray();

                
                _inventory.AddGrocery(selected.ResultGrocerie);

                Console.WriteLine($" You made: {selected.Result}! It has been added to your inventory.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
