using ContosoPizzaComplete.Data;
using ContosoPizzaComplete.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

var products = context.Products
    .Where(p => p.Price > 500)
    .OrderBy(p => p.Name);

foreach (Product p in products)
{
    Console.WriteLine($"Id: {p.Id}");
    Console.WriteLine($"Name: {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}