namespace SqlClientBackend.Controllers
{
    public static class DatabaseController
    {
        public static IResult NewConnection()
        {
            return Results.Ok();
        }

        public static IResult GetAllConnections(){

            return Results.Ok();
        }

        public static IResult GetConnection(int connectionId)
        {
            return Results.Ok();
        }

        public static IResult DeleteConnection(int connectionId){
            return Results.Ok();
        }
    }
}