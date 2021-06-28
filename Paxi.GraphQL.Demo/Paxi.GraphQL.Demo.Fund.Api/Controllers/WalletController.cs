using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Paxi.GraphQL.Demo.Fund.Api.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Fund.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WalletController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Route("GetClientWallet")]
        [HttpGet]
        public async Task<IActionResult> GetClientWalletByClientIdAsync([FromQuery] Guid clientId)
        {
            return Ok(await _context.Wallets.Include(i => i.FixedIncomeFunds).Include(i => i.MultimarketFunds).FirstOrDefaultAsync(f => f.ClientId.Equals(clientId)));
        }

        [Route("AddClientWallet")]
        [HttpPost]
        public async Task<IActionResult> AddClientWalletAsync([FromBody] Model.Wallet wallet)
        {
            try
            {
                var newWallet = await _context.Wallets.AddAsync(wallet);
                await _context.SaveChangesAsync();
                return Ok(newWallet);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }


        }
    }
}
