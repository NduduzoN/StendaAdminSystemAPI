using System.ComponentModel.DataAnnotations;

namespace StendaAdminSystemAPI.Models
{
    public class BankingDetails
    {
        [Key]
        public int SapNo { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public String BranchCode { get; set; }
        [Required]
        public String AccountNumber { get; set; }
        [Required]
        public String AccountType { get; set; }


    }
}
