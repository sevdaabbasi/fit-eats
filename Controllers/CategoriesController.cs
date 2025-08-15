using ApiProje.API.Context;
using ApiProje.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiProje.API;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : Controller
{
    private readonly ApiContext _context;
    
    public CategoriesController(ApiContext context)
    {
        _context = context;
    }
    
    
    [HttpGet]
    public IActionResult CategoryList()
    {
        var values = _context.Categories.ToList();
        return Ok(values);
    } 

    [HttpPost]
    public IActionResult CreateCategory(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
        return Ok("Kategori eklendi");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id)
    {
        var category = _context.Categories.Find(id); 
        _context.Categories.Remove(category);
        _context.SaveChanges();
        return Ok("Kategori silindi");
    }

    [HttpGet("{id}")]
    public IActionResult GetCategory(int id)
    {
        var category = _context.Categories.Find(id);
        return Ok(category);
    }

    [HttpPut]
    public IActionResult UpdateCategory(Category category)
    {
        _context.Categories.Update(category);
        _context.SaveChanges();
        return Ok("Kategori güncellendi");
    }
}