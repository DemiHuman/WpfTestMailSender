using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace WpfMailSender.Services
{
    public class SmtpSender
    {

        private readonly string _Address;
        private readonly int _Port;
        private readonly bool _UseSsl;
        private readonly string _Login;
        private readonly string _Password;

        public SmtpSender(string address, int port, bool useSsl, string login, string password)
        {
            _Address = address;
            _Port = port;
            _UseSsl = useSsl;
            _Login = login;
            _Password = password;
        }

        public void Send(string from, string to,
            string title, string message)
        {
            using var msg = new MailMessage(from, to)
            {
                Subject = title,
                Body = message
            };

            using var client = new SmtpClient(_Address, _Port)
            {
                EnableSsl = _UseSsl,
                Credentials = new NetworkCredential(_Login, _Password)
            };

            try
            {
                client.Send(msg);
                MessageBox.Show("Почта успешно отправлена!", "Отправка почты", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (SmtpException)
            {
                MessageBox.Show("Ошибка авторизации", "Ошибка отправки почты", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Ошибка адреса сервера", "Ошибка отправки почты", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
        
    }
}
