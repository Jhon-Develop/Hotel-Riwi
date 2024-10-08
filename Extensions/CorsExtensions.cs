using Microsoft.Extensions.DependencyInjection;

namespace Hotel_Riwi.Extensions
{
    public static class CorsExtensions
    {
        public static IServiceCollection AddCorsConfiguration(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:5128", 
                                            "http://localhost:3000")
                                .AllowAnyHeader()
                                .AllowAnyMethod()
                                .AllowCredentials();
                    });
            });

            return services;
        }
    }
}