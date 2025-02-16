﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationRepository());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllNotificationsForWriter()
        {
            var values = notificationManager.GetList();
            return View(values);
        }
    }
}
