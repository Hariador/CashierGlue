using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace CashierGlue
{
    [Serializable]
    public class AddNote 
    {
        public string Note { get; set; }

        public string Type { get; }

        public AddNote(String note)
        {
            Type = ActionType.ADD_NOTE.ToString();
            Note = note;
        }


    }

    [JsonConverter(typeof(AddFeeSerializer))]
    public class AddFee
    {
        public string Id { get; set; }

        public string LineText { get; set; }
        
        public Currency Currency { get; set; }

        public bool Taxable { get; set; }

        public string Type { get; }

        public AddFee(string id, string lineText, Currency currency, bool taxable)
        {
            Id = id;
            LineText = lineText;
            Currency = currency;
            Taxable = taxable;
            Type = ActionType.ADD_FEE.ToString();
        }
    }
}
