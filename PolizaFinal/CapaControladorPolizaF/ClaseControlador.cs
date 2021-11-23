using CapaModeloPolizaF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControladorPolizaF
{
    public class ClaseControlador
    {
        ClaseModelo mo = new ClaseModelo();
        public void funLlenarComboControl(ComboBox cbx)
        {
            mo.funLlenarCombo(cbx);
        }

        public DataTable llenarTbl(string id)
        {
            return mo.llenarTbl(id);
        }

        public void insertarPedidoEnc(string idCuenta, string nombre, string idTipoCuenta, string cargo, string abono, string estado)
        {
            mo.insertarPedidoEnc(idCuenta, nombre, idTipoCuenta, cargo, abono, estado);
        }

        public void Actualizar(string nombre, string idTipo, string cargo, string abono, string estado, string idCuenta)
        {
            mo.Actualizar(nombre, idTipo, cargo, abono, estado, idCuenta);
        }

        public void DarBaja(string idCuenta)
        {
            mo.DarBaja(idCuenta);
        }

    }
}
