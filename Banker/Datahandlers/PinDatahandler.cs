using Banker.Interfaces;
using Banker.Models;
using Banker.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker.Datahandlers
{
    public class PinDatahandler : IPinDatahandler
    {
        PinValidator pv = new PinValidator();

        public bool ValidatePin(string inputPin, BankCard card)
        {
            string dbPin = GetPin(card);

            return pv.ValidatePin(inputPin, dbPin);
        }

        public string GetPin(BankCard card)
        {
            // Get pin from db instead of hardcoded
            return "1234";
        }
    }
}
