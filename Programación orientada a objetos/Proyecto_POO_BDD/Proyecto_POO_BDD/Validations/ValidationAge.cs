using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_POO_BDD.Validations
{
    class ValidationAge
    {
        public static bool VerificationAge(int edad)
        {
            if (edad > 0)
            {
                return true;
            }
            else
                MessageBox.Show("Edad invalida", "Registro Ciudadano", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            return false;
        }
    }
}