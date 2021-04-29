using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiChartsInvestV2.Model.Entities
{
    [Table("QuestradeToken")]
    public partial class QuestradeToken
    {
        public int QuestradeTokenId { get; set; }
        [Required(ErrorMessage = "The Token field is empty")]
        [StringLength(250)]
        public string Token { get; set; }
        [Display(Name = "Validity")]
        [Required(ErrorMessage = "The Validity field is empty!")]
        public DateTime? Validade { get; set; }

        public bool? IsValid { get; set; }
    }
}
