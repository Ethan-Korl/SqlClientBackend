using Microsoft.AspNetCore.Mvc;
using SqlClientBackend.Models;
using SqlClientBackend.Respositories;
using SqlClientBackend.Utils;
using SqlClientBackend.Dtos;

namespace SqlClientBackend.Controllers
{
    [ApiController]
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
        public static IResult Signup(EamilVerificationDto data)
        {
            Console.WriteLine(GeneralUtils.GenerateCode(1000, 9999));
            // data.email
            // Results.Problem(statusCode)
            return Results.Ok(data);
        }
        public static IResult Login()
        {
            return Results.Ok();
        }

        // Get


    }

}
