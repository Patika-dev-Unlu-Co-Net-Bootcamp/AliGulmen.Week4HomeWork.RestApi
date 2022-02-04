using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.GetRotations
{
    public class GetRotationsQuery
    {
        private static List<Rotation> RotationList = DataGenerator.RotationList;

        public GetRotationsQuery()
        {

        }

        public List<Rotation> Handle()
        {
            var rotationList = RotationList.OrderBy(r => r.Id).ToList<Rotation>();
            return rotationList;

        }
    }
}
