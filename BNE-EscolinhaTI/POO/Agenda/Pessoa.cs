using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Pessoa
    {
        private String _nome;
        private String _email;
        private String _telefone;

        public Pessoa(string nome, string email, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }

        public Pessoa()
        {
            this.nome = "";
            this.email = "";
            this.telefone = "";

        }

        public string nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

        public String email
        {
            get
            {
                return this._email;
            }
            set
            {
                this.email = value;
            }
        }

        public String telefone
        {
            get
            {
                return this._telefone;
            }
            set
            {
                this._telefone = value;
            }
        }

        public void exibeDados()
        {
            Console.Clear();
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Email: {this.email}");
            Console.WriteLine($"Telefone: {this.telefone}");
        }
    }
}
