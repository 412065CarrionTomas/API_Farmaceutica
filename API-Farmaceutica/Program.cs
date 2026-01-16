using API_Farmaceutica.Application.Features.FacturasFeatures;
using API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters;
using API_Farmaceutica.Application.Features.FacturasFeatures.PostFactura;
using API_Farmaceutica.Application.Features.ProductosFeatures.GetProductos;
using API_Farmaceutica.Application.Features.ProductosFeatures.GetProductosByFilters;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Infrastructure.Repositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using System.Reflection;
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
