using AliGulmen.Week4.HomeWork.RestfulApi.Entities;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Services.StorageService
{
    public interface IStorageService
    {
            public void Locate(Container container);

        public void AddToStock(Container container);
    }
}
