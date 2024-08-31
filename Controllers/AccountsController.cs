using Microsoft.AspNetCore.Mvc;
using SqlClientBackend.Models;
using SqlClientBackend.Respositories;
using SqlClientBackend.Utils;
using SqlClientBackend.Dtos;
using SqlClientBackend.Models.MongoDb;
using Microsoft.EntityFrameworkCore;

namespace SqlClientBackend.Controllers
{
    [ApiController]
    public static class AccountsController
    {
        public static async Task<IResult> SubmitEmailForVerification(EmailCode data, SqlClientDbContext db)
        {
            await db.email_codes.FindAsync(data.email);


            var code = GeneralUtils.GenerateCode(1000, 9999);

            data.code = code.ToString();

            db.email_codes.Add(data);
            await db.SaveChangesAsync();
            return Results.Ok(new Dictionary<string, string> { ["message"] = "Confirm code send to tour email" });
        }
        public static IResult VerifyEmail()
        {
            var message = new Dictionary<string, string>();
            message.Add("message", "Email Verified");
            return Results.Ok(message);
        }
        public static IResult Signup(UserRegistrationDto data, SqlClientDbContext db)
        {
            Console.WriteLine(GeneralUtils.GenerateCode(1000, 9999));
            // db.users.Add(data);
            return Results.Ok(data);
        }
        public static IResult Login()
        {
            return Results.Ok();
        }
    }

}
