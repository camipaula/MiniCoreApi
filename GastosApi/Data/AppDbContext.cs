using GastosApi.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Departamento> Departamento { get; set; }
    public DbSet<Empleado> Empleado { get; set; }
    public DbSet<Gasto> Gastos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}