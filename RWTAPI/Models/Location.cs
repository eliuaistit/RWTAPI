
using AllianceCRM.Insurance;
using System;

namespace NexsourceCRM.Demography
{
    public class Location : BaseEntity
    {
        public String Reference { get; set; }
        public string Name { get; set; }
        public bool IsTopCountry { get; set; }
        public object TimeZone { get; set; }
        public object Group { get; set; }

    }


}
