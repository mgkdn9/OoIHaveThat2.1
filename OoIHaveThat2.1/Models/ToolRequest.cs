using Microsoft.AspNetCore.Mvc;

namespace OoIHaveThat2._1.Models
{
    public class ToolRequest
    {
        public int Id { get; set; }

        public int SeekerId { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public string? TimeNeededFor { get; set; }

        public double PriceFirstOffer { get; set; }

        public string? PictureUrl { get; set; }

        public byte[]? PictureAsByteArr { get; set; }

    }
}
