using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CashierGlue
{
    class CurrencySerialization: JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var currency = value as Currency;
            writer.WriteStartObject();
            writer.WritePropertyName("Value");
            writer.WriteValue(currency.ToString());
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }

    class AddFeeSerializer: JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var addFeeAction = value as AddFee;
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteValue(addFeeAction.Id);
            writer.WritePropertyName("line_text");
            writer.WriteValue(addFeeAction.LineText);
            writer.WritePropertyName("value");
            writer.WriteValue(addFeeAction.Currency.ToString());
            writer.WritePropertyName("taxable");
            writer.WriteValue(addFeeAction.Taxable);
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
}
}
