
using NexsourceCRM.Demography;
using System;

namespace AllianceCRM.Insurance
{
    public class HealthPriceRate : BaseEntity
    {
        public CountryGroup CountryGroup { get; set; }
        public int Age { get; set; }
        public float Price { get; set; }
        public string ProductPlan_ID { get; set; }
        public DateTimeOffset StartDate { get; set; }

    }

}

