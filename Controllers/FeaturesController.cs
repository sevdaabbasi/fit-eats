using ApiProje.API.Context;
using ApiProje.API.Dtos.FeatureDtos;
using ApiProje.API.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiProje.API;

[Route("api/[controller]")]
[ApiController]

public class FeaturesController : Controller
{
   private readonly ApiContext _context;
   private readonly IMapper _mapper;

   public FeaturesController(ApiContext context, IMapper mapper)
   {
      _context = context;
      _mapper = mapper;
   }

   [HttpGet]
   public IActionResult FeatureList()
   {
      var features = _context.Features.ToList();
      return Ok(_mapper.Map<List<ResultFeatureDto>>(features));
   }

   [HttpPost]
   public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
   {
      var feature = _mapper.Map<Feature>(createFeatureDto);
      _context.Features.Add(feature);
      _context.SaveChanges();
      return Ok(_mapper.Map<ResultFeatureDto>(feature));
   }

   [HttpDelete]
   public IActionResult DeleteFeature(int id)
   {
      var feature = _context.Features.Find(id);
      _context.Features.Remove(feature);
      _context.SaveChanges();
      return Ok(_mapper.Map<ResultFeatureDto>(feature));
   }

   [HttpGet("{id}")]
   public IActionResult GetFeature(int id)
   {
      var feature = _context.Features.Find(id);
      return Ok(_mapper.Map<ResultFeatureDto>(feature));
   }

   [HttpPut]
   public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
   {
      var feature = _mapper.Map<Feature>(updateFeatureDto);
      _context.Features.Update(feature);
      _context.SaveChanges();
      return Ok(_mapper.Map<ResultFeatureDto>(feature));
   }

}