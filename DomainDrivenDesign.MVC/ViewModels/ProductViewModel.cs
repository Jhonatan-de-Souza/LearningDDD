using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomainDrivenDesign.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [MaxLength(150, ErrorMessage = "Max {0}  for this field")]
        [MinLength(2, ErrorMessage = "Minimum of {0} characters")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Please Fill out the Value Field")]
        public decimal Value { get; set; }

        public bool Available { get; set; }

        public int ClientId { get; set; }
        public virtual ClientViewModel Client { get; set; }
    }
}