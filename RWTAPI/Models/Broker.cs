
using NexsourceCRM.Demography;
using System;
using System.Collections.Generic;

namespace AllianceCRM.Insurance
{
    public class Broker : BaseEntity
    {
        public int Reference { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public ProfilePhoto ProfilePhoto { get; set; }
        public string Website { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonPhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTimeOffset EffectiveFromDate { get; set; }
        public string EffectiveUntilDate { get; set; }
        public string BankName { get; set; }
        public string BankLocation { get; set; }
        public string BankAddress { get; set; }
        public string BankSwiftCode { get; set; }
        public string BankIBAN { get; set; }
        public string BankAccountNo { get; set; }
        public string BankNameAndAddress { get; set; }
        public bool IsRequireCustomerRelationshipManager { get; set; }
        public IList<BrokerCommissionRate> NewBrokerCommissionRates { get; set; }
        public IList<BrokerCommissionRate> RenewalBrokerCommissionRates { get; set; }
        public ProductType[] ProductTypes { get; set; }
        public IList<Country> ExcludedCountries { get; set; }
        public IList<Broker> Histories { get; set; }

    }

}
