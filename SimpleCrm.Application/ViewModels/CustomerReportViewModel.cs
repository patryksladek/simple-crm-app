using SimpleCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrm.Application.Models
{
    public class CustomerReportViewModel : Customer
    {
        public string StatusVat { get; set; }
        public IEnumerable<string> AccountNumbers { get; set; }

        public CustomerReportViewModel() { }

        public CustomerReportViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            TaxNumber = customer.TaxNumber;
            Email = customer.Email;
            PhoneNumber = customer.PhoneNumber;
        }

        public CustomerReportViewModel(Customer customer, string statusVat, IEnumerable<string> accountNumbers)
        {
            Id = customer.Id;
            Name = customer.Name;
            TaxNumber = customer.TaxNumber;
            Email = customer.Email;
            PhoneNumber = customer.PhoneNumber;
            StatusVat = statusVat;
            AccountNumbers = accountNumbers;
        }
    }
}
