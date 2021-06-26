using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_POO_BDD.Validations
{
    class ValidationDui
    {
        public static bool VerificationDui(String dui)
        {
            var expression = "^[0-9]{8}-[0-9]{1}$";//que inicie con 8 digitos, luego un guion y un numero mas y que ahi termine la expresion
    
            if (Regex.IsMatch(dui, expression))
            {
                return true;
            }
            else
                MessageBox.Show("Numero de dui invalido", "Registro Ciudadano", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            return false;
        }
    }
}
