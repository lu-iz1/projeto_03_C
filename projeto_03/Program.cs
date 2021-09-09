using System;

namespace projeto_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string funcionario;
            double salario, aumento;

            Console.WriteLine("Digite o nome do funcionário: ");
            funcionario = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem de aumento do salário do funcionário: ");
            aumento = Convert.ToDouble(Console.ReadLine());

            salario = salario + (salario * (aumento / 100));

            Console.WriteLine("O novo salário do funcionário " + funcionario + " é de: R$" + salario);
        }
    }
}
