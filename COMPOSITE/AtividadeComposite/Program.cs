using System;
using System.Collections.Generic;

public abstract class HoraTrabalhada
{
    public string Nome { get; set; }

    public HoraTrabalhada(string nome)
    {
        Nome = nome;
    }

    public abstract int GetHoraTrabalhada();

    public virtual void Add(HoraTrabalhada componente) { }
    public virtual void Remove(HoraTrabalhada componente) { }
}

public class Funcionario : HoraTrabalhada
{
    private int horas;

    public Funcionario(string nome, int horas) : base(nome)
    {
        this.horas = horas;
    }

    public override int GetHoraTrabalhada()
    {
        Console.WriteLine($"Funcionário {Nome} trabalhou {horas} horas.");
        return horas;
    }
}

public class Organizacao : HoraTrabalhada
{
    private List<HoraTrabalhada> membros = new List<HoraTrabalhada>();

    public Organizacao(string nome) : base(nome) { }

    public override void Add(HoraTrabalhada componente)
    {
        membros.Add(componente);
    }

    public override void Remove(HoraTrabalhada componente)
    {
        membros.Remove(componente);
    }

    public override int GetHoraTrabalhada()
    {
        int totalHoras = 0;
        Console.WriteLine($"\nOrganização {Nome}:");

        foreach (var membro in membros)
        {
            totalHoras += membro.GetHoraTrabalhada();
        }

        Console.WriteLine($"Total de horas na organização {Nome}: {totalHoras} horas.");
        return totalHoras;
    }
}

public class Program
{
    public static void Main()
    {
        // Empresa (composite raiz)
        var empresa = new Organizacao("Empresa XPTO");

        // Departamentos
        var departamento1 = new Organizacao("Departamento TI");
        var departamento2 = new Organizacao("Departamento RH");

        // Funcionários do TI
        departamento1.Add(new Funcionario("Alice", 40));
        departamento1.Add(new Funcionario("Bob", 38));
        departamento1.Add(new Funcionario("Carlos", 42));

        // Funcionários do RH
        departamento2.Add(new Funcionario("Daniela", 36));
        departamento2.Add(new Funcionario("Eduardo", 40));
        departamento2.Add(new Funcionario("Fernanda", 37));

        // Adiciona os departamentos à empresa
        empresa.Add(departamento1);
        empresa.Add(departamento2);

        Console.WriteLine("========== Relatório de Horas Trabalhadas ==========");
        int total = empresa.GetHoraTrabalhada();
        Console.WriteLine($"\nTotal geral de horas trabalhadas: {total} horas.");
    }
}

