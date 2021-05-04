using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace CurrencyConverterLib.Tests
{
    [TestClass]
    public class CurrencyConverterTests
    {
        private List<CurrencyConversion> conversions;
        private CurrencyConverter currencyConverter;

        [TestInitialize]
        public void Setup()
        {
            this.conversions = new List<CurrencyConversion>()
            {
                new CurrencyConversion{ CountryCode = "CAD", RateFromUSDToCurrency = 2m },
                new CurrencyConversion{ CountryCode = "MXN", RateFromUSDToCurrency = 20m }
            };

            Mock<ICurrencyConverterRepository> mockRepo = new Mock<ICurrencyConverterRepository>();
            mockRepo.Setup(r => r.GetConversions()).Returns(this.conversions);

            this.currencyConverter = new CurrencyConverter(mockRepo.Object);
        }

        [TestMethod]
        public void GetConvertedAmount_ConvertsCorrectly()
        {
            var actual = this.currencyConverter.GetConvertedAmount("CAD", "MXN", 10);

            Assert.Fail();
        }
    }
}
