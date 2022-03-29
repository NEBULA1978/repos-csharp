using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");

            Con.Open();

            DataSet DS = new DataSet();//tengo la matriz formada con todos los datos que yo quiero
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();

            return DS;
        }
    }
}
