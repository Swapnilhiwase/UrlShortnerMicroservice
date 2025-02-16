using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using UrlShortnerMicroservice.Model;

namespace UrlShortnerMicroservice.Data
{
    public class UrlShortenerContext : DbContext
    {
        /// <summary>
        /// Represent the urlMApping table in database
        /// </summary>
        public DbSet<UrlMapping> UrlMappings { get; set; }


        /// <summary>
        /// This will configure the database engine used for DbContext.
        /// </summary>
        /// <param name="optionsBuilder">Instace of DbContextOptionsBuilder.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            if (!optionsBuilder.IsConfigured)
            {
               optionsBuilder.UseSqlServer("Data Source=LAPTOP-6NSQHL3G\\MSSQLSERVER01;Initial Catalog=UrlShortenerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }
    }
    
}
