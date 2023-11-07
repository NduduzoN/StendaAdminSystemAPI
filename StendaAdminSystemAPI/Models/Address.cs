using System.ComponentModel.DataAnnotations;

namespace StendaAdminSystemAPI.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StreetNumber { get; set; }
        [Required]
        public String StreetName { get; set; }
        [Required]
        public String Town { get; set; }
        [Required]
        public String Section { get; set; }
    }
}
