using System;
using System.Collections.Generic;

namespace EntPlatform.Services.Models
{
    public partial class BusinessNature
    {
        public BusinessNature()
        {
            BusinessNatureDetails = new HashSet<BusinessNatureDetails>();
        }

        public int Id { get; set; }
        public string Nature { get; set; }

        public ICollection<BusinessNatureDetails> BusinessNatureDetails { get; set; }
    }
}
