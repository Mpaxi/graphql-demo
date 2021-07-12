using Paxi.GraphQL.Demo.Offer.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.Entity
{
    public class Offer
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public ICollection<Proposal> Proposals { get; set; }
        public FundWallet FundWallet { get; set; }
    }
}
