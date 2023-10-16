using WinFormsApp1;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Persona objPersona = new Persona();
        int tipoPersona = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panelEstudiante.Visible = false;
            this.panelProfesor.Visible = false;
        }

        private void txtProfesion_TextChanged(object sender, EventArgs e)
        {
            // No se hace nada en este método
        }

        private void buttonInformacion_Click(object sender, EventArgs e)
        {
            this.mostrarYllenarPersona();
        }

        public void mostrarYllenarPersona()
        {
            objPersona.Nombres = txtNombre.Text;
            objPersona.Apellidos = txtApellido.Text;
            objPersona.Edad = int.Parse(txtEdadPersona.Text);
            objPersona.FechaNacimiento = DateTime.Parse(DateTime.Now.ToString());

            Estudiante objEstudiante = null;
            Profesor objProfesor = null;

            if (tipoPersona == 0)
            {
                objEstudiante = new Estudiante();
                objEstudiante.Ciclo = int.Parse(txtCiclo.Text);
                objEstudiante.Carrera = txtCarrera.Text;
                objEstudiante.Nota = double.Parse(txtNota.Text);
            }
            if (tipoPersona == 1)
            {
                objProfesor = new Profesor();
                objProfesor.Titulo = txtTitulo.Text;
                objProfesor.CarreraAsignada = txtCarrera.Text;
                objProfesor.Salario = double.Parse(txtSueldo.Text);
            }

            MessageBox.Show("\n Nombre Completo: " + objPersona.nombreCompleto()
                + "\n Edad: " + objPersona.Edad
                + "\n Fecha de Nacimiento: " + objPersona.FechaNacimiento
                + (objEstudiante != null ? "\n Ciclo: " + objEstudiante.Ciclo
                + "\n Carrera: " + objEstudiante.Carrera
                + "\n Nota: " + objEstudiante.Nota : "")
                + (objProfesor != null ? "\n Titulo: " + objProfesor.Titulo
                + "\n Carrera Asignada: " + objProfesor.CarreraAsignada
                + "\n Salario: " + "$" + objProfesor.Salario : ""));
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // No se hace nada en este método
        }

        private void cmbTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoPersona = this.cmbTipoPersona.SelectedIndex;

            if (tipoPersona == 0)
            {
                this.panelEstudiante.Visible = true;
                this.panelProfesor.Visible = false;
            }
            else if (tipoPersona == 1)
            {
                panelProfesor.Visible = true;
                panelEstudiante.Visible = false;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // No se hace nada en este método
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            // No se hace nada en este método
        }
    }
}
