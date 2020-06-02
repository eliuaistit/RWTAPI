using System.Collections.Generic;

namespace AllianceCRM.Insurance
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Reference { get; set; }
        public IList<BenefitCoverage> BenefitCoverages { get; set; }

    }

}

