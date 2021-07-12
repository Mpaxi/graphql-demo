using Paxi.GraphQL.Demo.Offer.Domain.Contract.Service;
using Paxi.GraphQL.Demo.Offer.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Services.MultiMarket
{
    public class MultimarketFundService : IMultimarketFundService
    {
        public async Task<ICollection<MultimarketFund>> GetMultimarketFunds(Guid clientId)
        {
            return new List<MultimarketFund> { new MultimarketFund { Id = Guid.NewGuid(), WalletId = clientId } };
        }
    }
}
