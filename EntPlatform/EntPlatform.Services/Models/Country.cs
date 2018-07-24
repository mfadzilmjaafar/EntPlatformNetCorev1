using System;
using System.Collections.Generic;

namespace EntPlatform.Services.Models
{
    public partial class Country
    {
        public int CountryCode { get; set; }
        public string Name { get; set; }
        public string IsoalphaCode { get; set; }
        public decimal? CallingCode { get; set; }
        public string Ibancode { get; set; }
    }
}
