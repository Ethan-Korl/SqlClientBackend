namespace SqlClientBackend.Controllers
{
    public class User
    {
        public required string email { get; set; }
        public required string password { get; set; }
        public string getEmail()
        {
            return email;
        }
    }

    public static class AccountsController
    {
        public static IResult Signup(User data)
        {
            Console.WriteLine(data.getEmail());
            return Results.Ok(data);
        }
        public static IResult Login()
        {

            return Results.Ok();
        }

    }

}
