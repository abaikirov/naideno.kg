using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using naideno.kg.Models;

namespace naideno.kg.Context
{
	public class EFDbContext
	{
        DbSet<Passport> Passports { get; set; }
        DbSet<Universal> Universals { get; set; }
        DbSet<User> Users { get; set; }
    }
}