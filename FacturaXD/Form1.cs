using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//utilizar variables de conexiones
using ClassLibrary1;
using System.Data;

namespace FacturaXD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //hago la peticion y me devuelve la contraseña
                string CMD = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());
                
                //y lo guardo de la frase anterior aqui abajo DataSet
                DataSet ds = Utilidades.Ejecutar(CMD);

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if(cuenta == txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {
                    MessageBox.Show("Se ha conectado");
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta!...");
                }

                MessageBox.Show("Se ha conectado2");


            }
            catch (Exception error)
            {
                MessageBox.Show("ha ocurrido un error:" + error.Message);
            }

            //metodos dataset hacer las consultas y guardarlas 
            //y metodo validar formulario se utilizan para DLL








            Utilidades.Ejecutar("Select * FROM Clientes Where id=1");




        }
    }
}
