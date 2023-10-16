using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Persona
    {
        protected int edad;
        protected string nombres;
        protected string apellidos;
        protected DateTime fechaNacimiento;



        public Persona()
        {
        }

        public int Edad { get => edad; set => edad = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public string nombreCompleto()
        {
            return $" {nombres}{apellidos}";
        }


    }




}

