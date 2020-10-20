using System;
using Microsoft.EntityFrameworkCore;

// required to add console logging
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

// import the Models (representing structure of tables in database)
using SMS.Data.Models; 

namespace SMS.Data.Repositories
{
    // The Context is How EntityFramework communicates with the database
    // We define DbSet properties for each table in the database
    public class DatabaseContext :DbContext
    {
        // create DbSets for various models
        public DbSet<Student> Students { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<StudentModule> StudentModules { get; set; }


        // Configure the context to use sqlite database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite("Filename=SMS.db")
                /** use logger to log the sql commands issued by entityframework **/
                /*.UseLoggerFactory(new ServiceCollection()
                     .AddLogging(builder => builder.AddConsole())
                     .BuildServiceProvider()
                     .GetService<ILoggerFactory>()
                 )*/
                ;
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
