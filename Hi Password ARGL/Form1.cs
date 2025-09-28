using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hi_Password_ARGL
{
    public partial class FPassword : Form
    {
        public FPassword()
        {
            InitializeComponent();
        }

        private void validar_Click(object sender, EventArgs e) // Al dar click en el boton Validar...
        {
            string contrasena1 = txtcontrasena1.Text;// Lee el texto ingresado en el primer cuadro de texto
            string contrasena2 = txtcontrasena2.Text;// Lee el texto ingresado en el segundo cuadro de texto

            /*Acontinuacion declaro las condiciones que debe de tener la contraseña, las separe en varias expresiones regulares para que los mensajes de error sean mas especificos
             y el usuario pueda corregir su error de manera mas facil*/
            string mayuscula = @"[A-Z]"; // Expresión regular para validar que la contraseña tenga al menos una letra mayúscula
            string minuscula = @"[a-z]"; // Expresión regular para validar que la contraseña tenga al menos una letra minúscula
            string numero = @"[0-9]"; // Expresión regular para validar que la contraseña tenga al menos un número
            string caracterEspecial = @"[!@#$%^&*(),.?""':;{}|<>]"; // Expresión regular para validar que la contraseña tenga al menos un carácter especial

            if (!Regex.IsMatch(contrasena1,minuscula))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra minúscula.");// Comienza validando que la contraseña tenga una minnuscula
                return;
            }
            if (!Regex.IsMatch(contrasena1, mayuscula))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.");//Despues Valida que la contraseña tenga una mayuscula
                return;
            }
            if (!Regex.IsMatch(contrasena1, numero))
            {
                MessageBox.Show("La contraseña debe contener al menos un número.");// Despues Valida que la contraseña tenga un numero
                return;
            }
            if (!Regex.IsMatch(contrasena1, caracterEspecial))
            {
                MessageBox.Show("La contraseña debe contener al menos un carácter especial.");// Despues Valida que la contraseña tenga un caracter especial
                return;
            }

            //Finalmente validamos que la contraseñas sean iguales 
            if (contrasena1 == contrasena2)
            {
                MessageBox.Show("La Contraseña es Valida"); // Si la contraseña cumple con todas las condiciones y son iguales, muestra este mensaje
                return;
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales, vuelva a ingresarlas"); // Si las contraseñas no son iguales, muestra este mensaje
            }
        }
    }
}
