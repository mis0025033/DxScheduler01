using Scheduler01.Models;
using Scheduler01.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scheduler01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "No one is logined";

            if (Session["User_id"] != null)
            {
                ViewBag.Message = "ADMIN is logined";
            }

            return View(new SchedulerViewModel
            {
                Bookings = BookingData.Bookings,
                Doctors = BookingData.Doctors,
                Rooms = BookingData.Rooms,
                StatusList = BookingData.StatusList
            });
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