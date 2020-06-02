

using AllianceCRM.Insurance;
using System;

namespace NexsourceCRM.Accounting
{
    public class Commission : BaseEntity
    {
        public string Reference { get; set; }
        public float Amount { get; set; }
        public DateTimeOffset CommissionDate { get; set; }
        public Payslip Payslip { get; set; }

    }

}
