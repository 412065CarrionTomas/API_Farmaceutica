using API_Farmaceutica.Application.Features.FacturasFeatures;
using API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters;
using API_Farmaceutica.Application.Features.FacturasFeatures.PostFactura;
using API_Farmaceutica.Application.Features.JWTFeatures;
using API_Farmaceutica.Application.Features.JWTFeatures.Authenticate;
using API_Farmaceutica.Application.Features.ProductosFeatures.GetProductos;
using API_Farmaceutica.Application.Features.ProductosFeatures.GetProductosByFilters;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Infrastructure.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Scalar.AspNetCore;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

namespace API_Farmaceutica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                .AddControllers()
                .AddJsonOptions(opts =>
                {
                    opts.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                    opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                });
            builder.Services.AddOpenApi();

            //CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            //CONTEXT
            builder.Services.AddDbContext<FarmaceuticaContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

            //AUTOMAPPER
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //REPOSITORIES
                // FACTURAS 
            builder.Services.AddScoped<IFacturaRepository, FacturaRepository>();
                //PRODUCTOS
            builder.Services.AddScoped<IProductoRepository, ProductoRepository>();

            //FEATURES
                //FACTURA
            builder.Services.AddScoped<GetFacturasHandler>();
            builder.Services.AddScoped<GetFacturasByFiltersHandler>();
            builder.Services.AddScoped<PostFacturaHandler>();

                //PRODUCTOS
            builder.Services.AddScoped<GetProductosHandler>();
            builder.Services.AddScoped<GetProductosByFiltersHandler>();

            //JWT
            builder.Services.AddScoped<IUsusarioRepository, UsuarioRepository>();
            builder.Services.AddScoped<GenerateToken>();
            builder.Services.AddScoped<LoginUsuarioHandler>();

            //AddAuthentication
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["Jwt:Audience"],
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)),
                    ClockSkew = TimeSpan.Zero
                };
            });

            //AddAuthorization
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy =>
                policy.RequireRole("Admin"));

                options.AddPolicy("UserOrAdmin", policy =>
                policy.RequireRole("Admin", "User"));

            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference(options
                    => options.WithTitle(title: "Farmaceutica-API")
                    .WithTheme(ScalarTheme.DeepSpace)
                    .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient));
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowAll");

            app.UseAuthentication();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
