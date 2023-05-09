using System;

class Program
{

    Adm gerente = new Adm("gerencia", "Bruno", "bruno@gmail.com", 123);

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
}

class Adm : Usuarios
{
    public string ? _setor;

    public Adm(string setor, string nome, string email, int senha) : base(nome, email, senha)
    {
        this._setor = setor;
    } 
}

class Funcionarios
{

}