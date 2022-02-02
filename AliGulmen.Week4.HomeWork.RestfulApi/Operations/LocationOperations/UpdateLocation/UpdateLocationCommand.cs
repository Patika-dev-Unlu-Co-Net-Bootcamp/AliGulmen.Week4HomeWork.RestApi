using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.UpdateLocation
{
    public class UpdateLocationCommand
    {
        public int LocationId { get; set; }
        public Location Model { get; set; }
        private static List<Location> LocationList = DataGenerator.LocationList;


        public UpdateLocationCommand()
        {

        }

        public void Handle()
        {
            if (Model is null)
                throw new InvalidOperationException("No data entered!");


            var location = LocationList.SingleOrDefault(loc => loc.locationId == LocationId); 
            if (location is null)
                throw new InvalidOperationException("Location is not found!");



            location.locationId = Model.locationId != default ? Model.locationId : location.locationId;
            location.locationName = Model.locationName != default ? Model.locationName : location.locationName;
            location.rotationId = Model.rotationId != default ? Model.rotationId : location.rotationId;
           

        }
    }
}
