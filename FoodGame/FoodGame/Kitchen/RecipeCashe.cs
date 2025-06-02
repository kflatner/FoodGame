using FoodGame.Grocerie;

namespace FoodGame.Kitchen;


public class RecipeCache
{
    public static List<Recipe> AllRecipes => new List<Recipe>
    {
        //Italian
        new Recipe
        {
            Id = 1,
            Name = "Pasta al Sale",
            RequiredGrocerieIds = new List<int> { 7, 9 },
            Result = "Basic Pasta Dish",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 2000,
                Name = "Basic Pasta Dish",
                Type = GrocerieType.Dish,
                Price = 0,
                Quantity = 1,
                StoreId = 0
            }
        },
        new Recipe
        {
            Id = 2,
            Name = "Spaghetti al Pomodoro",
            RequiredGrocerieIds = new List<int> { 7, 9, 11, 12 }, // Spaghetti, Tomato Sauce, Garlic, Basil
            Result = "Spaghetti al Pomodoro",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 2001,
                Name = "Spaghetti al Pomodoro",
                Type = GrocerieType.Dish,
                Price = 0,
                Quantity = 1,
                StoreId = 0
            }
        },
        new Recipe
        {
            Id = 3,
            Name = "Lasagna Tradizionale",
            RequiredGrocerieIds = new List<int> { 14, 9, 13, 15 }, // Lasagna Sheets, Tomato Sauce, Mozzarella, Ricotta
            Result = "Lasagna Tradizionale",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 2002,
                Name = "Lasagna Tradizionale",
                Type = GrocerieType.Dish,
                Price = 0,
                Quantity = 1,
                StoreId = 0
            }
        },
        new Recipe
        {
            Id = 4,
            Name = "Pasta con Aglio e Olio",
            RequiredGrocerieIds = new List<int> { 7, 10, 11 }, // Spaghetti, Olive Oil, Garlic
            Result = "Pasta con Aglio e Olio",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 2003,
                Name = "Pasta con Aglio e Olio",
                Type = GrocerieType.Dish,
                Price = 0,
                Quantity = 1,
                StoreId = 0
            }
        },
        new Recipe
        {
            Id = 501,
            Name = "Spicy Stir-Fry Bowl",
            RequiredGrocerieIds = new List<int> { 110, 111, 112, 113 }, // Bok Choy, Spring Onion, Soy Sauce, Ginger
            Result = "Spicy Stir-Fry Bowl",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6001,
                Name = "Spicy Stir-Fry Bowl",
                Type = GrocerieType.Dish,
                Price = 0,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 502,
            Name = "Garlic Butter Pasta",
            RequiredGrocerieIds = new List<int> { 7, 11, 29 }, // Spaghetti, Garlic, Butter
            Result = "Garlic Butter Pasta",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6002,
                Name = "Garlic Butter Pasta",
                Type = GrocerieType.Dish,
                Price = 0,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 503,
            Name = "Rib & Red Wine Plate",
            RequiredGrocerieIds = new List<int> { 36, 17 }, 
            Result = "Rib & Red Wine Plate",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6003,
                Name = "Rib & Red Wine Plate",
                Type = GrocerieType.Dish,
                Price = 0,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 504,
            Name = "Chicken Chow Mein",
            RequiredGrocerieIds = new List<int> { 27, 110, 111, 112 }, // Chicken, Bok Choy, Spring Onion, Soy Sauce
            Result = "Chicken Chow Mein",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6004,
                Name = "Chicken Chow Mein",
                Type = GrocerieType.Dish,
                Price = 0,
                Quantity = 1,
                StoreId = 0
            }
        },
        new Recipe
        {
            Id = 510,
            Name = "Beef & Basil Pizza",
            RequiredGrocerieIds = new List<int> { 125, 100, 12 },
            Result = "Beef & Basil Pizza",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6010,
                Name = "Beef & Basil Pizza",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 511,
            Name = "Mozzarella Chicken Bake",
            RequiredGrocerieIds = new List<int> { 13, 27, 28 },
            Result = "Mozzarella Chicken Bake",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6011,
                Name = "Mozzarella Chicken Bake",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 512,
            Name = "Garlic Soy Noodles",
            RequiredGrocerieIds = new List<int> { 7, 112, 11 },
            Result = "Garlic Soy Noodles",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6012,
                Name = "Garlic Soy Noodles",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 513,
            Name = "BBQ Ribs with Beans",
            RequiredGrocerieIds = new List<int> { 36, 35, 103 },
            Result = "BBQ Ribs with Beans",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6013,
                Name = "BBQ Ribs with Beans",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 514,
            Name = "Ricotta Pancakes",
            RequiredGrocerieIds = new List<int> { 15, 24, 25 },
            Result = "Ricotta Pancakes",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6014,
                Name = "Ricotta Pancakes",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 515,
            Name = "Fried Tofu Sandwich",
            RequiredGrocerieIds = new List<int> { 114, 21, 23 },
            Result = "Fried Tofu Sandwich",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6015,
                Name = "Fried Tofu Sandwich",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 516,
            Name = "Meatball Lasagna",
            RequiredGrocerieIds = new List<int> { 14, 34, 8 },
            Result = "Meatball Lasagna",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6016,
                Name = "Meatball Lasagna",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 517,
            Name = "Classic Pepperoni Pizza",
            RequiredGrocerieIds = new List<int> { 125, 13, 16 },
            Result = "Classic Pepperoni Pizza",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6017,
                Name = "Classic Pepperoni Pizza",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 518,
            Name = "Cheesy Tofu Pasta",
            RequiredGrocerieIds = new List<int> { 114, 8, 7 },
            Result = "Cheesy Tofu Pasta",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6018,
                Name = "Cheesy Tofu Pasta",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 519,
            Name = "Soy Chicken Stir Fry",
            RequiredGrocerieIds = new List<int> { 27, 112, 111 },
            Result = "Soy Chicken Stir Fry",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6019,
                Name = "Soy Chicken Stir Fry",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 520,
            Name = "Ginger Garlic Steak",
            RequiredGrocerieIds = new List<int> { 30, 11, 113 },
            Result = "Ginger Garlic Steak",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6020,
                Name = "Ginger Garlic Steak",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 521,
            Name = "Parmesan Crust Buns",
            RequiredGrocerieIds = new List<int> { 21, 8, 29 },
            Result = "Parmesan Crust Buns",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6021,
                Name = "Parmesan Crust Buns",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 522,
            Name = "Basil Tofu Bake",
            RequiredGrocerieIds = new List<int> { 114, 12, 13 },
            Result = "Basil Tofu Bake",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6022,
                Name = "Basil Tofu Bake",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 523,
            Name = "Spaghetti & Beans",
            RequiredGrocerieIds = new List<int> { 7, 35, 9 },
            Result = "Spaghetti & Beans",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6023,
                Name = "Spaghetti & Beans",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 524,
            Name = "Chicken Parmesan Pizza",
            RequiredGrocerieIds = new List<int> { 27, 13, 125, 9 },
            Result = "Chicken Parmesan Pizza",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6024,
                Name = "Chicken Parmesan Pizza",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 525,
            Name = "Spring Veg Pizza",
            RequiredGrocerieIds = new List<int> { 125, 111, 12 },
            Result = "Spring Veg Pizza",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6025,
                Name = "Spring Veg Pizza",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 526,
            Name = "Egg Fried Rice (Mock)",
            RequiredGrocerieIds = new List<int> { 24, 25, 112, 111 },
            Result = "Egg Fried Rice (Mock)",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6026,
                Name = "Egg Fried Rice (Mock)",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 527,
            Name = "Steak Lasagna",
            RequiredGrocerieIds = new List<int> { 30, 14, 11 },
            Result = "Steak Lasagna",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6027,
                Name = "Steak Lasagna",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 528,
            Name = "Spicy Meat Pizza",
            RequiredGrocerieIds = new List<int> { 34, 9, 125, 11 },
            Result = "Spicy Meat Pizza",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6028,
                Name = "Spicy Meat Pizza",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 529,
            Name = "Honey Glazed Bacon Buns",
            RequiredGrocerieIds = new List<int> { 102, 125, 29 },
            Result = "Honey Glazed Bacon Buns",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6029,
                Name = "Honey Glazed Bacon Buns",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        },

        new Recipe
        {
            Id = 530,
            Name = "Pizza Bianca",
            RequiredGrocerieIds = new List<int> { 125, 15, 10 },
            Result = "Pizza Bianca",
            ResultGrocerie = new Grocerie.Grocerie
            {
                Id = 6030,
                Name = "Pizza Bianca",
                Type = GrocerieType.Dish,
                Quantity = 1,
                StoreId = 0
            }
        }
    };


}



            



            
        

        

