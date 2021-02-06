using Dapper;
using HomeWork.Aop.Helper;
using HomeWork.DataModels.DataModels;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace HomeWork.DataAccess.Daos
{
    public class CurrencyDao
    {
        private string _connectionString = string.Empty;
        public CurrencyDao()
        {
            _connectionString = ConfigHelper.GetConnectionString();
        }
        public IEnumerable<Currency> GetCurrency()
        {
            var data = Enumerable.Empty<Currency>();
            using (var conn = new SqlConnection(_connectionString))
            {
                string statement = @"
                            select CurrencyId,CurrencyName from Currency
                        ";

                data = conn.Query<Currency>(statement);
            }
            return data;
        }

        public void InsertCurrency(Currency currency)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                string strSql = "insert into Currency(CurrencyId,CurrencyName) VALUES (@CurrencyId,@CurrencyName);";
                conn.Execute(strSql, currency);
            }
        }
        public void UpdateCurrency(Currency currency)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                string strSql = "update Currency set CurrencyName = @CurrencyName where CurrencyId = @CurrencyId ";

                conn.Execute(strSql, currency);
            }
        }

        public void DeleteCurrency(string currencyId)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                string strSql = @"Delete ExchangeRate where CurrencyId = @CurrencyId 
                                  Delete Currency where CurrencyId = @CurrencyId 
                                    ";
                conn.Execute(strSql, new { currencyId });
            }
        }
    }
}
