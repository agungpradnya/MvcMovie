﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<HelloWorld>/
      public IActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "This is the Welcome action method ...";
        }
    }
}
