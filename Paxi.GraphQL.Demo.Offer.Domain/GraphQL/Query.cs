using HotChocolate;
using HotChocolate.Data;
using Paxi.GraphQL.Demo.Offer.Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.GraphQL
{
    [GraphQLDescription("Represents the queries available.")]
    public class Query
    {

        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable platform.")]
        public IQueryable<Entity.Offer> GetOffer([ScopedService] AppDbContext context)
        {
            return context.Offers.AsQueryable();
        }
    }
}
