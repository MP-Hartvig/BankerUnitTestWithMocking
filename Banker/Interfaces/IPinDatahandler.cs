﻿using Banker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker.Interfaces
{
    public interface IPinDatahandler
    {
        public string GetPin(BankCard card);
    }
}
