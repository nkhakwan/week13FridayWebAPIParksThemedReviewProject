using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace StateNationalPks.Models
{
  public class StateNationalPksContextFactory : IDesignTimeDbContextFactory<StateNationalPksContext>
  {
    StateNationalPksContext IDesignTimeDbContextFactory<StateNationalPksContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<StateNationalPksContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new StateNationalPksContext(builder.Options);
    }
  }
}