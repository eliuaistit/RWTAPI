
using AllianceCRM.Security;
using NexsourceCRM.Communication;
using NexsourceCRM.Demography;
using NexsourceCRM.Logging;
using System.Collections.Generic;

namespace AllianceCRM.Insurance
{
    public class Client : BaseEntity
    {
        public Person Person { get; set; }
        public IList<ActivityLog> ActivityLogs { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<Conversation> EmailHistories { get; set; }
        public string LastContact { get; set; }
        public bool IsDuplicate { get; set; }
        public bool DoNotCall { get; set; }
        public int Status { get; set; }
        public string EnquiryDate { get; set; }
        public object TempReference { get; set; }

    }

}


