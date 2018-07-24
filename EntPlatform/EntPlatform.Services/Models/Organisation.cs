using System;
using System.Collections.Generic;

namespace EntPlatform.Services.Models
{
    public partial class Organisation
    {
        public Organisation()
        {
            OrganisationBusinessNature = new HashSet<OrganisationBusinessNature>();
            OrganisationContact = new HashSet<OrganisationContact>();
        }

        public Guid Id { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Postcode { get; set; }
        public int? City { get; set; }
        public int? Country { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }

        public ICollection<OrganisationBusinessNature> OrganisationBusinessNature { get; set; }
        public ICollection<OrganisationContact> OrganisationContact { get; set; }
    }
}
