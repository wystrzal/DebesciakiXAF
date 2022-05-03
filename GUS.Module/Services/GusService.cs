using DevExpress.ExpressApp;
using GUS.Module.BusinessObjects;
using GUS.Module.Interfaces;
using GUS.Module.Utils;
using GusHelper;
using GusHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GUS.Module.Services
{
    public class GusService
    {
        private readonly IObjectSpace objectSpace;
        private readonly string key;

        public GusService(IObjectSpace objectSpace, string key)
        {
            this.objectSpace = objectSpace;
            this.key = key;
        }

        public async Task GetDataFromGus(ICustomer customer)
        {
            var nip = customer.Nip;
            while (nip.Contains("-")) nip = nip.Replace("-", "");

            var gusHelperClient = new GusHelperClient(key);
            DataOfPersonBusiness data;
            try
            {
                data = await gusHelperClient.GetFullReport(nip);
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message);
            }

            if (data == null) return;

            var gusOrganizationMapper = new GusOrganizationMapper(objectSpace, data);
            gusOrganizationMapper.MapGusOrganization(customer);

            var gusAddressMapper = new GusAddressMapper(data);
            gusAddressMapper.MapGusAddress(customer);

            if (string.IsNullOrWhiteSpace(customer.Name))
            {
                customer.Name = data.Name;
            }
            if (string.IsNullOrWhiteSpace(customer.Symbol))
            {
                customer.Symbol = data.ShortName;
            }
            if (string.IsNullOrWhiteSpace(customer.Email))
            {
                customer.Email = data.Email;
            }
            if (string.IsNullOrWhiteSpace(customer.Phone))
            {
                customer.Phone = data.PhoneNumber;
            }
            MapPkdList(customer, data);
        }

        private void MapPkdList(ICustomer customer, DataOfPersonBusiness data)
        {
            List<PkdCode> pkdCodeList = new List<PkdCode>();
            foreach (var pkd in data.PkdList)
            {
                if (string.IsNullOrWhiteSpace(pkd.Code)) continue;

                var pkdCode = objectSpace.GetObjectsQuery<PkdCode>(true).Where(x => x.Code == pkd.Code).FirstOrDefault();
                if (pkdCode == null)
                {
                    pkdCode = objectSpace.CreateObject<PkdCode>();
                    pkdCode.Name = pkd.Name;
                    pkdCode.Code = pkd.Code;
                }
                pkdCodeList.Add(pkdCode);
            }
            customer.PkdCodeList = pkdCodeList;
        }
    }
}