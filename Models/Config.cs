using Microsoft.EntityFrameworkCore;
using SqlClientBackend.Models;

namespace SqlClientBackend.Models
{
    class SqlClientDbContext(DbContextOptions<SqlClientDbContext> options)
   : DbContext(options)
    {
        public DbSet<User> users => Set<User>();
        public DbSet<QueryHistory> query_history => Set<QueryHistory>();
        public DbSet<EmailCode> email_codes => Set<EmailCode>();
        public DbSet<ConnectedDb> connected_dbs => Set<ConnectedDb>();

    }
}