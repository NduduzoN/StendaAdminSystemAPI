using System.ComponentModel.DataAnnotations;

namespace StendaAdminSystemAPI.Models
{
    public class EmergencyContact
    {
        [Key]
        public int SapNo { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public String MiddleName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public String CellNuumber { get; set; }

    }
}
