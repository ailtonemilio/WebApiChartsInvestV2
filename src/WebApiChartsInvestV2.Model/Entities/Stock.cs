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
        [Column(TypeName = "decimal(18,8)")]
        public decimal StockAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal StockPrice { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Comission { get; set; }
        public bool TypeAction { get; set; }
        public int PortfolioId { get; set; }

        public virtual Portfolio Portfolio { get; set; }
    }
}
