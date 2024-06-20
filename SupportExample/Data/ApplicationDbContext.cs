using Microsoft.EntityFrameworkCore;
using SupportExample.Models;

namespace SupportExample.Data;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Project> Projects { get; set; }
}