using Paxi.GraphQL.Demo.Offer.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.Contract
{
    public interface IFundService
    {
        Task<FundWallet> GetFundWallet(Guid clientId);
    }
}
