using AllianceCRM.Insurance;
using NexsourceCRM.Demography;

namespace NexsourceCRM.Communication
{
    public class PhoneNumber : BaseEntity
    {
        public CountryCode CountryCode { get; set; }
        public string Number { get; set; }
        public string SourceNumber { get; set; }
        public string OutsidePrefixNine { get; set; }
    }
}