using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibrary1;
using System.Data;

namespace ClassLibrary1
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=Administracion3;Integrated Security=True");
            Con.Open();

            DataSet DS = new DataSet();//tengo la matriz formada con todos los datos que yo quiero
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();

            return ;
        }

    }
}
