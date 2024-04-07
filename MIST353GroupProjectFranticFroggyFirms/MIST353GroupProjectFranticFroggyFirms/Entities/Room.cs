using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MIST353GroupProjectFranticFroggyFirms.Entities
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomID { get; set; }

        [Required]
        public int HotelID { get; set; }

        [Required]
        public int NumBeds { get; set; }

        [StringLength(10)]
        public string RoomType { get; set; }

        public int? RoomNum { get; set; }

        public int? Floor { get; set; }

        [ForeignKey("HotelID")]
        public Hotel Hotel { get; set; }
    }
}