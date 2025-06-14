using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Data
{
    /// <summary>
    /// The DBcontext class represents a session with the database.
    /// It allows Entity Framework Core to query, save, and manage data
    /// by mapping database tables to C# classes.
    /// </summary>
    public class ApplicationDBContext : DbContext
    {

        /// Constructor for the InventoryContext class.
        /// Accepts DbContextOptions to configure the context, such as the database provider and connection string.
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        /// The DbSet provides access to all Product entities and allows querying and saving instances.
        public DbSet<Insurees> Insurees { get; set; }
    }


}
