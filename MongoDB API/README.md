# MongoDB .NET API

This is a simple .NET Web API that connects to MongoDB running on Docker.

## Prerequisites

- .NET 8.0 SDK
- MongoDB running on Docker (port 8081)

## Setup

1. Restore NuGet packages:
```bash
dotnet restore
```

2. Build the project:
```bash
dotnet build
```

3. Run the application:
```bash
dotnet run
```

## API Endpoints

The API will be available at `http://localhost:5000` (HTTP) or `https://localhost:5001` (HTTPS).

### Product Endpoints

- `GET /api/product` - Get all products
- `GET /api/product/{id}` - Get product by ID
- `POST /api/product` - Create a new product
- `PUT /api/product/{id}` - Update an existing product
- `DELETE /api/product/{id}` - Delete a product
- `GET /api/product/category/{category}` - Get products by category
- `GET /api/product/instock` - Get all in-stock products

### Sample Product JSON

```json
{
  "name": "Sample Product",
  "description": "This is a sample product",
  "price": 29.99,
  "category": "Electronics",
  "inStock": true
}
```

## Swagger Documentation

When running in development mode, visit `/swagger` to see the interactive API documentation.

## MongoDB Configuration

The MongoDB connection is configured in `appsettings.json`:

```json
{
  "MongoDbSettings": {
    "ConnectionString": "mongodb://localhost:8081",
    "DatabaseName": "ProductDatabase",
    "ProductCollectionName": "Products"
  }
}
```
