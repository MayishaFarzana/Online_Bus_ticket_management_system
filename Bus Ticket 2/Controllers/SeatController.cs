﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bus_Ticket_2.Controllers
{
    public class SeatController : Controller
    {
        // GET: Seat
        public ActionResult SeatBook()
        {
            return View();
        }
        public ActionResult BusSchedule()
        {
            return View();
        }

    }
}