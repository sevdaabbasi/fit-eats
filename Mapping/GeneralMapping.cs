using ApiProje.API.Dtos.ContactDtos;
using ApiProje.API.Dtos.FeatureDtos;
using ApiProje.API.Entities;
using AutoMapper;

namespace ApiProje.API.Mapping;

public class GeneralMapping: Profile
{
    public GeneralMapping()
    {
        CreateMap<Feature, ResultFeatureDto>().ReverseMap();
        CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();
        CreateMap<Feature, CreateFeatureDto>().ReverseMap();
        CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
        
        CreateMap<Contact, ResultContactDto>().ReverseMap();
        CreateMap<Contact, CreateContactDto>().ReverseMap();
        CreateMap<Contact, UpdateContactDto>().ReverseMap();
        CreateMap<Contact, GetByIdFeatureDto>().ReverseMap();
    }
}