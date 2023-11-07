using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace StendaAdminSystemAPI.Models
{
    public class Employees
    {
        [Key]
        public int SapNo { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public String MiddleName  { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public String CellNuumber { get; set; }
        [Required]
        public String IdNumber { get; set; }
        [Required]
        public String Race { get; set; }
        [Required]
        public String Nationality { get; set; }
        [Required]
        public String MaritualStatus { get; set; }
        [Required]
        public String HomeLanguage { get; set; }
        [Required]
        public String SecondLanguage { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Position { get; set; }
        [Required]
        public String Department { get; set; }

    }
}

