using System;

namespace csharpguiadoprogramador
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var cultInfo = CultureInfo.InvariantCulture;

            Console.Write("Digite um número: ");
            string ? n1 = double.Parse(Console.ReadLine(), cultInfo);

            Console.Write("Digite outro número: ");
            string ? n2 = double.Parse(Console.ReadLine(), cultInfo);
            */
            
            Console.Clear();

            double n1 = 5.2;
            double n2 = 7.4;

            Calc.Somar(n1, n2);

            CadastrarProduto.Cadastrar();

            





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

    interface IopenAccount
    {
        void openNewAccount();
    }
    class CheckingAccount : IopenAccount
    {
        void IopenAccount.openNewAccount()
        {   
            Console.WriteLine("Qual tipo de conta deseja abrir?");
            var type = Console.ReadLine();

            if(type == "Corrente")
            {
                IopenAccount newaccount = new CheckingAccount();
            }
        }
    }


}