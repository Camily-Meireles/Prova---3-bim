using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest01
{
    class Jogador
    {
        private string nome, apelido;
        private bool lider;
        

        public Jogador(string nome, string apelido, bool lider)
        {
            this.nome = nome;
            this.apelido = apelido;
            this.lider = lider;
        }
        
        
        public override string ToString() 
        {

            return $"{nome} -{apelido} {lider}";
        }
    }
    
}
