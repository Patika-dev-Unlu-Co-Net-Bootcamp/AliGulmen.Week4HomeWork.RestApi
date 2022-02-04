using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.GetRotationLocations
{
    public class GetRotationLocationsQuery
    {
        private static List<Rotation> RotationList = DataGenerator.RotationList;
        private static List<Location> LocationList = DataGenerator.LocationList;

        public int RotationId { get; set; } 

        public GetRotationLocationsQuery()
        {

        }

        public List<Location> Handle()
        {

            var locations = LocationList.Where(loc => loc.RotationId == RotationId).ToList();
            if (locations.Count == 0)
                throw new InvalidOperationException("There is no location defined with this rotation");

            return locations;



        }
    }
}
