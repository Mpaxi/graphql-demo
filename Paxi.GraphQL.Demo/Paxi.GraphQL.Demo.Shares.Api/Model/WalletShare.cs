using System;

namespace Paxi.GraphQL.Demo.Shares.Api.Model
{
    public class WalletShare
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public int Unit { get; set; }
        public Guid WalletId { get; set; }
        public Wallet Wallet { get; set; }
    }
}