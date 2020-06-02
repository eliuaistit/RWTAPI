namespace AllianceCRM.Insurance
{
    public class NewBrokerCommissionRates : BaseEntity
    {
        public PolicyStatus ProductType { get; set; }
        public float Rate { get; set; }
    }

}
