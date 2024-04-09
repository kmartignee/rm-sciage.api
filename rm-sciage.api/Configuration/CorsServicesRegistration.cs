using rm_sciage.domain.Model.Settings;

namespace rm_sciage.api.Configuration;

public static class CorsServicesRegistration
{
    private const string AllowMySpecificOrigins = "allowMySpecificOrigins";

    private static readonly CorsSettings CorsSettings = new();

    public static void ConfigureCorsServices(this IServiceCollection service, IConfiguration configuration)
    {
        configuration.GetSection(CorsSettings.Key).Bind(CorsSettings);

        service.AddCors(options =>
        {
            options.AddPolicy(AllowMySpecificOrigins,
                builder =>
                    builder.WithOrigins(CorsSettings.AllowedHosts)
                        .SetIsOriginAllowedToAllowWildcardSubdomains()
                        .SetIsOriginAllowed(_ => true)
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
        });
    }

    public static IApplicationBuilder UseDefaultCors(this IApplicationBuilder applicationBuilder)
    {
        return applicationBuilder.UseCors(AllowMySpecificOrigins);
    }
}