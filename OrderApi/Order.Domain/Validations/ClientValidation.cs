using FluentValidation;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Validations
{
    public class ClientValidation: AbstractValidator<ClientModel>
    {
        public ClientValidation() 
        { 
            RuleFor(x=> x.Name).NotNull().NotEmpty().Length(3,30);
            RuleFor(x => x.Email).NotNull().NotEmpty().EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);
            RuleFor(x => x.PhoneNumber).NotNull().NotEmpty();

        }
    }
}
