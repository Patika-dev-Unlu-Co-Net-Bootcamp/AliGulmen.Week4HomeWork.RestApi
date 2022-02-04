using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Services.StorageService
{
  
    public class CrossDockingStorage : IStorageService
    {
        private static List<Stock> StockList = DataGenerator.StockList;
        public void AddToStock(Container container)
        {
          

            var stock = StockList.FirstOrDefault(s => s.ProductId > container.Product.Id);
            if (stock != null)
                stock.ReadyToShip += 1;
            else
                StockList.Add(new Stock { ProductId=container.Product.Id, ReadyToShip=1,StockOnRack=0});
        }

        public void Locate(Container container)
        {
            container.LocationId = 1;
        }
    }
}
