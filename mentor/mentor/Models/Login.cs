using System.ComponentModel.DataAnnotations;

namespace Mentor.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Email address is required")]
		[EmailAddress(ErrorMessage = "Please enter a valid email address")]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = "Password is required")]
		[DataType(DataType.Password)]
		public string Password { get; set; } = string.Empty;

		public bool RememberMe { get; set; }
	}
}