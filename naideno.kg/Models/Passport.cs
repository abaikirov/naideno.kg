using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace naideno.kg.Models
{
    public class Passport
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime UploadDate { get; set; }
        public string Category { get; set; }
        public bool Status { get; set; } // true - найдено, false - потеряно
        public int UserID { get; set; }

        public virtual User User { get; set; }
    }
}