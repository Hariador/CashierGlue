using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CashierGlue
{
    [JsonConverter(typeof(CurrencySerialization))]
    public class Currency

    {
        public string IsoCode { get; set; }

        public Boolean HasDecimal { get; set; }

        public UInt16 DecimalPlaces { get; set; }

        
        public long Value { get; set; }

        public Currency()
        {
            IsoCode = "";
            HasDecimal = false;
            Value = 0;
            DecimalPlaces = 0;

        }
        public Currency(string isoCode, Boolean hasDecimal, long value, UInt16 decimalPlaces = 0)
        {
            IsoCode = isoCode;
            HasDecimal = hasDecimal;
            Value = value;
            DecimalPlaces = decimalPlaces;
        }

        public override string ToString()
        {
          
            if(HasDecimal)
            {
                long temp = Value / (long)Math.Pow(10,DecimalPlaces);
                return temp.ToString("F" + DecimalPlaces.ToString());

            } else
            {
                return Value.ToString();
            }
        }

     
    }
}
