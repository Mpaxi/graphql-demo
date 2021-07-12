using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.Entity
{
    public class FixedIncomeFund
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public decimal Price { get; set; }
        public float Cota { get; set; }
    }
}
