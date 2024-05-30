using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace X.Data.EF
{
    public class XDbContextFactory : IDesignTimeDbContextFactory<XDbContext>
    {
        public XDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot congifuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var connectionString = congifuration.GetConnectionString("XDatabase");
            var optionBuilder = new DbContextOptionsBuilder<XDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new XDbContext(optionBuilder.Options);
        }
    }
}