using LineEfficiencySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LineEfficiencySystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public JsonResult GetLines()
        {
            using (LESContext db = new LESContext())
            {
                var Lines = db.Lines.ToArray();

                Line[] LinesList = new Line[Lines.Length];

                int i = 0;
                foreach (Line l in Lines)
                {
                    LinesList[i++] = new Line { LineId = l.LineId, Name = l.Name };
                }

                return Json(LinesList, JsonRequestBehavior.AllowGet);


            }
        }

        public JsonResult GetStations(int id)
        {
            using (LESContext db = new LESContext())
            {
                List<Station> stations;
                if (id == 0)
                {
                    stations = db.Stations.ToList();
                }
                else
                {
                    stations = db.Stations.Where(m => m.LineId == id).ToList();
                }

                StationDTO[] machinesList = new StationDTO[stations.Count];

                int i = 0;
                foreach (Station m in stations)
                {
                    machinesList[i++] =
                        new StationDTO { StationId = m.StationId, Name = m.Name,  };
                }

                return Json(machinesList, JsonRequestBehavior.AllowGet);

            }
        }
    }
}