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
            

            var stock = StockList.FirstOrDefault(s => s.productId == container.productId);
            if (stock != null)
                stock.stockOnRack += 1;
            else
                StockList.Add(new Stock { productId = container.productId, readyToShip = 0, stockOnRack = 1 });
        }

        public void Locate(Container container)
        {
            container.locationId = 2;
        }
    }
}
