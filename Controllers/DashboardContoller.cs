using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SqlClientBackend.Models;

namespace SqlClientBackend.Controllers
{
    public class SqlQuery
    {
        public string? id { get; set; }
        public required string query { get; set; }
    }

    public static class DashboardContoller
    {
        public static IResult GetData()
        {
            Dictionary<string, int> dataItem = new Dictionary<string, int>();
            dataItem.Add("kalippo", 5);
            dataItem.Add("plate", 4);
            return Results.Ok();
        }

        public static IResult ExecuteQuery(SqlQuery ClientQuery)
        {
            return Results.Ok(ClientQuery);
        }

        public static IResult GetQueryHistory(){
            return Results.Ok();
        }
    }

}
