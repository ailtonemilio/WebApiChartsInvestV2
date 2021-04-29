using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiChartsInvestV2.Model.Entities
{
    public partial class Portfolio
    {
        public int PortfolioId { get; set; }
        [Display(Name = "Portfolio")]
        [Required(ErrorMessage = "The Portfolio field is empty")]
        [StringLength(250)]
        public string PortfolioName { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<Stock> Stock { get; set; }
    }
}
