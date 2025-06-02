namespace FoodGame.Grocerie;

public class GrocerieCache
{
    public static Grocerie[] AllGrocery =>
    [
        new Grocerie
    {

        Id = 1,  
        Name = "Salt",  
        Type = GrocerieType.Spices,
        Price = 50,  
        Quantity = 10,
        
        StoreId = 1
    },
       
        new Grocerie
        {
            Id = 99,
            Name = "Small knife",
            Type= GrocerieType.Knife,
            Price = 50,
            IsStarterItem = true,

        },
        new Grocerie
        {
            Id = 2,
            Name = "Small Wisp",
            Type= GrocerieType.Wisp,
            Price = 50,
            IsStarterItem = true,

        },
        new Grocerie
        {
            Id = 3,
            Name = "Spoon",
            Type= GrocerieType.Spoon,
            Price = 50,
            IsStarterItem = true,

        },
        new Grocerie
        {
            Id = 4,
            Name = "TeaSpoon",
            Type= GrocerieType.TeaSpoon,
            Price = 50,
            IsStarterItem = true,
        },
        new Grocerie
        {
            Id = 5,
            Name = "Rolling Pin",
            Type= GrocerieType.RollingPin,
            Price = 50,
            IsStarterItem = true,
        },
        new Grocerie
        {
            Id = 6,
            Name = "KitchenMashine",
            Type= GrocerieType.KitchenMashine,
            Price = 500,
        },
        //Italia resturant  
        new Grocerie { Id = 7,  Name = "Spaghetti",       Type = GrocerieType.Pasta, Price = 45, Quantity = 1, StoreId = 3 },
        new Grocerie { Id = 8,  Name = "Parmesan",        Type = GrocerieType.Dry,   Price = 60, Quantity = 1, StoreId = 3 },
        new Grocerie { Id = 9,  Name = "Tomato Sauce",    Type = GrocerieType.Dry,   Price = 40, Quantity = 1, StoreId = 3 },
        new Grocerie { Id = 10, Name = "Olive Oil",       Type = GrocerieType.Oil,   Price = 55, Quantity = 1, StoreId = 3 },
        new Grocerie { Id = 11, Name = "Garlic",          Type = GrocerieType.Spices,Price = 20, Quantity = 1, StoreId = 3 },
        new Grocerie { Id = 12, Name = "Basil",           Type = GrocerieType.Spices,Price = 25, Quantity = 1, StoreId = 3 },
        new Grocerie { Id = 13, Name = "Mozzarella",      Type = GrocerieType.Dry,   Price = 65, Quantity = 1, StoreId = 3 },
        new Grocerie { Id = 14, Name = "Lasagna Sheets",  Type = GrocerieType.Pasta, Price = 50, Quantity = 1, StoreId = 3 },
        new Grocerie { Id = 15, Name = "Ricotta Cheese",  Type = GrocerieType.Dry,   Price = 55, Quantity = 1, StoreId = 3 },
        new Grocerie { Id = 16, Name = "Prosciutto",      Type = GrocerieType.Dry,   Price = 70, Quantity = 1, StoreId = 3 },
        new Grocerie { Id = 17, Name = "Red Wine",      Type = GrocerieType.Alchohol,   Price = 100, Quantity = 1, StoreId = 3 },

       
        
        //American Meat store
        new Grocerie { Id = 100, Name = "Beef Steak", Type = GrocerieType.Dry, Price = 90, Quantity = 1, StoreId = 1 },
        new Grocerie { Id = 101, Name = "Chicken Breast", Type = GrocerieType.Dry, Price = 70, Quantity = 1, StoreId = 1 },
        new Grocerie { Id = 102, Name = "Bacon", Type = GrocerieType.Dry, Price = 60, Quantity = 1, StoreId = 1 },
        new Grocerie { Id = 103, Name = "Whiskey", Type = GrocerieType.Alchohol, Price = 100, Quantity = 1, StoreId = 1 },
        new Grocerie { Id = 104, Name = "Beer", Type = GrocerieType.Alchohol, Price = 50, Quantity = 1, StoreId = 1 },
        new Grocerie { Id = 29, Name = "Honey", Type = GrocerieType.Oil, Price = 50, Quantity = 1, StoreId = 1 },
        
        // HongKong
        
        new Grocerie { Id = 110, Name = "Bok Choy", Type = GrocerieType.Spices, Price = 25, Quantity = 1, StoreId = 2 },
        new Grocerie { Id = 111, Name = "Spring Onion", Type = GrocerieType.Spices, Price = 20, Quantity = 1, StoreId = 2 },
        new Grocerie { Id = 112, Name = "Soy Sauce", Type = GrocerieType.Alchohol, Price = 30, Quantity = 1, StoreId = 2 },
        new Grocerie { Id = 113, Name = "Ginger", Type = GrocerieType.Spices, Price = 15, Quantity = 1, StoreId = 2 },
        new Grocerie { Id = 114, Name = "Tofu", Type = GrocerieType.Dry, Price = 35, Quantity = 1, StoreId = 2 },
        
        // Fritz Bakery 
        new Grocerie { Id = 120, Name = "Flour", Type = GrocerieType.Dry, Price = 20, Quantity = 1, StoreId = 4 },
        new Grocerie { Id = 121, Name = "Rye Flour", Type = GrocerieType.Dry, Price = 25, Quantity = 1, StoreId = 4 },
        new Grocerie { Id = 122, Name = "Butter", Type = GrocerieType.Dry, Price = 30, Quantity = 1, StoreId = 4 },
        new Grocerie { Id = 123, Name = "Yeast", Type = GrocerieType.Dry, Price = 15, Quantity = 1, StoreId = 4 },
        new Grocerie { Id = 124, Name = "Baking Powder", Type = GrocerieType.Dry, Price = 10, Quantity = 1, StoreId = 4 },
        new Grocerie { Id = 125, Name = "Pizza Doug", Type = GrocerieType.Dry, Price = 10, Quantity = 1, StoreId = 4 },




        
        
    ];
}