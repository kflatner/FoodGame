namespace FoodGame.Store;

public class StoreCache
{
    public static Store[] AllStores =>
    [
        new Store
        {
            Id = 1,  
            Name = "Big Bernies Meat, Honey and Alcohol",  
            Type = StoreType.AmericanShop
        },
        new Store
        {
        Id = 2,  
        Name = "Hong Kong Groceries",  
        Type = StoreType.AsianShop
        },
        new Store
        {
        Id = 3,  
        Name = "Paulas Pasta",  
        Type = StoreType.ItalianShop
        },
        new Store
        {
            Id = 4,
            Name = "Fritz Bakery",
            Type = StoreType.BakeryShop
        },
    
        

           
       
        
        
    ];
}