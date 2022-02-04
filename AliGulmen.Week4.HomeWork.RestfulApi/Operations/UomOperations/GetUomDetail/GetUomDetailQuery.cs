using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.GetUomDetail
{
    public class GetUomDetailQuery
    {
        private static List<Uom> UomList = DataGenerator.UomList;
        public int UomId { get; set; } 

        public GetUomDetailQuery()
        {

        }

        public Uom Handle()
        {
            var uom = UomList.Where(u => u.Id == UomId).SingleOrDefault();
            if (uom is null)
                throw new InvalidOperationException("The uom is not exist!");


            return uom;

          

        }
    }
}
