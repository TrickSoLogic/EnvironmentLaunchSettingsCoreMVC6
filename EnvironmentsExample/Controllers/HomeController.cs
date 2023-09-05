﻿using Microsoft.AspNetCore.Mvc;

namespace EnvironmentLaunchSettingsCoreMVC6.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    [Route("some-route")]
    public IActionResult Index()
    {
      return View();
    }

    [Route("some-route")]
    public IActionResult Other()
    {
      return View();
    }
  }
}
