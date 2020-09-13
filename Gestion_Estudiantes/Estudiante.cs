using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Estudiantes
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public int Edad { get; set; }
        public double Nota { get; set; }
        public string Genero { get; set; }

        public Estudiante(string nombre, string apellido, string cedula, int edad, double nota, string genero)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Edad = edad;
            Nota = nota;
            Genero = genero;
        }

        public Estudiante()
        {

        }
    }
}
