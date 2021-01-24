using MeshurSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MeshurSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            this.httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> VeriGetir()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://postman-echo.com/delay/10");
            var client = httpClientFactory.CreateClient();
            var message = await client.SendAsync(request);
            ViewBag.GelenVeri = await message.Content.ReadAsStringAsync();

            return View();
        }

        //public IActionResult VeriGetir()
        //{
        //    var request = new HttpRequestMessage(HttpMethod.Get, "https://postman-echo.com/delay/10");
        //    var client = httpClientFactory.CreateClient();
        //    var message = client.Send(request);
        //    var stream = message.Content.ReadAsStream();
        //    var reader = new StreamReader(stream);
        //    ViewBag.GelenVeri = reader.ReadToEnd();
        //    return View();
        //}

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
