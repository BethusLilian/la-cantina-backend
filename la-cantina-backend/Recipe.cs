using Microsoft.AspNetCore.Mvc;
using la_cantina_backend.DAO;
using la_cantina_backend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace la_cantina_backend
{
    [Route("[controller]")]
    [ApiController]
    public class Recipe : ControllerBase
    {
        // GET: /<Recipe>
        [HttpGet]
        public void Get()
        {
            //TODO : recuperer toutes les recettes
           
        }

        // GET /<Recipe>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //TODO : recuperer recette avec id
            return "value";
        }

        // GET /<Recipe>/5
        [HttpGet]
        [Route("[controller]/random")]
        public string GetRandom(int id)
        {
            //TODO : recuperer recette random avec nombre dans url
            return "value";
        }
    }
}
