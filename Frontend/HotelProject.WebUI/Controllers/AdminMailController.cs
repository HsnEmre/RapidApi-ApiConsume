using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;


namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(AdminViewModel model)
        {

            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxFromAddress = new MailboxAddress("HotelierAdmin", "Burası Bizim Mailimiz");
            mimeMessage.From.Add(mailboxFromAddress);


            MailboxAddress mailboxAdressTo = new MailboxAddress("User", model.ReceiverMail);


            mimeMessage.To.Add(mailboxAdressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("mail", "passwordKey");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
