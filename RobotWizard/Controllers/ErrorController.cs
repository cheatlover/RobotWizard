﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobotWizard.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

         public ViewResult Index()
         {
            return View("Error");
         }

         public ViewResult FourOFouryoself()
         {
            Response.TrySkipIisCustomErrors = true;
            Response.StatusCode = 404;  //you may want to set this to 200
            return View("FourOFouryoself");
         }

    }
}
