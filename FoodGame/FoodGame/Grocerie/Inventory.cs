namespace FoodGame.Grocerie
{
    public class Inventory
    {
        public int Gold { get; set; }

        public List<Grocerie> Groceries { get; set; } = new List<Grocerie>();

        public void AddStarterItems()
        {
            Gold = 1000;
            Groceries = GrocerieCache.AllGrocery.Where(item => item.IsStarterItem).ToList();
        }

        public void AddBoughtGrocery(Grocerie grocerie)
        {
            Groceries.Add(grocerie);
        }

        public void RemoveGrocery(Grocerie grocerie)
        {
            Groceries.Remove(grocerie);
        }

        public void AddGrocery(Grocerie grocerie)
        {
            Groceries.Add(grocerie);
        }
    }
}
    

