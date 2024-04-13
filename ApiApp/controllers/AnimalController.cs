using Microsoft.AspNetCore.Mvc;
using WebApplication1.interfaces;
using WebApplication1.models;

namespace WebApplication1.controllers;

[ApiController]
[Route("/animals")]
public class AnimalController(IAnimal animal) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(animal.GetAll());
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetOne(int id)
    {
        var animal1 = animal.GetOne(id);

        if (animal1 is null) return NotFound("Not found animal with this is id");

        return Ok(animal1);
    }

    [HttpPost]
    public IActionResult AddAnimal(Animal animal1)
    {
        animal.AddAnimal(animal1);
        return Created("Created", animal1);
    }
    
    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal theAnimal)
    {
        animal.UpdateAnimal(id, theAnimal);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        animal.DeleteAnimal(id);
        return NoContent();
    }
}