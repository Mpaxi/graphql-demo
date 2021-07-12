using GraphQL.Server.Ui.Voyager;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Paxi.GraphQL.Demo.Offer.Api.Data;
using Paxi.GraphQL.Demo.Offer.Domain.Contract.Service;
using Paxi.GraphQL.Demo.Offer.Domain.GraphQL;
using Paxi.GraphQL.Demo.Offer.Domain.GraphQL.FundWallet;
using Paxi.GraphQL.Demo.Offer.Services.MultiMarket;

namespace Paxi.GraphQL.Demo.Offer.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddPooledDbContextFactory<AppDbContext>(opt => opt.UseSqlite("Data Source=Contatos.db"));

            services.AddScoped<IMultimarketFundService, MultimarketFundService>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Paxi.GraphQL.Demo.Offer.Api", Version = "v1" });
            });

            services.AddPooledDbContextFactory<AppDbContext>(opt => opt.UseSqlite
            ("Data Source=Contatos.db"));

            services
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddType<FundWalletType>()
                .AddFiltering()
                .AddSorting()
                .AddInMemorySubscriptions();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Paxi.GraphQL.Demo.Offer.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGraphQL();
            });

            app.UseGraphQLVoyager(new GraphQLVoyagerOptions()
            {
                GraphQLEndPoint = "/graphql",
                Path = "/graphql-voyager"
            });

        }
    }
}
