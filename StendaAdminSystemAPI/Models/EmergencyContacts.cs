using System.ComponentModel.DataAnnotations;

namespace StendaAdminSystemAPI.Models
{
    public class EmergencyContacts
    {
        [Key]
        public int Id { get; set; }
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
