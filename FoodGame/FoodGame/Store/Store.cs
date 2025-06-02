using FoodGame.Grocerie;

namespace FoodGame.Store;

public class Store
{
    public int Id { get; set; }
    public string Name { get; set; }
    public StoreType Type { get; set; }

    public class GetGroceries
    {
        public static void ShowGroceriesForStore(Store store, Inventory inventory)
        {
            Console.WriteLine($"\nYou selected: {store.Name}");
            Console.WriteLine("Available groceries:");

            var groceriesInStore = GrocerieCache.AllGrocery
                .Where(g => g.StoreId == store.Id)
                .ToList();

            if (!groceriesInStore.Any())
            {
                Console.WriteLine("This store currently has no items.");
                return;
            }

            for (int i = 0; i < groceriesInStore.Count; i++)
            {
                var g = groceriesInStore[i];
                Console.WriteLine($"{i + 1}. {g.Name}  - cost: {g.Price}");
            }

            Console.WriteLine("\nEnter the number of the grocery you'd like to buy (or type 'back' to return):");
            Console.Write("> ");
            var input = Console.ReadLine()?.Trim().ToLower();

            if (input == "back") return;

            if (int.TryParse(input, out int index) &&
                index >= 1 && index <= groceriesInStore.Count)
            {
                var selected = groceriesInStore[index - 1];

                if (inventory.Gold >= selected.Price)
                {
                    inventory.Gold -= selected.Price;
                    inventory.AddGrocery(selected);
                    Console.WriteLine($" You bought {selected.Name}! Remaining gold: {inventory.Gold}");
                }
                else
                {
                    Console.WriteLine(" You can't afford that item.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}




