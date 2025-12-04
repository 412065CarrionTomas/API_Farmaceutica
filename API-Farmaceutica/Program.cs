using API_Farmaceutica.Application.Features.FacturasFeatures;
using API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters;
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
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            //CONTEXT
            builder.Services.AddDbContext<FarmaceuticaContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

            //AUTOMAPPER
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //REPOSITORIES
                // PROVEEDORES
            builder.Services.AddScoped<IProveedorRepository, ProveedorRepository>();
                // SUCURSALES
            builder.Services.AddScoped<ISucursalRepository, SucursalRepository>();
                // COMPRAS
            builder.Services.AddScoped<ICompraRepository, CompraRepository>();
                // FACTURAS 
            builder.Services.AddScoped<IFacturaRepository, FacturaRepository>();
                // MEDICAMENTOS
            builder.Services.AddScoped<IMedicamentoRepository, MedicamentoRepository>();
                // PRODUCTOS
            builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
                // DETALLE DE COMPRA
            builder.Services.AddScoped<IDetalleCompraRepository, DetalleCompraRepository>();
                // EMPLEADOS
            builder.Services.AddScoped<IEmpleadoRepostiory, EmpleadoRepository>();
                // REPARTIDOR
            builder.Services.AddScoped<IRepartidorRepository, RepartidorRepository>();

            //FEATURES
                //FACTURA
            builder.Services.AddScoped<GetFacturasHandler>();
            builder.Services.AddScoped<GetFacturasByFiltersHandler>();

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
