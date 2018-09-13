using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Pojos;
using System.Data;

namespace Datos
{
    class DaoFinalizar
    {
        Conexion conec = new Conexion();
        public List<PojoFinalizar> obtenerFializar()
        {

            try
            {

                List<PojoFinalizar> concep = new List<PojoFinalizar>();
                PojoFinalizar pojoFinalizar;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.Conectar();
                string sql = " select * from asesores";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.cnConexion;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoFinalizar = new PojoFinalizar();
                    pojoFinalizar.IdAsesores = dr.GetString("idAsesores");
                    pojoFinalizar.NombreAsesores = dr.GetString("nombreAsesores");
                    pojoFinalizar.ApellidoM = dr.GetString("apellidop");
                    pojoFinalizar.ApellidoM = dr.GetString("apellidoM");
                    pojoFinalizar.Correo = dr.GetString("correo");
                    pojoFinalizar.Tutores_idTutores1 = dr.GetInt32("Tutores_idTutores");
                    concep.Add(pojoFinalizar);
                }
                return concep;
            }
            catch (Exception exc)
            {
                return null;
            }
            finally
            {
                conec.Cerrar();
            }
        }
    }
}
