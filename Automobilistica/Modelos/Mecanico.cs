﻿namespace Automobilistica.Modelos;

internal class Mecanico
{
    public Mecanico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }

    public string Nome { get; set; }
    public string Especialidade { get; set; }
}
