using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Vendedor: Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario) { }
        public void bonificacao()
        {
            salario = salario + 3000;
            Console.WriteLine("O salario do Gerente com a bonificação sera :" + salario);
        }
    }
}
