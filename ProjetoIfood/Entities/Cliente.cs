using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoIfood.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime NascimentoData { get; set; }

        public Cliente() { }

        public Cliente(string nome, string email, DateTime nascimentoData)
        {
            Nome = nome;
            Email = email;
            NascimentoData = nascimentoData;
        }

        public override string ToString()
        {
            return Nome
               + " - "
                + Email;
        }

    }
}
