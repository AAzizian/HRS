﻿using HRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRS.Controllers
{
    public class OrdersController : Controller
    {
        [Authorize(Roles = RoleName.CanManageHotels)]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = RoleName.CanManageHotels)]
        public ActionResult New()
        {
            return View();
        }

        [Authorize(Roles = RoleName.CanManageHotels)]
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}