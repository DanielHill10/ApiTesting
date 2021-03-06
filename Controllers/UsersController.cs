using ApiTesting.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiTesting.Controllers
{
    public class UsersController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewBag.Test = "Test";

            List<Root> rootList = new List<Root>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://jsonplaceholder.typicode.com/users"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    rootList = JsonConvert.DeserializeObject<List<Root>>(apiResponse);
                }
            }
            return View(rootList);
        }
    }
}
