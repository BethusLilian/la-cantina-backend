using la_cantina_backend.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace la_cantina_backend
{
    [Route("admin/[controller]")]
    [ApiController]
    public class AdminRecipe : ControllerBase
    {
        // POST api/<AdminRecipe>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //TODO: ajouter recette
            Database db = Database.GetInstance();
            Tag tag = new Tag() { Name = value };
            var laCantina = db.Client.GetDatabase("la-cantina");
            var tags = laCantina.GetCollection<Tag>("Tag");
            tags.InsertOne(tag);
        }

        // PUT api/<AdminRecipe>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //TODO: modifier recette
        }

        // DELETE api/<AdminRecipe>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO: supprimer recette
        }
    }
}
