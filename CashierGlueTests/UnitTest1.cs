using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CashierGlue;
using Newtonsoft.Json;

namespace CashierGlueTests
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void NonDecimalFormatTest()
        {
            Currency nonDecimalCurrency = new Currency();
            nonDecimalCurrency.DecimalPlaces = 0;
            nonDecimalCurrency.HasDecimal = false;
            nonDecimalCurrency.Value = 100;
            string value = nonDecimalCurrency.ToString();
            Assert.AreEqual("100", value);
        }

        [TestMethod]
        public void DecimalCurrenciesFormatTest()
        {
            Currency decimalCurrency = new Currency();
            decimalCurrency.HasDecimal = true;
            decimalCurrency.Value = 10000;
            decimalCurrency.DecimalPlaces = 2;
            Assert.AreEqual("100.00", decimalCurrency.ToString());
            decimalCurrency.DecimalPlaces = 3;
            Assert.AreEqual("10.000", decimalCurrency.ToString());
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Currency decimalCurrency = new Currency("USD", true, 10000, 2);
            Assert.AreEqual("100.00", decimalCurrency.ToString());
            Currency nonDecimalCurrency = new Currency("JPY", false, 10000);
            Assert.AreEqual("10000", nonDecimalCurrency.ToString());
        }

        [TestMethod]
        public void CurrencySerializationTest()
        {
            Currency decimalCurrency = new Currency("USD", true, 10000, 2);
            Assert.AreEqual("{\"Value\":\"100.00\"}" , JsonConvert.SerializeObject(decimalCurrency));
        }


    }
}
