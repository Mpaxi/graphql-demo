using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.Entity
{ 
    public class FundWallet
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public ICollection<MultimarketFund> MultimarketFunds { get; set; }
        public ICollection<FixedIncomeFund> FixedIncomeFunds { get; set; }
    }
}
