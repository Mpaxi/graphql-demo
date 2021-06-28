using Microsoft.EntityFrameworkCore;
using Paxi.GraphQL.Demo.Fund.Api.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Fund.Api.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<FixedIncomeFund> FixedIncomeFunds { get; set; }
        public DbSet<MultimarketFund> MultimarketFunds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
