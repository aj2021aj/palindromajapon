using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace palindromajapon.palindroma
{
    
    public partial class palindroma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btn_validar_Click(object sender, EventArgs e)
        {
          
          
            int cantidad = countPalin(txtoracion.Text);
            txttotal.Text = Convert.ToString(cantidad);
        } //fin boton validar
          // Funcion que permite validar si el texto es palindrome
        public static bool validar(string texto)
        {
            int n = texto.Length;
            texto = texto.ToLower();
            for (int i = 0; i < n; i++, n--)
            {
                if (texto[i] != texto[n - 1])
                {
                    return false;
                }
            }
            return true;
           
        }

        // Funcion que permite contar cuantas palabras palindromes
        //tiene el texto
        public static int countPalin(string str)
        {
            // Ultima palabra palindroma
            str = str + " ";

            // Contador de palabras
            string texto = "";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                // extracting each word
                if (ch != ' ')
                {
                    texto = texto + ch;
                }
                else
                {
                    if (validar(texto))
                    {
                        count++;
                    }
                    texto = "";
                }
            }

            return count;
           
        }

}//fin class
} // fin namespace