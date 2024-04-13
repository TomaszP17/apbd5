namespace ApiApp.models;

public class Animal(int id, string name, string category, double weight, string colour)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Category { get; set; } = category;
    public double Weight { get; set; } = weight;
    public string Colour { get; set; } = colour;
}