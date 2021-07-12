using Paxi.GraphQL.Demo.Offer.Domain.Contract.Service;
using Paxi.GraphQL.Demo.Offer.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.GraphQL.FundWallet.Resolver
{
    public class MultimarketFundResolver
    {
        private readonly IMultimarketFundService _service;

        public MultimarketFundResolver(IMultimarketFundService service)
        {
            _service = service;
        }

        public async Task<ICollection<MultimarketFund>> GetMultimarketFund(Entity.FundWallet fundWallet)
        {
            return await _service.GetMultimarketFunds(fundWallet.ClientId);

        }
    }
}
