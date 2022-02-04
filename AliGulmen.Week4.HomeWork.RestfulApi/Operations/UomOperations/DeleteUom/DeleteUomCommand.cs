using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.DeleteUom
{

    public class DeleteUomCommand
    {
        public int UomId { get; set; }
        private static List<Uom> UomList = DataGenerator.UomList;

        public DeleteUomCommand()
        {

        }



        public void Handle()
        {

            var ourRecord = UomList.SingleOrDefault(b => b.Id == UomId); //is it exist?
            if (ourRecord is null)
                throw new InvalidOperationException("There is no record to delete!");
          
            UomList.Remove(ourRecord);

        }
    }
}
