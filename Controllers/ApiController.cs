using APITalycap.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APITalycap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        [HttpGet("consultaBooks")]

        public IEnumerable<Books> Bookslist()
        {

            ApiExterna apiExterna = new ApiExterna();
            string response = apiExterna.GetApiExterna("Books");
            List<Books> booksList = new List<Books>();
            booksList = JsonConvert.DeserializeObject<List<Books>>(response);
            return booksList;
        }

        [HttpGet("consultaAuthors")]

        public IEnumerable<Authors> Authorslist()
        {

            ApiExterna apiExterna = new ApiExterna();
            string response = apiExterna.GetApiExterna("Authors");
            //declaramos en donde se va a cargar el json en este caso sera Authorlist
            List<Authors> authorsList = new List<Authors>();
            authorsList = JsonConvert.DeserializeObject<List<Authors>>(response);
            return authorsList;
        }



    }
}

