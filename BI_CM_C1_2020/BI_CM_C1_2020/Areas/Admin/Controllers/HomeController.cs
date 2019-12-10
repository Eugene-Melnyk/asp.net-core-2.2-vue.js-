using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BI_CM_C1_2020.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace BI_CM_C1_2020.Areas.Admin.Controllers
{

    public class HomeController : Controller
    {
		


		[Area("Admin"), Route("/admin")]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		
    }
}