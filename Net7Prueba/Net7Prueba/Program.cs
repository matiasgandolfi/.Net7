using Microsoft.EntityFrameworkCore;
using Net7Prueba.Data;
using Net7Prueba.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuracion de DbContext

builder.Services.AddDbContext<StoreDbContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("StoreConnection"));
    }
    );

builder.Services.AddTransient<IProductService, ProductService> ();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
