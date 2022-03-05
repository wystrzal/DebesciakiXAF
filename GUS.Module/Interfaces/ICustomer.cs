using GUS.Module.BusinessObjects;
using System.Collections.Generic;

namespace GUS.Module.Interfaces
{
    public interface ICustomer : IOrganizationGus
    {
        public string VatNumber { get; set; }
        public string CustomerName { get; set; }
        public string Symbol { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ApartmentNumber { get; set; }
        public string PropertyNumber { get; set; }
        public string Commune { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string Province { get; set; }
        public string PostOffice { get; set; }
        public string PostalCode { get; set; }
        public List<PkdCode> PkdCodeList { get; set; }
    }
}