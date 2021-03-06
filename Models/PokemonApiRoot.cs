using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTesting.Models
{
    public class PokemonApiRoot
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Pokemon> results { get; set; }
    }
}
