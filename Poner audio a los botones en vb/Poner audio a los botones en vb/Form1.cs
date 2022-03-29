using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poner_audio_a_los_botones_en_vb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Sub button1_Click( sender As System.Object, else As System.EventArgs) Handles Button1.Click
        {
            My.Computer.Audio.Play(My.Resources.beep3)
        End Sub

        }
    }
}
