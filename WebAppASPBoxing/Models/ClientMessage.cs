using System.ComponentModel.DataAnnotations;

namespace WebAppASPBoxing.Models
{
    public class ClientMessage
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Пожалуйста, заполните Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста, заполните Phone")]
        public string Phone { get; set; }
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Пожалуйста, заполните валидный Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пожалуйста, заполните Message")]
        public string Message { get; set; }
    }
}
