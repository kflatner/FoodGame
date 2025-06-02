namespace FoodGame.Grocerie;

public class Grocerie
{
    public int Id { get; set; }  
    public string Name { get; set; }  
    public GrocerieType Type { get; set; }  
    public int Price { get; set; }  
    public int Quantity { get; set; } 
    public bool IsStarterItem { get; set; } 
    public int StoreId { get; set; }
    
  
}