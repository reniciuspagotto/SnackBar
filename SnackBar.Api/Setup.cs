using Microsoft.Extensions.DependencyInjection;
using SnackBar.Domain.Handlers;
using SnackBar.Domain.Repositories;
using SnackBar.Infra.Repositories;
using Swashbuckle.AspNetCore.Swagger;

namespace SnackBar.Api
{
    public static class Setup
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IIngredientRepository, IngredientRepository>();
            services.AddSingleton<ISnackRepository, SnackRepository>();
            services.AddSingleton<IOrderRepository, OrderRepository>();
        }

        public static void ConfigureHandlers(this IServiceCollection services)
        {
            services.AddTransient<OrderHandler, OrderHandler>();
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "APIs",
                    Description = "Available Web APIs",
                    TermsOfService = "None",
                    Contact = new Contact() { Name = "SnackBar", Email = "arquitetura@teste.com", Url = "www.arquitetura.com" }
                });
            });
        }
    }
}
