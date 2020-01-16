using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
			Gerente g = new Gerente("Vinicius",55,14000);
			Supervisor s = new Supervisor("Samara",33,8000);
			Vendedor v = new Vendedor("Raphael",20,1600);
			

			Console.WriteLine("Os dados do gerente: " + "Nome: " + g.nome + "\nIdade: " + g.idade + "\nSalario: " + g.salario);
			g.bonificacao();
			Console.WriteLine("-------------------------------------------------------------------------------------------------");
			Console.WriteLine("Os dados do supervisor: " + "Nome: " + s.nome + "\nIdade: " + s.idade + "\nSalario: " + s.salario);
			s.bonificacao();
			Console.WriteLine("-------------------------------------------------------------------------------------------------");
			Console.WriteLine("Os dados do vendedor: " + "Nome: " + v.nome + "\nIdade: " + v.idade + "\nSalario: " + v.salario);
			v.bonificacao();
			Console.WriteLine("-------------------------------------------------------------------------------------------------");
		}
    }
}
