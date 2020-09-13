using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Estudiantes
{
    class Validar
    {
        public static void Letras(KeyPressEventArgs V)
        {
            if (char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }
        }
        public static void Numeros(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }
        }
        public static void NumerosDecimal(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (V.KeyChar.ToString().Equals(","))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }
        }
    }
}
