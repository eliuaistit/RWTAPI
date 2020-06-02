
using AllianceCRM.Insurance;
using NexsourceCRM.Occurrance;

namespace NexsourceCRM.Accounting.Payments
{
    public class CreditCardPayment : BaseEntity
    {
        public CardType CardType { get; set; }
        public string CardNumber { get; set; }
        public string NameOnCard { get; set; }
        public int Cvc { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
        public Frequency Frequency { get; set; }


    }

}
