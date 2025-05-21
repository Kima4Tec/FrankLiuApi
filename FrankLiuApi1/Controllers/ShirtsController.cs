using FrankLiuApi1.Filters;
using FrankLiuApi1.Models;
using FrankLiuApi1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace FrankLiuApi1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ShirtsController : ControllerBase
    {
        //Mock data



        /*-------------------------------------------------
                Action Methods:
        [FromRoute] [FromRoute] string color
        [FromQuery]  [FromQuery] string color URL/id?color=red
        [FromHeader] [FromHeader(Name= "Color")] string color --> edit Header in Postman
        [FromBody] - usually in post or put
        [FromForm] - Key and Value
        ---------------------------------------------------*/

        [HttpGet] // the verb
        public ActionResult<List<Shirt>> GetAllShirts()
        {
            var shirts = ShirtRepository.GetShirts();
            return Ok(shirts);
        }

        [HttpGet("{id}")]
        [Shirt_ValidateShirtIdFilter]
        public ActionResult GetShirtById(int id)
        {
            //if (id < 1 || id > 4)
            //{
            //    return BadRequest($"The shirt with id {id} is not valid.");
            //}
            //if (!ShirtRepository.ShirtExists(id))
            //{
            //    return NotFound($"The shirt with id {id} was not found.");
            //}
            var shirt = ShirtRepository.GetShirtById(id);
            return Ok(shirt);
        }

        //[HttpGet("{color}")]
        ////[Route("/shirts/{id}")]
        //public ActionResult<List<Shirt>> GetShirtById(string color )
        //{
        //    var shirtList = shirts.Where(x => x.Color?.ToLower() == color).ToList();
        //    if (shirtList.Count == 0)
        //    {
        //        return NotFound($"The color {color} is not available.");
        //    }
        //    return shirtList;
        //    //return $"Reading shirt with id: {id}";
        //}
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
