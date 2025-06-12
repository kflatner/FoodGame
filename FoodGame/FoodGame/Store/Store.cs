

using FoodGame.Grocerie;
using FoodGame.Station;

namespace FoodGame.Store;



    public class Store
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public StoreType Type { get; set; }
        public Inventory Inventory { get; set; }
        public List<Grocerie.Grocerie> Groceries
        {
            get { return GrocerieCache.AllGrocery
                .Where(g => g.StoreId == Id)
                .ToList(); }
        }


    

    public  List<Grocerie.Grocerie> GetDishesToSell()
    {
        return Inventory.Groceries
            .Where(g => g.Type == GrocerieType.Dish)
            .ToList();
    }

    // public  bool TryPurchase() //mye makt
    // {
    //     if (inventory.Gold >= item.Price)
    //     {
    //         inventory.Gold -= item.Price;
    //         inventory.AddGrocery(item);
    //         return true;
    //     }
    //
    //     return false;
    // }

    public Grocerie.Grocerie Purchase(int id)
    {
        
        return Groceries.FirstOrDefault(x=>x.Id==id);
    }
   


    public static decimal GetSellPrice(Grocerie.Grocerie dish)
    {
        var recipe = RecipeCache.AllRecipes.FirstOrDefault(r => r.ResultGrocerie.Name == dish.Name);
        return recipe?.CalculateSellPrice(GrocerieCache.AllGrocery.ToList()) ?? 0;
    }

    public void SellDish(Grocerie.Grocerie dish)
    {
        var price = GetSellPrice(dish);
        Inventory.Gold += (int)price;
        Inventory.RemoveGrocery(dish);
    }
}
    


    



