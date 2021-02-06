using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.DataAccess.Daos;
using HomeWork.DataModels.DataModels;


namespace HomeWork.service.Services
{
    public class CurrencyService
    {
        private CurrencyDao _currencyDao;
        public CurrencyService()
        {
            _currencyDao = new CurrencyDao();
        }
        public List<Currency> GetCurrency()
        {
            return _currencyDao.GetCurrency().ToList();
        }

        public bool InsertCurrency(Currency currency) 
        {
            bool status;
            try
            {
                _currencyDao.InsertCurrency(currency);
                status = true;
            }
            catch
            {
                status = false;
            }
            return status;
        }

        public bool UpdateCurrency(Currency currency)
        {
            bool status;
            try
            {
                _currencyDao.UpdateCurrency(currency);
                status = true;
            }
            catch
            {
                status = false;
            }
            return status;
        }

        public bool DeleteCurrency(string CurrencyId)
        {
            bool status;
            try
            {
                _currencyDao.DeleteCurrency(CurrencyId);
                
                status = true;
            }
            catch(Exception ex)
            {
                status = false;
            }
            return status;
        }
    }
}
