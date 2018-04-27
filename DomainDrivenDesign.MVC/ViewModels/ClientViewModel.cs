using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomainDrivenDesign.MVC.ViewModels
{
    public class ClientViewModel
    {
        // When Dealing with the ViewModel  the basic DataAnnotations Should be applied
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "The name field is required.")]
        [MaxLength(150, ErrorMessage = "Max {0}  for this field")]
        [MinLength(2, ErrorMessage = "Minimum of {0} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The surname field is required.")]
        [MaxLength(150, ErrorMessage = "Max {0}  for this field")]
        [MinLength(2, ErrorMessage = "Minimum of {0} characters")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "The email field is required.")]
        [MaxLength(150, ErrorMessage = "Max {0}  for this field")]
        [MinLength(2, ErrorMessage = "Minimum of {0} characters")]
        [EmailAddress(ErrorMessage = "Please fill out a valid E-mail")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }

        public bool Active { get; set; }

        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}