using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Domain.Entities
{
    public class Base
    {
        public Long Id { get; set; }

        internal List<string> _erros;
        public IReadOnlyCollection<string> Erros => _erros;
        public abstract bool Validate(); 
    }
}

