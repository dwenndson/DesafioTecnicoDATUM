using API2.Services;
using API2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Controllers
{
    [Controller]
    [Route("api2/[controller]")]
    public class CalculoController : ControllerBase
    {
        private readonly IObterJuros _service;
        private readonly string UrlBase = "https://github.com/dwenndson";
        public CalculoController(IObterJuros service)
        {
            _service = service;
        }

        [HttpGet("/calculajuros")]
        public async Task<string> CalcularJuros([FromQuery] decimal ValorInicial, [FromQuery] int Tempo)
        {
            var juros = await _service.OnGet();
            string taxaJuros = _service.ValorFinal(ValorInicial, juros, Tempo);
            return taxaJuros;
        }

        [HttpGet("/showmethecode")]
        public IActionResult ShowUrl()
        {
            string Url = UrlBase + "/DesafioTecnicoDATUM";
            return Ok(Url);
        }
    }
}
