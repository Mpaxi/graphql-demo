using Paxi.GraphQL.Demo.Offer.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.Contract.Service
{
    public interface IMultimarketFundService
    {
        Task<ICollection<MultimarketFund>> GetMultimarketFunds(Guid clientId);
    }
}
