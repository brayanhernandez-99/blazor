using System.Globalization;
namespace BlazingPizza;

public class Topping
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public string GetFormattedPrice() => Price.ToString("N2", new CultureInfo("es-CO"));

}