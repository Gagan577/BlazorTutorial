using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models.CustomValidators
{
    public class EmailDomainValidator : ValidationAttribute
    {
        public string AllowedDomail { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] strings = value.ToString().Split('@');
            if(strings[1].ToUpper() == AllowedDomail.ToUpper())
            {
                return null;
            }
            //return base.IsValid(value, validationContext);
            //return new ValidationResult($"Domain name must be {AllowedDomail}", new[] { validationContext.MemberName});
            return new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });
        }
    }
}
