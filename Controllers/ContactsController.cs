using ApiProje.API.Context;
using Microsoft.AspNetCore.Mvc;

namespace ApiProje.API;

[Route("api/[controller]")]
[ApiController]

public class ContactsController : Controller
{
   private readonly ApiContext _context;

   public ContactsController(ApiContext context)
   {
      _context = context;
   }
}