using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System.Collections.Generic;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Repositories
{
    public interface IRotationRepository
    {
        void CreateRotation(Rotation newRotation);
        void DeleteRotation(int rotationId);
        Rotation GetRotationDetail(int rotationId);
        List<Location> GetRotationLocations(int rotationId);
        List<Product> GetRotationProducts(int rotationId);
        List<Rotation> GetRotations();
        void UpdateRotation(int rotationId, Rotation newRotation);
        void UpdateRotationCode(int rotationId, string rotationCode);
    }
}
