using ApiApp.models;

namespace ApiApp.interfaces;

public interface IAnimal
{
    public ICollection<Animal> GetAll();
    public Animal? GetOne(int id);
    public void AddAnimal(Animal animal);
    public void UpdateAnimal(int id, Animal animal);
    public void DeleteAnimal(int id);
}