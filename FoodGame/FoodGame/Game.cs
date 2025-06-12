using FoodGame.Grocerie;
using FoodGame.Station;


namespace FoodGame
{
    public class Game
    {
       
        public Inventory Inventory { get; private set; }
        public Store.Store CurrentStore { get; private set; }
        
        

        public Game()
        {
            
            Inventory = new Inventory();
            Inventory.AddStarterItems();

        }
        
        public void VisitShop(Store.Store store)
        {
            CurrentStore = store; 
        }


        public CraftingStation GetKitchenStation()
        {
            return new CraftingStation(Inventory);
        }

        public void AddAllIngredientsCheat()
        {
            foreach (var g in GrocerieCache.AllGrocery)
            {
                Inventory.AddGrocery(new Grocerie.Grocerie
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
        


       


       

        

