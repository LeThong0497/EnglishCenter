using EnglishCenter.Business.Interfaces;
using EnglishCenter.Common.Models.Result;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : Controller
    {
        private readonly IResultService _resultService;

        public ResultController(IResultService resultService)
        {
            _resultService = resultService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResultResponse>>> GetResults(int accId)
        {
            var list = await _resultService.GetResult(accId);

            return Ok(list);
        }
    }
}
