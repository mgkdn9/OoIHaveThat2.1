namespace OoIHaveThat2._1.Models
{
    public class Response
    {
        public int Id { get; set; }

        public int SeekerUserId { get; set; }

        public int OwnerUserId { get; set; }

        public int ToolRequestId { get; set; }

        public double PriceCounterOffer { get; set; }

        public double PriceCounterOfferCounter { get; set; }

        public double DistanceBetween { get; set; }

        public Response()
        {

        }
    }
}
