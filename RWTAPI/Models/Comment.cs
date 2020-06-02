using AllianceCRM.Insurance;
using System;

namespace AllianceCRM.Security
{
    public class Comment : BaseEntity
    {
        public object Content { get; set; }
        public object Client { get; set; }
        public object TempReference { get; set; }
        public DateTimeOffset TimeStamp { get; set; }

    }

}