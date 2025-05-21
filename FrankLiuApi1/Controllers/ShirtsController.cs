using FrankLiuApi1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrankLiuApi1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ShirtsController : ControllerBase
    {
        /*-------------------------------------------------
                Action Methods:
        [FromRoute] [FromRoute] string color
        [FromQuery]  [FromQuery] string color URL/id?color=red
        [FromHeader] [FromHeader(Name= "Color")] string color --> edit Header in Postman
        [FromBody] - usually in post or put
        [FromForm] - Key and Value
        ---------------------------------------------------*/

        [HttpGet] // the verb
       //Unødvendig med template [Route("/shirts")] //attribute/url --> Denne controller/action skal reagere på anmodninger til URL-stien /shirts.
        public string GetAllShirts()
        {
            return "Reading all the shirts";
        }
        [HttpGet("{id}")]
        //[Route("/shirts/{id}")]
        public string GetShirtById(int id)
        {
            return $"Reading shirt with id: {id}";
        }
        [HttpPost]
        //[Route("/shirts")]
        public IActionResult CreateShirt([FromBody] Shirt shirt)
        {
            ////Køres kun ved manglende [ApiController]
            //if (!ModelState.IsValid)
            //{
            //    Console.WriteLine("Kims Model validation failed:");
            //    foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            //    {
            //        Console.WriteLine(error.ErrorMessage);
            //    }
            //    return BadRequest(ModelState);
            //}

                Shirt theShirt = new()
            {
                Brand = shirt.Brand,
                Color = shirt.Color,
                Size = shirt.Size,
                Gender = shirt.Gender,
                Price = shirt.Price
            };
            return Ok($"Creating a shirt: \n{theShirt.Brand}\n{theShirt.Color}\n{theShirt.Price}");
        }

        //public string CreateShirt([FromForm] Shirt shirt)
        //{
        //    Shirt theShirt = new()
        //    {
        //        Brand = shirt.Brand,
        //        Color = shirt.Color,
        //        Size = shirt.Size,
        //        Gender = shirt.Gender,
        //        Price = shirt.Price
        //    };
        //    return $"Creating a shirt: \n{theShirt.Brand}\n{theShirt.Color}\n{theShirt.Price}";
        //}

        [HttpPut("{id}")]
        //[Route("/shirts/{id}")]
        public string UpdateShirt(int id)
        {
            return $"Edit shirt with id: {id}";
        }
        [HttpDelete("{id}")]
        //[Route("/shirts/{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting shirt with id: {id}";
        }
    }
}
