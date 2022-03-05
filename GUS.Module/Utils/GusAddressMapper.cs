using GUS.Module.Interfaces;
using GusHelper.ViewModels;

namespace GUS.Module.Utils
{
    public class GusAddressMapper
    {
        private readonly DataOfPersonBusiness data;

        public GusAddressMapper(DataOfPersonBusiness data)
        {
            this.data = data;
        }

        public void MapGusAddress(ICustomer customer)
        {
            MapCityGus(customer);
            MapStreetGus(customer);
            MapCommuneGus(customer);
            MapCountryGus(customer);
            MapCountyGus(customer);
            MapProvinceGus(customer);
            MapPostCityGus(customer);
        }

        private void MapCityGus(ICustomer customer)
        {
            if (data == null || data.Address == null || data.Address.City == null) return;
            customer.City = data.Address.City.Name;
        }

        private void MapStreetGus(ICustomer customer)
        {
            if (data == null || data.Address == null || data.Address.Street == null) return;
            customer.Street = data.Address.Street.Name;
            customer.ApartmentNumber = data.Address.Street.ApartmentNumber;
            customer.PropertyNumber = data.Address.Street.PropertyNumber;
        }

        private void MapCommuneGus(ICustomer customer)
        {
            if (data == null || data.Address == null || data.Address.Commune == null) return;
            customer.Commune = data.Address.Commune.Name;
        }

        private void MapCountryGus(ICustomer customer)
        {
            if (data == null || data.Address == null || data.Address.Country == null) return;
            customer.Country = data.Address.Country.Name;
        }

        private void MapCountyGus(ICustomer customer)
        {
            if (data == null || data.Address == null || data.Address.County == null) return;
            customer.County = data.Address.County.Name;
        }

        private void MapProvinceGus(ICustomer customer)
        {
            if (data == null || data.Address == null || data.Address.Province == null) return;
            customer.Province = data.Address.Province.Name;
        }

        private void MapPostCityGus(ICustomer customer)
        {
            if (data == null || data.Address == null || data.Address.PostOffice == null) return;
            customer.PostOffice = data.Address.PostOffice.Name;
            customer.PostalCode = data.Address.PostOffice.Postcode;
        }
    }
}