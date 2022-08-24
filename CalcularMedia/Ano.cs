using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularMedia
{
    public class Ano
    {
        public int ano;
        public List<Mes> listadeMeses;

        public Ano()
        {
            listadeMeses = new List<Mes>();
        }
    }
}
