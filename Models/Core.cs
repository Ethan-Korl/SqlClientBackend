using Microsoft.EntityFrameworkCore;
using SqlClientBackend.Models;

namespace SqlClientBackend.Models
{
    class SqlClientBackendDatabase : DbContext
    {
        public DbSet<User> user { get; set; }

        public string? DbPath { get; set; }

        public void SqlClientBackendDatabaseContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}