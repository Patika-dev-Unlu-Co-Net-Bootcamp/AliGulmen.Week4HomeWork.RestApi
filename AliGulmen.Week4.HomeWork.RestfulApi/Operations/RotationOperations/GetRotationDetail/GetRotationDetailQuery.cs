using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.GetRotationDetail
{
    public class GetRotationDetailQuery
    {

        private static List<Rotation> RotationList = DataGenerator.RotationList;
        public int RotationId { get; set; }

        public GetRotationDetailQuery()
        {

        }

        public Rotation Handle()
        {
            var rotation = RotationList.Where(r => r.Id == RotationId).SingleOrDefault();
            if (rotation is null)
                throw new InvalidOperationException("The rotation is not exist!");


            return rotation;



        }
    }
}
