using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Domain.Entities;
using FluentValidation;

namespace CRUD.Domain.Validators
{
    public class UserValidator :  AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A entidade nao pode ser vazia")
                
                .NotNull()
                .WithMessage("A entidade nao pode ser nula");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("A nome nao pode ser vazia")
                
                .NotNull()
                .WithMessage("A nome nao pode ser nula")
                
                .MinimumLength(3)
                .WithMessage("A nome deve ter no minimo 3 caracteres")

                .MaximumLength(80)
                .WithMessage("O nome deve ter no máximo 80 caracteres.");

            RuleFor(x => x.Password)
                .NotNull()
                .WithMessage("A senha não pode ser nula.")

                .NotEmpty()
                .WithMessage("A senha não pode ser vazia.")
                
                .MinimumLength(6)
                .WithMessage("A senha deve ter no mínimo 6 caracteres.")

                .MaximumLength(80)
                .WithMessage("A senha deve ter no máximo 30 caracteres.");

            RuleFor(x=>x.Email)
                .NotNull()
                .WithMessage("O email não pode ser nulo.")

                .NotEmpty()
                .WithMessage("O email não pode ser vazio.")
                
                .MinimumLength(10)
                .WithMessage("O email deve ter no mínimo 10 caracteres.")

                .MaximumLength(180)
                .WithMessage("O email deve ter no máximo 180 caracteres.")
                
                .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                .WithMessage("O email informado não é válido.");
        }
    }
        
}
