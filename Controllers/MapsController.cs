using ApiTesting.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ApiTesting.Controllers
{
    public class MapsController : Controller
    {
        public IActionResult Index()
        {
            var journeyCalculator = new JourneyCalculator();
            return View(journeyCalculator);
        }

        [HttpPost]
        public async Task<IActionResult> Index(JourneyCalculator journeyCalculator)
        {
            //string postCodeOne = String.Concat(journeyCalculator.PostCodeOne.Where(c => !Char.IsWhiteSpace(c)));
            //string postCodeTwo = String.Concat(journeyCalculator.PostCodeTwo.Where(c => !Char.IsWhiteSpace(c)));

            /* Regex Validation */
            Regex rgx = new Regex("^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z])))) [0-9][A-Za-z]{2})$");
            string postCodeOne = journeyCalculator.PostCodeOne;
            string postCodeTwo = journeyCalculator.PostCodeTwo;
            bool validPostCode;

            validPostCode = rgx.IsMatch(postCodeOne);
            validPostCode = rgx.IsMatch(postCodeTwo);

            //Get API key from file to avoid storing in code
            string apiKey;
            using (var sr = new StreamReader("C:/Users/Daniel.Hill/OneDrive - Access UK Ltd/Desktop/Personal/googleAPIKey.txt"))
            {
                apiKey = sr.ReadToEnd();
            }

            //Generate CURL URL
            string url;
            url = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins={postCodeOne}&destinations={postCodeTwo}&mode=driving&key={apiKey}";

            if (validPostCode)
            {
                if (ModelState.IsValid)
                {
                    using (var client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(url);
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var o = JObject.Parse(responseBody);
                        journeyCalculator.DistanceValue = (string)o["rows"][0]["elements"][0]["distance"]["text"];
                    }
                }
            } else
            {
                journeyCalculator.DistanceValue = "Invalid Postcode";
            }

            return View(journeyCalculator);
        }

        [HttpPost]
        public async Task<IActionResult> CalculateMileage(JourneyCalculator model)
        {
            //string postCodeOne = String.Concat(journeyCalculator.PostCodeOne.Where(c => !Char.IsWhiteSpace(c)));
            //string postCodeTwo = String.Concat(journeyCalculator.PostCodeTwo.Where(c => !Char.IsWhiteSpace(c)));

            /* Regex Validation */
            Regex rgx = new Regex("^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z])))) [0-9][A-Za-z]{2})$");
            string postCodeOne = model.PostCodeOne;
            string postCodeTwo = model.PostCodeTwo;
            bool validPostCode;

            validPostCode = rgx.IsMatch(postCodeOne);
            validPostCode = rgx.IsMatch(postCodeTwo);

            //Get API key from file to avoid storing in code
            string apiKey;
            using (var sr = new StreamReader("C:/Users/Daniel.Hill/OneDrive - Access UK Ltd/Desktop/Personal/googleAPIKey.txt"))
            {
                apiKey = sr.ReadToEnd();
            }

            //Generate CURL URL
            string url;
            url = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins={postCodeOne}&destinations={postCodeTwo}&mode=driving&key={apiKey}";

            if (validPostCode)
            {
                if (ModelState.IsValid)
                {
                    using (var client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(url);
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var o = JObject.Parse(responseBody);
                        model.DistanceValue = (string)o["rows"][0]["elements"][0]["distance"]["text"];
                    }
                }
            }
            else
            {
                model.DistanceValue = "Invalid Postcode";
            }

            return View("Index",model);
        }
    }
}
