using AutoMapper;
using SimpleCrm.Application.Mappings;
using SimpleCrm.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrm.Application.Dto
{
    public class CustomerReportDto : IMap
    {
        public string Name { get; set; }

        public string TaxNumber { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string StatusVat { get; set; }

        public IEnumerable<string> AccountNumbers { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CustomerReportViewModel, CustomerReportDto>();
        }
    }
}
