
using AllianceCRM.Insurance;
using System;

namespace AllianceCRM.Model.Insurance
{
    public class CallingPool : BaseEntity
    {
        public Guid PolicyId { get; set; }
        public Guid ProductId { get; set; }
        public string Type { get; set; }
        public string UserId { get; set; }
        public bool IsLocked { get; set; }
        public DateTimeOffset Callback { get; set; }

    }

}
