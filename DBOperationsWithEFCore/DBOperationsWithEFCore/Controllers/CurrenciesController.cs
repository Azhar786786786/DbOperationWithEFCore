using DBOperationsWithEFCore.Data;
using DBOperationsWithEFCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CurrenciesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAllCurrencies()
        {
            //var result=_appDbContext.Currencies.ToList();
            // var result=(from currencies in _appDbContext.Currencies select currencies).ToList();
            //var result =await _appDbContext.Currencies.ToListAsync();

            //var result = await (from currency in _appDbContext.Currencies
            //                    select new CurrencyType()
            //                    {
            //                        Id = currency.Id,
            //                        Title = currency.Title,
            //                        Description = currency.Description
            //                    }).ToListAsync();

            var result = await (from currency in _appDbContext.Currencies
                                select new
                                {
                                    CurrencyId = currency.Id,
                                    CurrencyName = currency.Title,
                                    CurrencyDescription = currency.Description
                                }).ToListAsync();

            return Ok(result);
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAllCurrenciesByIdAsync()
        {
            var ids = new List<int> { 1, 6, 4, 3 };

            var result = await _appDbContext.Currencies
                .Where(x => ids.Contains(x.Id))
                .ToListAsync();

            return Ok(result);
        }

        [HttpPost("all")]
        public async Task<IActionResult> GetAllCurrenciesByIdAsync([FromBody] List<int> ids)
        {
            //var ids = new List<int> { 1, 6, 4, 3 };

            var result = await _appDbContext.Currencies.Where(x => ids.Contains(x.Id)).ToListAsync();

            return Ok(result);
        }
    }
}
