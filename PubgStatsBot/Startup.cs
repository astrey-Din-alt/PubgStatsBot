using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using PubgStatsBot.Pubg.Services;
using PubgStatsBot.Telegram.Models;

namespace PubgStatsBot
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
            services.Configure<dynamic>(Configuration);
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IMatchService, MatchService>();
            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PubgStatBot API", Version = "v1", Description = "Интрефейс PubgStatBot API" });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PubgStatBot API");
                c.RoutePrefix = string.Empty;
            });
            //Bot.GetBotClientAsync().Wait();
        }
    }
}