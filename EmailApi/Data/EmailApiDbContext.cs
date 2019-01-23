using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmailApi.Data
{
    public class EmailApiDbContext : DbContext
    {
        public EmailApiDbContext(DbContextOptions<EmailApiDbContext> options) : base(options)
        { }
    }
}
