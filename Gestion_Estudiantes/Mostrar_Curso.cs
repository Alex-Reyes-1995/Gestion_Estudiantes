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
    public partial class Mostrar_Curso : Form
    {
        public Curso estudiante { get; set; }
        public Mostrar_Curso()
        {
            InitializeComponent();
            estudiante = new Curso();
        }
        private void Mostrar_Curso_Load(object sender, EventArgs e)
        {            
           // dgvCurso.DataSource = estudiante.estud;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            try
            {
                double mayor = estudiante.estud.Max(x => x.Nota);
                List<Estudiante> MayorNota = estudiante.estud.FindAll(x => (x.Nota == mayor));
                dgvCurso.DataSource = MayorNota;
            }
            catch { };
           
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            try
            {
                double menor = estudiante.estud.Min(x => x.Nota);
                List<Estudiante> MenorNota = estudiante.estud.FindAll(x => (x.Nota == menor));
                dgvCurso.DataSource = MenorNota;
            }
            catch { };
           
        }

        private void btnCedula_Click(object sender, EventArgs e)
        {
            dgvCurso.DataSource = estudiante.CedulaInicia(txtCI.Text);
            txtCI.Text = "";
        }

        private void btnHombres_Click(object sender, EventArgs e)
        {
            try
            {
                List<Estudiante> Hombres = estudiante.estud.FindAll(x => (x.Genero == "Masculino"));
                dgvCurso.DataSource = Hombres;
            }
            catch { };
           
        }

        private void btnMujeres_Click(object sender, EventArgs e)
        {
            try
            {
                List<Estudiante> Hombres = estudiante.estud.FindAll(x => (x.Genero == "Femenino"));
                dgvCurso.DataSource = Hombres;
            }
            catch { };
            
        }

        private void btnRefrescarTabla_Click(object sender, EventArgs e)
        {
            dgvCurso.DataSource = estudiante.estud;

        }

        private void dgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Numeros(e);
        }
    }
}
