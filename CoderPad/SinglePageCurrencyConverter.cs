using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {

        //Create tests here i.e.
        //Console.WriteLine( "Expected = 19.94, Actual = " + GetConvertedAmount("USA", "MEX", 1) );
    }
}


    public class CurrencyConverter
    {
        private CurrencyConverterRepository repository;
        public CurrencyConverter(CurrencyConverterRepository repository)
        {
            this.repository = repository;
        }

        public decimal GetConvertedAmount(string fromCountryCode, string toCountryCode, decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class CurrencyConverterRepository
    {

        public IEnumerable<CurrencyConversion> GetConversions()
        {
            //RateFromUSD may be outdated values
            return new[] {
                new CurrencyConversion() { CountryCode = "USD", CurrencyName = "United States Dollars", RateFromUSDToCurrency = 1.0M },
                new CurrencyConversion() { CountryCode = "CAD", CurrencyName = "Canada Dollars", RateFromUSDToCurrency = 1.26M },
                new CurrencyConversion() { CountryCode = "MXN", CurrencyName = "Mexico Pesos", RateFromUSDToCurrency = 19.94M },
                new CurrencyConversion() { CountryCode = "CRC", CurrencyName = "Costa Rica Colons", RateFromUSDToCurrency = 538.52M },
                new CurrencyConversion() { CountryCode = "DZD", CurrencyName = "Algeria Dinars", RateFromUSDToCurrency = 97.56M },
                new CurrencyConversion() { CountryCode = "CNY", CurrencyName = "China Renminbis", RateFromUSDToCurrency = 6.08M },
                new CurrencyConversion() { CountryCode = "DKK", CurrencyName = "Denmark Krones", RateFromUSDToCurrency = 6.6181M },
                new CurrencyConversion() { CountryCode = "PLN", CurrencyName = "Poland Zlotys", RateFromUSDToCurrency = 3.6284M }
            };
        }
    }


    public class CurrencyConversion
    {
        public String CountryCode;
        public String CurrencyName;
        public Decimal RateFromUSDToCurrency;
    }
