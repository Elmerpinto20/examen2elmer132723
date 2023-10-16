using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace WinFormsApp1
{
    internal class Profesor : Persona
    {
        private string titulo;
        private string carreraAsignada;
        private double salario;


        public Profesor()
        {
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string CarreraAsignada { get => carreraAsignada; set => carreraAsignada = value; }
        public double Salario { get => salario; set => salario = value; }

        public string mostrarInformacion()
        {
            return $"Nombre Completo: {nombreCompleto()}\n" +
               $"Edad: {Edad}\n" +
               $"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}\n" +
               $"Título: {titulo}\n" +
               $"Salario: {Salario:C}\n" +
               $"Carrera Asignada: {CarreraAsignada}";

        }
    }

}
