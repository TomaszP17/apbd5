using ApiApp.interfaces;
using ApiApp.models;

namespace ApiApp.db;


public class AnimalDb : IAnimal
{
    private static readonly ICollection<Animal> Animals = new List<Animal>
    {
        new (0,"Azor",
            "pies",
            5.5,
            "czarny"),
        new (1,"Chrupek",
            "kot",
            8.0,
            "czarno-bialy"),
        new (2, "Bartek",
            "żółw",
            15.2,
            "czerwony")
    };

    public ICollection<Animal> GetAll()
    {
        return Animals;
    }

    public Animal? GetOne(int id)
    {
        return Animals.FirstOrDefault(animal => animal.Id == id);
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public void UpdateAnimal(int id, Animal animal)
    {
        var theAnimal = Animals.FirstOrDefault(a => a.Id == id);
        if (theAnimal == null) return;
        Animals.Remove(theAnimal);
        Animals.Add(animal);
    }

    public void DeleteAnimal(int id)
    {
        var theAnimal = Animals.FirstOrDefault(a => a.Id == id);
        if (theAnimal != null)
        {
            Animals.Remove(theAnimal);
        }
    }
}