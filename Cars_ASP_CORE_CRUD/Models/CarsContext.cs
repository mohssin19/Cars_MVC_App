using Cars_ASP_CORE_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars_ASP_CORE_CRUD.Data
{
    public class CarsContext:DbContext
    {
        public CarsContext(DbContextOptions<CarsContext> options) : base(options)
        {

        }

        public DbSet<Cars> Cars { get; set; }
    }
}
