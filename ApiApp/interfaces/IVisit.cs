using ApiApp.models;

namespace ApiApp.interfaces;

public interface IVisit
{
    public ICollection<Visit> GetAnimalVisits(int animalId);
    public void AddVisit(Visit visit);
}