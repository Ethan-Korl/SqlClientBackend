using SqlClientBackend.Routes;
using SqlClientBackend.Configs;
using SqlClientBackend.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// USE OUR BUILDER OJECT TO REGISTER SERVICES("DATABASES)
var connString = GeneralConfigs.ConnectionString;
var ss = builder.Environment;
// now register a service
builder.Services.AddSqlite<SqlClientDbContext>(connString);


var app = builder.Build();




app.MapGroup("/accounts").AccountRouteBuilder()
                     .WithParameterValidation();


app.MapGroup("/dashboard").DashboardRouteBuilder()
                        .WithParameterValidation();

app.Run();

