﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "LWT" && txtContraseña.Text =="123")
            {
                //   MessageBox.Show("Se ha iniciado sesion!...");

                this.Hide();

                Ventana2 NuevaVentana = new Ventana2();

                NuevaVentana.Show();
            }
            else
            {
                MessageBox.Show("Error en el ID o la contraseña...Intente de nuevo!...");

                txtID.Text = "";
                txtContraseña.Text = "";
                txtID.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
