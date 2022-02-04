﻿using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.UpdateRotationCode
{
    public class UpdateRotationCodeCommand
    {
        public int RotationId { get; set; }
        public string Code { get; set; }
        private static List<Rotation> RotationList = DataGenerator.RotationList;


        public UpdateRotationCodeCommand()
        {

        }

        public void Handle()
        {

            var rotation = RotationList.SingleOrDefault(u => u.Id == RotationId); 
            if (rotation is null)
                throw new InvalidOperationException("Rotation is not found!");


            rotation.RotationCode = Code != default ? Code : rotation.RotationCode;


        }
    }
}
