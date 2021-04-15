using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiChartsInvestV2.Model.Entities
{
    [Table("QuestradeToken")]
    public partial class QuestradeToken
    {
        public int QuestradeTokenId { get; set; }

        [StringLength(250)]
        public string Token { get; set; }

        public DateTime? Validade { get; set; }

        public bool? IsValid { get; set; }
    }
}
