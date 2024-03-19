using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiElaboracao.Models
{
    public class Treino
    {//Quando for declarar um novo treino precisa saber quantos exercicios terão no dia.
        public Treino(int num)
        {
            this.Exercicios = new Exercicio[num];
        }

        //Verificar um tipo melhor de lista para usar e manipular
        public Exercicio[] Exercicios{ get; set; }



        public bool AddExercicio(Exercicio exercicio)
        {
            if(Exercicios.Contains(exercicio))//Verificando se o exercicio consta, caso não ele adiciona ao treino
                return false;
            
            this.Exercicios.Append(exercicio);
            
            return true;
        }
    }
}