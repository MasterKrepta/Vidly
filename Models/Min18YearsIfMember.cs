using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MemberShipTypeId == MembershipType.Unknown || customer.MemberShipTypeId == MembershipType.PayAsYouGo) {
                //if pay as you go customer
                return ValidationResult.Success;
            }
            else {
                if (customer.Birthdate == null) {
                    return new ValidationResult("Birthdate is Required.");
                }

                var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

                return (age >= 18) 
                    ? ValidationResult.Success 
                    : new ValidationResult("Customer must be at least 18 years of age for membership");
            }
        }
    }
}