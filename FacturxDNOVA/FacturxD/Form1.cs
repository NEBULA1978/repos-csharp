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
using MiLibreria;
using System.Data;

namespace FacturxD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilidades.Ejecutar("Select * FROM Clientes where id=1");
           try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account = '{0)' AND password='{1)'", txtNomAcc.Text.Trim(),txtPass.Text.Trim());
                //Trim en caso que haya espacio agara la cadena entera no solamente un pedazo
                DataSet ds = Utilidades.Ejecutar(CMD);//guardo en ds

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();


                if(cuenta==txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {
                    Console.WriteLine("Se ha iniciado");
                }
                //else
                //{
                //    MessageBox.Show("Usuario o contraseña incorrecta!...");
                //}

            }
            catch (Exception error)
            {
                // MessageBox.Show("Error: " + error.Message);
                MessageBox.Show("Usuario o contraseña incorrecta!...");

            }

        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
