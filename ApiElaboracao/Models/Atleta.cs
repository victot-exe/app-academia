using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiElaboracao.Models
{
    public class Atleta
    {
        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        ArrayList Treinos { get; set; }
    }
}