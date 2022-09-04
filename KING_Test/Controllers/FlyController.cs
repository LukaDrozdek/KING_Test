using amadeus;
using KING_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
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


        public IActionResult LiveTest()
        {
            Amadeus amadeus = Amadeus
                .builder("FRGt1GzljciurbN7CZRixQuKv8KQ3OWR", "iezhRB9VDmz38pQv")
                .build();

            amadeus.resources.Location[] locations = amadeus.referenceData.locations.get(Params
                    .with("keyword", "LON")
                    .and("subType", resources.referenceData.Locations.ANY));


            
            return View(locations);
        }
    }
}
