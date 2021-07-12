using HotChocolate;
using HotChocolate.Data;
using Paxi.GraphQL.Demo.Offer.Domain.GraphQL.FundWallet.Input;
using System;

namespace Paxi.GraphQL.Demo.Offer.Domain.GraphQL
{
    /// <summary>
    /// Represents the queries available.
    /// </summary>
    [GraphQLDescription("Represents the queries available.")]
    public class Query
    {
        /// <summary>
        /// Gets the queryable <see cref="Command"/>.
        /// </summary>
        /// <param name="context">The <see cref="AppDbContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        //[UseDbContext(typeof(AppDbContext))]
        //[UseFiltering]
        //[UseSorting]
        [GraphQLDescription("Gets the queryable command.")]
        public Domain.Entity.FundWallet GetFundWallet(Guid input)//[ScopedService] AppDbContext context)
        {
            return new Domain.Entity.FundWallet
            {
                Id = Guid.NewGuid(),
                ClientId = Guid.NewGuid()
            };
        }
    }
}
