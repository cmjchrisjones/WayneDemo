﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await APISimulator.SimulateAPIUsersCall();
            var viewModel = new AADUsersViewModel();
            viewModel.Users = new List<User>();
            users.ForEach(_ => viewModel.Users.Add(_));
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}