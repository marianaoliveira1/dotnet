using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Domain.Entities
{
    public class User : Base
    {
         public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        //EF
        protected User(){}

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            _errors = new List<string>();

            Validate();
        }


        //Comportamentos
        public void SetName(string name){
            Name = name;
            Validate();
        }

        public void SetPassword(string password){
            Password = password;
            Validate();
        }

        public void SetEmail(string email){
            Email = email;
            Validate();
        }

        //Autovalida
        public override bool Validate(){
            var validator = new UserValidator();
            var validation = validator.Validate(this);

            if(!validation.IsValid) 
            {
                foreach(var error in validation.Errors)
                    _erros.Add(error.ErrorMessage);

                throw new Exception("Alguns campos estão invalidos, por favor, corrija-os" +_erros[0]);
            }
        }
           

    }
}