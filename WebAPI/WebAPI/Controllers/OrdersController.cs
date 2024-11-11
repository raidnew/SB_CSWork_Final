using Microsoft.AspNetCore.Mvc;


namespace CSFinal_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "SDDDDDDD";
        }

        [HttpGet]
        [Route("Id/{id}")]
        public string GetContactById(int id)
        {
            return $"dfasfd {id}";
        }
        
    }
}
