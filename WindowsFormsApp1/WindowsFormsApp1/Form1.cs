using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClassLibrary1;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string Cmd = "Select * FROM Clientes Where id=1";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    MessageBox.Show("Se ha conectado");

            //}
            //catch(Exception error)
            //{
            //    MessageBox.Show("ha ocurrido un error" + error.Message);
            //}
            Utilidades.Ejecutar(Cmd);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //hago la peticion y lo...
                string CMD = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());
                
                //  ...lo wardo en ds
                DataSet ds = Utilidades.Ejecutar(CMD);

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if(cuenta ==txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {
                    MessageBox.Show("Se ha iniciado");
                }
                //else
                //{
                //    MessageBox.Show("Usuario o contraseña incorrecta!...");
                //}

            }
            catch(Exception error)
            {
                //MessageBox.Show("Error: " + error.Message);
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
