using FoodGame.Grocerie;
using FoodGame.Kitchen;

namespace FoodGame.Store
{
    public class DishMerchant(Inventory inventory)
    {
        public void VisitMerchant()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n--- Andrew, The Dish Merchant ---");

                var dishes = inventory.Groceries
                    .Where(g => g.Type == GrocerieType.Dish)
                    .ToList();

                if (!dishes.Any())
                {
                    Console.WriteLine("You have no dishes to sell.");
                    return;
                }

                Console.WriteLine("Here are your dishes:");
                for (int i = 0; i < dishes.Count; i++)
                {
                    var dish = dishes[i];
                    var recipe = RecipeCache.AllRecipes.FirstOrDefault(r => r.ResultGrocerie.Name == dish.Name);
                    decimal sellPrice = recipe?.CalculateSellPrice(GrocerieCache.AllGrocery.ToList()) ?? 0;
                    Console.WriteLine($"{i + 1}. {dish.Name} - Sell Price: {sellPrice} ");
                }

                Console.WriteLine("Type number to sell, or 'back' to exit:");
                Console.Write("> ");
                var input = Console.ReadLine()?.Trim().ToLower();

                if (input == "back") return;

                if (int.TryParse(input, out int index) && index >= 1 && index <= dishes.Count)
                {
                    var selected = dishes[index - 1];
                    var recipe = RecipeCache.AllRecipes.FirstOrDefault(r => r.ResultGrocerie.Name == selected.Name);
                    decimal sellPrice = recipe?.CalculateSellPrice(GrocerieCache.AllGrocery.ToList()) ?? 0;

                    inventory.Gold += (int)sellPrice;
                    inventory.RemoveGrocery(selected);


                    Console.WriteLine($"You sold {selected.Name} for {sellPrice}!");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}