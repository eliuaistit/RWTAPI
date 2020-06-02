using AllianceCRM.Insurance;
using AllianceCRM.Security;

using System;

namespace NexsourceCRM.Logging
{
    public class ActivityLog : BaseEntity
    {
        public String Reference { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ActivityLogType Type { get; set; }
        public User CompleteBy { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public object TempReference { get; set; }

    }

}
