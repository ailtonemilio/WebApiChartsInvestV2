using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiChartsInvestV2.Model.Entities
{
    [Table("Stock")]
    public partial class Stock
    {
        public int StockId { get; set; }
        [StringLength(10)]
        public string StockCode { get; set; }
        [StringLength(250)]
        public string StockName { get; set; }
        public DateTime DateAction { get; set; }
        public decimal StockAmount { get; set; }
        public decimal StockPrice { get; set; }
        public decimal Comission { get; set; }
        public bool TypeAction { get; set; }
        public int PortfolioId { get; set; }

        public virtual Portfolio Portfolio { get; set; }
    }
}
