

using AllianceCRM.Insurance;
using NexsourceCRM.Communication;
using System;

namespace NexsourceCRM.Demography
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<DateTime> BirthDate { get; set; }
        public PhoneNumber PrimaryNumber { get; set; }
        public PhoneNumber SecondaryNumber { get; set; }
        public object PrimaryEmail { get; set; }
        public object SecondaryEmail { get; set; }
        public object Address1 { get; set; }
        public object Address2 { get; set; }
        public object Address3 { get; set; }
        public object City { get; set; }
        public object State { get; set; }
        public object PostCode { get; set; }
        public object Salutation { get; set; }
        public Nationality Nationality { get; set; }
        public Gender Gender { get; set; }
        public object Location { get; set; }

    }

}


