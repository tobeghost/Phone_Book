using AutoMapper;
using PhoneBook.Libraries.Core;

namespace PhoneBook.Libraries.Data
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ReportCollection, ReportDto>().ReverseMap();
            CreateMap<ReportCollection, ReportCreateDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Contact, ContactCreateDto>().ReverseMap();
        }
    }
}
