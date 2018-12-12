using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InttroducaoVisualCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDoFuncionario = "Leonardo Aleixo da Silva";
            string cargoDoFuncionario = "Analista de Sistemas - SharePoint";
            decimal salario = 6000.00m;
            DateTime dataDeAniversario = DateTime.Now;
            char tipoDeSexo = 'M';
            bool possuiFerias = true;
            

            Console.WriteLine("Nome do Funcionário        : " + nomeDoFuncionario.ToUpper());
            Console.WriteLine("Cargo do Funcionário       : " + cargoDoFuncionario.ToUpper());
            Console.WriteLine("Salário do Funcionário     : " + salario);
            Console.WriteLine("Tipo do Sexo               : " + tipoDeSexo);
            Console.WriteLine("Cargo do Funcionário       : " + dataDeAniversario.ToShortDateString());
            Console.WriteLine("Funcionário possui Férias  : " + possuiFerias);
            Console.ReadKey();
        }
    }
}
