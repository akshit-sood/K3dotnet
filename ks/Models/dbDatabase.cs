using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace ks.Models
{
    public class dbDatabase: DbContext
    {
        public dbDatabase(DbContextOptions<dbDatabase> options)
           : base(options)
        {
        }
        public  DbSet<save> Profiles { get; set; }
    }
}
