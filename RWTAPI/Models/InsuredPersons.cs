
using NexsourceCRM.Demography;
using System;

namespace AllianceCRM.Insurance
{
    public class InsuredPersons
    {
        public Person Person { get; set; }
        public float Amount { get; set; }
        public InsuredPersonStatus Status { get; set; }
        public bool IsSmoker { get; set; }
        public bool IsChronic { get; set; }
        public bool IsCurrentlyRecieveingTreament { get; set; }
        public bool IsHaveBeenHospitalizedIn5Year { get; set; }
        public float Evacuation { get; set; }
        public float EvacuationNet { get; set; }
        public DateTimeOffset EntryDate { get; set; }
        public int TempCustomerProductID { get; set; }
    }

}


