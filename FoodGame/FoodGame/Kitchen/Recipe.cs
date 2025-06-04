
namespace FoodGame.Kitchen
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<int> RequiredGrocerieIds { get; set; } = new List<int>();
        public string Result { get; set; } = string.Empty;
        public Grocerie.Grocerie ResultGrocerie { get; set; } = new Grocerie.Grocerie();

        public decimal CalculateSellPrice(List<Grocerie.Grocerie> allGroceries)
        {
            decimal totalCost = 0;
            foreach (var id in RequiredGrocerieIds)
            {
                var item = allGroceries.FirstOrDefault(g => g.Id == id);
                if (item != null)
                    totalCost += item.Price;
            }

            return Math.Round(totalCost * 1.2m);
        }
    }
}


