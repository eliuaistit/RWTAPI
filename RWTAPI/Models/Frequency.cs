
using AllianceCRM.Insurance;

namespace NexsourceCRM.Occurrance
{
    public class Frequency : BaseEntity
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public float Rate { get; set; }

    }

}
