using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

// import the Models (representing structure of tables in database)
using SMS.Data.Models; 

namespace SMS.Data.Repositories
{
    // The Context is How EntityFramework communicates with the database
    // We define DbSet properties for each table in the database
    public class DatabaseContext : DbContext
    {
        // create DbSets for various models
        public DbSet<Student> Students { get; set; }
     

        // Configure the context to use sqlite database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder               
                /** use logger to log the sql commands issued by entityframework **/
                // .UseLoggerFactory(new ServiceCollection()
                //      .AddLogging(builder => builder.AddConsole())
                //      .BuildServiceProvider()
                //      .GetService<ILoggerFactory>()
                //  )
                 .UseSqlite("Filename=SMS.db");
        }

        // Convenience method to recreate the database thus ensuring the new database takes account of any 
        // changes to the Models or Context.
        public void Initialise()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }       

    }
}
