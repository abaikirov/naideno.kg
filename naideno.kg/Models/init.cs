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
            db.Users.Add(new User { Name = "buronahodok", Email = "office@naideno.kg", PhoneNumber = "+996555555555" });
            db.SaveChanges();
            

            var users = new List<User>
          {
                new User { ID = 1, Name = "Бека", Email = "bekabog@gmail.com", PhoneNumber = "+996777456312", Status = true },
                new User { ID = 2, Name = "Эмир", Email = "eka@gmail.com", PhoneNumber = "+996707343212", Status = false },
                new User { ID = 3, Name = "Роза", Email = "roman@gmail.com", PhoneNumber = "+996555647854", Status = true },
                new User { ID = 4, Name = "Артур", Email = "ivrit@forever.com", PhoneNumber = "+996123456645", Status = false },
                new User { ID = 5, Name = "Настя", Email = "belova@yandex.ru", PhoneNumber = "+996312675894", Status = true },
                new User { ID = 6, Name = "Gender", Email = "horosho@yahoo.org", PhoneNumber = "+996777659807", Status = false },
                new User { ID = 7, Name = "Бека", Email = "bekabog@gmail.com", PhoneNumber = "+996777456312", Status = true },
                new User { ID = 8, Name = "Эмир", Email = "eka@gmail.com", PhoneNumber = "+996707343212", Status = false },
                new User { ID = 9, Name = "Роза", Email = "roman@gmail.com", PhoneNumber = "+996555647854", Status = true },
                new User { ID = 10, Name = "Артур", Email = "ivrit@forever.com", PhoneNumber = "+996123456645", Status = false },
                new User { ID = 11, Name = "Настя", Email = "belova@yandex.ru", PhoneNumber = "+996312675894", Status = true },
                new User { ID = 12, Name = "Gender", Email = "horosho@yahoo.org", PhoneNumber = "+996777659807", Status = false },
                new User { ID = 13, Name = "Бека", Email = "bekabog@gmail.com", PhoneNumber = "+996777456312", Status = true },
                new User { ID = 14, Name = "Эмир", Email = "eka@gmail.com", PhoneNumber = "+996707343212", Status = false },
                new User { ID = 15, Name = "Роза", Email = "roman@gmail.com", PhoneNumber = "+996555647854", Status = true },
                new User { ID = 16, Name = "Артур", Email = "ivrit@forever.com", PhoneNumber = "+996123456645", Status = false },
                new User { ID = 17, Name = "Настя", Email = "belova@yandex.ru", PhoneNumber = "+996312675894", Status = true },
                new User { ID = 18, Name = "Gender", Email = "horosho@yahoo.org", PhoneNumber = "+996777659807", Status = false }
          };
            users.ForEach(m => db.Users.Add(m));
            db.SaveChanges();
            
            var passports = new List<Passport>
            {
                new Passport { ID = 1, Name = "Виталий", SecondName = "Кличко", ThirdName = "Витальевич", Birthday = new DateTime(1977, 09, 12), UploadDate = new DateTime(2016, 03, 19), Category = "Пасспорт", Status = false, UserID = 1 },
                new Passport { ID = 2, Name = "Нелла", SecondName = "Азаматова", ThirdName = "Чингизхановна", Birthday = new DateTime(1985, 12, 01), UploadDate = new DateTime(2016, 03, 19), Category = "Права", Status = false, UserID = 10 },
                new Passport { ID = 3, Name = "Виталий", SecondName = "Кличко", ThirdName = "Алексеевич", Birthday = new DateTime(1977, 09, 12), UploadDate = new DateTime(2016, 03, 19), Category = "Пасспорт", Status = false, UserID = 2 },
                new Passport { ID = 4, Name = "Юра", SecondName = "Азаматова", ThirdName = "Чингизхановна", Birthday = new DateTime(1985, 12, 01), UploadDate = new DateTime(2016, 03, 19), Category = "Права", Status = false, UserID = 11 },
                new Passport { ID = 5, Name = "Виталий", SecondName = "Кличко", ThirdName = "Витальевич", Birthday = new DateTime(1977, 09, 12), UploadDate = new DateTime(2016, 03, 19), Category = "Пасспорт", Status = false, UserID = 18 },
                new Passport { ID = 6, Name = "Нелла", SecondName = "Азаматова", ThirdName = "Чингизхановна", Birthday = new DateTime(1985, 12, 01), UploadDate = new DateTime(2016, 03, 19), Category = "Права", Status = false, UserID = 13 },
                new Passport { ID = 7, Name = "Вий", SecondName = "Кличко", ThirdName = "Витальевич", Birthday = new DateTime(1977, 09, 12), UploadDate = new DateTime(2016, 03, 19), Category = "Пасспорт", Status = false, UserID = 5 },
                new Passport { ID = 8, Name = "Настя", SecondName = "Азаматова", ThirdName = "Чингизхановна", Birthday = new DateTime(1985, 12, 01), UploadDate = new DateTime(2016, 03, 19), Category = "Права", Status = false, UserID = 15 },
                new Passport { ID = 9, Name = "Виталий", SecondName = "Кличко", ThirdName = "Витальевич", Birthday = new DateTime(1977, 09, 12), UploadDate = new DateTime(2016, 03, 19), Category = "Пасспорт", Status = false, UserID = 1 },
                new Passport { ID = 10, Name = "Нана", SecondName = "Азаматова", ThirdName = "Чингизхановна", Birthday = new DateTime(1985, 12, 01), UploadDate = new DateTime(2016, 03, 19), Category = "Права", Status = false, UserID = 1 },
                new Passport { ID = 11, Name = "Виталий", SecondName = "Кличко", ThirdName = "Витальевич", Birthday = new DateTime(1977, 09, 12), UploadDate = new DateTime(2016, 03, 19), Category = "Пасспорт", Status = false, UserID = 8 },
                new Passport { ID = 12, Name = "Нелла", SecondName = "Азаматова", ThirdName = "Чингизхановна", Birthday = new DateTime(1985, 12, 01), UploadDate = new DateTime(2016, 03, 19), Category = "Права", Status = false, UserID = 4 },
                new Passport { ID = 13, Name = "Виталий", SecondName = "Кличко", ThirdName = "Витальевич", Birthday = new DateTime(1977, 09, 12), UploadDate = new DateTime(2016, 03, 19), Category = "Пасспорт", Status = false, UserID = 17 },
                new Passport { ID = 14, Name = "Оллоло", SecondName = "Азаматова", ThirdName = "Чингизхановна", Birthday = new DateTime(1985, 12, 01), UploadDate = new DateTime(2016, 03, 19), Category = "Права", Status = false, UserID = 12 },
                new Passport { ID = 15, Name = "Виталий", SecondName = "Кличко", ThirdName = "Витальевич", Birthday = new DateTime(1977, 09, 12), UploadDate = new DateTime(2016, 03, 19), Category = "Пасспорт", Status = false, UserID = 9 },
                new Passport { ID = 16, Name = "Нелла", SecondName = "Азаматова", ThirdName = "Чингизхановна", Birthday = new DateTime(1985, 12, 01), UploadDate = new DateTime(2016, 03, 19), Category = "Права", Status = false, UserID = 16 }
          };
            passports.ForEach(p => db.Passports.Add(p));
            db.SaveChanges();
            
            var universals = new List<Universal>
            {
                new Universal { ID = 1, Name = "Велик", Description = "Очень красивый1", Category = "Велосипеды", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 1 },
                new Universal { ID = 2, Name = "Ожерелье", Description = "Очень красивый2", Category = "Драгоценности", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 2 },
                new Universal { ID = 3, Name = "Кольцо", Description = "Очень красивый3", Category = "Драгоценности", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 18 },
                new Universal { ID = 4, Name = "Велик", Description = "Очень красивый4", Category = "Велосипеды", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 3 },
                new Universal { ID = 5, Name = "Ожерелье", Description = "Очень красивый5", Category = "Драгоценности", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 4 },
                new Universal { ID = 6, Name = "Кольцо", Description = "Очень красивый6", Category = "Драгоценности", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 17 },
                new Universal { ID = 7, Name = "Велик", Description = "Очень красивый7", Category = "Велосипеды", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 5 },
                new Universal { ID = 8, Name = "Ожерелье", Description = "Очень красивый8", Category = "Драгоценности", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 6 },
                new Universal { ID = 9, Name = "Кольцо", Description = "Очень красивый9", Category = "Драгоценности", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 16 },
                new Universal { ID = 10, Name = "Велик", Description = "Очень красивый10", Category = "Велосипеды", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 7 },
                new Universal { ID = 11, Name = "Ожерелье", Description = "Очень красивый11", Category = "Драгоценности", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 8 },
                new Universal { ID = 12, Name = "Кольцо", Description = "Очень красивый12", Category = "Драгоценности", UploadDate = new DateTime(2016, 03, 19), Status = false, UserID = 15 }
            };
           universals.ForEach(u => db.Universals.Add(u));
           db.SaveChanges();

            base.Seed(db);
        }
    }
}