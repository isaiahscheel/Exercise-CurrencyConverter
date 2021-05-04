using CurrencyConverterLib;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverterWebApi.Controllers
{
    [EnableCors("All")]
    [Route("api/[controller]")]
    public class CurrencyConverterController : Controller
    {
        ICurrencyConverter converter;

        public CurrencyConverterController(ICurrencyConverter converter)
        {
            this.converter = converter;
        }

        [HttpGet]
        public decimal Get(string from, string to, decimal amount)
        {
            return this.converter.GetConvertedAmount(from, to, amount);
        }
        
    }
}
