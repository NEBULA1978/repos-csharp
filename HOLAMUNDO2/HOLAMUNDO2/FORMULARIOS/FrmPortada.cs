using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOLAMUNDO2.FORMULARIOS
{
    public partial class FrmPortada : Form
    {
        public FrmPortada()
        {
            InitializeComponent();
        }

        private void FrmPortada_Load(object sender, EventArgs e)
        {
            label1.Text = "HOLA " + CLASES.CLASEINICIAL.NOMBRE;
        }
    }
}
