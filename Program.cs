// Program.cs
using DotNetEnv;
using Hotel_Riwi.Extensions;
using Hotel_Riwi.Repositories;
using Hotel_Riwi.Repositories.Interfaces;
using Hotel_Riwi.Services;

Env.Load();

var builder = WebApplication.CreateBuilder(args);

// Configuración de servicios
builder.Services.AddDatabaseConfiguration(); // Asegúrate de que este método registre ApplicationDbContext
builder.Services.AddCorsConfiguration(); // Configuración de CORS
builder.Services.AddSwaggerConfiguration(); // Configuración de Swagger
builder.Services.AddJwtConfiguration(builder.Configuration); // Configuración de JWT

builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();

builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<BookingService>();

var app = builder.Build();

// Middleware para desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Middleware de Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hotel_Riwi API V1");
});

// Middleware para redirigir la raíz a Swagger
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/")
    {
        context.Response.Redirect("/swagger");
        return;
    }
    await next();
});

// Middleware de CORS
app.UseCors("AllowSpecificOrigin");

// Habilitar archivos estáticos
app.UseStaticFiles();

// Autenticación y autorización
app.UseAuthentication();
app.UseAuthorization();

// Mapeo de controladores
app.MapControllers();

app.Run();
