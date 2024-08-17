using SqlClientBackend.Controllers;

namespace SqlClientBackend.Routes
{
    public static class DashboardRoutes
    {
        public static WebApplication DashboardRouteBuilder(this WebApplication app)
        {
            var groupBuilder = app.MapGroup("/dashboard");
            groupBuilder.MapGet("/data", DashboardContoller.GetData);
            groupBuilder.MapPost("/query", DashboardContoller.ExecuteQuery);
            groupBuilder.MapGet("/history", DashboardContoller.GetQueryHistory);
            return app;
        }
    }
}
