using System;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = new MailAddress("test@yandex.ru","TestName");
            var to = new MailAddress("test2@yandex.ru", "TestName2");

            var message = new MailMessage(from, to);
            message.Subject = "Заголовок";
            message.Body = "Текст письма";

            var client = new SmtpClient("smpt.yandex.ru", 465);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential
            {
                UserName = "Test",
                Password = "TestPassword"
            };

            client.Send(message);
        }
    }
}
