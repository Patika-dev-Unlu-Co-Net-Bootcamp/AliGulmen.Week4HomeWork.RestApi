using AliGulmen.Week4.HomeWork.RestfulApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Controllers
{
    [Authorize]
    [Route("api/[controller]s")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockRepository _repository;

        public StockController(IStockRepository repository)
        {
            _repository = repository;
        }


        //GET api/stocks
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetStocks()
        {
            var result = _repository.GetStocks();
            return Ok(result);
          
        }
    }
}
