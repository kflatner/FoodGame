
namespace FoodGame.Kitchen
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> RequiredGrocerieIds { get; set; } = new();
        public string Result { get; set; }
        public Grocerie.Grocerie ResultGrocerie { get; set; } 
    }
}
