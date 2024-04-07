using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MIST353GroupProjectFranticFroggyFirms.Entities
{
    public class RoomAvail
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomAvailID { get; set; }

        [Required]
        public int RoomID { get; set; }

        [Required]
        public DateTime AvDate { get; set; }

        [Required]
        public decimal Price { get; set; }

        [ForeignKey("RoomID")]
        public Room Room { get; set; }
    }
}