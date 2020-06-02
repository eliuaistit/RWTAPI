using System;
namespace AllianceCRM.Insurance
{
    public class Invoices : BaseEntity
    {
        public String Reference { get; set; }
        public float Amount { get; set; }
        public DateTimeOffset InvoiceDate { get; set; }
        public Receipt Receipt { get; set; }
        public object AppointmentID { get; set; }
        public object TempCustProductId { get; set; }

    }

}


