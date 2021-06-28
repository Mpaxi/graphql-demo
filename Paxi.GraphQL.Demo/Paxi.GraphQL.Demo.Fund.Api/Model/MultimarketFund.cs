using System;
using System.Text.Json.Serialization;

namespace Paxi.GraphQL.Demo.Fund.Api.Model
{
    public class MultimarketFund
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        [JsonIgnore]
        public Wallet Wallet { get; set; }
        public decimal Price { get; set; }
        public float Cota { get; set; }
    }
}