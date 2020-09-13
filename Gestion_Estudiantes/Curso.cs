using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Estudiantes
{
    public class Curso
    {
        public List<Estudiante> estud { set; get; }
        public Curso()
        {
            estud = new List<Estudiante>();
        }
        public void Agregar(Estudiante alumno)
        {
            estud.Add(alumno);
        }
        public List<Estudiante> CedulaInicia(string cadena)
        {
            List<Estudiante> Estud = new List<Estudiante>();
            foreach (Estudiante estu in estud)
            {
                if (estu.Cedula.StartsWith(cadena))
                {
                    Estud.Add(estu);
                }
            }
            return Estud;
        }

    }
}
