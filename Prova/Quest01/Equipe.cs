using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest01
{
    class Equipe
    {
        private string nome;
        public void SetNome( string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        private Jogador[] jogs = new Jogador[10];
        int k;

        public void Inserir(Jogador j)
        {
            if (k < 10)
            {
                jogs[k++] = j;
            }
        }
        public Jogador[] Jogadores()
        {
            Jogador[] jog = new Jogador[k];
            Array.Copy(jogs, jog, k); 
            return jog;
        }
        public Jogador[] Lideres()
        {
            Jogador[] lider = new Jogador[k];
            Array.Copy(jogs, lider, k);
            return lider;
        }


    }
}
