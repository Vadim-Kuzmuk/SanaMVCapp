using System.ComponentModel.DataAnnotations;

namespace MVCapp.Models
{
    public class GreetHomeViewModel
    {
        [Required(ErrorMessage = "Please, enter your name.")]
        [MinLength(2, ErrorMessage = "Name must have at least {1} characters")]
        public string Name { get; set; }
	}
}
