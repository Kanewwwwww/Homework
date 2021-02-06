using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.DataModels.DataModels
{
    public class ExchangeRate
    {
        public string CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public float CashSale { get; set; }
        public float CashBuy { get; set; }
        public string LastUpdateTime { get; set; }
    }
}
