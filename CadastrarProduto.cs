using System;

namespace csharpguiadoprogramador
{
    public static class CadastrarProduto
    {
        public static void Cadastrar(){

            Console.WriteLine("Qual Nome do Produto?");
            string ? nome = Console.ReadLine();

            Produto produto = new Produto(nome);
            Console.WriteLine($"ITEN CADASTRADO: {produto}");

        }
    }
}