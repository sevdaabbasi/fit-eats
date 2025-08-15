using ApiProje.API.Context;
using ApiProje.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiProje.API;

[Route("api/[controller]")]
[ApiController]

public class ChefsController : Controller
{
 private readonly ApiContext _context;

 public ChefsController(ApiContext context)
 {
  _context = context;
 }


 [HttpGet]
 public IActionResult ChefList()
 {
  var list = _context.Chefs.ToList();
  return Ok(list);
 }
 
 [HttpPost]
 public IActionResult CreateChef(Chef chef)
 {
  _context.Chefs.Add(chef);
  _context.SaveChanges();
  return Ok("Şef eklendi");
 }

 [HttpDelete("{id}")]
 public IActionResult DeleteChef(int id)
 {
  var chef = _context.Chefs.Find(id);
  _context.Chefs.Remove(chef);
  _context.SaveChanges();
  return Ok("Şef silindi");
 }

 [HttpPut]
 public IActionResult UpdateChef(Chef chef)
 {
  _context.Chefs.Update(chef);
  _context.SaveChanges();
  return Ok("Şef güncellendi");
 }

 [HttpGet("{id}")]
 public IActionResult GetChef(int id)
 {
  //var chef = _context.Chefs.Find(id);
  //return Ok(chef); // tek satırda yapabilirz
  return Ok(_context.Chefs.Find(id));
 }
 
}