using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Services.StorageService
{
    public class WarehouseStorage : IStorageService
    {
        private static List<Stock> StockList = DataGenerator.StockList;
        public void AddToStock(Container container)
        {
            

            var stock = StockList.FirstOrDefault(s => s.Product.Id == container.Product.Id);
            if (stock != null)
                stock.StockOnRack += 1;
            else
                StockList.Add(new Stock { ProductId = container.Product.Id, ReadyToShip = 0, StockOnRack = 1 });
        }

        public void Locate(Container container)
        {
            container.LocationId = 2;
        }
    }
}
