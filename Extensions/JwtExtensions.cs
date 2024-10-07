using System.Text;
using Microsoft.IdentityModel.Tokens;
using Hotel_Riwi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Hotel_Riwi.Services.Interfaces;
using Hotel_Riwi.Repositories.Interfaces;
using Hotel_Riwi.Repositories;



namespace Hotel_Riwi.Extensions
{
    public static class JwtExtensions
    {
        public static IServiceCollection AddJwtConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtKey = configuration["JWTKEY"] ?? throw new InvalidOperationException("JWT Key is not configured.");
            var jwtExpireMinutes = int.Parse(configuration["JWT_EXPIRE_MINUTES"] ?? "30");

            services.AddSingleton<IJwtService>(new JwtService(jwtKey, jwtExpireMinutes));

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtKey)),
                    ClockSkew = TimeSpan.Zero
                };
            });

            services.AddScoped<IGuestRepository, GuestRepository>();

            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}