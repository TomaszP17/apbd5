namespace ApiApp.models;

public class Visit(String date, Animal animal, String description, double price)
{
    public String Date { get; set; } = date;
    public Animal Animal { get; set; } = animal;
    public String Description { get; set; } = description;
    public double Price { get; set; } = price;
}