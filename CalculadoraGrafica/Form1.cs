using Calculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textPrimeiroNumero.Text != "" && textSegundoNumero.Text != "")
            {
                decimal primeroNumero = Convert.ToDecimal(textPrimeiroNumero.Text);
                decimal segundoNumero = Convert.ToDecimal(textSegundoNumero.Text);
                var calculadora = new Calculator(primeroNumero, segundoNumero);
                lblResultAdicao.Text = Convert.ToString(calculadora.Adicao());
            }
            else
            {
                if (textPrimeiroNumero.Text == "")
                    MessageBox.Show("Informe o primeiro numero.");
                if (textSegundoNumero.Text == "")
                    MessageBox.Show("Informe o segundo numero.");
            }
            

            
        }
    }
}
