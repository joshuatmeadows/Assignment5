using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MIST353GroupProjectFranticFroggyFirms.Entities

{
    public class HotelReview
    {
        [Key]
        public int HotelReviewID { get; set; }
        public int HotelID { get; set; }
        public int review { get; set; }
        public string? userID { get; set; }
        public string? comments { get; set; }
    }
}
