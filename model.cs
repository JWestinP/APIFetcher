using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(INSERT LOCAL HOST SERVER NAME);Database=APIFetcherDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}

public class Product
{
    public int id { get; set; }
    public string title { get; set; }
    public decimal price { get; set; }
    public string description { get; set; }
    public string category { get; set; }

}

public class Customer
{
    public int id { get; set; }
    public string name { get; set; }
}