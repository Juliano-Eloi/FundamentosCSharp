using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculator
    {
        private decimal _primeiroNumero;
        private decimal _segundoNumero;

        public Calculator(decimal primeiroNumero, decimal segundoNumero)
        {
            _primeiroNumero = primeiroNumero;
            _segundoNumero = segundoNumero;
        }

        public decimal Adicao()
        {
            return _primeiroNumero + _segundoNumero;
        }

        public decimal Subtracao()
        {
            return _primeiroNumero - _segundoNumero;
        }

        public decimal Multiplicacao()
        {
            return _primeiroNumero * _segundoNumero;
        }

        public decimal Divisao()
        {
            return _primeiroNumero / _segundoNumero;
        }
    }
}
