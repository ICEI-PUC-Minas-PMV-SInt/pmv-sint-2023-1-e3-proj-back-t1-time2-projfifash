using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using back_end_crud.Models;

namespace back_end_crud.Data
{
    public class back_end_crudContext : DbContext
    {
        public back_end_crudContext (DbContextOptions<back_end_crudContext> options)
            : base(options)
        {
        }

        public DbSet<back_end_crud.Models.Departamentos> Departamentos { get; set; }
    }
}
