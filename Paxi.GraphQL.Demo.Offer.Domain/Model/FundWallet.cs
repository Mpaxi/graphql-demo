using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.Model
{
    public class FundWallet
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public IEnumerable<MultimarketFund> MultimarketFunds { get; set; }
        public IEnumerable<FixedIncomeFund> FixedIncomeFunds { get; set; }
    }
}
