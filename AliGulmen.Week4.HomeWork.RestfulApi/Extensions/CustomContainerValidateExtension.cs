using AliGulmen.Week4.HomeWork.RestfulApi.Entities;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Extensions
{
    public static class CustomContainerValidateExtension
    {
       
          
            public static void ValidateWith(this Container existingContainer, Container newContainer)
            {

            existingContainer.containerId = newContainer.containerId != default ? newContainer.containerId : existingContainer.containerId;
            existingContainer.productId = newContainer.productId != default ? newContainer.productId : existingContainer.productId;
            existingContainer.uomId = newContainer.uomId != default ? newContainer.uomId : existingContainer.uomId;
            existingContainer.quantity = newContainer.quantity != default ? newContainer.quantity : existingContainer.quantity;
            existingContainer.locationId = newContainer.locationId != default ? newContainer.locationId : existingContainer.locationId;
            existingContainer.weight = newContainer.weight != default ? newContainer.weight : existingContainer.weight;
            existingContainer.creationDate = newContainer.creationDate != default ? newContainer.creationDate : existingContainer.creationDate;
        }
        
    }
}
