﻿using System.Linq;
using System.Threading.Tasks;
using CrossExchange.Repository;
using CrossExchange.Model;
using Microsoft.AspNetCore.Mvc;

namespace CrossExchange.Controller
{
    [Route("api/Portfolio")]
    public class PortfolioController : ControllerBase
    {
        private IPortfolioRepository _portfolioRepository { get; set; }

        public PortfolioController(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }

        [HttpGet("{portFolioid}")]
        public async Task<IActionResult> GetPortfolioInfo([FromRoute]int portFolioId)
        {
            var portfolio = await _portfolioRepository.GetAsync(portFolioId);

            return Ok(portfolio);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Portfolio value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _portfolioRepository.InsertAsync(value);

            return Created($"Portfolio/{value.Id}", value);
        }

    }
}
