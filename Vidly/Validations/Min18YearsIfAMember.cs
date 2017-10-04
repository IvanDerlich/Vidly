using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*Agregadas por el usuario*/
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Validations
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == 1)
                return ValidationResult.Success;

            if (customer.BirthDate == null)
                return new ValidationResult("Por favor ingrese la fecha de nacimiento");  /*¿Porque hay que instancialo? ¿Porque es necesario el "new"? */

            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;

            return (
                  age < 18
                ? ValidationResult.Success
                : new ValidationResult("El usuario tiene que tener minimo 18 años de edad")
            );
        }
    }
}