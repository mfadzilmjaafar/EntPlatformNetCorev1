using System;
using System.Collections.Generic;
using System.Text;

namespace EntPlatform.Repository.Model
{
    public class OrganisationModel
    {
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }


        public int CityCode { get; set; }

        public int CountryCode { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string Postcode { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public string Fax { get; set; }
    }
}
