using SqlClientBackend.Routes;
using SqlClientBackend.Configs;
using SqlClientBackend.Models;
using Microsoft.EntityFrameworkCore;
using SqlClientBackend.Models.MongoDb;

var builder = WebApplication.CreateBuilder(args);

// USE OUR BUILDER OJECT TO REGISTER SERVICES("DATABASES)
var connString = GeneralConfigs.ConnectionString;
// var ss = builder.Environment;

builder.Services.AddAuthentication().AddJwtBearer();

// now register a service
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var vv = Environment.GetEnvironmentVariables();

// Mongodb
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbStoreDatabase"));

builder.Services.AddSqlite<SqlClientDbContext>(connString);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}


// app.UseAuthorization();

app.AccountRouteBuilder();

app.DashboardRouteBuilder();

app.DatabseGroupRouter();

app.Run();

