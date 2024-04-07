using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MIST353GroupProjectFranticFroggyFirms.Entities
{
    public class HotelRatings
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HotelRatingsID { get; set; }

        [Required]
        public int HotelID { get; set; }

        [Required]
        public int Rating { get; set; }

        [StringLength(36)]
        public string UserID { get; set; }

        public string Review { get; set; }

        [ForeignKey("HotelID")]
        public Hotel Hotel { get; set; }

    }
}