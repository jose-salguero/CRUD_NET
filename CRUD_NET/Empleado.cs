using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;
using System.Linq;
using System.Web;

namespace CRUD_NET
{
    public class Empleado
    {
        ConexionBD conectar;
        private DataTable drop_puesto()
        {
            DataTable tabla = new DataTable();
            conectar = new ConexionBD();
            string strConsulta = string.Format("SELECT id_puesto as id,puesto FROM puestos;");
            conectar.AbrirConexion();
            MySqlDataAdapter consulta = new MySqlDataAdapter(strConsulta,conectar.conectar);
            consulta.Fill(tabla);
            conectar.CerrarConexion();
            return tabla;
        }
        public void drop_puesto(DropDownList drop)
        {
            drop.ClearSelection();
            drop.Items.Clear();
            drop.AppendDataBoundItems = true;
            drop.Items.Add("Elegir Puesto");
            drop.Items[0].Value = "0";
            drop.DataSource = drop_puesto();
            drop.DataTextField = "puesto";
            drop.DataValueField = "id";
            drop.DataBind();
        }

        private DataTable grid_empleado()
        {
            DataTable tabla = new DataTable();
            conectar = new ConexionBD();
            string strConsulta = string.Format("SELECT e.id_empleado as id, e.codigo,e.nombres,e.apellidos,e.direccion,e.telefono, p.puesto,e.fecha_nacimiento,p.id_puesto FROM empleados as e inner join puestos as p on e.id_puesto=p.id_puesto");
            conectar.AbrirConexion();
            MySqlDataAdapter consulta = new MySqlDataAdapter(strConsulta, conectar.conectar);
            consulta.Fill(tabla);
            conectar.CerrarConexion();
            return tabla;
        }

        public void grid_empleado(GridView grid)
        {
            grid.DataSource = grid_empleado();
            grid.DataBind();
        }

        public int agregar(string codigo, string nombres, string apellidos, string direccion, string telefono, string fecha, int id_puesto)
        {
            int no_ingreso = 0;
            string strConsulta = string.Format("INSERT INTO empleados(codigo,nombres,apellidos,direccion,telefono,fecha_nacimiento,id_puesto) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6});", codigo, nombres, apellidos, direccion, telefono, fecha, id_puesto);
            conectar = new ConexionBD();
            conectar.AbrirConexion();
            MySqlCommand insertar = new MySqlCommand(strConsulta,conectar.conectar);
            insertar.Connection = conectar.conectar;
            no_ingreso = insertar.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no_ingreso;
        }
        public int modificar(int id, string codigo, string nombres, string apellidos, string direccion, string telefono, string fecha, int id_puesto)
        {
            int no_ingreso = 0;
            string strConsulta = string.Format("update empleados set codigo = '{0}',nombres='{1}',apellidos='{2}',direccion='{3}',telefono='{4}',fecha_nacimiento='{5}',id_puesto= {6} where id_empleado = {7};", codigo, nombres, apellidos, direccion, telefono, fecha, id_puesto, id);
            conectar = new ConexionBD();
            conectar.AbrirConexion();
            MySqlCommand insertar = new MySqlCommand(strConsulta, conectar.conectar);
            insertar.Connection = conectar.conectar;
            no_ingreso = insertar.ExecuteNonQuery();
            conectar.CerrarConexion();

            return no_ingreso;
        }
        public int eliminar(int id)
        {
            int no_ingreso = 0;
            string strConsulta = string.Format("delete from empleados where id_empleado = {0};", id);
            conectar = new ConexionBD();
            conectar.AbrirConexion();
            MySqlCommand insertar = new MySqlCommand(strConsulta, conectar.conectar);
            insertar.Connection = conectar.conectar;
            no_ingreso = insertar.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no_ingreso;
        }


    }
}