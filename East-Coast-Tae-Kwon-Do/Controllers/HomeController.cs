using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace East_Coast_Tae_Kwon_Do.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        string userAgent = HttpContext.Request.Headers["User-Agent"];
        bool isMobile = userAgent.Contains("Android") || userAgent.Contains("Mobile") || userAgent.Contains("iPhone");
        return View();

        ViewBag.IsMobile = isMobile;
    }

    public IActionResult About()
    {
        return View();
    }
}