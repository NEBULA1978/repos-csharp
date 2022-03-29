using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariMdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Nuevo = new Form2();//este objeto ventana pertenece al contenedor mdmi de abjo

            Nuevo.MdiParent = this;//lo llamo

            Nuevo.Show();

        }
    }
}
