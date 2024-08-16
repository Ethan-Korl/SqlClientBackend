using SqlClientBackend.Controllers;

namespace SqlClientBackend.Routes
{
    public static class AccountRoutes
    {
        public static RouteGroupBuilder AccountRouteBuilder(this RouteGroupBuilder accountGroup)
        {
            accountGroup.MapPost("/signup", AccountsController.Signup);
            accountGroup.MapPost("/verify-email", AccountsController.VerifyEmail);
            accountGroup.MapPost("/submit-email", AccountsController.SubmitEmailForVerification);
            return accountGroup;
        }
    }
}
