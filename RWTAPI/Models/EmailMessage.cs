using AllianceCRM.Insurance;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace NexsourceCRM.Communication
{
    public class EmailMessage
    {
        public String Subject { get; set; }
        public Email From { get; set; }
        public Boolean HasAttachments { get; set; }
        public Boolean IsRead { get; set; }
        public Boolean IsDraft { get; set; }
        public Boolean IsDirty { get; set; }
        public Boolean IsFromMe { get; set; }
        public String Body { get; set; }
        public String BodyPrefix { get; set; }
        public IList<Attachment> Attachments { get; set; }
        public IList<Email> ToRecipients { get; set; }
        public IList<Email> CCRecipients { get; set; }
        public IList<Email> BCCRecipients { get; set; }
        public Client Client { get; set; }
        public Conversation Conversation { get; set; }
        public Folder Folder { get; set; }
        public String Preview { get; set; }
        public String ConversationTopic { get; set; }

    }
}