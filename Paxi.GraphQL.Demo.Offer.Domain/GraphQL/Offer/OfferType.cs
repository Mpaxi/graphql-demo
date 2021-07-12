using HotChocolate;
using HotChocolate.Types;
using Paxi.GraphQL.Demo.Offer.Domain.Contract;
using Paxi.GraphQL.Demo.Offer.Domain.Implementation;
using Paxi.GraphQL.Demo.Offer.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Offer.Domain.GraphQL.Offer
{
    public class OfferType : ObjectType<Entity.Offer>
    {
        protected override void Configure(IObjectTypeDescriptor<Entity.Offer> descriptor)
        {
            descriptor.Description("Representa a Entidade de Ofertas");

            descriptor
                .Field(p => p.Id)
                .Description("Representa o identificador unico de Ofertas");

            descriptor
                .Field(p => p.FundWallet)
                .ResolveWith<Resolvers>(p => p.GetCommands(default!, default!))
                .Description("This is the list of available commands for this platform.");
        }

        private class Resolvers
        {
            public async Task<FundWallet> GetCommands(Entity.Offer offer, [ScopedService] IFundService service)
            {
                return await service.GetFundWallet(offer.ClientId);
            }
        }
    }
}
