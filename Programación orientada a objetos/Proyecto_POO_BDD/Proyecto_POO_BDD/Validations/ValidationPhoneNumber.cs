using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_POO_BDD.Validations
{
    class ValidationPhoneNumber
    {
        public static bool VerificationNumer(string number)
        {
            var expression = "^[0-9]{8}$";//que inicie con 8 digitos, luego un guion y un numero mas y que ahi termine la expresion
    
            if (Regex.IsMatch(number, expression))
            {
                return true;
            }
            else
                MessageBox.Show("Numero telefonico invalido", "Registro Ciudadano", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            return false;
        }
    }
}