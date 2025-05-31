using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using TechStoreInventory.Models;

namespace TechStoreInventory.Data
{

    /// <summary>
    /// The DBcontext class represents a session with the database.
    /// It allows Entity Framework Core to query, save, and manage data
    /// by mapping database tables to C# classes.
    /// </summary>
    public class InventoryContext : DbContext
        {

        /// <summary>
        /// Constructor for the InventoryContext class.
        /// Accepts DbContextOptions to configure the context, such as the database provider and connection string.
        /// </summary>
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
                


        }

        /// The DbSet provides access to all Product entities and allows querying and saving instances.
        public DbSet<Products> Products { get; set; }


    }
}
