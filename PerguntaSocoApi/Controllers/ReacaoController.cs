﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UcSecretApi.Controllers
{
    public class ReacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
