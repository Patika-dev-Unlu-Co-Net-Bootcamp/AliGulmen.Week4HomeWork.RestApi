﻿using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using Microsoft.AspNetCore.Mvc;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.CreateUom;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.DeleteUom;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.GetUoms;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.GetUomDetail;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.UpdateUom;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.UpdateUomDescription;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Controllers
{
    [Route("api/[controller]s")]
	[ApiController]
	public class UomController : ControllerBase
	{

		/************************************* GET *********************************************/

		

		public UomController()
		{

		}



		//Get all records
		//GET api/uoms
		[HttpGet]
		public IActionResult GetUoms()
		{
			var query = new GetUomsQuery();
			var result =query.Handle();
			return Ok(result);
		}



		//Get only one record from list
		//GET api/uoms/1
		[HttpGet("{id}")]
		public IActionResult GetUomById(int id)
		{
			var query = new GetUomDetailQuery();
			query.UomId = id;

			var result = query.Handle();
			return Ok(result);
		}





		/************************************* POST *********************************************/


		//Create new uom
		//POST api/uoms
		[HttpPost]
		public IActionResult CreateUom([FromBody] Uom newUom)
		{

			var command = new CreateUomCommand();
			command.Model = newUom;
			command.Handle();

			
			return Created("~api/uoms", newUom); //http 201 
		}



		/************************************* PUT *********************************************/


		//Update all informations
		//PUT api/uoms/id
		[HttpPut("{id}")]
		public IActionResult Update(int id, Uom newUom)
		{

			var command = new UpdateUomCommand();
			command.UomId = id;
			command.Model = newUom;


			command.Handle();

			return NoContent(); //http 204 

		}

		/************************************* DELETE *********************************************/



		//DELETE api/uoms/id
		[HttpDelete("{id}")]

		public IActionResult Delete(int id)
		{
			var command = new DeleteUomCommand();
			command.UomId = id;
			command.Handle();

			return NoContent(); //http 204
		}



		/************************************* PATCH *********************************************/


		//udate description information
		//PATCH api/uoms/id
		[HttpPatch("{id}")]
		public IActionResult UpdateDescription(int id, string description)
		{
			var command = new UpdateUomDescriptionCommand();
			command.UomId = id;
			command.Description = description;


			command.Handle();

			return NoContent(); //http 204
		}
	}
}
