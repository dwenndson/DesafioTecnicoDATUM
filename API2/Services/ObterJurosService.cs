using API2.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace API2.Services
{
    public class ObterJurosService : IObterJuros
    {
        const string Url = "http://localhost:5000";
        readonly HttpClient client = new HttpClient();
        public async Task<decimal> OnGet()
        {
            decimal juros = 0.00m;
            HttpResponseMessage response = await client.GetAsync(Url + "/taxaJuros");
            if (response.IsSuccessStatusCode)
            {
                juros = await response.Content.ReadAsAsync<decimal>();
            }
            return juros;
        }
        public string ValorFinal(decimal ValorInicial, decimal Juros, int Tempo)
        {
            double UmJuros = 1 + Convert.ToDouble(Juros);
            decimal ValorFinal = ValorInicial * Convert.ToDecimal(Math.Pow(UmJuros, Tempo));
            decimal result = Math.Round(ValorFinal, 2);
            return result.ToString();
        }


    }
}
