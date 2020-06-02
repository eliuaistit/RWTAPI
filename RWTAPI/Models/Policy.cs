
using AllianceCRM.Model.Extension;
using AllianceCRM.Security;
using NexsourceCRM.Accounting;
using NexsourceCRM.Demography;
using System;
using System.Collections.Generic;

namespace AllianceCRM.Insurance
{
    public class Policy : BaseEntity
    {
        public string Reference { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public float SaleDiscount { get; set; }
        public bool LowClaim { get; set; }
        public float LowCliamPremium { get; set; }
        public float SaleDiscountPremium { get; set; }
        public float BrokerCommission { get; set; }
        public float BrokerCommissionPremium { get; set; }
        public float ProductPremium { get; set; }
        public float GrossPremium { get; set; }
        public float NetPremium { get; set; }
        public float FrequencyPremium { get; set; }
        public DateTimeOffset EmailBankTransferDate { get; set; }
        public DateTimeOffset EmailCertificateDate { get; set; }
        public DateTimeOffset ApproveDate { get; set; }
        public Nullable<int> RenewalPolicyLevel { get; set; }
        public string TokenRenewal { get; set; }
        public Reminder Reminder { get; set; }
        public object MainPolicyID { get; set; }
        public object Version { get; set; }
        public ProductType ProductType { get; set; }
        public Product Product { get; set; }
        public Broker Broker { get; set; }
        public Client Client { get; set; }
        public InsuredPersons[] InsuredPersons { get; set; }
        public Invoices[] Invoices { get; set; }
        public List<Endorsement> Endorsements { get; set; }
        public IList<Commission> BrokerCommissions { get; set; }
        public Generator Generator { get; set; }
        public User DataAnalyst { get; set; }
        public User CustomerRelationshipExecutive { get; set; }
        public User CustomerRelationshipManager { get; set; }
        public User AccountManagementTeam { get; set; }
        public User AccountSupervisor { get; set; }
        public Location Location { get; set; }
        public PolicyStatus Status { get; set; }
        public Payment Payment { get; set; }
        public string RemarkMemo { get; set; }
        public DateTimeOffset AccountPendingDate { get; set; }
        public Policy RenewalPolicy { get; set; }
        public Nullable<DateTime> FirstPremiumCollectionDate { get; set; }
        public String TempReference { get; set; }
        public string OldInsuredPersonID { get; set; }
        public DateTimeOffset PolicyCreatedDate { get; set; }
        public bool IsRenewal { get; set; }

    }

}


