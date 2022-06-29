using System.Net;
using System.Net.Mail;

namespace WebAppIntro.Services
{
  public class EmailService : IEmailService
  {
    private IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    public void Send(string from, string to, string subject, string body)
    {

      string provider = _configuration.GetValue<string>("EmailSettings:Provider");
      string username= _configuration.GetValue<string>("EmailSettings:Credentials:Email");
      string pass = _configuration.GetValue<string>("EmailSettings:Credentials:Password");

      SmtpClient client = new SmtpClient(provider);
      client.Port = 587;
      client.EnableSsl = true;
      client.Credentials = new NetworkCredential(username, pass);


      MailMessage message = new MailMessage(from, to);
      message.Body = body;
      message.IsBodyHtml = true;

      client.Send(message);   
    
      // Clean up.
      message.Dispose();
      Console.WriteLine("Goodbye.");
    }
  }
}
