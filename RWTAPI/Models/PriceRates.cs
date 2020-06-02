namespace AllianceCRM.Insurance
{
    public class PriceRates : BaseEntity
    {
        public object CountryGroup { get; set; }
        public int Age { get; set; }
        public object Gender { get; set; }
        public bool Tobacco { get; set; }
        public int Rate { get; set; }
    }

}
