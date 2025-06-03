namespace BlazingPizza.Server;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        // Lista de ingredientes (toppings)
        var toppings = new Topping[]
        {
            new Topping() { Name = "Queso extra", Price = 2350.50m },
            new Topping() { Name = "Tocino americano", Price = 5890.75m },
            new Topping() { Name = "Tocino británico", Price = 5990.99m },
            new Topping() { Name = "Tocino canadiense", Price = 6125.30m },
            new Topping() { Name = "Té y panecillos ingleses", Price = 8999.99m },
            new Topping() { Name = "Panecillos recién horneados", Price = 8750.60m },
            new Topping() { Name = "Pimientos", Price = 2100.25m },
            new Topping() { Name = "Cebollas", Price = 2050.00m },
            new Topping() { Name = "Champiñones", Price = 2200.75m },
            new Topping() { Name = "Pepperoni", Price = 2550.50m },
            new Topping() { Name = "Salchicha de pato", Price = 6350.10m },
            new Topping() { Name = "Albóndigas de venado", Price = 5800.90m },
            new Topping() { Name = "Servido en bandeja de plata", Price = 925000.99m },
            new Topping() { Name = "Langosta encima", Price = 248999.50m },
            new Topping() { Name = "Caviar de esturión", Price = 399999.99m },
            new Topping() { Name = "Corazones de alcachofa", Price = 5180.60m },
            new Topping() { Name = "Tomates frescos", Price = 3050.20m },
            new Topping() { Name = "Albahaca", Price = 3120.40m },
            new Topping() { Name = "Carne asada (término medio)", Price = 11990.00m },
            new Topping() { Name = "Pimientos muy picantes", Price = 6120.25m },
            new Topping() { Name = "Pollo estilo búfalo", Price = 9475.80m },
            new Topping() { Name = "Queso azul", Price = 4650.50m },
        };


        // Lista de pizzas especiales
        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial()
            {
                Name = "Pizza básica de queso",
                Description = "Es con queso y deliciosa. ¿Por qué no querrías una?",
                BasePrice = 18990.50m,
                ImageUrl = "img/pizzas/cheese.jpg",
            },
            new PizzaSpecial()
            {
                Id = 2,
                Name = "La Tocinatorizadora",
                Description = "Tiene TODO tipo de tocino",
                BasePrice = 23450.99m,
                ImageUrl = "img/pizzas/bacon.jpg",
            },
            new PizzaSpecial()
            {
                Id = 3,
                Name = "Pepperoni clásico",
                Description = "Es la pizza con la que creciste, ¡pero al estilo Blazing!",
                BasePrice = 21000.75m,
                ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new PizzaSpecial()
            {
                Id = 4,
                Name = "Pollo estilo búfalo",
                Description = "Pollo picante, salsa caliente y queso azul, ¡garantizado para calentarte!",
                BasePrice = 25500.80m,
                ImageUrl = "img/pizzas/meaty.jpg",
            },
            new PizzaSpecial()
            {
                Id = 5,
                Name = "Amantes de los champiñones",
                Description = "Tiene champiñones. ¿No es obvio?",
                BasePrice = 21990.00m,
                ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new PizzaSpecial()
            {
                Id = 6,
                Name = "El Británico",
                Description = "Cuando estás en Londres...",
                BasePrice = 20500.60m,
                ImageUrl = "img/pizzas/brit.jpg",
            },
            new PizzaSpecial()
            {
                Id = 7,
                Name = "Delicia vegetariana",
                Description = "Es como una ensalada, pero en pizza",
                BasePrice = 22599.45m,
                ImageUrl = "img/pizzas/salad.jpg",
            },
            new PizzaSpecial()
            {
                Id = 8,
                Name = "Margarita",
                Description = "Pizza italiana tradicional con tomate y albahaca",
                BasePrice = 18999.90m,
                ImageUrl = "img/pizzas/margherita.jpg",
            },
            new PizzaSpecial()
            {
                Id = 9,
                Name = "Brayan Pizza",
                Description = "Pizza italiana tradicional con tomate y albahaca",
                BasePrice = 18999.90m,
                ImageUrl = "img/pizzas/cheese.jpg",
            },
         };

        db.Toppings.AddRange(toppings);
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}
