using HotChocolate;
using HotChocolate.Types;
using Paxi.GraphQL.Demo.Offer.Domain.Contract.Service;
using Paxi.GraphQL.Demo.Offer.Domain.Entity;
using Paxi.GraphQL.Demo.Offer.Domain.GraphQL.FundWallet.Resolver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.GraphQL.FundWallet
{
    public class FundWalletType : ObjectType<Entity.FundWallet>
    {
        protected override void Configure(IObjectTypeDescriptor<Entity.FundWallet> descriptor)
        {
            descriptor.Description("Represents any executable command.");

            descriptor
                .Field(c => c.Id)
                .Description("Represents the unique ID for the fund.");

            descriptor
                .Field(c => c.ClientId)
                .Description("Represents the unique ID for the client.");


            descriptor
                .Field(c => c.MultimarketFunds)
                .ResolveWith<MultimarketFundResolver>(c => c.GetMultimarketFund(default!))
                .Description("This is the platform to which the command belongs.");

        }

    }
}
