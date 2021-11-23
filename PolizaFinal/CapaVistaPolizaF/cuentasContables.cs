using CapaControladorPolizaF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaPolizaF
{
    public partial class cuentasContables : Form
    {
        ClaseControlador co = new ClaseControlador();
        public cuentasContables()
        {
            InitializeComponent();

        }

        private void cuentasContables_Load(object sender, EventArgs e)
        {
            funLlenarComboControl();
            llenarTabla();
        }

        public void funLlenarComboControl()
        {
            co.funLlenarComboControl(cbxTipoCuenta);
        }

        public void llenarTabla()
        {
            DataTable dt = co.llenarTbl(txtIdCuenta.Text);
            dgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuentas.DataSource = dt;
        }

        private void txtIdCuenta_TextChanged(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            co.insertarPedidoEnc(txtIdCuenta.Text, txtxNombreCuenta.Text, cbxTipoCuenta.ValueMember, txtCargo.Text, txtAbono.Text, txtEstatus.Text);
            llenarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            co.Actualizar(txtxNombreCuenta.Text, cbxTipoCuenta.ValueMember, txtCargo.Text, txtAbono.Text, txtEstatus.Text,txtIdCuenta.Text);
            llenarTabla();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            co.DarBaja(txtIdCuenta.Text);
            llenarTabla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdCuenta.Text = "";
            txtAbono.Text = "";
            txtCargo.Text = "";
            txtEstatus.Text = "";
            txtxNombreCuenta.Text = "";
        }

    }
}
