using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MIST353GroupProjectFranticFroggyFirms.Entities
{
    public class ReservationLines
    {

        [Key]
        public Guid ReservationID { get; set; }

        public int RoomID { get; set; }

        public DateTime AvDate { get; set; }

        public decimal Price { get; set; }

        public int? AdultNum { get; set; }

        public int? ChildNum { get; set; }

        public string ReservationStatus { get; set; }
    }
}