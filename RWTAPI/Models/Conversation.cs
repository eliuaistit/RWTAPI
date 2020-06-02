using AllianceCRM.Insurance;
using System;
using System.Collections.Generic;

namespace NexsourceCRM.Communication
{
    public class Conversation : BaseEntity
    {
        public string Topic { get; set; }
        public int MessageCount { get; set; }
        public int GlobalMessageCount { get; set; }
        public int UnreadCount { get; set; }
        public int GlobalUnreadCount { get; set; }
        public bool HasAttachments { get; set; }
        public bool GlobalHasAttachments { get; set; }
        public DateTimeOffset LastDeliveryDateTime { get; set; }
        public DateTimeOffset GlobalLastDeliveryDateTime { get; set; }
        public IList<String> GlobalUniqueSenders { get; set; }
        public IList<String> GlobalUniqueRecipients { get; set; }
        public IList<String> UniqueSenders { get; set; }
        public IList<String> UniqueRecipients { get; set; }
        public Client Client { get; set; }
        public IList<EmailMessage> EmailMessages { get; set; }
        public IList<EmailMessage> GlobalEmailMessages { get; set; }

    }

}
