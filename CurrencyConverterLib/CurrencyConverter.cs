using System;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyConverterLib
{
    public class CurrencyConverter : ICurrencyConverter
    {
        private ICurrencyConverterRepository repository;
        public CurrencyConverter(ICurrencyConverterRepository repository)
        {
            this.repository = repository;
        }

        public decimal GetConvertedAmount(string fromCountryCode, string toCountryCode, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}

