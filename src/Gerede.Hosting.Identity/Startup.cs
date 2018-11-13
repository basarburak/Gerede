using Gerede.Domain.Data.Manager;
using Gerede.Hosting.Core.Extensions;
using Gerede.Hosting.Identity.ConfigurationStore;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gerede.Hosting.Identity
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddCors(options =>
                       {
                           options.AddPolicy("default", policy =>
                            {
                                policy.WithOrigins("http://localhost:4200")
                                   .AllowAnyHeader()
                                   .AllowAnyMethod();
                            });
                       });

            services.AddIdentityServer()
                    .AddDeveloperSigningCredential()
                    .AddResourceStore<ResourceStore>()
                    .AddClientStore<ClientStore>();

            //  .AddProfileService<ProfileService>();

            services.AddTransient<IClientStore, ClientStore>();
            services.AddTransient<IResourceStore, ResourceStore>();

            services.AddScoped<IIdentityServerService, IIdentityServerManager>();

            services.AddGeredeData(Configuration.GetServerSettings(), false);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseIdentityServer();

            app.UseStaticFiles();

            app.UseCors("default");

            app.UseMvcWithDefaultRoute();
        }
    }
}