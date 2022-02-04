using AliGulmen.Week4.HomeWork.RestfulApi.Operations.StockOperations.GetStocks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Controllers
{
    [Authorize]
    [Route("api/[controller]s")]
    [ApiController]
    public class StockController : ControllerBase
    {

        //GET api/stocks
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetStocks()
        {
            var query = new GetStocksQuery();
            var result = query.Handle();
            return Ok(result);
          
        }
    }
}
