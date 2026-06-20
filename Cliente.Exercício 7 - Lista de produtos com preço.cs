using System;
using System.Collections.Generic;
using System.Text;
public class Cliente
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Cidade { get; set; }

    public Cliente(string nome, string telefone, string cidade)
    {
        Nome = nome;
        Telefone = telefone;
        Cidade = cidade;
    }

    public override string ToString()
    {
        return $"Nome: {Nome} | Telefone: {Telefone} | Cidade: {Cidade}";
    }
}

