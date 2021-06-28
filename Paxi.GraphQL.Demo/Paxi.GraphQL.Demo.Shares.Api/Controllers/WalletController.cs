using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Paxi.GraphQL.Demo.Shares.Api.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Shares.Api.Controllers
{
    [ApiController]
    [Route("Share/[controller]")]
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
            return Ok(await _context.Wallets.Include(i => i.Shares).FirstOrDefaultAsync(f => f.ClientId.Equals(clientId)));
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
