using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using naideno.kg.Context;
using System.Data.Entity;

namespace naideno.kg.Models
{
    public class init : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext db)
        {
            db.Users.Add(new User { Name = "buronahodok" });
            base.Seed(db);
        }
    }
}