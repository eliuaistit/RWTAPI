namespace AllianceCRM.Insurance
{
    public class PolicyNumberScheme : BaseEntity
    {
        public string Reference { get; set; }
        public int Year { get; set; }
        public PolicyStatus ProductType { get; set; }
        public Product Product { get; set; }

    }

}
