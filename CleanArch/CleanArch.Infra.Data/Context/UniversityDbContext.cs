using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context;

public class UniversityDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Course> Courses { get; set; }
}
