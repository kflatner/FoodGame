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
        //Italia resturant // 
        new Grocerie
        {
            Id = 7,
            Name = "Spaghetti",
            Type = GrocerieType.Pasta,
            Price = 45,
            Quantity = 1,
            StoreId = 3
        },
        new Grocerie
        {
            Id = 8,
            Name = "Parmesan",
            Type = GrocerieType.Dry,
            Price = 60,
            Quantity = 1,
            StoreId = 3
        },
        new Grocerie
        {
            Id = 9,
            Name = "Tomato Sauce",
            Type = GrocerieType.Dry,
            Price = 40,
            Quantity = 1,
            StoreId = 3
        },
        new Grocerie
        {
            Id = 10,
            Name = "Olive Oil",
            Type = GrocerieType.Oil, 
            Price = 55,
            Quantity = 1,
            StoreId = 3
        },
        new Grocerie
        {
            Id = 11,
            Name = "Garlic",
            Type = GrocerieType.Spices,
            Price = 20,
            Quantity = 1,
            StoreId = 3
        },
        new Grocerie
        {
            Id = 12,
            Name = "Basil",
            Type = GrocerieType.Spices,
            Price = 25,
            Quantity = 1,
            StoreId = 3
        },
        new Grocerie
        {
            Id = 13,
            Name = "Mozzarella",
            Type = GrocerieType.Dry,
            Price = 65,
            Quantity = 1,
            StoreId = 3
        },
        new Grocerie
        {
            Id = 14,
            Name = "Lasagna Sheets",
            Type = GrocerieType.Pasta,
            Price = 50,
            Quantity = 1,
            StoreId = 3
        },
        new Grocerie
        {
            Id = 15,
            Name = "Ricotta Cheese",
            Type = GrocerieType.Dry,
            Price = 55,
            Quantity = 1,
            StoreId = 3
        },
        new Grocerie
        {
            Id = 16,
            Name = "Prosciutto",
            Type = GrocerieType.Dry,
            Price = 70,
            Quantity = 1,
            StoreId = 3
        }

        
        
    ];
}