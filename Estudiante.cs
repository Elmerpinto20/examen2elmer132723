using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace WinFormsApp1
{
    internal class Estudiante : Persona
    {
        private int ciclo;
        private double nota;
        private string carrera;



        public Estudiante()
        {

        }

        public int Ciclo { get => ciclo; set => ciclo = value; }
        public double Nota { get => nota; set => nota = value; }
        public string Carrera { get => carrera; set => carrera = value; }

        public string mostrarInformacion()
        {
            return $"Nombre Completo: {nombreCompleto()}\n" +
              $"Edad: {Edad}\n" +
              $"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}\n" +
              $"Ciclo: {Ciclo}\n" +
              $"Nota: {Nota}\n" + // Mostramos la nota del estudiante
              $"Carrera: {Carrera}";

        }



    }


}
