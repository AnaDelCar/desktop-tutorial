using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica4_FORMULARIO
{
    public partial class FORM_Formulario : Form
    {
        public FORM_Formulario()
        {
            InitializeComponent();
        }

        private void Boton_Guardar_Click(object sender, EventArgs e)
        {
            //GUARDAR LOS VALORES DE LOS TEXTBOX EN VARIABLES 
            string nombre = TXT_Nombre.Text;
            string apellido = TXT_Apellido.Text;
            string edad = TXT_Edad.Text;
            string estatura = TXT_Estatura.Text;
            string telefono = TXT_Telefono.Text;

            //GUARDAR LA INFO DE LOS RADIOBUTTONS EN VARIABLES
            string genero = "";
            if (RadButton_Hombre.Checked)
            {
                genero = "Hombre";
            }
            else if (RadButton_Mujer.Checked)
            {
                genero = "Mujer";
            }

            //UNA VARIABLE DONDE ALMACENE TODOS LOS DATOS Y APAREZCA EN UNA VENTANA
            string informacion = $"NOMBRE: {nombre}\r\nAPELLIDO: {apellido}\r\nTELEFONO: {telefono} kg\r\nESTATURA: {estatura} cm\r\nEDAD: {edad} años\r\nGENERO: {genero}";

            //CREAR UN ARCHIVO txt DONDE GUARDE LA INFORMACION
            string rutaArchivo = "C:/Users/otaku/Downloads/DocumFormulario.txt";

            bool archivoExiste = File.Exists(rutaArchivo);
            Console.WriteLine(archivoExiste);

            if (archivoExiste == false) //CONDICIONALES PARA QUE GUARDE MULTIPLES DATOS EN EL ARCHIVO
            {
                File.WriteAllText(rutaArchivo, informacion);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true)) //GUARDA LOS DATOS
                {
                    if (archivoExiste)
                    {
                        //CONDICION PARA DAR UN SALTO DE LINEA SI EL ARCHIVO EXISTE
                        writer.WriteLine("\n");
                    }
                    writer.WriteLine(informacion);
                }
            }
            //MENSAJE DE TEXTO "SE GUARDO BIEN", USANDO BOTONES DE "ACEPTAR" E "INFORMACION MAS"
            MessageBox.Show("GUARDADO CON EXITO!:\n\n" + informacion, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            TXT_Nombre.Clear();
            TXT_Apellido.Clear();
            TXT_Telefono.Clear();
            TXT_Edad.Clear();
            TXT_Estatura.Clear();
            RadButton_Hombre.Checked = false ;
            RadButton_Mujer.Checked = false ;

        }


    }
}

