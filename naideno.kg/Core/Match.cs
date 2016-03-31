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

        public int PassMatch(Passport otherPass)
        {

            try {
                Passport matchPass = db.Passports.Single(p => p.MatchID == otherPass.MatchID);
                return matchPass.ID;
            }
            catch(Exception)
            {
                return 0;
            }
        }
    }
}