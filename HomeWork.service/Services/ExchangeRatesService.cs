using HomeWork.DataAccess.Daos;
using HomeWork.DataModels.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.service.Services
{
    public class ExchangeRatesService
    {
        ExchangeRatesDao _exchangeRatesDao;
        public ExchangeRatesService()
        {
            _exchangeRatesDao = new ExchangeRatesDao();
        }

        public List<ExchangeRate> GetExchangeRates(DateTime exchangeDate)
        {

            return _exchangeRatesDao.GetExchangeRates(exchangeDate).ToList();
        }
    }
}
