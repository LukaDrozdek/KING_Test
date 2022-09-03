using KING_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace KING_Test.Controllers
{
    public class FlyController : Controller
    {


        public IActionResult Index()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"E:\.Net\KING_Test\KING_Test\wwwroot\lib\AmadeusFlyInfo.json");
            var countries = JsonConvert.DeserializeObject<Data>(json);

            return View(countries);
        }
    }
}
