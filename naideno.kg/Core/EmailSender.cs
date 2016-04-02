using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Text;
using naideno.kg.Models;

namespace naideno.kg.Core
{

   

    public class EmailSender
    {
        public string MailToAddress = "";// кому
        public string MailFromAddress = "";//от кого
        public bool UseSsl = true;
        public string Username = "";
        public string Password = "";
        public string ServerName = "smtp-mail.outlook.com";
        public int ServerPort = 587;
        public bool WriteAsFile = false;
        public string FileLocation = @"C:\korshop_emails";

        public void ProccessOrder(Passport passport, User user)
        {
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.EnableSsl = UseSsl;
                smtpClient.Host = ServerName;
                smtpClient.Port = ServerPort;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(Username, Password);

                StringBuilder body = new StringBuilder()
                    .Append("Найдено!/n")
                    .Append("--------/n")
                    .AppendFormat("{0}/n", passport.Category)
                    .AppendFormat("На имя:{0} {1} {2}/n", passport.Name, passport.SecondName, passport.ThirdName)
                    .AppendFormat("Дата рождения: {0}/n", passport.Birthday.Date)
                    .AppendFormat("Пожалуйста свяжитесь с {0} по номеру {1} или по адресу электронной почты {2}/n", user.Name, user.PhoneNumber, user.Email);






                MailMessage mailMessage = new MailMessage(
                                         MailFromAddress, //От кого
                                         "GrinderBrad@gmail.com",//passport.User.Email, //Кому
                                         "Найдено!", // Тема
                                         body.ToString()); // Тело письма

                smtpClient.Send(mailMessage);

            }
        }
    }
}