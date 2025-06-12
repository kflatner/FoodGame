using FoodGame.Grocerie;

namespace FoodGame.Station
{
    public class CraftingStation
    {
        private readonly Inventory inventory;

        public CraftingStation(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public Inventory Inventory => inventory;


        public List<Recipe> GetCraftableRecipes()
        {
            return RecipeCache.AllRecipes
                .Where(recipe => recipe.RequiredGrocerieIds
                    .All(id => Inventory.Groceries.Any(g => g.Id == id)))
                .ToList();
        }

        public bool CookRecipe(Recipe recipe)
        {
            if (!recipe.RequiredGrocerieIds.All(id => Inventory.Groceries.Any(g => g.Id == id)))
                return false;

            foreach (var id in recipe.RequiredGrocerieIds)
            {
                var itemToRemove = Inventory.Groceries.FirstOrDefault(g => g.Id == id);
                if (itemToRemove != null)
                {
                    Inventory.RemoveGrocery(itemToRemove);
                }
            }

            Inventory.AddBoughtGrocery(recipe.ResultGrocerie);
            return true;
        }
    }
}


