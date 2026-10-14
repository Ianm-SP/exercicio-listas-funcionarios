using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        List<Funcionario> lista = new List<Funcionario>();

        Console.Write("Quantos funcionários serão registrados? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Funcionário #" + i + ":");

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            bool repetido = true;
            while (repetido)
            {
                repetido = false;
                foreach (Funcionario f in lista)
                {
                    if (f.Id == id)
                    {
                        repetido = true;
                    }
                }

                if (repetido)
                {
                    Console.Write("Id já existe! Tente novamente: ");
                    id = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            lista.Add(new Funcionario(id, nome, salario));
        }

        Console.WriteLine();
        Console.Write("Digite o id do funcionário que terá aumento salarial: ");
        int idAumento = int.Parse(Console.ReadLine());
        Funcionario encontrado = null;
        foreach (Funcionario f in lista)
        {
            if (f.Id == idAumento)
            {
                encontrado = f;
            }
        }

        if (encontrado == null)
        {
            Console.WriteLine("Este id não existe!");
        }
        else
        {
            Console.Write("Digite a porcentagem: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            encontrado.AumentarSalario(porcentagem);
        }

        Console.WriteLine();
        Console.WriteLine("Lista atualizada de funcionários:");
        foreach (Funcionario f in lista)
        {
            Console.WriteLine(f);
        }
    }
}