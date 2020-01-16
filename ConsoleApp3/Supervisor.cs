using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Supervisor : Funcionario
    {
        public Supervisor(string nome,int idade,double salario) : base(nome,idade,salario)
        { }
        public void bonificacao()
        {
            salario = salario + 5000;
            Console.WriteLine("O salario do Gerente com a bonificação sera :" + salario);
        }
    }
}
