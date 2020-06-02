using AllianceCRM.Insurance;
using System;
using System.Collections.Generic;

namespace AllianceCRM.Security
{
    public class Roles : BaseEntity
    {
        public String Reference { get; set; }
        public string Name { get; set; }
        public IList<RoleAction> RoleActions { get; set; }

    }

}
