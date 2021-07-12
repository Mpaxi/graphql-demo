using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.Configuration
{
    public class OfferConfiguration : IEntityTypeConfiguration<Domain.Entity.Offer>
    {
        public void Configure(EntityTypeBuilder<Domain.Entity.Offer> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.ClientId);

            builder.Ignore(p => p.FundWallet);
            builder.Ignore(p => p.Proposals);
        }
    }
}
