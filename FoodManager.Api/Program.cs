using FoodManager.Api.Filters;
using FoodManager.DataAccess;
using FoodManager.DataAccess.Context;
using FoodManager.DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<FoodManagerContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IDataSeeder, EfCoreDataSeeder>();
builder.Services.AddScoped<EntityContext>();

builder.Services.AddControllers(opts =>
{
    opts.Filters.Add<ActionInitialiserFilter>();
})
    .AddJsonOptions(jsonOpts =>
{
    jsonOpts.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    SeedDatabase();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void SeedDatabase()
{
    
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<IDataSeeder>();
        service.SeedData();
    }
}
