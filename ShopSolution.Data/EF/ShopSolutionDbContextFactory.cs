using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShopSolution.Data.EF
{
    //https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dbcontext-creation
    public class ShopSolutionDbContextFactory : IDesignTimeDbContextFactory<ShopSolutionDbContext>
    {
        public ShopSolutionDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<ShopSolutionDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopSolutionDbContext(optionsBuilder.Options);
        }
    }
}
