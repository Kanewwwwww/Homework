using HomeWork.DataModels.DataModels;
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
    public class CurrencyController : ApiController
    {
        private readonly CurrencyService _currencyService;
        public CurrencyController()
        {
            _currencyService = new CurrencyService();
        }
        //[get]api/Currency 
        public string Get()
        {
            return JsonConvert.SerializeObject(new { currencyList = _currencyService.GetCurrency() });
        }
        //[post]api/Currency 
        public string Post(Currency currency)
        {
            return JsonConvert.SerializeObject(new { result = _currencyService.InsertCurrency(currency) });
        }
        //[Put]api/Currency 
        public string Put(Currency currency)
        {
            return JsonConvert.SerializeObject(new { result = _currencyService.UpdateCurrency(currency) });
        }
        //[Delete]api/Currency 
        public string Delete(string currencyId)
        {
            return JsonConvert.SerializeObject(new { result = _currencyService.DeleteCurrency(currencyId) });
        }
    }
}
