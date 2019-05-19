using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Andes_EPC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EpcResults()
        {
            ViewBag.Message = "Runnymede energy rating page.";
            //var json = "epc_testJSON2.json";
            return View();
        }

        public object Get()
        {
            //string allText = System.IO.File.ReadAllText(@Server.MapPath("~/App_Data/epc_testJSON2.json"));
            string allText = System.IO.File.ReadAllText(@Server.MapPath("~/App_Data/test.json"));
            object jsonObject = JsonConvert.DeserializeObject(allText);
            return jsonObject;
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