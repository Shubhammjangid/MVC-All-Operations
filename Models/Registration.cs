using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace WebApplication1.Models

{
    public class Registration
    {
        [DisplayName("First Name")]  
        [Required(ErrorMessage = "The First Name is required.")]  
        [MinLength(5, ErrorMessage = "The First Name must be atleast 5 characters")]  
        [MaxLength(15, ErrorMessage = "The First Name cannot be more than 15 characters")]  

        public string FirstName
        {
            get;
            set;
        }
        [DisplayName("Last Name")]  
        [StringLength(15, MinimumLength = 5, ErrorMessage = "The Last Name should be between 5 to 15 characters")]  
        public string LastName
        {
            get;
            set;
        }
        public int UserId
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        [Required(ErrorMessage = "The Email is required.")]  
        [EmailAddress(ErrorMessage = "Email is incorrect")]  
        public string Email
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Phone Number Required")]  
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter PhoneNumber as 0123456789, 012-345-6789, (012)-345-6789.")]  
        public string Contact
        {
            get;
            set;
        }
    }
}
