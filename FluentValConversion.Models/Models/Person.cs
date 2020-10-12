using FluentValConversion.Validators;
using FluentValidation.Attributes;

namespace FluentValConversion.Models
{
    [Validator(typeof(PersonValidator))]
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
