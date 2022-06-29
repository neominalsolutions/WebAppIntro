namespace WebAppIntro.Models.Settings
{

  // 1.adım
  public class EmailSettings
  {
    public string Provider { get; set; }
    public string From { get; set; }
    public EmailCredentials Credentials { get; set; }
  }

  public class EmailCredentials
  {
    public string Email { get; set; }
    public string Password { get; set; }

  }


}
