using HomeWork.service.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeWork.Controllers
{
    public class ExchangeRatesController : ApiController
    {
        private readonly ExchangeRatesService _exchangeRatesService;

        public ExchangeRatesController() {
            _exchangeRatesService = new ExchangeRatesService();
        }

        //[get]api/ExchangeRates 
        public string Get(DateTime exchangeDate)
        {
            return JsonConvert.SerializeObject(new { currencyList = _exchangeRatesService.GetExchangeRates(exchangeDate) });
        }
    }
}
