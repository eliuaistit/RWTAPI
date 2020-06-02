namespace AllianceCRM.Insurance
{
    public class Endorsement : BaseEntity
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public object File { get; set; }

    }

}
