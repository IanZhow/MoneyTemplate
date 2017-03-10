using MoneyTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyTemplate.Controllers
{
    public class HomeController : Controller
    {

        List<Data> DataList = new List<Data>();
       
  
        public ActionResult Index()
        {
            for (int i = 1; i < 11; i++)
            {
                Data data = new Data();
                data.NUM = i;
                if (i % 2 == 1)
                    data.TYPE = "支出";
                else
                    data.TYPE = "收入";
                data.DATE = DateTime.Now;
                data.TOTAL = i * 1000;
                DataList.Add(data);                
            }          
           
            return View(DataList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}