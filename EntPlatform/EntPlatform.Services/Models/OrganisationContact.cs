using System;
using System.Collections.Generic;

namespace EntPlatform.Services.Models
{
    public partial class OrganisationContact
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public Guid? OrganisationId { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public Organisation Organisation { get; set; }
    }
}
