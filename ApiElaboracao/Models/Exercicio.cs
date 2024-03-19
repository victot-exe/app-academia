using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiElaboracao.Models
{
    public class Exercicio
    {
        public Exercicio(string nome, int rep, int series, double carga, Musculo musculo)
        {
            this.Nome = nome;
            this.Repeticoes = rep;
            this.Series = series;
            this.Carga = carga;
            this.Musculo = musculo;
        }

        public string Nome { get; set; }
        public int Repeticoes { get; set; }
        public int Series { get; set; }
        public double Carga { get; set; }
        public Musculo Musculo { get; set; }


    }
}