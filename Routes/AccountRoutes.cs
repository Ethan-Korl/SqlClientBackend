using SqlClientBackend.Controllers;

namespace SqlClientBackend.Routes
{
    public static class AccountRoutes
    {
        public static RouteGroupBuilder AccountRouteBuilder(this RouteGroupBuilder accountGroup)
        {

            accountGroup.MapPost("/signup", AccountsController.Signup);

            return accountGroup;
        }
    }
}
