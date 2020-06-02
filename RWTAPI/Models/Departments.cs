using AllianceCRM.Insurance;
using System.Collections.Generic;

namespace AllianceCRM.Security
{
    public class Departments : BaseEntity
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public User Supervisor { get; set; }
        public IList<ProductType> ProductTypes { get; set; }

    }

}
