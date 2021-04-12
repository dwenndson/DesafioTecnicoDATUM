using API1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace API1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {

        [HttpGet]
        [Route("/taxaJuros")]
        public IActionResult GetTaxaJuros()
        {
            var taxaJuros = JurosModel.JurosTaxa;
            
            return Ok( taxaJuros );
        }
    }
}
