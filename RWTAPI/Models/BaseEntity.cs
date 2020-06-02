using AllianceCRM.Security;
using System;

namespace AllianceCRM.Insurance
{
    public class BaseEntity
    {
        public string ID { get; set; }
        public ProxyInfo ProxyInfo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public User CreatedBy { get; set; }
        public User ModifiedBy { get; set; }

    }
}
