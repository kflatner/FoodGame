using FoodGame.Grocerie;

namespace FoodGame.Kitchen;


    public class RecipeCache
    {
        public static List<Recipe> AllRecipes => new List<Recipe>
        {
            new Recipe
            {
                Id = 1,
                Name = "Pasta al Sale",
                RequiredGrocerieIds = new List<int> { 7, 9 },
                Result = "Basic Pasta Dish",
                ResultGrocerie = new Grocerie.Grocerie
                {
                    Id = 1001,
                    Name = "Basic Pasta Dish",
                    Type = GrocerieType.Dish,
                    Price = 0,
                    Quantity = 1,
                    StoreId = 0
                }
            }
        };

        }

