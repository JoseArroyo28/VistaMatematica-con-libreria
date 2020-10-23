using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaMatematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String Num1 = "", Num2 = "", Op = "";
        private void dosNumerosEnterosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperacionesAritmeticas Op = new OperacionesAritmeticas();
            Op.Show();
        }

        private void numerosEnterosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperacionesAritmeticas Op = new OperacionesAritmeticas();
            Op.Show();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Num2 = txtPantalla.Text;
            switch (Op)
            {
                case "Suma":
                   txtPantalla.Text= Math1._1.Aritmetica.SumaDosValoresDecimales(Convert.ToDouble(Num1),Convert.ToDouble(Num2)).ToString();
                    break;
                case "Menos":
                    txtPantalla.Text = Math1._1.Aritmetica.RestaDosNumerosDecimales(Convert.ToDouble(Num1), Convert.ToDouble(Num2)).ToString();
                    break;
                case "Div":
                    txtPantalla.Text = Math1._1.Aritmetica.divisionDosNumeros(Convert.ToDouble(Num1), Convert.ToDouble(Num2)).ToString();
                    break;
                case "Mul":
                    txtPantalla.Text = Math1._1.Aritmetica.MultiplicacionDosNumeros(Convert.ToDouble(Num1), Convert.ToDouble(Num2)).ToString();
                    break;
                default:
                    break;
            }
            btnAsterisco.Enabled = true;
            btnDiagonal.Enabled = true;
            btnMenos.Enabled = true;
            
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "9";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "0";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            Num1 = txtPantalla.Text;
            btnSuma.Enabled = false;
            btnDiagonal.Enabled = false;
            btnMenos.Enabled = false;
            txtPantalla.Clear();

            Op = "Mul";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            Num1 = txtPantalla.Text;
            btnAsterisco.Enabled = false;
            btnDiagonal.Enabled = false;
            btnSuma.Enabled = false;
            txtPantalla.Clear();
            Op = "Menos";

        }

        private void btnDiagonal_Click(object sender, EventArgs e)
        {
            Num1 = txtPantalla.Text;
            btnAsterisco.Enabled = false;
            btnSuma.Enabled = false;
            btnMenos.Enabled = false;
            txtPantalla.Clear();
            Op = "Div";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Num1 = txtPantalla.Text;
            btnAsterisco.Enabled = false;
            btnDiagonal.Enabled = false;
            btnMenos.Enabled = false;
            txtPantalla.Clear();
            Op = "Suma";
        }
    }
}
