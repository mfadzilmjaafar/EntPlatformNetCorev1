using System;
using System.Collections.Generic;

namespace EntPlatform.Services.Models
{
    public partial class OrganisationBusinessNature
    {
        public int RowId { get; set; }
        public Guid? OrganisationId { get; set; }
        public int? BusinessNatureDetailsId { get; set; }

        public BusinessNatureDetails BusinessNatureDetails { get; set; }
        public Organisation Organisation { get; set; }
    }
}
