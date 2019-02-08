using System;
using System.Windows.Forms;

namespace Nick.Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BotaoAdicionarClick(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double resultado;

            resultado = numero1 += numero2;
            txtResultado.Text = resultado.ToString();

        }

        private void BotaoSubtrairClick(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double resultado;

            resultado = numero1 -= numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void BotaoDividirClick(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double resultado;

            resultado = numero1 /= numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void BotaoMultiplicarClick(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double resultado;

            resultado = numero1 *= numero2;
            txtResultado.Text = resultado.ToString();
        }     
    }
}


