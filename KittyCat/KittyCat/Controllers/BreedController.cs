﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KittyCat.Controllers
{
    public class BreedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}