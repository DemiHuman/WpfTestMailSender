﻿using System;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Windows;
using System.Windows.Media;

namespace WpfMailSender
{
    public class EmailSendServiceClass
    {
        public EmailSendServiceClass()
        {
            
        }

        public void SendMeil(string host, int port, string login, SecureString password, MailMessage message)
        {

            var client = new SmtpClient(host, port);
            client.EnableSsl = true;
            client.Timeout = 3000;

            client.Credentials = new NetworkCredential
            {
                UserName = login,
                SecurePassword = password
            };

            try
            {
                client.Send(message);
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
