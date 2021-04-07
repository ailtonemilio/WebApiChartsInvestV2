using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiChartsInvestV2.Model.Entities
{
    public partial class Portfolio
    {
        public int PortfolioId { get; set; }
        [StringLength(250)]
        public string PortfolioName { get; set; }

        public virtual ICollection<Stock> Stock { get; set; }

    }
}
