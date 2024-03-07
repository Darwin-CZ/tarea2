using aporte5tod.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aporte5tod
{
    public partial class Nomina_de_empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_calcular_Click(object sender, EventArgs e)
        {
            calcular();
        }
        private void calcular ()
        {
            try
            {
                // Obtener los valores ingresados por el usuario
                string nombre = txtnombre.Text;
                int edad = Convert.ToInt32(txtedad.Text);
               decimal preciohoras = 15.33m;
                decimal diasTrabajados = Convert.ToDecimal(txtdiastrabajados.Text);
                decimal bono1 = Convert.ToDecimal(bono.Text);
               
                decimal sueldo_base = preciohoras * diasTrabajados;


                // Calcular descuento del IESS
                decimal descuentoIESS = 9.45m;

                // Calcular descuento del impuesto a la renta
                decimal descuentoIR = 8m;

                //sueldo con descuento iess
                decimal descuento_valor1 = sueldo_base * (descuentoIESS / 100);
                decimal valor_v = sueldo_base - descuento_valor1;

                //sueldo con descuendo del impuesto a la renta
                decimal descuento_valor2 = sueldo_base * (descuentoIR / 100);
                decimal valor_c = valor_v - descuento_valor2;

                decimal sueldo_bono = valor_c + bono1;
                

                txtresultado.Text = sueldo_bono.ToString();

            }
            catch (Exception ex)
            {
                txtresultado.Text = $"Error: {ex.Message}";
            }
        }

        protected void Btnregistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string edad = txtedad.Text;
            string precio = precioh.Text;
            string dias = txtdiastrabajados.Text;
            string iess = txtdescuentoiess.Text;
            string ir = txtdescuentoir.Text;
            string bono1 = bono.Text;


            conexion miconexion = new conexion();
            miconexion.Insertar(nombre, edad, precio, dias, iess, ir, bono1);
        }
    }
}