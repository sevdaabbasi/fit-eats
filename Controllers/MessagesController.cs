using ApiProje.API.Context;
using ApiProje.API.Dtos.MessageDtos;
using ApiProje.API.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiProje.API;

[Route("api/[controller]")]
[ApiController]

public class MessagesController : Controller
{
   private readonly IMapper _mapper;
   private readonly ApiContext _context;

   public MessagesController(IMapper mapper, ApiContext context)
   {
      _mapper = mapper;
      _context = context;
   }

   [HttpGet]
   public IActionResult MessageList()
   {
     var messageList = _context.Messages.ToList();
     return Ok(_mapper.Map<List<ResultMessageDto>>(messageList));
   }

   [HttpGet("{id}")]
   public IActionResult GetMessage(int id)
   {
       var message = _context.Messages.Find(id);
       return Ok(_mapper.Map<ResultMessageDto>(message));
   }

   [HttpPost]
   public IActionResult PostMessage(CreateMessageDto createMessageDto)
   {
       var message = _mapper.Map<Message>(createMessageDto);
       _context.Messages.Add(message);
       _context.SaveChanges();
       return Ok(_mapper.Map<ResultMessageDto>(message));
   }

   [HttpPut]
   public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
   {
       var message = _mapper.Map<Message>(updateMessageDto);
       _context.Messages.Update(message);
       _context.SaveChanges();
       return Ok(_mapper.Map<ResultMessageDto>(message));
   }

   [HttpDelete]
   public IActionResult DeleteMessage(int id)
   {
       var message = _context.Messages.Find(id);
       _context.Messages.Remove(message);
       _context.SaveChanges();
       return Ok(_mapper.Map<ResultMessageDto>(message));
   }
   
}