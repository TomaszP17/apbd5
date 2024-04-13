using Microsoft.AspNetCore.Mvc;
using WebApplication1.interfaces;
using WebApplication1.models;

namespace WebApplication1.controllers;

[ApiController]
[Route("/visits")]
public class VisitController(IVisit visit) : ControllerBase
{
    [HttpGet("{animalId:int}")]
    public IActionResult GetAnimalVisits(int animalId)
    {
        if (visit.GetAnimalVisits(animalId).Count == 0)
            return NotFound("Not found any visits for this animal");
        return Ok(visit.GetAnimalVisits(animalId));
    }
    
    [HttpPost]
    public IActionResult AddVisit(Visit visit1)
    {
        visit.AddVisit(visit1);
        return Created("Created", visit1);
    }
}