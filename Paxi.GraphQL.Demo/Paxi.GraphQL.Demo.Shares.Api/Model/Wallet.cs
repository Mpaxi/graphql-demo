using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Shares.Api.Model
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public IEnumerable<WalletShare> Shares { get; set; }
    }
}
