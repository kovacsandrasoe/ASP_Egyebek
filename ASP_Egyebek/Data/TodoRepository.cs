using ASP_Egyebek.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Egyebek.Data
{
    public class TodoRepository : DbContext
    {
        public TodoRepository(DbContextOptions<TodoRepository> opt)
            :base(opt)
        {

        }
        public DbSet<TodoDay> TodoDays { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<TodoPersonConnector> Conns { get; set; }

    }
}
