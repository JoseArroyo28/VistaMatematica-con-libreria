using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Math;

namespace VistaMatematica
{
    public partial class OperacionesAritmeticas : Form
    {
        public OperacionesAritmeticas()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (cbxArreglo.Checked)
            {

            }
            else
            {
                var resultado = Math.Aritmetica.SumaDosNumerosEnteros(Convert.ToInt32(txtValor1.Text), Convert.ToInt32(txtValor2.Text));
                lblResultado.Text = String.Format("Resultado = {0} ", resultado);
               
                
            }
        }
    }
}
