using SqlClientBackend.Controllers;

namespace SqlClientBackend.Routes
{
    public static class AccountRoutes
    {
        public static WebApplication AccountRouteBuilder(this WebApplication app)
        {
            var groupBuilder = app.MapGroup("/accounts");
            groupBuilder.MapPost("/signup", AccountsController.Signup).WithParameterValidation();
            groupBuilder.MapPost("/verify-email", AccountsController.VerifyEmail);
            groupBuilder.MapPost("/submit-email", AccountsController.SubmitEmailForVerification);
            return app;
        }
    }
}
