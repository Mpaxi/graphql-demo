using HotChocolate.Data.Filters;
using Paxi.GraphQL.Demo.Offer.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.GraphQL.FundWallet.Filter
{
    public class FundWalltetFilterType : FilterInputType<Entity.FundWallet>
    {
        protected override void Configure(IFilterInputTypeDescriptor<Entity.FundWallet> descriptor)
        {
            descriptor.BindFieldsExplicitly();
            descriptor.Field(f => f.ClientId).Name("client_id");            
        }

    }


}
