using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LosBucanerosApp
{
    public partial class Form1 : Form
    {
        string Var;
        public Form1(string var)
        {
            InitializeComponent();
            //igualamos la variable publica por lo que recibimos en el constructor
            Var = var;

        }
        //crear objetos de la clase
        ClsRutas objrutas = new ClsRutas();
        ClsUsuarios objusuarios = new ClsUsuarios();
        
        private void btnLogin_Click(object sender, EventArgs e)
        {         
           
            login(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  picLogo.Image = LosBucanerosApp.Properties.Resources.Logo;

            if (Var=="cambio")
            {

            }
            else
            {
                //muestra la imagen del logo
              
                //manda llamar el metodo para verificar si existe conexion con la base de datos
                objrutas.TestOpenConnect();
                //verificamos si la conexion es correcta

           


                if (objrutas.msj == "1")
                {
                    //si es correcto mostramos mensaje de exito
                    MessageBox.Show("Conexion Establecida Con Exito", "EXITO");
                }
                else
                {
                    //si no hay conexion, manda error y cierra la aplicacion
                    MessageBox.Show("ERROR: Revisar Conexion a Internet", "ERROR DE CONEXION");
                    this.Close();
                }
            }
           
          
     

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar ==(int) Keys.Enter)
            {
                login();
            }
        }

        public void login()
        {

            //asignar valor a las variables de la clase
            objusuarios.Usuario = txtUser.Text;
            objusuarios.Pass = txtPass.Text;
            //mandar llamar el metodo de la clase login
            objusuarios.login();



            if (Convert.ToInt16(objusuarios.Contador) == 1)
            {
                string nombre = objusuarios.Nombre;
                string apellido = objusuarios.Apellido;
                string permiso = objusuarios.Permisos;

                FrmMenu objmostrar = new FrmMenu(nombre, apellido, permiso);
                objmostrar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales Invalidas", "Sesion Invalida");
            }


        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
