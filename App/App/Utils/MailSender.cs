﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace App.Utils
{
    /// <summary>
    /// 
    /// Mail sendig class
    /// Author : Catalin Radoiu
    /// Author: Dezsi Razvan
    /// 
    /// </summary>
    public class MailSender
    {

        /// <summary>
        /// This method sends an email from a gmail account (cannot send email from another account; eg : yahoo )
        /// Gets as paraeter a sender, which has to be a gmail account in order to work
        /// The receiver can be any other email adress, does not have to be a gmail adress like the sender 
        /// The mailBody and the mailSubject params represent the body and the subject of the mail that will be sended
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        /// <param name="mailBody"></param>
        /// <param name="mailSubject"></param>
        public void sendMail(MailAddress receiver, string mailBody, string mailSubject)
        {
           
            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient();
            MailAddress senderMail = new MailAddress("iss.cmsmailer@gmail.com");
            mail.From = senderMail;
            mail.To.Add(receiver);
            mail.Subject = mailSubject;
            mail.Body = mailBody;

            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("iss.cmsmailer@gmail.com", "copilenunemergemailerul");
            client.EnableSsl = true;

            client.Send(mail);
        }
    }
}
