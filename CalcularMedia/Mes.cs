using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularMedia
{
    public class Mes
    {
        public string nome;
        public List<Produto> listadeProdutos;
        public float investimento;

        public Mes()
        {
            listadeProdutos =  new List<Produto>();
        }

    }
}
