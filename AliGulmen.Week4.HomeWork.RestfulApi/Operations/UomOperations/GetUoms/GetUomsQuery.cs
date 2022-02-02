using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.GetUoms
{
    public class GetUomsQuery
    {
        private static List<Uom> UomList = DataGenerator.UomList;

        public GetUomsQuery()
        {

        }

        public List<Uom> Handle()
        {
            var uomList = UomList.OrderBy(u => u.uomId).ToList<Uom>();
            return uomList;

        }
    }
}
