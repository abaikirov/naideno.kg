using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using naideno.kg.Context;
using naideno.kg.Models;

namespace naideno.kg.Core
{
    public class Match
    {
        private EFDbContext db = new EFDbContext();

        public int PassMatch(string name, string secondName, string thirdName, DateTime Birthday, string category)
        {

            Passport matchPass = db.Passports.First(p => p.Name == name && p.SecondName == secondName && p.ThirdName == thirdName); // && p.SecondName == secondName   ).ID;

            if (matchPass.Birthday.Date == Birthday.Date && matchPass.Category == category)
                return matchPass.ID;
            else return 0;
        }
    }
}