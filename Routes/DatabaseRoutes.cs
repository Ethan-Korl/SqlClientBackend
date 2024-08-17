using SqlClientBackend.Controllers;

namespace SqlClientBackend.Routes
{
    public static class DatabaseRoutes
    {
        public static WebApplication DatabseGroupRouter(this WebApplication app)
        {
            var groupBuilder = app.MapGroup("/database");

            groupBuilder.MapGet("/all-connections", DatabaseController.GetAllConnections);
            groupBuilder.MapPost("/add-connection", DatabaseController.NewConnection);
            groupBuilder.MapGet("/get-conection:id", DatabaseController.GetConnection);
            groupBuilder.MapDelete("/delete-connection", DatabaseController.DeleteConnection);
            return app;
        }
    }
}