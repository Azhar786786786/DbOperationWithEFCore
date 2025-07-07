using DBOperationsWithEFCore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyTypeController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyTypeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //[HttpGet]
        //public IActionResult GetAllCurrencies()
        //{
        //    //var result = _appDbContext.Currencies.ToList();

        //    //var result = (from curr in _appDbContext.Currencies
        //    //              select curr).ToList();

        //    var result = from curr in _appDbContext.Currencies
        //                 select curr;
        //    return Ok(result.ToList());
        //}

        [HttpGet]
        public async Task<IActionResult> GetAllCurrencies()
        {
            //var result =await _appDbContext.Currencies.ToListAsync();
            //return Ok(result);

            var result = await (from curr in _appDbContext.Currencies
                                select curr).ToListAsync();
            return Ok(result);
        }

        [HttpGet("{id:int}")]//mandatory with integer value
        public async Task<IActionResult> GetCurrencieByIdAsync([FromRoute] int id)
        {
            var result = await _appDbContext.Currencies.FindAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("{name}")]//mandatory with string value
        public async Task<IActionResult> GetCurrencieByNameAsync([FromRoute] string name)
        {
            var result = await _appDbContext.Currencies.Where(x => x.Title == name).FirstOrDefaultAsync();
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        //[HttpGet("{name}")]//mandatory with optional value
        //public async Task<IActionResult> GetCurrencieByNameAsync([FromRoute] string name, [FromQuery] string description)
        //{
        //    var result = await _appDbContext.Currencies.Where(x => x.Title == name && (string.IsNullOrEmpty(description) || x.Description == description)).FirstOrDefaultAsync();
        //    if (result == null)
        //        return NotFound();
        //    return Ok(result);
        //}

        [HttpGet("{name}/{description}")]
        public async Task<IActionResult> GetCurrencieByNameAsync([FromRoute] string name, [FromRoute] string description)
        {
            //var result = await _appDbContext.Currencies.Where(x => x.Title == name && x.Description == description).FirstOrDefaultAsync();//for single record
            var result = await _appDbContext.Currencies.Where(x => x.Title == name && x.Description == description).ToListAsync();//for multiple record
            if (result == null)
                return NotFound();
            return Ok(result);
        }
    }
}
