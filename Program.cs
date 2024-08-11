using SqlClientBackend.Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGroup("/accounts").AccountRouteBuilder();

app.MapGroup("/dashboard").DashboardRouteBuilder();

app.Run();

