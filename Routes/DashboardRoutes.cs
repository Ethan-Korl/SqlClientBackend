using SqlClientBackend.Controllers;

namespace SqlClientBackend.Routes
{
    public static class DashboardRoutes
    {
        public static RouteGroupBuilder DashboardRouteBuilder(this RouteGroupBuilder DashboardGroup)
        {
            DashboardGroup.MapGet("/data", DashboardContoller.GetData);
            DashboardGroup.MapPost("/query", DashboardContoller.ExecuteQuery);
            DashboardGroup.MapGet("/history", DashboardContoller.GetQueryHistory);
            return DashboardGroup;
        }
    }
}
