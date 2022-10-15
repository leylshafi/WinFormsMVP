using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories.Contexts;

public  class MyDBContext:DbContext
{
    // Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = 'DemoMVP'; Integrated Security = True; 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog='DemoMVP';Integrated Security=True;");

        //Configuration
        //Configuration.Json
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Student>? Students { get; set; }
}
