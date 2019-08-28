using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreDz.Controllers
{
    public class ExeptionController : Controller
    {
        public IActionResult Index()
        {
            Response.StatusCode = 400;
            throw new Exception("Exception");
            return View();
        }
    }
}