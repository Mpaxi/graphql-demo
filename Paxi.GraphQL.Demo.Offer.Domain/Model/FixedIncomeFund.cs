using System;

namespace Paxi.GraphQL.Demo.Offer.Domain.Model
{
    public class FixedIncomeFund
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public decimal Price { get; set; }
        public float Cota { get; set; }
    }
}