
using AllianceCRM.Insurance;
using System;

namespace NexsourceCRM.Demography
{
    public class Nationality : BaseEntity
    {
        public String Reference { get; set; }
        public string Name { get; set; }
        public bool IsTopNationality { get; set; }

    }


}
