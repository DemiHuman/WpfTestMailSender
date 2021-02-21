using System.Net;
using System.Net.Mail;
using System.Windows;

namespace WpfMailSender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {

            //var from = new MailAddress("@gmail.com", "Test!!!");
            //var to = new MailAddress("@yandex.ru");

            //var from = new MailAddress("test@yandex.ru", "Test!!!");
            //var to = new MailAddress("test@gmail.com");

            //var message = new MailMessage(from, to);
            //message.Subject = tbSubjectMail.Text;
            //message.Body = tbBodyMail.Text;

            //EmailSendServiceClass sendMail = new EmailSendServiceClass();
            //sendMail.SendMeil(ConfigMailServerClass.Host, ConfigMailServerClass.Port, tbLogin.Text, pasBox.SecurePassword, message);

        }
    }
}
