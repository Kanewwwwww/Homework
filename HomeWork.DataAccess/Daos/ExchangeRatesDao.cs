using Dapper;
using HomeWork.Aop.Helper;
using HomeWork.DataModels.DataModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.DataAccess.Daos
{
    public class ExchangeRatesDao
    {
        private string _connectionString = string.Empty;
        public ExchangeRatesDao()
        {
            _connectionString = ConfigHelper.GetConnectionString();
        }

        public IEnumerable<ExchangeRate> GetExchangeRates(DateTime exchangeDate)
        {
            var data = Enumerable.Empty<ExchangeRate>();
            using (var conn = new SqlConnection(_connectionString))
            {
                string statement = @"
                              select c.CurrencyId,CurrencyName,cashSale,cashBuy,
                              Convert(varchar(10),lastUpdateTime,112) + 
                              Replace(Convert(varchar(8),lastUpdateTime,108),':','') lastUpdateTime 
                              from ExchangeRate e
                              left join Currency c on e.CurrencyId = c.CurrencyId
                              where Convert(varchar(10),lastUpdateTime,111) = 
                                    Convert(varchar(10),@exchangeDate,111)
                        ";

                data = conn.Query<ExchangeRate>(statement,new { exchangeDate });
            }
            return data;
        }
    }
}
