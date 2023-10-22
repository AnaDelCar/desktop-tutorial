using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //LIBRERIA DE CONEXION

namespace Practica_Validar_Datos_Formulario_
{
    public partial class Form1 : Form
    {
        string conexionSQL = "Server=localhost; Port = 3306;Database=formulariobased;Uid=root;Pwd=Morado03Morado;";
        public Form1()
        {
            InitializeComponent();
            txt_Nombre.TextChanged += validarNombre;
            txt_Apellido.TextChanged += validarApellido;
            txt_Edad.TextChanged += validarEdad;
            txt_Estatura.TextChanged += validarEstatura;
            txt_Telefono.TextChanged += validarTelefono;
        }

        private void Boton_Cancelar_Click_1(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Telefono.Clear();
            txt_Edad.Clear();
            txt_Estatura.Clear();
            RadButton_Hombre.Checked = false;
            RadButton_Mujer.Checked = false;
        }
        private void insertarRegistros (string nombre,string apellido, int edad, decimal estatura, string telefono, string genero)
        {
            using (MySqlConnection conection = new MySqlConnection(conexionSQL))
            {
                conection.Open();
                string insertQuery = "INSERT INTO usuario (Nombre, Apellido, Edad, Estatura, Telefono, Genero)" +
                                     "VALUES (@Nombre, @Apellido, @Edad, @Estatura, @Telefono, @Genero)";
                using (MySqlCommand command = new MySqlCommand (insertQuery, conection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Estatura", estatura);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Genero", genero);

                    command.ExecuteNonQuery();
                }
                conection.Close();
            }
        }

        private void Boton_Guardar_Click(object sender, EventArgs e)
        {
            //GUARDAR LOS VALORES DE LOS TEXTBOX EN VARIABLES 
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            string edad = txt_Edad.Text;
            string estatura = txt_Estatura.Text;
            string telefono = txt_Telefono.Text;

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
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidode10Digitos(telefono) && EsTextoValido(nombre) && EsTextoValido(apellido))
            {
                string informacion = $"NOMBRE: {nombre}\r\nAPELLIDO: {apellido}\r\nTELEFONO: {telefono} \r\nESTATURA: {estatura} cm\r\nEDAD: {edad} años\r\nGENERO: {genero}";

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
                            writer.WriteLine("\n");
                            insertarRegistros(nombre, apellido, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE!");
                        }
                        else
                        {
                            writer.WriteLine(informacion);
                            insertarRegistros(nombre, apellido, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE!");
                        }
                    }
                }
                MessageBox.Show("GUARDADO CON EXITO!:\n\n" + informacion, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("PORFAVOR INGRESE INFORMACION EN LOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidode10Digitos(string valor)
        {
            if (valor.Length != 10)
            {
                return false;
            }
            if (!valor.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }
        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private void validarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Porfavor ingrese un valor valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void validarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Porfavor ingrese un valor valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void validarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;

            if (input.Length < 10)
            {
                return;
            }
                if (!EsEnteroValidode10Digitos(input))
                {
                    MessageBox.Show("Porfavor ingrese un valor valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
        }
        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Porfavor ingrese un valor valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void validarApellido(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Porfavor ingrese un valor valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
    }
}