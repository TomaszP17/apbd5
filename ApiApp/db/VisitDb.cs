using ApiApp.interfaces;
using ApiApp.models;

namespace ApiApp.db;

public class VisitDb : IVisit
{
    private static readonly List<Visit> Visits = new()
    {
        new Visit("2021-01-01",
            new Animal(1,"Azor", "pies", 5.5, "czarny"),
            "badanie",
            100.0),
        new Visit("2021-01-01",
            new Animal(1,"Azor", "pies", 5.5, "czarny"),
            "czy ty widzisz ten kafelek?",
            100.0),
        new Visit("2021-01-02",
            new Animal(2,"papiez", "wiedzial", 5.5, "bialy"),
            "szczepienie",
            50.0),
        new Visit( "2021-01-03",
            new Animal(3,"gagri", "gagri", 8.0, "zielony"),
            "badanie",
            100.0),
        new Visit( "2021-01-04",
            new Animal(4,"kowalski", "pingwin", 8.0, "czarno-bialy"),
            "kastracja",
            50.0)
    };
    
    public ICollection<Visit> GetAnimalVisits(int animalId)
    {
        return Visits.Where(visit => visit.Animal.Id == animalId).ToList();
    }
    
    public void AddVisit(Visit visit)
    {
        Visits.Add(visit);
    }
}