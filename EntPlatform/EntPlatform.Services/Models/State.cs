using System;
using System.Collections.Generic;

namespace EntPlatform.Services.Models
{
    public partial class State
    {
        public int CountryCode { get; set; }
        public int StateCode { get; set; }
        public string StateName { get; set; }
        public string Isocode { get; set; }
        public string Abbreviation { get; set; }
    }
}
