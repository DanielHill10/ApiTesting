using ApiTesting.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ApiTesting.Controllers
{
    public class PokemonController : Controller
    {
        /*
        public ActionResult Index()
        {
            ViewBag.Test = "Test";
            return View();
        }
        */
        /*
        public async Task<IActionResult> Index()
        {
            ViewBag.Test = "Test";

            List<Pokemon> pokemonList = new List<Pokemon>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var array = Newtonsoft.Json.JsonConvert.DeserializeObject<JArray>(apiResponse);
                    foreach (var result in array)
                    {
                        foreach(JObject pokemonResult in result["results"])
                        {
                            var pokemon = new Pokemon { name = (string)pokemonResult["name"] , url = (string)pokemonResult["url"]};
                            pokemonList.Add(pokemon);
                        }
                    }

                }
            }
            return View(pokemonList);
        }
        */
        public async Task<IActionResult> Index()
        {
            ViewBag.Test = "Test";

            List<Pokemon> pokemonList = new List<Pokemon>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon?limit=100"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    PokemonApiRoot jsonResponse = JsonConvert.DeserializeObject<PokemonApiRoot>(apiResponse);
                    foreach(Pokemon pokemon in jsonResponse.results)
                    {
                        pokemonList.Add(pokemon);
                    }
                }
            }
            return View(pokemonList);
        }
    }
}
