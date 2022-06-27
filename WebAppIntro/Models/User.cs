using System.ComponentModel.DataAnnotations;

namespace WebAppIntro.Models
{
  public class User
  {

    /// <summary>
    /// attributed based validation
    /// </summary>
    [Required(ErrorMessage ="Name alanı boş geçilemez")]
    public string Name { get; set; }

    [Required(ErrorMessage ="Soyad alanı boş geçilemez")]
    [StringLength(12,ErrorMessage = "Soyad alanı 12 karakteri aşamaz")]
    public string SurName { get; set; }

  }
}
