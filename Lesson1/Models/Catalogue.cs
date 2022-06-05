namespace Lesson1.Models;

public class Catalogue
{
    public List<Category>? Categories { get; set; } = new();
    public List<Product>? Products { get; set; } = new();
}