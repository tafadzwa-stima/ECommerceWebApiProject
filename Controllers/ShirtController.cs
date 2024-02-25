using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebApiProject.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ShirtController: ControllerBase
    {
        //Action methods should be in this class  for all the request you want to implement

        [HttpGet]
        public string GetAllShirts () 
        {
            return "Getting all the shirts available ";
        }

        [HttpGet("{id}")]
        
        public string GetShirt([FromQuery] int id) 
        {
            return $"This shirt is available {id}"; 
        }

        [HttpPost]
        public string PostShirt() 
        {
            return " To be implented";
        }

        [HttpDelete]
        public string DeleteShirt()
        {
            return " To be implented";
        }
    }
    
}
