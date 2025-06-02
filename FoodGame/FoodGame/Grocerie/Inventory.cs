using System.Collections;

namespace FoodGame.Grocerie;

public class Inventory
{
    public int Gold { get; set; }
    
    
    
    
    public Grocerie[] Groceries { get; set; }

    public void AddStarterItems()
    {
        Gold = 1000;
        Groceries = GrocerieCache.AllGrocery.Where(item => item.IsStarterItem).ToArray();
    }

    public void AddGrocery(Grocerie grocerie)
    {
        var groceries = Groceries.ToList(); 
        groceries.Add(grocerie);            
        Groceries = groceries.ToArray();     
    }
    
}

