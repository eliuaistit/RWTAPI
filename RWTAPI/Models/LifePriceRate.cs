
using NexsourceCRM.Demography;
using System;

namespace AllianceCRM.Insurance
{
    public class LifePriceRate : BaseEntity
    {

        public CountryGroup CountryGroup { get; set; }
        public int Age { get; set; }
        public CountryGroup Gender { get; set; }
        public bool Tobacco { get; set; }
        public float Rate { get; set; }
        public DateTimeOffset StartDate { get; set; }

    }

}


