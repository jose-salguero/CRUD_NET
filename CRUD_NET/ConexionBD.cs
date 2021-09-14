using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_NET
{
    public class ConexionBD
    {
        private string contenido = "server=localhost;database=db_empresa_2021;user=root;password=admin1234";
        public MySqlConnection conectar = new MySqlConnection();
        public MySqlDataAdapter adaptador = new MySqlDataAdapter();
        public void AbrirConexion()
        {
            try
            {
                string sConn;
                sConn = contenido;
                conectar = new MySqlConnection();
                conectar.ConnectionString = sConn;
                conectar.Open();
                System.Diagnostics.Debug.WriteLine("Conexion Exitosa");
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Conexion Erronea");
            }
        }

        public void CerrarConexion()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}