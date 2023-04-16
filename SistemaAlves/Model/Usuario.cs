using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlves.Model
{
    internal class Usuario
    {
        private string nome, senha;
        private bool logado = false;
        private int id;


        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool Logado { get => logado; set => logado = value; }
        public int Id { get => id; set => id = value; }

    }
}
