using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloPolizaF
{
    public class ClaseModelo
    {

        public void funLlenarCombo(ComboBox cbx)
        {
            Conexion con = new Conexion();
            OdbcDataReader leer = null;

            string psql = "SELECT * FROM tipoCuenta WHERE estado='A'";

            OdbcConnection conect = con.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cbx.Items.Add(leer.GetString(1));
                    cbx.ValueMember = leer.GetString(0);
                }

            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                con.desconexion(conect);
            }
        }

        public DataTable llenarTbl(string id)
        {
            Conexion cn = new Conexion();

            string sql = "SELECT * from cuenta where idCuenta='"+id+"'";

            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
            cn.desconexion(conn);


            DataTable table = new DataTable();
            dataTable.Fill(table);
            return table;
        }

        public void insertarPedidoEnc(string idCuenta, string nombre, string idTipoCuenta,string cargo,string abono,string estado)
        {
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();
            string sql = "INSERT INTO cuenta (idCuenta, nombre, idTipoCuenta,cargo,abono,estado) " +
            " VALUES ('" + idCuenta + "', '" + nombre + "', '" + idTipoCuenta + "', '"+ cargo + "', '"+abono+"','"+estado+"' )";

            try
            {
                OdbcCommand insertar = new OdbcCommand(sql, conn);
                insertar.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.StackTrace);

            }
            finally
            {
                cn.desconexion(conn);
            }


            MessageBox.Show("Ingresado Correctamente");
        }

        public void Actualizar(string nombre, string idTipo,string cargo,string abono,string estado,string idCuenta)
        {
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();
            string sql = "update cuenta set nombre= '"+nombre+"',idTipoCuenta='"+idTipo+"'" + ",cargo='"+cargo+"',abono='"+abono+"',estado='"+estado+"'" +   "WHERE idCuenta='"+ idCuenta + "'";

            try
            {
                OdbcCommand insertar = new OdbcCommand(sql, conn);
                insertar.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                cn.desconexion(conn);
            }

            MessageBox.Show("Modificado Correctamente");
        }

        public void DarBaja(string idCuenta)
        {
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();
            string sql = "update cuenta set estado='I'" + "WHERE idCuenta='" + idCuenta + "'";

            try
            {
                OdbcCommand insertar = new OdbcCommand(sql, conn);
                insertar.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                cn.desconexion(conn);
            }

            MessageBox.Show("Dado de Baja Correctamente");
        }
    }
}
