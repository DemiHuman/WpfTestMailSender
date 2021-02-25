using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMailSender.Models;

namespace WpfMailSender.Data
{
    internal static class TestData
    {
        public static List<Server> Servers { get; } = Enumerable.Range(1, 5)
            .Select(i => new Server
            {
                Id = i,
                Address = $"smpt.server{i}.ru",
                UseSSL = i % 2 == 0,
                Login = "user@yandex.ru",
                Password = "PassWord",
                Description = $"This is server {i}",
                Name = $"Server {i}"

            }).ToList();

        public static List<Sender> Senders { get; } = Enumerable.Range(1, 5)
            .Select(i => new Sender
            {
                Id = i,
                Name = $"Sender{i}",
                Address = $"Sender{i}@server.ru",
                Description = $"Mail from Sender{i}"

            }).ToList();

        public static List<Recipient> Recipients { get; } = Enumerable.Range(1, 5)
            .Select(i => new Recipient
            {
                Id = i,
                Name = $"Recipient{i}",
                Address = $"Recipient{i}@server.ru",
                Description = $"Mail for Recipient{i}"

            }).ToList();

        public static List<Message> Messages { get; } = Enumerable.Range(1, 5)
            .Select(i => new Message
            {
                Id = i,
                Title = $"Сообщение {i}",
                Body = $"Текст сообщения {i}"

            }).ToList();
    }
}
