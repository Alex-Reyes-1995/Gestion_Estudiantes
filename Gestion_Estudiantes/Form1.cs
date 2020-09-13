using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Estudiantes
{
    public partial class Form1 : Form
    {
        Curso estudiantes = new Curso();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            panelNuevoEst.Visible = true;
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtNota.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelNuevoEst.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarInformacion())
                {

                    Estudiante est = new Estudiante();
                    est.Nombre = txtNombre.Text;
                    est.Apellido = txtApellido.Text;
                    est.Cedula = txtCedula.Text;
                    est.Edad = Convert.ToInt32(txtEdad.Text);
                    est.Nota = Convert.ToDouble(txtNota.Text);
                    est.Genero = cbxGenero.Text;

                    estudiantes.Agregar(est);
                    MessageBox.Show("Datos Guardados Correctamente");                   
                }
                else
                {
                    MessageBox.Show("Ingresar toda la informacion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool VerificarInformacion()
        {
            bool verifica = false;
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtCedula.Text != "" && txtEdad.Text != "" && txtNota.Text != "")
            {
                verifica = true;
            }
            return verifica;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Curso mostrar_est = new Mostrar_Curso();
            mostrar_est.Show();
            mostrar_est.estudiante = estudiantes;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Letras(e);
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Letras(e);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Numeros(e);
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Numeros(e);
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimal(e);
        }
    }
}
