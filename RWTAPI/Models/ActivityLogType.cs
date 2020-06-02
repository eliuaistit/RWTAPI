
using AllianceCRM.Insurance;

using System;

namespace NexsourceCRM.Logging
{
    public class ActivityLogType : BaseEntity
    {
        public String Reference { get; set; }
        public string Name { get; set; }
        public object Icon { get; set; }

    }

}
