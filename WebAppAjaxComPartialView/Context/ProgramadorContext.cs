using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAjaxComPartialView.Models;

namespace WebAppAjaxComPartialView.Context
{
    public class ProgramadorContext : DbContext
    {
        public ProgramadorContext(DbContextOptions<ProgramadorContext> options):base(options)
        {

        }

        public virtual DbSet<Programador> Programadores { get; set; }

    }
}
