using SqlClientBackend.Models;
using SqlClientBackend.Utils;

namespace SqlClientBackend.Controllers
{

    public static class AccountsController
    {
        public static IResult SubmitEmailForVerification()
        {
            var message = new Dictionary<string, string>();
            message.Add("message", "Email Verified");
            return Results.Ok(message);
        }
        public static IResult VerifyEmail()
        {
            var message = new Dictionary<string, string>();
            message.Add("message", "Email Verified");
            return Results.Ok(message);
        }
        public static IResult Signup(User data)
        {
            Console.WriteLine(GeneralUtils.GenerateCode(1000, 9999));
            return Results.Ok(data);
        }
        public static IResult Login()
        {
            return Results.Ok();
        }



    }

}
