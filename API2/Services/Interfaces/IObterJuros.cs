using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Services.Interfaces
{
    public interface IObterJuros 
    {
        string ValorFinal(decimal v, decimal j, int t);
        Task<decimal> OnGet();
    }
}
