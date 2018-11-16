using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_ao_visual_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal primeiroNumero = 10;
            const decimal segundoNumero = 20;
            var calculadora = new Calculator(primeiroNumero, segundoNumero);

            Console.WriteLine(calculadora.Adicao());
            Console.WriteLine(calculadora.Subtracao());
            Console.WriteLine(calculadora.Multiplicacao());
            Console.WriteLine(calculadora.Divisao());

            Console.ReadKey();
        }

        static void IncrementoDecremento()
        {
            int saldo = 10;
            saldo++;
            Console.WriteLine("O Saldo e " + saldo);
        }

        static bool ONumeroEPar(int numero)
        {
            if(numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void OperadoresAritmeticos()
        {
            double meuPrimeiroNumero = 10;
            double meuSegundoNumero = 20;

            double retornoDaAdicao = meuPrimeiroNumero + meuSegundoNumero;
            Console.WriteLine("Adicao " + retornoDaAdicao);

            double retornoDaSubtracao = meuPrimeiroNumero - meuSegundoNumero;
            Console.WriteLine("Subtracao " + retornoDaSubtracao);

            double retornoDaMultiplicacao = meuPrimeiroNumero * meuSegundoNumero;
            Console.WriteLine("Multiplicacao " + retornoDaMultiplicacao);

            double retornoDaDivisao = meuPrimeiroNumero / meuSegundoNumero;
            Console.WriteLine("Divisao " + retornoDaDivisao);
        }
    }
}
