namespace BlazorAppXyci6.Components.Models;

public class PizzaIngredient
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public bool IsSelected { get; set; }
    
    public string Emoji { get; set; } = "🍕"; 
}