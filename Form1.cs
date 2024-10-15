using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1, Numero2;
        string operador;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Numero2 = Convert.ToDouble(textBox1.Text);
                double resultado = 0;


                if (double.TryParse(textBox1.Text, out double numero1) && double.TryParse(textBox1.Text, out double numero2))
                {
                    if (numero2 != 0) // Evita la división por cero
                    {
                        double resultados = numero1 / numero2;
                        textBox1.Text = resultado.ToString("N2"); // Muestra el resultado con 2 decimales
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.");
                    }
                }

                switch (operador)
                {
                    case "+":
                        resultado = Numero1 + Numero2;
                        break;
                    case "-":
                        resultado = Numero1 - Numero2;
                        break;
                    case "*":
                        resultado = Numero1 * Numero2;
                        break;
                    case "/":
                        resultado = Numero1 / Numero2;
                        break;
                }

                textBox1.Text = resultado.ToString();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Verifica que el TextBox no esté vacío
            if (textBox1.Text.Length > 0)
            {
                // Elimina el último carácter del TextBox
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }


        private void btnNegativo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
            {
                textBox1.Text = textBox1.Text.TrimStart('-');
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {                                  
                    Numero1 = Convert.ToDouble(textBox1.Text);
                    operador = "/";
                    textBox1.Clear();
                }
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Numero1 = Convert.ToDouble(textBox1.Text);
                operador = "*";
                textBox1.Clear();
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Numero1 = Convert.ToDouble(textBox1.Text);
                operador = "-";
                textBox1.Clear();
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double numero))
            {
                double resultado = numero / 100;
                textBox1.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Numero1 = Convert.ToDouble(textBox1.Text);
                operador = "+";
                textBox1.Clear();
            }
        }

    }
}
