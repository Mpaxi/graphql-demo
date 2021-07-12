using Paxi.GraphQL.Demo.Offer.Domain.Contract;
using Paxi.GraphQL.Demo.Offer.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.Implementation
{
    public class FundService : IFundService
    {
        public async Task<FundWallet> GetFundWallet(Guid clientId)
        {
            return new FundWallet
            {
                ClientId = Guid.NewGuid(),
                Id = Guid.NewGuid()
            };
        }
    }
}
