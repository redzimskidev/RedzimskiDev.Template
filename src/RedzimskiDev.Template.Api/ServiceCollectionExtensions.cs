using Microsoft.OpenApi.Models;

namespace RedzimskiDev.Template.Api;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApi(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "RedzimskiDev Template API"
                });
        });
        services.AddHealthChecks();

        return services;
    }
}