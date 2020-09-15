using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperacionesBásicasPOO
{
    public partial class Form1 : Form
    {
        Operaciones operaciones = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            operaciones.setNumero1(double.Parse(txtNumero1.Text));
            operaciones.setNumero2(double.Parse(txtNumero2.Text));
            operaciones.setOperacion(cbxOperaciones.Text);

            if (operaciones.getOperacion() == "Suma")
            {
                operaciones.calcularSuma();
                label5.Visible = true;
                lblRespuesta.Visible = true;
                lblRespuesta.Text = Convert.ToString(operaciones.getSuma());
            }else if (operaciones.getOperacion() == "Resta")
            {
                operaciones.calcularResta();
                label5.Visible = true;
                lblRespuesta.Visible = true;
                lblRespuesta.Text = Convert.ToString(operaciones.getResta());
            }else if (operaciones.getOperacion() == "Multiplicación")
            {
                operaciones.calcularMultiplo();
                label5.Visible = true;
                lblRespuesta.Visible = true;
                lblRespuesta.Text = Convert.ToString(operaciones.getMultiplo());
            }else if(operaciones.getOperacion() == "División" && operaciones.getNumero2() == 0)
            {
                MessageBox.Show("Debes ingresar un número diferente de cero", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtNumero2.Focus();
            }
            else
            {
                operaciones.calcularCociente();
                label5.Visible = true;
                lblRespuesta.Visible = true;
                lblRespuesta.Text = Convert.ToString(operaciones.getCociente());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            cbxOperaciones.Text = String.Empty;
            label5.Visible = false;
            lblRespuesta.Visible = false; 
            lblRespuesta.Text = "0"; 

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
