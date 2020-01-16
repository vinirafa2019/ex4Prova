using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Funcionario
    {
        public string nome;
        public int idade;
        public double salario;

        public Funcionario(string nome,int idade,double salario) {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
        }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Salario { get => salario; set => salario = value; }

        public double bonificacao() {
            return salario;
        }
    }
}
