using System;
using System.Collections.Generic;

namespace EntPlatform.Services.Models
{
    public partial class BusinessNatureDetails
    {
        public BusinessNatureDetails()
        {
            OrganisationBusinessNature = new HashSet<OrganisationBusinessNature>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? BusinessNature { get; set; }

        public BusinessNature BusinessNatureNavigation { get; set; }
        public ICollection<OrganisationBusinessNature> OrganisationBusinessNature { get; set; }
    }
}
