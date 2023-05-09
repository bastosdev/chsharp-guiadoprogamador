using System;
using System.Net;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* PRATICANDO HERANÇA E POLIMORFISMO*/
            Adm gerente = new Adm("gerencia", "Bruno", "bruno@gmail.com", 123);

            /* PRATICANDO HTTP*/
        }

    }
    class Usuarios
    {
        public string ? _nome;
        public string ? _email;
        public int ? _senha;

        public Usuarios(string nome, string email, int senha)
        {
            this._nome = nome;
            this._email = email;
            this._senha = senha;
        }
        
        //VIRTUALIZAÇÃO DE UM METODO PARA PERMITIR A SOBRESCRITA DO MESMO:
        public virtual void ExibirDados()
        {
            Console.WriteLine($"NOME: {_nome}");
            Console.WriteLine($"EMAIL: {_email}");
            Console.WriteLine($"SENHA: {_senha}");
        }
    }

    class Adm : Usuarios
    {
        public string ? _setor;

        //HERANAÇ COM CONSTRUTOR:
        public Adm(string setor, string nome, string email, int senha) : base(nome, email, senha)
        {
            this._setor = setor;
        }

        //SOBRESCRITA DO METODO VIRTUALIZADO DA CLASS PAI:
        public override void ExibirDados()
        {
            Console.WriteLine("DADOS ADM:");
            base.ExibirDados();
            Console.WriteLine($"SENHA: {_setor}");
            
        }
    }
}