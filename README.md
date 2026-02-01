# API Farmaceutica 💊

A RESTful API for managing pharmaceutical operations including medications, products, suppliers, employees, purchases, sales, and more. Built with ASP.NET Core and Entity Framework Core using PostgreSQL database.

## 📋 Description

API Farmaceutica is a comprehensive pharmaceutical management system that handles various aspects of a pharmacy business including:

- Medication and product inventory management
- Supplier and provider management
- Purchase and sales operations
- Invoice generation
- Employee and delivery personnel management
- Branch office management
- Stock control with batch tracking

## ✨ Features

- **Medication Management**: Track medications with detailed information including dosage, presentation types, and batch control
- **Product Management**: Handle general pharmaceutical products and supplies
- **Supplier Management**: Manage provider information and relationships
- **Purchase Operations**: Record and track purchases with detailed line items
- **Invoice System**: Generate and manage invoices for sales
- **Employee Management**: Organize employee information and branch assignments
- **Delivery Management**: Coordinate delivery personnel and operations
- **Branch Management**: Handle multiple pharmacy locations
- **Stock Control**: Track product and medication batches with expiration dates
- **Geographic Organization**: Support for countries, provinces, and localities

## 🛠️ Technology Stack

- **Framework**: .NET 10.0
- **Language**: C#
- **Database**: PostgreSQL
- **ORM**: Entity Framework Core with Npgsql
- **API Documentation**: OpenAPI (Swagger) with Scalar
- **Object Mapping**: AutoMapper
- **Architecture**: Clean Architecture with Repository Pattern

### Main Dependencies

- Microsoft.AspNetCore.OpenApi (10.0.0)
- Npgsql.EntityFrameworkCore.PostgreSQL (10.0.0)
- AutoMapper (12.0.1)
- Scalar.AspNetCore (2.11.0)

## 📦 Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later
- [PostgreSQL](https://www.postgresql.org/download/) 12 or later
- A code editor (Visual Studio 2022, Visual Studio Code, or Rider)
- Git

## 🚀 Installation

### 1. Clone the Repository

```bash
git clone https://github.com/412065CarrionTomas/API_Farmaceutica.git
cd API_Farmaceutica
```

### 2. Database Setup

#### Create Database

```sql
CREATE DATABASE farmaceutica;
```

#### Run Database Scripts

Execute the SQL scripts in order:

1. **DDL Script** - Creates all tables and relationships:
   ```bash
   psql -U postgres -d farmaceutica -f API-Farmaceutica/FarmaceuticaDDL.sql
   ```

2. **Insert Script** - Populates initial data:
   ```bash
   psql -U postgres -d farmaceutica -f API-Farmaceutica/FarmaceuticaInserts.sql
   ```

### 3. Configure Connection String

Update the connection string in `API-Farmaceutica/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=farmaceutica;Username=your_username;Password=your_password"
  }
}
```

> ⚠️ **Security Note**: Never commit sensitive credentials. Consider using User Secrets for development or environment variables for production.

### 4. Restore Dependencies

```bash
cd API-Farmaceutica
dotnet restore
```

### 5. Build the Project

```bash
dotnet build
```

### 6. Run the Application

```bash
dotnet run
```

The API will start and be available at:
- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`

## 📖 API Documentation

When running in development mode, the API documentation is available through Scalar:

```
https://localhost:5001/scalar/v1
```

You can also access the OpenAPI specification at:

```
https://localhost:5001/openapi/v1.json
```

## 🗂️ Project Structure

```
API_Farmaceutica/
├── API-Farmaceutica/
│   ├── Application/              # Application layer
│   │   ├── Features/            # Feature-specific logic
│   │   └── Shareds/             # Shared application components
│   │       └── InterfacesRepository/  # Repository interfaces
│   ├── Domain/                  # Domain layer
│   │   └── Models/              # Entity models
│   ├── Infrastructure/          # Infrastructure layer
│   │   └── Repositories/        # Repository implementations
│   ├── Controllers/             # API controllers (if any)
│   ├── Program.cs               # Application entry point
│   ├── FarmaceuticaDDL.sql      # Database schema script
│   ├── FarmaceuticaInserts.sql  # Database seed data script
│   └── appsettings.json         # Configuration file
```

## 💾 Database Schema

The database includes the following main entities:

### Core Tables
- **medicamentos**: Medications catalog
- **productos**: General products catalog
- **proveedores**: Suppliers information
- **sucursales**: Branch offices
- **empleados**: Employees
- **repartidores**: Delivery personnel
- **compras**: Purchase orders
- **detalles_compras**: Purchase order line items
- **facturas**: Sales invoices
- **detalles_facturas**: Invoice line items

### Supporting Tables
- **tipos_documentos**: Document types
- **paises**: Countries
- **provincias**: Provinces/States
- **localidades**: Cities/Localities
- **tipos_presentaciones**: Product presentation types
- **unidades_medidas**: Measurement units
- **tipos_suministros**: Supply types
- **metodos_pagos**: Payment methods
- **lotes_medicamentos**: Medication batches
- **lotes_productos**: Product batches

## 🔌 Available Repositories

The API provides the following repositories:

- `IProveedorRepository` - Supplier management
- `ISucursalRepository` - Branch office management
- `ICompraRepository` - Purchase management
- `IFacturaRepository` - Invoice management
- `IMedicamentoRepository` - Medication management
- `IProductoRepository` - Product management
- `IDetalleCompraRepository` - Purchase detail management
- `IEmpleadoRepository` - Employee management
- `IRepartidorRepository` - Delivery personnel management

## 🔧 Configuration

### Development Environment

The application uses different configuration files for different environments:

- `appsettings.json` - Base configuration
- `appsettings.Development.json` - Development-specific settings

### JSON Serialization

The API is configured with:
- Null value handling: Properties with null values are omitted from responses
- Reference handling: Circular references are ignored to prevent serialization errors

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is available for educational and commercial use.

## 👤 Author

**Tomas Carrion**
- GitHub: [@412065CarrionTomas](https://github.com/412065CarrionTomas)

## 🙏 Acknowledgments

- Built with ASP.NET Core
- Database management with PostgreSQL
- API documentation with Scalar

---

For questions or support, please open an issue in the GitHub repository.
