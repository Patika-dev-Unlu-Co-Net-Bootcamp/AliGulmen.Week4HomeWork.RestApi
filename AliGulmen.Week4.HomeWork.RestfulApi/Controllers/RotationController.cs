using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.CreateRotation;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.DeleteRotation;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.GetRotationDetail;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.GetRotationLocations;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.GetRotationProducts;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.GetRotations;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.UpdateRotation;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.UpdateRotationCode;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Controllers
{
	[Authorize]
	[Route("api/[controller]s")]
	[ApiController]
	public class RotationController : ControllerBase
	{

		
		public RotationController()
		{ }

		/************************************* GET *********************************************/

		//GET api/rotations
		[AllowAnonymous]
		[HttpGet]
		public IActionResult GetRotations()
		{
			var query = new GetRotationsQuery();
			var result = query.Handle();
			return Ok(result);
		}


		//GET api/rotations/1
		[HttpGet("{id}")]
		public IActionResult GetRotationById(int id)
		{
			var query = new GetRotationDetailQuery();
			query.RotationId = id;

			var result = query.Handle();
			return Ok(result);
		}


		//GET api/rotations/1/Locations
		[HttpGet("{id}/Locations")]
		public IActionResult GetLocationsByRotation(int id)
		{
			var query = new GetRotationLocationsQuery();
			query.RotationId = id;

			var result = query.Handle();
			return Ok(result);
		}


		//GET api/rotations/1/Products
		[HttpGet("{id}/Products")]
		public IActionResult GetProductsByRotation(int id)
		{
			var query = new GetRotationProductsQuery();
			query.RotationId = id;

			var result = query.Handle();
			return Ok(result);
		}



		/************************************* POST *********************************************/



		//POST api/rotations
		[HttpPost]
		public IActionResult CreateRotation([FromBody] Rotation newRotation)
		{
			var command = new CreateRotationCommand();
			command.Model = newRotation;
			command.Handle();

			return Created("~api/rotations", newRotation); 
		}



		/************************************* PUT *********************************************/


		//PUT api/rotations/id
		[HttpPut("{id}")]
		public IActionResult Update(int id,Rotation newRotation)
		{

			var command = new UpdateRotationCommand();
			command.RotationId = id;
			command.Model = newRotation;


			command.Handle();
			return NoContent(); 
		}


		/************************************* DELETE *********************************************/

		//DELETE api/rotations/id
		[HttpDelete("{id}")]

		public IActionResult Delete(int id)
		{
			var command = new DeleteRotationCommand();
			command.RotationId = id;
			command.Handle();

			return NoContent(); 
		}



		/************************************* PATCH *********************************************/

		//PATCH api/rotations/id
		[HttpPatch("{id}")]
		public IActionResult UpdateCode(int id, string code)
		{
			var command = new UpdateRotationCodeCommand();
			command.RotationId = id;
			command.Code = code;


			command.Handle();
			return NoContent(); 

		}





	}
}
