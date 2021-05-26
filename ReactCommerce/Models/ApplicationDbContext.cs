using Microsoft.EntityFrameworkCore;
using ReactCommerce.Models.Entities;

namespace ReactCommerce.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the customers.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// Gets or sets the employee territories.
        /// </summary>
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }

        /// <summary>
        /// Gets or sets the order details.
        /// </summary>
        public DbSet<OrderDetail> OrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the regions.
        /// </summary>
        public DbSet<Region> Regions { get; set; }

        /// <summary>
        /// Gets or sets the shippers.
        /// </summary>
        public DbSet<Shipper> Shippers { get; set; }

        /// <summary>
        /// Gets or sets the suppliers.
        /// </summary>
        public DbSet<Supplier> Suppliers { get; set; }

        /// <summary>
        /// Gets or sets the territories.
        /// </summary>
        public DbSet<Territory> Territories { get; set; }
    }
}
