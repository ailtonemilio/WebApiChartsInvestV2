using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiChartsInvestV2.Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var type = new List<string>();
            var qty = new List<int>();

            type.Add("Male");
            qty.Add(35);
            type.Add("Female");
            qty.Add(23);
            type.Add("Outher");
            qty.Add(20);

            ViewBag.Type = type;
            ViewBag.Qty = qty;

            return View();
        }
        [HttpGet]
        public ActionResult GetData()
        {
            int male = 3;//context.HighCharts.Where(x => x.Gender == "Male").Count();
            int female = 2; //context.HighCharts.Where(x => x.Gender == "Female").Count();
            int other = 6; //context.HighCharts.Where(x => x.Gender == "Other").Count();
            //Ratio obj = new Ratio();
            //obj.Male = male;
            //obj.Female = female;
            //obj.Other = other;

            TypePesquisa obj = new TypePesquisa();

            obj.Type = "Male";
            obj.Qty = 3;
            obj.Type = "Female";
            obj.Qty = 5;
            obj.Type = "Other";
            obj.Qty = 1;

            var listPesquisa = new List<TypePesquisa>();

            listPesquisa.Add(new TypePesquisa("Male",3));
            listPesquisa.Add(new TypePesquisa("Female", 5));
            listPesquisa.Add(new TypePesquisa("Other", 1));

            return Json(listPesquisa);
        }
        public class Ratio
        {
            public int Male { get; set; }
            public int Female { get; set; }
            public int Other { get; set; }
        }

        public partial class TypePesquisa
        {
            public TypePesquisa() { }

            public TypePesquisa(string Type, int Qty)
            {
                this.Type = Type;
                this.Qty = Qty;
            }

            public string Type { get; set; }
            public int Qty { get; set; }
        }
    }
}
