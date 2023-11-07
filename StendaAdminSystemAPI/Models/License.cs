using System.ComponentModel.DataAnnotations;

namespace StendaAdminSystemAPI.Models
{
    public class License
    {
        [Key]
        public int SapNo { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string ExpDate { get; set; }
    }
}
