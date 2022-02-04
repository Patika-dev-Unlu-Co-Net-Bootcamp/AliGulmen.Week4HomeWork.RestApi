using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.StockOperations.GetStocks
{
    public class GetStocksQuery
    {
        private static List<Stock> StockList = DataGenerator.StockList;

        public GetStocksQuery()
        {

        }

        public List<Stock> Handle()
        {
            var stockList = StockList.OrderBy(u => u.ProductId).ToList<Stock>();
            return stockList;

        }
    }
}
