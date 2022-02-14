using AutoMapper;
using SimpleCrm.Application.Mappings;
using SimpleCrm.Domain.Entities;

namespace SimpleCrm.Application.Dto
{
    public class CustomerDto : IMap
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string TaxNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Customer, CustomerDto>();
        }
    }
}
