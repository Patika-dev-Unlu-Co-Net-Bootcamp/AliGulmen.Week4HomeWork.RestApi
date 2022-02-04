using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.UpdateLocationRotation
{
    public class UpdateLocationRotationCommand
    {
        public int LocationId { get; set; }
        public int RotationId { get; set; }
        private static List<Location> LocationList = DataGenerator.LocationList;


        public UpdateLocationRotationCommand()
        {

        }

        public void Handle()
        {

            var location = LocationList.SingleOrDefault(loc => loc.Id == LocationId); 
            if (location is null)
                throw new InvalidOperationException("Uom is not found!");


            location.RotationId = RotationId != default ? RotationId : location.RotationId;


        }
    }
}
