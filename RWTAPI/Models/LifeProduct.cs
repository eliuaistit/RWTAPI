namespace AllianceCRM.Insurance
{
    public class LifeProduct : BaseEntity
    {
        public PriceRates[] PriceRates { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public object[] BenefitCoverages { get; set; }

    }

}
