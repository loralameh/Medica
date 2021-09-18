using System.ComponentModel.DataAnnotations;

namespace Medica.Models
{
    
    public class QRCodeModel
    {
        [Display(Name = "Enter The prescription: ")]
        public string QRCodeText { get; set; }

    }
}