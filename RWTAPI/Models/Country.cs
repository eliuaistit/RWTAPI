
using AllianceCRM.Insurance;

namespace NexsourceCRM.Demography
{

    public class Country : BaseEntity
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public bool IsTopCountry { get; set; }
        public string TimeZone { get; set; }
        public CountryGroup Group { get; set; }

    }

}
