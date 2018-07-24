using System;
using System.Collections.Generic;
using System.Text;

namespace EntPlatform.Repository.Model
{
    public class BusinessNaturesModel
    {
        public BusinessNaturesModel()
        {
            this.Details = new List<BusinessNaturesDetailsModel>();
        }
        public int BusinessNaturesId { get; set; }

        public string BusinessNaturesDesc { get; set; }

        public List<BusinessNaturesDetailsModel> Details { get; set; }
    }

    public class BusinessNaturesDetailsModel
    {
        public int BusinessNaturesDetailsId { get; set; }

        public string BusinessNaturesDetailsDesc { get; set; }
    }
}
