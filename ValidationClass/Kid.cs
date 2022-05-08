using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationClass
{
    class Kid
    {
        [Range(0, 18)] // The age cannot be over 18 and cannot be negative
        public int Age { get; set; }
        [MaxLength(255, ErrorMessage = "The name cannot be more than 50 chars"), Required(ErrorMessage = "*")]
        [MinLength(5, ErrorMessage = "The name cannot be under 3")]
        public string Name { get; set; }
        [DataType(DataType.Date)] // The birthday will be displayed as a date only (without the time)
        public DateTime Birthday { get; set; }

        [NotABanana(ErrorMessage = "Bananas are not allowed.")]
        public string FavoriteFruit { get; set; }

    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class NotABananaAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var inputValue = value as string;
            var isValid = true;

            if (!string.IsNullOrEmpty(inputValue))
            {
                isValid = inputValue.ToUpperInvariant() != "BANANA";
            }

            return isValid;
        }
    }

}
