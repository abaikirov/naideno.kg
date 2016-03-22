using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using naideno.kg.Models;

namespace naideno.kg.Context
{
	public class EFDbContext : DbContext
	{
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Universal> Universals { get; set; }
        public DbSet<User> Users { get; set; }
        //Ktaff
        //lol
    }
}