using System;

namespace AllianceCRM.Insurance
{
    public class Receipt : BaseEntity
    {
        public Decimal Amount { get; set; }
        public DateTime PaidDate { get; set; }
    }
}