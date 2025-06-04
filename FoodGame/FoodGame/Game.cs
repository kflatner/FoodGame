using FoodGame.Grocerie;
using FoodGame.Store;
using Microsoft.VisualBasic;

namespace FoodGame
{
  

    public class Game
    {
        private readonly Inventory _inventory = new Inventory();

        public void Start()
        {
            _inventory.AddStarterItems();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n--- Food Game ---");
                Console.WriteLine("1. Visit a Store");
                Console.WriteLine("2. Kitchen");
                Console.WriteLine("3. Information");
                Console.WriteLine("4. Exit");
                Console.Write("> ");
                var input = Console.ReadLine();
                
                if (input == "motherload")
                {
                    AddAllIngredientsCheat();
                    Console.WriteLine(" Cheat activated! All ingredients added to your inventory.");
                    continue;
                }

                switch (input)
                {
                    case "1":
                        VisitStore();
                        break;
                    case "2":
                        var kitchen = new Kitchen.Kitchen(_inventory);
                        kitchen.Open();
                        break;
                    case "3":
                        Information();
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

  

        private object? SelectStoreOrMerchant()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose a store (or type 'back' to return):");

                for (int i = 0; i < StoreCache.AllStores.Length; i++)
                {
                    var store = StoreCache.AllStores[i];
                    Console.WriteLine($"{i + 1}. {store.Name}");
                }

                Console.WriteLine($"{StoreCache.AllStores.Length + 1}. Sell Dishes to Andrew, The Dish Merchant");

                Console.Write("> ");
                var input = Console.ReadLine()?.Trim().ToLower();

                if (input == "back") return null;

                if (int.TryParse(input, out int index))
                {
                    if (index >= 1 && index <= StoreCache.AllStores.Length)
                        return StoreCache.AllStores[index - 1];

                    if (index == StoreCache.AllStores.Length + 1)
                        return "merchant";
                }

                Console.WriteLine("Invalid input. Try again.\n");
            }
        }

        private void VisitStore()
        {
            Console.Clear();
            var selection = SelectStoreOrMerchant();
            if (selection == null) return;
            
           

            if (selection is string str && str == "merchant")
            {
                var merchant = new DishMerchant(_inventory);
                merchant.VisitMerchant();
            }
            else if (selection is Store.Store store)
            {
                Store.Store.GetGroceries.ShowGroceriesForStore(store, _inventory);

            }
        }

        private void Information()
        {
            Console.Clear();
            Console.WriteLine($"""
                                                   --- Information ---
                                                 
                                     Visit the different stores to buy unique ingredients.
                                     
                               Bring them all in the kitchen so you can make som wonderfull dishes
                               
                                        and sell it with profit to Andrew,The Merchant
                                        
                                                    Good luck,Chef!
                               """);
            Console.WriteLine("\n(Press Enter to go back)");
            Console.ReadLine();
        }
        private void AddAllIngredientsCheat()
        {
            foreach (var g in GrocerieCache.AllGrocery)
            {
                _inventory.AddGrocery(new Grocerie.Grocerie
                {
                    Id = g.Id,
                    Name = g.Name,
                    Type = g.Type,
                    Price = g.Price,
                    Quantity = g.Quantity,
                    StoreId = g.StoreId
                });
            }
        }

       
    }
}
