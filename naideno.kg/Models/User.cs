using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace naideno.kg.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }// true - нашел, false - потерял;

        public virtual List<Passport> Passports { get; set; }
        public virtual List<Universal> Universals { get; set; }
    }
}