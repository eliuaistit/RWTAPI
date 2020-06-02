
using AllianceCRM.Insurance;
using System;

namespace NexsourceCRM.Demography
{
    public class CountryCode : BaseEntity
    {
        public String Reference { get; set; }
        public object Code { get; set; }
        public Country Country { get; set; }

    }


}
