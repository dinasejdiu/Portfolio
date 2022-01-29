using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Message
    {
        [Required(ErrorMessage = "Ju lutem shkruani emrin.")]
        [DataType(DataType.Text)]
        [Display(Name = "Emri")]
        public string Emri { get; set; }
        [Required(ErrorMessage = "Ju lutem shkruani mbiemrin.")]
        [DataType(DataType.Text)]
        [Display(Name = "Mbiemri:")]
        public string Mbiemri { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Gender:")]
        public string Gjinia { get; set; }
        [Required(ErrorMessage = "Shkruani email tuaj.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Adresa:")]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Numrin e telefonit nese mundeni:")]
        public string Telefoni { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Komentet:")]
        public string Komentet { get; set; }
    }
}
