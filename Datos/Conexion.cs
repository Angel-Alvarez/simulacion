using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class Conexion
    {
        public MySqlConnection cnConexion = new MySqlConnection();
        public void Conectar()
        {
            string strCadenaConexion;
            strCadenaConexion = "SERVER=" + "localhost" + ";PORT=3307" + ";DATABASE=" + "asesores" + ";UID=" + "root" + ";PWD=" + "root";
            cnConexion.ConnectionString = strCadenaConexion;
            cnConexion.Open();
        }

        public void Cerrar()
        {
            cnConexion.Close();
        }
    }
}
