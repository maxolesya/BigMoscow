using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BigMoscow.Logic
{
    class FeedBackRepository
    {
        public void SendMessage(string question, string email)
        {
            try
            {
                MailMessage mailmess = new MailMessage();
                mailmess.From = new MailAddress("maxolesya1@rambler.ru");
                mailmess.Subject = "PersonScheduler Notification";
                mailmess.To.Add(new MailAddress(email));
                mailmess.Body = string.Format("{0}",question);
                SmtpClient smpt = new SmtpClient("smtp.rambler.ru", 25);
                smpt.EnableSsl = true;
                smpt.Credentials = new NetworkCredential("maxolesya1@rambler.ru".Split('@')[0], "jqf35dgSmolder");
                smpt.DeliveryMethod = SmtpDeliveryMethod.Network;
                smpt.Send(mailmess);
                smpt.Dispose();


            }
            catch (Exception)
            {

                
            }
        }
    }
}
