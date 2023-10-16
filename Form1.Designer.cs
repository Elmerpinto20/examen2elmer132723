using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbTipoPersona = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            panelProfesor = new Panel();
            txtSueldo = new TextBox();
            txtCarrera = new TextBox();
            txtTitulo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panelEstudiante = new Panel();
            txtCiclo = new TextBox();
            txtProfesion = new TextBox();
            txtNota = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtNombre = new TextBox();
            txtEdadPersona = new TextBox();
            txtApellido = new TextBox();
            txtFechaNacimiento = new TextBox();
            buttonInformacion = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panelProfesor.SuspendLayout();
            panelEstudiante.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 46);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 123);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 83);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // cmbTipoPersona
            // 
            cmbTipoPersona.FormattingEnabled = true;
            cmbTipoPersona.Items.AddRange(new object[] { "Estudiante", "Profesor" });
            cmbTipoPersona.Location = new Point(148, 203);
            cmbTipoPersona.Name = "cmbTipoPersona";
            cmbTipoPersona.Size = new Size(121, 23);
            cmbTipoPersona.TabIndex = 3;
            cmbTipoPersona.SelectedIndexChanged += cmbTipoPersona_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 206);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 4;
            label4.Text = "Tipo Persona";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 167);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 5;
            label5.Text = "Fecha Nacimiento";
            // 
            // panelProfesor
            // 
            panelProfesor.Controls.Add(label13);
            panelProfesor.Controls.Add(txtSueldo);
            panelProfesor.Controls.Add(txtCarrera);
            panelProfesor.Controls.Add(txtTitulo);
            panelProfesor.Controls.Add(label8);
            panelProfesor.Controls.Add(label7);
            panelProfesor.Controls.Add(label6);
            panelProfesor.Location = new Point(421, 24);
            panelProfesor.Name = "panelProfesor";
            panelProfesor.Size = new Size(325, 158);
            panelProfesor.TabIndex = 6;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(59, 123);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(104, 23);
            txtSueldo.TabIndex = 5;
            txtSueldo.TextChanged += txtSueldo_TextChanged;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(120, 91);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(168, 23);
            txtCarrera.TabIndex = 4;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(65, 51);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(224, 23);
            txtTitulo.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 126);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 2;
            label8.Text = "Sueldo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 96);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 1;
            label7.Text = "Carrera Asignada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 54);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 0;
            label6.Text = "Titulo";
            // 
            // panelEstudiante
            // 
            panelEstudiante.Controls.Add(label14);
            panelEstudiante.Controls.Add(txtCiclo);
            panelEstudiante.Controls.Add(txtProfesion);
            panelEstudiante.Controls.Add(txtNota);
            panelEstudiante.Controls.Add(label11);
            panelEstudiante.Controls.Add(label10);
            panelEstudiante.Controls.Add(label9);
            panelEstudiante.Location = new Point(421, 188);
            panelEstudiante.Name = "panelEstudiante";
            panelEstudiante.Size = new Size(325, 158);
            panelEstudiante.TabIndex = 7;
            // 
            // txtCiclo
            // 
            txtCiclo.Location = new Point(102, 42);
            txtCiclo.Name = "txtCiclo";
            txtCiclo.Size = new Size(147, 23);
            txtCiclo.TabIndex = 3;
            // 
            // txtProfesion
            // 
            txtProfesion.Location = new Point(102, 119);
            txtProfesion.Name = "txtProfesion";
            txtProfesion.Size = new Size(133, 23);
            txtProfesion.TabIndex = 5;
            txtProfesion.TextChanged += txtProfesion_TextChanged;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(102, 71);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(144, 23);
            txtNota.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 122);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 2;
            label11.Text = "Carrera";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 79);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 1;
            label10.Text = "Nota";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 45);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 0;
            label9.Text = "Ciclo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(133, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(217, 23);
            txtNombre.TabIndex = 8;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtEdadPersona
            // 
            txtEdadPersona.Location = new Point(119, 117);
            txtEdadPersona.Name = "txtEdadPersona";
            txtEdadPersona.Size = new Size(73, 23);
            txtEdadPersona.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(133, 81);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(217, 23);
            txtApellido.TabIndex = 10;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(179, 159);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(171, 23);
            txtFechaNacimiento.TabIndex = 11;
            // 
            // buttonInformacion
            // 
            buttonInformacion.Location = new Point(89, 290);
            buttonInformacion.Name = "buttonInformacion";
            buttonInformacion.Size = new Size(186, 23);
            buttonInformacion.TabIndex = 12;
            buttonInformacion.Text = "Mostrar Informacion";
            buttonInformacion.UseVisualStyleBackColor = true;
            buttonInformacion.Click += buttonInformacion_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(133, 9);
            label12.Name = "label12";
            label12.Size = new Size(96, 15);
            label12.TabIndex = 13;
            label12.Text = "Datos Personales";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(31, 14);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 6;
            label13.Text = "Profesor";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(32, 9);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 6;
            label14.Text = "Estudiante";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 450);
            Controls.Add(label12);
            Controls.Add(buttonInformacion);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtEdadPersona);
            Controls.Add(txtNombre);
            Controls.Add(panelEstudiante);
            Controls.Add(panelProfesor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbTipoPersona);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            panelProfesor.ResumeLayout(false);
            panelProfesor.PerformLayout();
            panelEstudiante.ResumeLayout(false);
            panelEstudiante.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbTipoPersona;
        private Label label4;
        private Label label5;
        private Panel panelProfesor;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panelEstudiante;
        private TextBox txtNombre;
        private TextBox txtEdadPersona;
        private TextBox txtApellido;
        private TextBox txtSueldo;
        private TextBox txtCarrera;
        private TextBox txtTitulo;
        private TextBox txtNota;
        private TextBox txtCiclo;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtProfesion;
        private TextBox txtFechaNacimiento;
        private Button buttonInformacion;
        private Label label13;
        private Label label12;
        private Label label14;
    }
}