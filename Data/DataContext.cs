using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
    :base(options)
    {
        
    }

    public DbSet<Producto> Productos { get; set; }
}