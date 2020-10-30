using Lap04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lap04.Controllers
{
    public class LaptopController : Controller
    {
        TMDT5Entities db = new TMDT5Entities();
        // GET: Laptop 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }
        public ActionResult getTypeName()
        {
            var ListTypeNames = db.laptops.GroupBy(l => l.TypeName).Select(l => l.Key);
            return PartialView(ListTypeNames);
        }
        public ActionResult getScreenResolution()
        {
            var ListScreenResolution = db.laptops.GroupBy(l => l.ScreenResolution).Select(l => l.Key);
            return PartialView(ListScreenResolution);
        }
        public ActionResult getSpeed()
        {
            var ListSpeed = db.laptops.GroupBy(l => l.Speed).Select(l => l.Key);
            return PartialView(ListSpeed);
        }
        public ActionResult getInches()
        {
            var ListInches = db.laptops.GroupBy(l => l.Inches).Select(l => l.Key);
            return PartialView(ListInches);
        }
        public ActionResult getMemory()
        {
            var ListMemory = db.laptops.GroupBy(l => l.Memory).Select(l => l.Key);
            return PartialView(ListMemory);
        }
        //public ActionResult getRam()
        //{
        //    var ListRam = db.laptops.GroupBy(l => l.Ram).Select(l => l.Key);
        //    return PartialView(ListRam);
        //}
        public ActionResult getGPU()
        {
            var ListGPU = db.laptops.GroupBy(l => l.GPU).Select(l => l.Key);
            return PartialView(ListGPU);
        }
        public ActionResult getOS()
        {
            var ListOS = db.laptops.GroupBy(l => l.OS).Select(l => l.Key);
            return PartialView(ListOS);
        }
    }
}